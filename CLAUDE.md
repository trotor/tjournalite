# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

TJournaLite is a Windows desktop application (C# / .NET Framework 4.5 / WinForms) for personal journaling and computer activity monitoring. It tracks keystrokes, mouse movement, application usage, idle time, and user mood via journal entries.

## Build

Open `src/TJournaLite.sln` in Visual Studio 2013/2015+ or build with MSBuild:

```
msbuild src/TJournaLite.sln /p:Configuration=Release
```

NuGet packages must be restored first. Output goes to `bin/`.

## Architecture

**Solution has two projects:**

- **TJournal** (`src/TJournal/`) — Main WinForms application. Entry point is `Program.cs` → `FormMain`. FormMain (~1100 lines) is the monolithic core: it manages the system tray, timers, activity tracking counters, journal UI, and direct EF6 database access all in one class.
- **Gma.UserActivityMonitor** (`src/Gma.UserActivityMonitor/`) — Library that uses Windows native hooks (P/Invoke `SetWindowsHookEx`) to capture global keyboard and mouse events system-wide. `HookManager` is the static API; split across partial classes (`Callbacks`, `Structures`, `Windows`).

**Data layer:** SQLite database (`tjournal.sqlite`) accessed via Entity Framework 6. The model is defined in `TjournalModel.edmx` with T4-generated entity classes (`tj_blog`, `tj_programs`, `tj_mouse`). The DbContext class is `tjournalEntities` in `Model1.Context.cs`.

**Key mechanisms:**
- Global hotkey WIN+CTRL+J registered via `Hotkey.cs` (implements `IMessageFilter`)
- Activity polling via `timer1` in FormMain — detects window switches, idle state, periodic DB writes
- `Crypto.cs` provides Rijndael (AES) encryption for sensitive data
- `Helper.cs` reads embedded resources (version, build time)

**Naming conventions:** Form classes are `Form<Name>.cs`, entities are `tj_<table>`, private fields use `s_` (static) and `m_` (member) prefixes.

## Known Technical Debt

The README acknowledges the codebase needs cleanup. Key issues:
- Legacy unused DataSet classes (`DataSet1`, `TJournalDataSet`) from old SQL Server era
- Commented-out SQL Server/Oracle code scattered throughout
- No unit tests, no CI/CD
- FormMain mixes UI logic with data access — no separation of concerns

## Project Viability (assessed March 2026)

**Windows modernization (.NET 10):** Viable. All core dependencies have modern equivalents:
- WinForms: still supported on .NET 10
- EF6 + SQLite → EF Core 10 + SQLite (straightforward migration)
- Gma.UserActivityMonitor (custom P/Invoke hooks) → SharpHook (maintained cross-platform library)
- P/Invoke `GetForegroundWindow` etc. → still works on .NET 10 Windows, or replaceable

**macOS/Linux:** Not easy. Global input hooks and window tracking are deeply platform-specific:
- macOS: requires Accessibility + Input Monitoring permissions, app signing, different APIs
- Linux/Wayland: no standard API for global hooks or active window detection
- Cross-platform adds significant complexity for a personal tool

**Recommendation:** Focus on Phase 1-2 (Windows/.NET 10 + refactoring). Cross-platform (Phase 3-4) deprioritized.

See `docs/MIGRATION_PLAN.md` for the full migration plan and GitHub Issues #1-#19 for tracked tasks.
