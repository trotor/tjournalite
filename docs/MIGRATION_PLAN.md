# TJournaLite — .NET 10 Migration & Multiplatform Plan

Related issue: https://github.com/trotor/tjournalite/issues/1

## Current State

- .NET Framework 4.5, WinForms, EF6, SQLite
- Global keyboard/mouse hooks via P/Invoke (Gma.UserActivityMonitor library)
- Active window tracking via GetForegroundWindow/GetWindowText
- Monolithic FormMain (~1100 lines mixing UI and business logic)
- Legacy unused code: DataSet classes, SQL Server/Oracle references

## Target State

- .NET 10 (LTS, supported until Nov 2028)
- EF Core 10 + SQLite
- Separated business logic with abstractions for platform-specific features
- Multiplatform support via Avalonia UI and SharpHook

---

## Phase 1: .NET 10 + WinForms (Windows only)

Goal: Get the existing app running on .NET 10 without changing UI framework.

### Steps

1. **Convert .csproj to SDK-style format**
   - Replace the old verbose .csproj with SDK-style `<Project Sdk="Microsoft.NET.Sdk">` targeting `net10.0-windows`
   - Set `<UseWindowsForms>true</UseWindowsForms>`
   - Remove legacy AssemblyInfo.cs (move attributes to .csproj properties)

2. **Migrate EF6 → EF Core 10**
   - Replace packages:
     - `EntityFramework` 6.1.3 → `Microsoft.EntityFrameworkCore.Sqlite` 10.x
     - `System.Data.SQLite.*` → included in EF Core SQLite provider
   - Convert EDMX + T4 templates → Code-First DbContext:
     ```csharp
     public class TjournalContext : DbContext
     {
         public DbSet<TjBlog> Blogs { get; set; }
         public DbSet<TjProgram> Programs { get; set; }
         public DbSet<TjMouse> MouseActivity { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder options)
             => options.UseSqlite("Data Source=tjournal.sqlite");
     }
     ```
   - Map existing table/column names with `[Table]` and `[Column]` attributes to preserve DB compatibility
   - Delete: `TjournalModel.edmx`, `Model1.Context.tt`, `Model1.tt`, auto-generated entity files

3. **Update P/Invoke declarations**
   - Migrate `[DllImport]` → `[LibraryImport]` where straightforward (better AOT support)
   - Gma.UserActivityMonitor: convert to .NET 10 class library project

4. **Clean up legacy code**
   - Delete `DataSet1.cs`, `DataSet1.xsd`, `TJournalDataSet.cs`, `TJournalDataSet.xsd`
   - Remove commented SQL Server / Oracle connection code
   - Remove unused `ObjectListView` dependency if not actively used, or replace with .NET 10 compatible version

5. **Update app.config → appsettings.json** (optional, WinForms still supports app.config)

6. **Verify functionality**
   - Keystroke tracking
   - Mouse movement tracking
   - Active window detection
   - Journal CRUD operations
   - System tray behavior
   - Hotkey (WIN+CTRL+J)
   - Encryption (Crypto.cs — Rijndael/AES)

### Expected Issues
- `ObjectListView.Official` may not have a .NET 10 compatible version — may need alternative
- T4 templates won't be used anymore (Code-First replaces them)
- `app.manifest` and ClickOnce settings need review

---

## Phase 2: Separate Concerns

Goal: Extract testable business logic from FormMain. Prerequisite for multiplatform.

### Abstractions to Create

```
src/
├── TJournaLite.Core/              (netstandard2.0 or net10.0, no UI dependency)
│   ├── Services/
│   │   ├── IInputHookService.cs    (keyboard/mouse event abstraction)
│   │   ├── IWindowTracker.cs       (active window abstraction)
│   │   ├── IActivityRepository.cs  (data access abstraction)
│   │   ├── ActivityTracker.cs      (core tracking logic, timers, counters)
│   │   └── JournalService.cs       (journal CRUD operations)
│   └── Models/
│       ├── TjBlog.cs
│       ├── TjProgram.cs
│       └── TjMouse.cs
├── TJournaLite.Windows/           (net10.0-windows)
│   ├── WindowsInputHookService.cs  (P/Invoke SetWindowsHookEx)
│   ├── WindowsWindowTracker.cs     (GetForegroundWindow)
│   └── Gma.UserActivityMonitor/   (existing hook library, refactored)
├── TJournaLite.WinForms/          (net10.0-windows, WinForms UI)
│   ├── FormMain.cs                 (thin UI shell, delegates to services)
│   └── Dialog Forms/
└── TJournaLite.Core.Tests/        (unit tests)
```

