# CRITICAL FIX: Patch Target Correction

## 🔴 Issue Found

The display patch was targeting the **WRONG PROPERTY**.

### ❌ What It Was Doing:
```csharp
[HarmonyPatch(typeof(TINationState), "unrestRestStateDetail", MethodType.Getter)]  // WRONG!
public static class Patch_UnrestDisplay
```

- Patching `unrestRestStateDetail` (unrest display)
- Trying to replace base value (10.5) with cohesion base (16)
- Trying to add discontiguity to UNREST display
- **This is completely backwards!**

### ✅ What It Should Do:
```csharp
[HarmonyPatch(typeof(TINationState), "CohesionRestStateDetail", MethodType.Getter)]  // CORRECT!
public static class Patch_CohesionDisplay
```

- Patch `CohesionRestStateDetail` (cohesion display)
- Replace base value (16.0) with `CohesionRestStateBaseValue` setting
- Add discontiguity to COHESION display (where it belongs!)
- **This is where the changes should apply!**

---

## Why This Matters

### Cohesion Display Should Show:
- Base value: 16.0 (or configured value)
- All cohesion impact factors
- **NEW: Discontiguity malus** (affects cohesion)
- Cohesion Limits (final value)

**Example:**
```
Cohesion Rest State Breakdown
Base Value: 20.0  ← Configurable
From Inequality: -0.5
From Low PC-GDP: -1.0
From Population: -1.5
From Regions: -2.0
From Hostile Claims: -0.2
...
From Discontiguity: -1.5  ← NEW: Shows the malus
Cohesion Limits: 13.3
```

### Unrest Display Should Show:
- Base value: 10.5 (always)
- All unrest impact factors
- Unrest Limits (final value)

**NOT affected by discontiguity directly** - discontiguity affects cohesion, which then affects unrest mathematically.

---

## The Fix Applied

### Changed:
- **From**: `[HarmonyPatch(typeof(TINationState), "unrestRestStateDetail", MethodType.Getter)]`
- **To**: `[HarmonyPatch(typeof(TINationState), "CohesionRestStateDetail", MethodType.Getter)]`

### Changed:
- **From**: Replace base "10.5" with cohesion base
- **To**: Replace base "16.00" with cohesion base

### Changed:
- **From**: Insert before "Unrest Limits"
- **To**: Insert before "Cohesion Limits"

### Changed:
- **From**: `"FromDiscontiguity: "`
- **To**: `"From Discontiguity: "` (formatting consistency)

### Changed:
- **From**: Format discontiguity as "N1" (1 decimal)
- **To**: Format as "N2" (2 decimals, matches cohesion display format)

---

## Now Correct

### ✅ Cohesion Display Patch:
- Patches the right property: `CohesionRestStateDetail`
- Replaces the right base value: 16.0 → configurable
- Adds discontiguity in the right place: cohesion breakdown
- Shows the right format: matches vanilla display

### ✅ Unrest Display:
- Untouched (as it should be)
- Shows correct base: 10.5 (always)
- Works independently from cohesion display
- Unrest values affected by cohesion changes mathematically (correct)

---

## How It Works Now

### Scenario: CohesionRestStateBaseValue = 20, EnableDiscontiguityMalus = true, Discontiguity = -1.5

**Cohesion Display Shows:**
```
Cohesion Rest State Breakdown
Base Value: 20.0              ← Updated from setting
From Inequality: -0.5
From Low PC-GDP: -1.0
From Population: -1.5
From Regions: -2.0
From Hostile Claims: -0.2
From Rivals: -0.5
From Wars: -1.0
From Ideology: -1.2
From Internal Differences: -0.8
From Autocracy: 0.0
From Anocracy: 0.0
From Democracy: +0.5
From Discontiguity: -1.5       ← NEW: Discontiguity malus
Cohesion Limits: 9.3
```

**Unrest Display Shows:**
```
Unrest Rest State Breakdown
Base Value: 10.5              ← Always 10.5 (independent)
From Cohesion: -9.3           ← Uses actual cohesion value
From PC-GDP: +0.2
From Armies: +1.0
...
Unrest Limits: 2.0
```

**How they interact:**
- Cohesion is 9.3 (affected by 20.0 base and -1.5 discontiguity)
- Unrest subtracts cohesion: 10.5 - 9.3 = 1.2 (before other factors)
- Discontiguity affects cohesion, which inversely affects unrest ✓
- **All displays are accurate and consistent** ✓

---

## Verification

| Check | Status |
|-------|--------|
| **Patch target** | ✅ Corrected to CohesionRestStateDetail |
| **Base value replacement** | ✅ Now replaces 16.0 with CohesionRestStateBaseValue |
| **Discontiguity insertion** | ✅ Now in cohesion display (correct location) |
| **Discontiguity format** | ✅ Changed to N2 (matches cohesion display) |
| **Unrest display** | ✅ Left untouched (as it should be) |
| **Build** | ✅ Successful |
| **Deploy** | ✅ Complete with cache cleanup |

---

## Summary

🟢 **CRITICAL BUG FIXED**

The display patch was applying to the wrong property entirely. It should patch the **cohesion display**, not the unrest display.

**Now:**
- ✅ Cohesion display shows configurable base value
- ✅ Cohesion display shows discontiguity malus
- ✅ Unrest display remains independent and correct
- ✅ Both displays accurately reflect their respective calculations

**The mod now correctly:**
- Modifies cohesion calculations (base value, discontiguity malus)
- Displays those modifications in cohesion breakdown
- Leaves unrest independent (as it should be)
- Shows accurate information to the player

