# CreepingBorders.cs - Line-by-Line Code Map

## File Structure Overview
**Total Lines**: 428  
**File**: C:\Users\Chris\source\repos\CreepingBorders\CreepingBordersCls.cs  
**Target Framework**: .NET Framework 4.8

---

## Section 1: Using Directives & Namespace (Lines 1-13)
```
1-10:   Using statements (HarmonyLib, PavonisInteractive.TerraInvicta, System.*, UnityEngine, UnityModManagerNet)
12-13:  Namespace declaration: CreepingBorders
```

---

## Section 2: Enums (Lines 15-22)
```
15-22:  LandmassType enum (Island, Continent)
```

---

## Section 3: Settings Class (Lines 24-41)
```
24:     public class CreepingBordersSettings : UnityModManager.ModSettings
25-35:  Settings properties:
		- EnableBorderExpansion (bool, default: true)
		- NoHostileClaims (bool, default: true)
		- NoDistanceCohesionMalus (bool, default: true)
		- NoPopulationMalus (bool, default: true)
		- ClaimIslandsOnCapitalContact (bool, default: false)
		- ClaimIslandsWithinDistance (bool, default: false)
		- ClaimIslandsDistanceKM (float, default: 500f)
		- CohesionRestStateBaseValue (float, default: 16f)
		- EnableDiscontiguityMalus (bool, default: false)
		- DiscontiguityMalusPercentage (float, default: 3.0f)
37-40:  Save() method override
```

---

## Section 4: Main Class & Lifecycle (Lines 43-130)
```
43:     public class CreepingBordersCls
45-47:  Static fields (mod, Settings, enabled)

49-69:  Load() method
		- Initializes settings
		- Sets up callbacks (OnToggle, OnGUI, OnSaveGUI)
		- Applies Harmony patches with error handling

71-75:  OnToggle() callback

77-130: OnGUI() method
		81-83:   Border Expansion toggle + label
		85-87:   No Hostile Claims toggle + label
		89-91:   Claim Islands on Capital Contact toggle + label
		93-95:   Claim Islands Within Distance toggle + label
		97-101:  Island Claim Distance slider (50-1000, 50 KM increments)
		103-105: No Distance Cohesion Malus toggle + label
		107-109: No Population Malus toggle + label
		111-115: Cohesion Rest State Base Value slider (-5 to +30, 0.5 increments)
		117-119: Enable Discontiguity Malus toggle + label
		121-125: Discontiguity Malus Percentage slider (conditional, 0.5-10%)
```

---

## Section 5: OnSaveGUI Method (Lines 127-130)
```
127-130: OnSaveGUI() - Saves settings when GUI is updated
```

---

## Section 6: Harmony Patches (Lines 133-428)

### Patch_CohesionRestState (Lines 135-179)
```
135:    [HarmonyPatch(typeof(TINationState), "cohesionRestState", MethodType.Getter)]
136:    public static class Patch_CohesionRestState
138:    static bool Prefix(out float __result, TINationState __instance)
		- Early return if mod disabled
		- Early return if nation not extant
		- Calculates base value from settings
		- Applies each impact factor conditionally
		- Adds discontiguity malus if enabled
		- Applies democracy impact
		- Clamps to [0f, 10f]
		- Returns false (skip vanilla)
```

### Patch_TransferRegionsControlTo (Lines 181-196)
```
181:    [HarmonyPatch(typeof(TINationState), "TransferRegionsControlTo")]
182:    public static class Patch_TransferRegionsControlTo
184:    static void Postfix()
		- Checks if mod enabled and NoHostileClaims setting
		- Clears hostile claims from all nations
```

### Patch_GetDiscontiguityImpactOnCohesion (Lines 198-247)
```
198:    public static class Patch_GetDiscontiguityImpactOnCohesion
200:    static void Postfix(ref float __result, TINationState __instance)
		- Early return if mod disabled or setting disabled
		- Handles single region or null regions (returns 0)
		- BFS algorithm to count contiguous groups:
		  - Uses visited HashSet and queue
		  - Traverses Neighbors to mark connected regions
		  - Counts total connected components
		- Calculates malus: -(groups - 1) * (percentage / 100)
```