### Key Refactoring in FormMain
- Move timer logic → `ActivityTracker`
- Move DB operations → `ActivityRepository` / `JournalService`
- Move hook setup → `IInputHookService` implementation
- Move window detection → `IWindowTracker` implementation
- FormMain becomes a thin view that subscribes to service events

---

## Phase 3: Multiplatform with Avalonia

Goal: Cross-platform UI and platform-specific service implementations.

### New Projects

```
src/
├── TJournaLite.Avalonia/          (Avalonia UI, targets net10.0)
│   ├── Views/
│   │   ├── MainWindow.axaml
│   │   ├── JournalView.axaml
│   │   └── ActivityView.axaml
│   ├── ViewModels/
│   │   ├── MainViewModel.cs
│   │   └── JournalViewModel.cs
│   ├── App.axaml                   (TrayIcon configuration)
│   └── Program.cs
├── TJournaLite.macOS/             (net10.0-macos)
│   ├── MacInputHookService.cs      (SharpHook / CGEventTap)
│   └── MacWindowTracker.cs         (CGWindowListCopyWindowInfo)
└── TJournaLite.Linux/             (net10.0)
    ├── LinuxInputHookService.cs    (SharpHook / XRecord)
    └── LinuxWindowTracker.cs       (_NET_ACTIVE_WINDOW via X11)
```

### Platform Support

| Feature | Windows | macOS | Linux (X11) | Linux (Wayland) |
|---|---|---|---|---|
| Global hooks | ✅ P/Invoke | ✅ SharpHook | ✅ SharpHook | ❌ Blocked |
| Window tracking | ✅ P/Invoke | ✅ CGWindowList | ✅ X11 prop | ⚠️ Compositor-specific |
| UI | ✅ Avalonia | ✅ Avalonia | ✅ Avalonia | ✅ Avalonia |
| System tray | ✅ | ✅ | ✅ | ✅ |

### macOS Considerations
- First-run wizard to guide users through granting Input Monitoring + Accessibility permissions
- App must be signed with Developer ID
- `CGPreflightListenEventAccess()` / `CGRequestListenEventAccess()` for permission checks

### Linux/Wayland Status
- SharpHook/libuiohook Wayland support is on their roadmap but not implemented
- Active window tracking has no standard API (varies by GNOME/KDE/Sway/Hyprland)
- Recommendation: Document X11/XWayland as requirement, revisit when ecosystem matures

---

## Phase 4: Polish

- CI/CD pipeline (GitHub Actions: build + test on Windows/macOS/Linux)
- Platform-specific packaging:
  - Windows: MSIX or self-contained exe
  - macOS: .app bundle + DMG
  - Linux: AppImage or Flatpak
- Auto-update mechanism
- Proper logging (Microsoft.Extensions.Logging)

---

## Key NuGet Packages

| Package | Purpose | Version |
|---|---|---|
| `Microsoft.EntityFrameworkCore.Sqlite` | Database | 10.x |
| `SharpHook` | Cross-platform global hooks | 7.x |
| `Avalonia` | Cross-platform UI | Latest |
| `Avalonia.Desktop` | Desktop integration | Latest |
| `CommunityToolkit.Mvvm` | MVVM support | Latest |

---

## Risk Assessment

| Risk | Impact | Mitigation |
|---|---|---|
| ObjectListView not compatible with .NET 10 | Medium | Replace with DataGridView or Avalonia DataGrid |
| EF6 → EF Core migration breaks existing DB | High | Write migration tests, backup DB before testing |
| SharpHook Wayland gap | Medium | Document X11 requirement, monitor libuiohook roadmap |
| macOS permission UX | Medium | Implement permission check + guidance dialog |
| FormMain refactoring scope | High | Incremental extraction, test each service separately |
