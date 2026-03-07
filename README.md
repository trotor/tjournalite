# TJournaLite

A simple tool to keep a journal and track your computer usage, including keystrokes since installation.

## About

TJournaLite is a personal journaling and computer activity monitoring application written in C# by Tero Rönkkö (tero.ronkko@gmail.com).

It tracks:
- Keystrokes and keyboard activity
- Mouse movements and clicks
- Time spent in different applications
- User mood via journal entries
- Idle/active time

### Screenshots

![alt tag](http://muikea.fi/tjournal/tjournal1.PNG)
![alt tag](http://muikea.fi/tjournal/tjournal2.PNG)

## How to get started

### "Installing"

At this point this app doesn't have a proper installer. Instead...

1. Download TJournal via convenient method (the zip)
2. Copy and/or rename bin directory to your needs
3. Run tjournal.exe
4. Add your first journal entry by pressing Ctrl-N
5. Ctrl-S and Alt-F4 to keep app running in the system tray

### Tips

1. Add tjournal.exe to autostart for continuous tracking
2. Use WIN+CTRL+J to bring the window to front from anywhere
3. Track your moods with journal entries

## Source Code

### Current stack

- **Platform:** Windows (.NET Framework 4.5)
- **UI:** Windows Forms
- **Database:** SQLite with Entity Framework 6
- **Activity monitoring:** Windows API hooks (global keyboard/mouse)

### Building

Open `src/TJournaLite.sln` in Visual Studio 2013/2015+ and build. No additional setup required.

### Project Viability Assessment (March 2026)

**Status: Active — Windows modernization viable, cross-platform deprioritized**

| Question | Answer |
|---|---|
| Can this be rebuilt on Windows with modern libraries? | **Yes.** .NET 10 + WinForms is supported. SharpHook replaces custom P/Invoke hooks. EF Core replaces EF6. Moderate effort. |
| Can this run on macOS? | **Possible but not easy.** macOS requires Accessibility + Input Monitoring permissions for global hooks, app signing, and completely different APIs for window tracking. SharpHook works on macOS but permission UX is painful. Disproportionate effort for a personal tool. |
| Can this run on Linux? | **Partially.** X11 works with SharpHook. Wayland has no standard API for global hooks or window tracking — blocked until ecosystem matures. |
| Is the project too large to modernize? | **No.** Core logic is ~1100 lines in FormMain + ~450 lines in hook library. Phase 1 (Windows/.NET 10) and Phase 2 (refactor) are achievable. Full cross-platform (Phase 3-4) is ambitious and optional. |

**Recommendation:** Proceed with Phase 1-2 (Windows modernization + refactoring). Revisit cross-platform when/if those are complete.

### Roadmap

Migration to .NET 10 is planned. Cross-platform support (Avalonia UI + SharpHook) is deprioritized. See [Migration Plan](docs/MIGRATION_PLAN.md) and [Issue #1](https://github.com/trotor/tjournalite/issues/1) for details.