### Patch_CohesionDisplay (Lines 305-395)
```
305:    [HarmonyPatch(typeof(TINationState), "CohesionRestStateDetail", MethodType.Getter)]
306:    public static class Patch_CohesionDisplay
308:    static bool Prefix(out string __result, TINationState __instance)
		- Initializes StringBuilder
		- Adds cohesion breakdown header
		- Uses settings base value instead of hardcoded 16f
		- Loops through all impact factors:
		  - Inequality impact
		  - Per capita GDP impact
		  - Population impact
		  - Regions impact
		  - Hostile claims impact
		  - Rivals impact
		  - Wars impact
		  - Elite divide impact
		  - Public opinion impact
		  - Autocracy impact
		  - Anocracy impact
		- Conditionally adds discontiguity impact (with coloring)
		- Handles democracy impact
		- Returns string with all impacts formatted
		- Returns false (skip vanilla)
```

### ColorCohesionRestStateValue Helper (Lines 395-400)
```
395:    private static string ColorCohesionRestStateValue(string value, float impact)
		- Returns red color tag + value for negative impact
		- Returns green color tag + value for positive impact
		- Used for formatting all impact displays
```

---

## Key Formulas & Calculations

### Cohesion Base Value
```csharp
float baseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue;
// Range: -5 to +30 (0.5 increments)
```

### Island Distance Slider
```csharp
ClaimIslandsDistanceKM = (float)System.Math.Round(ClaimIslandsDistanceKM / 50f) * 50f;
// Range: 50-1000 KM (50 KM increments)
```

### Cohesion Base Value Slider
```csharp
CohesionRestStateBaseValue = (float)System.Math.Round(CohesionRestStateBaseValue * 2f) / 2f;
// Range: -5 to +30 (0.5 increments)
```

### Discontiguity Malus
```csharp
// Formula: -(contiguousGroups - 1) * (DiscontiguityMalusPercentage / 100f)
// Example: 3 groups with 3% malus = -2 * 0.03 = -0.06
```

### Final Cohesion Clamp
```csharp
__result = Mathf.Clamp(num, 0f, 10f);
// Result range: 0 to 10 (vanilla game limit)
```

---

## Patch Interaction Flow

1. **Cohesion Calculation** → Patch_CohesionRestState (Prefix)
   - Replaces vanilla cohesion calculation
   - Applies all settings-based modifications
   - Result: Modified cohesion value [0-10]

2. **Region Transfer** → Patch_TransferRegionsControlTo (Postfix)
   - Runs after vanilla region transfer
   - Clears hostile claims if setting enabled

3. **Discontiguity Calculation** → Patch_GetDiscontiguityImpactOnCohesion (Postfix)
   - Calculates discontiguity penalty using BFS
   - Returns malus value for cohesion calculation

4. **Cohesion Display** → Patch_CohesionDisplay (Prefix)
   - Replaces vanilla cohesion detail display
   - Shows all impact factors with coloring
   - Includes discontiguity impact when enabled

---

## Settings Dependency Tree

```
EnableDiscontiguityMalus (bool)
├─ Affects: Patch_CohesionDisplay line 350
├─ Affects: Patch_CohesionRestState line 181
└─ Affects: Patch_GetDiscontiguityImpactOnCohesion line 200

CohesionRestStateBaseValue (float)
├─ Affects: Patch_CohesionRestState line 153
├─ Affects: Patch_CohesionDisplay line 317
└─ UI: Slider at line 113-115

NoDistanceCohesionMalus (bool)
├─ Affects: Patch_CohesionRestState line 164
└─ Affects: Patch_CohesionDisplay line 337

NoPopulationMalus (bool)
├─ Affects: Patch_CohesionRestState line 159
└─ Affects: Patch_CohesionDisplay line 331

NoHostileClaims (bool)
└─ Affects: Patch_TransferRegionsControlTo line 183

DiscontiguityMalusPercentage (float)
├─ Affects: Patch_GetDiscontiguityImpactOnCohesion line 244
└─ UI: Slider at line 124-125 (conditional)
```

---

## Debug & Monitoring

To monitor the mod during gameplay:
1. Check `CreepingBorders.Log` file for patch application status
2. Verify settings in mod UI (F11 in game by default)
3. Hover over cohesion values to see detailed breakdown
4. Compare cohesion calculations before/after enabling settings

All settings are saved and persist between game sessions.
