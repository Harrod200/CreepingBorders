# Terra Invicta Localization Structure Reference

## Overview
Terra Invicta uses a simple plain-text localization system with key=value format in .en (English) files. Other languages use similar file names with language codes (.fr for French, .de for German, etc.).

## File Format

### File Extension
- `.en` for English localization
- Files placed in mod root directory (same directory as DLL and ModInfo.json)

### File Contents
Plain text format, one entry per line:
```
KEY=Value String Here
KEY_WITH_PARAMS={0} formatted with {1} parameter
```

### Character Encoding
- UTF-8 (standard)
- No BOM (Byte Order Mark) typically used

## Key Naming Conventions

### Pattern
`UI.{Context}.{Category}.{Descriptor}`

### Examples from Vanilla Game
- `UI.Nation.BaseValue` - Nation UI base cohesion value
- `UI.Nation.FromInequality` - Cohesion impact from inequality
- `UI.Region.Name` - Region display name
- `UI.Options.AudioMaster` - Options menu audio master volume label

### Mod Convention (CreepingBorders)
- `UI.Nation.FromDiscontiguity` - Cohesion impact from discontiguity
- `UI.Nation.Contiguity.*` - Contiguity status values
- `UI.Nation.Landmass.*` - Landmass type labels
- `UI.Region.Tooltip.*` - Region tooltip information

## Code Usage

### Basic Localization
```csharp
// Simple string without parameters
string label = Loc.T("UI.Nation.Contiguity.Contiguous");
// Result: "Contiguous"

// String with parameters
string formatted = Loc.T("UI.Nation.FromDiscontiguity", 
	new object[] { populationValue });
// Result: "{populationValue} from territorial discontiguity..."
```

### Fallback Behavior
If a key is not found in the localization file, `Loc.T()` returns the key itself:
```
Loc.T("UI.Nation.NonExistentKey") 
// Returns: "UI.Nation.NonExistentKey" (the key name)
```

## File Structure Example

### UINation.en (10 entries)
```
UI.Nation.FromDiscontiguity={0} from territorial discontiguity (population in non-contiguous regions without island status)
UI.Nation.CohesionLimits=Calculated value: {0}. Cohesion may never go lower than 0 or higher than 10.
UI.Nation.Contiguity.Contiguous=Contiguous
UI.Nation.Contiguity.FullyDiscontiguous=Fully Discontiguous
UI.Nation.Contiguity.PartiallyDiscontiguous=Partially Discontiguous
UI.Nation.Contiguity.Unknown=Unknown
UI.Nation.Landmass.Island=Island
UI.Nation.Landmass.Continent=Continent
UI.Region.Tooltip.Landmass=Landmass Type
UI.Region.Tooltip.Contiguity=Contiguity
```

## Multi-Line Values

For multi-line descriptions, use literal newlines in the value:

```
UI.Nation.Description=First line
Second line continues here
Third line
```

Note: Most of Terra Invicta's localization is single-line for simplicity.

## Special Characters

### Handling Special Characters
- `=` - Used as delimiter between key and value, never use in key name
- `{0}`, `{1}` - Parameter placeholders in values
- Newlines - Preserved in values (use sparingly)
- Unicode - Supported (UTF-8)

### Escaping
- No escape sequences needed
- Plain text only

## Deployment

### File Location
- **Source:** `C:\Users\Chris\source\repos\CreepingBorders\UINation.en`
- **Deployed to:** `C:\Games\Steam\steamapps\common\Terra Invicta\Mods\Enabled\CreepingBorders\UINation.en`

### Deployment Method
Via `Deploy.bat` using `xcopy`:
```batch
xcopy /D /Y "!sourceDir!\UINation.en" "!targetDir!\" >nul 2>&1
```

**Flags:**
- `/D` - Only copy if source is newer (by date/time)
- `/Y` - Overwrite without prompting
- `>nul 2>&1` - Suppress output messages

### Loading in Game
1. Game startup scans mod directories
2. Loads localization files matching language setting
3. `Loc.T()` calls retrieve values at runtime
4. No restart needed for localization changes (generally)

## Adding New Localization Entries

### Steps
1. Edit `UINation.en` file
2. Add new line: `KEY=Value`
3. Use `Loc.T("KEY")` in code
4. Save file
5. Run `Deploy.bat` to copy to game directory
6. Restart game to load changes

### Example
**In UINation.en:**
```
UI.Nation.NewFeature=This is a new feature label
```

**In Code:**
```csharp
string label = Loc.T("UI.Nation.NewFeature");
```

## Best Practices

### Do's ✅
- Use hierarchical key names (Context.Category.Descriptor)
- Use consistent naming conventions
- Put all user-facing strings in localization files
- Use parameters for dynamic values
- Include context in key names for clarity

### Don'ts ❌
- Don't hardcode strings that users see
- Don't use special characters in keys (except dots)
- Don't use `=` in key names
- Don't forget to add to localization file when adding UI strings
- Don't assume fallback behavior - always provide complete keys

## Vanilla Game Localization Files

Terra Invicta includes localization files in:
- `Localization/en/` - Base game files
- `DLC_Content/*/Localization/en/` - DLC-specific files

Common file names:
- `UINotifications.en` - Notification messages
- `UIScience.en` - Science/research UI
- `TINationTemplate.en` - Nation template descriptions
- `TIRegionTemplate.en` - Region template descriptions

## Creating Additional Language Support

### File Naming
- `UINation.fr` - French
- `UINation.de` - German
- `UINation.es` - Spanish
- `UINation.zh` - Chinese
- etc.

### Key Structure
Keys remain identical across languages, only values change:

**UINation.en:**
```
UI.Nation.Contiguity.Contiguous=Contiguous
```

**UINation.fr:**
```
UI.Nation.Contiguity.Contiguous=Contigu
```

**UINation.de:**
```
UI.Nation.Contiguity.Contiguous=Zusammenhängend
```

### Deployment
Update `Deploy.bat` to include additional language files:
```batch
REM Existing code...
xcopy /D /Y "!sourceDir!\UINation.en" "!targetDir!\" >nul 2>&1

REM Add new language files:
xcopy /D /Y "!sourceDir!\UINation.fr" "!targetDir!\" >nul 2>&1
xcopy /D /Y "!sourceDir!\UINation.de" "!targetDir!\" >nul 2>&1
```

## Troubleshooting

### String Shows as Key Name
- **Cause:** Key not found in localization file
- **Solution:** Verify key name matches exactly (case-sensitive)
- **Debug:** Check `Loc.T()` call vs UINation.en key

### String Shows as Blank
- **Cause:** Value is empty or not parsed correctly
- **Solution:** Check file encoding (should be UTF-8)
- **Debug:** Verify file wasn't corrupted during editing

### Changes Not Applied
- **Cause:** Game cached old localization
- **Solution:** Restart game completely
- **Alternative:** Check file was deployed to correct mod directory

## References

### Key Naming Examples from CreepingBorders
| Context | Category | Descriptor | Full Key |
|---------|----------|-----------|----------|
| Nation | Contiguity | Contiguous | `UI.Nation.Contiguity.Contiguous` |
| Nation | Contiguity | FullyDiscontiguous | `UI.Nation.Contiguity.FullyDiscontiguous` |
| Nation | Landmass | Island | `UI.Nation.Landmass.Island` |
| Region | Tooltip | Landmass | `UI.Region.Tooltip.Landmass` |

### Character Encoding Test
To verify UTF-8 encoding in VS Code:
1. Open file
2. Check bottom-right corner shows "UTF-8"
3. If showing other encoding, click and change to "UTF-8"
4. Save file
