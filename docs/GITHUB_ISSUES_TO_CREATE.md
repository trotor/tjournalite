# GitHub Issues to Create

These issues should be created on `trotor/tjournalite` with the `trotor` account.
The existing issues #1-#19 cover the migration plan steps. Below are additional
assessment-related issues and label changes.

## New Label

```bash
gh label create "assessment" --description "Project viability and technical assessment" --color "7057ff"
gh label create "deprioritized" --description "Deprioritized — revisit later" --color "D4C5F9"
```

## Issue #20: Project viability assessment — Windows modernization viable, cross-platform deprioritized

**Labels:** `assessment`

**Body:**

### Assessment (March 2026)

The project's core functionality has been evaluated for modernization feasibility.

#### Windows (.NET 10) — Viable

All core dependencies have modern equivalents:

| Current | Replacement | Effort |
|---|---|---|
| .NET Framework 4.5 | .NET 10 | SDK-style csproj conversion |
| WinForms | WinForms (still supported) | Minimal changes |
| EF6 + SQLite | EF Core 10 + SQLite | Moderate — EDMX to Code-First |
| Gma.UserActivityMonitor (custom P/Invoke) | SharpHook 7.x | Moderate — API mapping |
| P/Invoke (GetForegroundWindow etc.) | Same P/Invoke or LibraryImport | Low |

Core logic is ~1100 lines (FormMain) + ~450 lines (hook library). Not too large.

#### macOS — Possible but disproportionate effort

- Requires Accessibility + Input Monitoring permissions
- App must be signed with Developer ID
- Completely different APIs for window tracking (CGWindowList)
- SharpHook works but permission UX is painful for users
- Not worth the effort for a personal utility at this stage

#### Linux — Partially blocked

- X11: works with SharpHook
- Wayland: no standard API for global hooks or active window detection
- Blocked until Wayland ecosystem matures

#### Decision

- **Proceed** with Phase 1 (Windows/.NET 10 migration) and Phase 2 (refactoring)
- **Deprioritize** Phase 3 (cross-platform/Avalonia) and Phase 4 (polish/packaging)
- Revisit cross-platform when Phase 1-2 are complete

---

## Issue #21: Deprioritize cross-platform issues (Phase 3-4)

**Labels:** `assessment`, `deprioritized`

**Body:**

Based on the viability assessment (#20), cross-platform support is deprioritized.

The following issues should be labeled `deprioritized`:
- #13 Create Avalonia UI project with basic shell and system tray
- #14 Implement cross-platform input hooks using SharpHook
- #15 Implement macOS active window tracker
- #16 Implement Linux (X11) active window tracker
- #17 Add macOS permission guidance for Input Monitoring and Accessibility
- #18 Set up GitHub Actions CI/CD pipeline
- #19 Add platform-specific packaging and installer

These remain open for future consideration but are not on the active roadmap.

---

## Quick script to create all at once

```bash
# Create labels
gh label create "assessment" --description "Project viability and technical assessment" --color "7057ff"
gh label create "deprioritized" --description "Deprioritized - revisit later" --color "D4C5F9"

# Create assessment issue
gh issue create --title "Project viability assessment: Windows modernization viable, cross-platform deprioritized" \
  --label "assessment" \
  --body "See README.md 'Project Viability Assessment' section and CLAUDE.md for full details.

## Summary
- **Windows/.NET 10:** Viable. All dependencies have modern equivalents. Moderate effort.
- **macOS:** Possible but disproportionate effort (permissions, signing, different APIs).
- **Linux/Wayland:** Partially blocked. X11 works, Wayland has no standard hook/window API.

## Decision
- Proceed with Phase 1-2 (Windows modernization + refactoring)
- Deprioritize Phase 3-4 (cross-platform + polish)
- Revisit cross-platform after Phase 1-2 are complete"

# Deprioritize cross-platform issues
for i in 13 14 15 16 17 18 19; do
  gh issue edit $i --add-label "deprioritized"
done

# Create tracking issue for deprioritization
gh issue create --title "Deprioritize cross-platform issues (Phase 3-4)" \
  --label "assessment,deprioritized" \
  --body "Based on viability assessment, cross-platform (Phase 3-4) issues #13-#19 have been labeled deprioritized. They remain open for future consideration."
```
