# 📜 Changelog

All notable changes to this project will be documented in this file.

## [v0.2.0] - 2025-03-22
### Added
- New scene: `ControlsScreen` with a UI-based introduction.
- `ControlsScreen.cs` script to manage tutorial panel and navigation.
- Improved character creation flow via new menus and transitions.

### Changed
- Overhauled `MainMenu` flow to load `ControlsScreen` first.
- Visual polish and restructuring of multiple game scenes (e.g., `Map`, `Village`, `Inventory`, `LevelUp`).
- Updated `.gitignore` and `.gitattributes` for better Unity and asset management.

### Removed
- Deprecated `CustomButton.cs` and associated inspector logic.
- Old `.vscode/` workspace configs and `UIElementsSchema`.

---

## [v0.1.0] - 2025-02-28
### Initial Release
- Playable RPG prototype with:
  - Real-time combat
  - Inventory and XP systems
  - AI companion and quest logic
- Scenes: Village, GoblinLand, Map, CreateCharacter, etc.
