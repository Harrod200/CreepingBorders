# UnrestRestStateDetail Display Accuracy Verification

## Current Display Patch

**File**: `CreepingBordersCls.cs` lines 305-352

```csharp
[HarmonyPatch(typeof(TINationState), "unrestRestStateDetail", MethodType.Getter)]
public static class Patch_UnrestDisplay
{
	static void Postfix(ref string __result, TINationState __instance)
	{
		if (string.IsNullOrEmpty(__result) || __instance == null)
		{
			return;
		}

		// Replace the display of the base value (10.5) with the settings value
		string oldBaseValue = 10.5f.ToString("N1");
		string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");
		if (oldBaseValue != newBaseValue)
		{
			__result = __result.Replace(oldBaseValue, newBaseValue);
		}

		// Add discontiguity malus to the unrest breakdown if enabled
		if (CreepingBordersCls.Settings.EnableDiscontiguityMalus)
		{
			// ... insertion logic ...
		}
	}
}
```

---

## Issue 1: Base Value Replacement Logic

### The Problem:

```csharp
string oldBaseValue = 10.5f.ToString("N1");  // "10.5"
string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");  // e.g., "20.0"
if (oldBaseValue != newBaseValue)
{
	__result = __result.Replace(oldBaseValue, newBaseValue);
}
```

### Issues:
1. **Cosmetic only**: Changes the display string, not the calculation
2. **Incorrect value**: Shows `CohesionRestStateBaseValue` (which is for cohesion, not unrest)
3. **Breaks display**: Users see "20.0" as unrest base, but the formula uses 10.5
4. **Misleading**: Makes the display show WRONG information

### Example:
- `CohesionRestStateBaseValue = 20`
- Display shows: "Base Value: 20.0" ❌ WRONG (calculation uses 10.5)
- Calculation actually: `10.5 - cohesion - PCGDP + ...`
- Display vs Reality: **MISMATCH**

### Correct Approach:
Either:
- ✅ Patch `unrestRestState` to use configurable base (then display is accurate)
- ✅ Don't replace the base value display (keep it showing 10.5)
- ❌ Current: Replace display with wrong value

---

## Issue 2: Discontiguity Display

### The Implementation:

```csharp
if (CreepingBordersCls.Settings.EnableDiscontiguityMalus)
{
	float discontiguityImpact = __instance.GetDiscontiguityImpactOnCohesion();
	if (discontiguityImpact != 0f)
	{
		string discontiguityLine = "FromDiscontiguity: " + formattedValue + "\n";
		__result = __result.Insert(insertIndex, discontiguityLine);
	}
}
```

### Accuracy Assessment: ⚠️ PARTIALLY MISLEADING

**What it displays:**
```
Base Value: 10.5
From Cohesion: -8.0
FromDiscontiguity: -1.5
```

**What it should mean:**
- Discontiguity malus affects cohesion: -1.5 to cohesion
- Cohesion affects unrest inversely: -1.5 cohesion = +1.5 unrest
- So discontiguity's effect on UNREST is **+1.5** (increases unrest)

**The display is wrong because:**
1. Shows discontiguity with SAME SIGN as it affects cohesion
2. Should show OPPOSITE SIGN for unrest impact
3. **Users see -1.5 and think unrest decreases, but it actually increases**

### Correct Display Would Be:
```
Base Value: 10.5
From Cohesion: -8.0
From Discontiguity (indirect via cohesion): +1.5
```

OR better yet (to avoid confusion):
```
Base Value: 10.5
From Cohesion (including discontiguity impact): -9.5  ← Combines both
```

---

## Issue 3: Missing Components

### Vanilla Display Components:
1. Base Value: 10.5
2. From Cohesion: -cohesion
3. From PCGDP: perCapitaGDPEffectOnUnrest
4. From Armies: armyImpactOnUnrest
5. From Xenoforming: xenoformingImpactOnUnrest
6. From Hostile Claims: hostileClaimsImpactOnUnrest
7. Unrest Limits: unclamped value

### Mod Display Components:
Same + discontiguity insertion

### Missing: **No validation that discontiguity value makes sense**

The patch inserts `GetDiscontiguityImpactOnCohesion()` value, but:
- This value is **negative** (it's a malus)
- Displaying it as "FromDiscontiguity: -1.5" makes it look like it REDUCES unrest
- Actually: Negative cohesion = positive unrest

---

## Verification Results

### ✅ What's Correct:
- Discontiguity line is inserted at the right location
- Display shows the discontiguity value that exists
- Formatting is consistent with vanilla display

### ❌ What's Wrong:
1. **Base value replacement**: Shows cohesion base, not unrest base
2. **Sign/meaning**: Discontiguity shown with cohesion sign, not unrest inverse sign
3. **Underlying calculation**: Display patch doesn't fix the broken unrestRestState formula

### 🔴 Critical Flaw:
- **Display is now MISLEADING to the player**
- Player sees "FromDiscontiguity: -1.5" and thinks unrest decreases
- Actually: Cohesion decreases by 1.5, which INCREASES unrest by ~1.5
- **Player will misunderstand the game mechanics**

---

## Comparison: Expected vs Actual

### Expected Display (if working correctly):

When a nation has 50% discontiguous population with 1.5 malus:
```
Unrest Rest State Breakdown
Base Value: 10.5
From Cohesion: -8.5  (includes -1.5 from discontiguity impact)
From PC-GDP: +0.2
From Armies: +1.0
From Xenoforming: 0.0
From Hostile Claims: +0.1
Unrest Limits: 2.3
```

### Actual Current Display:

```
Unrest Rest State Breakdown
Base Value: 16.0  ← WRONG (should be 10.5, unless calculation changed)
From Cohesion: -8.0
FromDiscontiguity: -1.5  ← WRONG SIGN (should indicate +1.5 unrest)
From PC-GDP: +0.2
From Armies: +1.0
From Xenoforming: 0.0
From Hostile Claims: +0.1
Unrest Limits: 2.3
```

**Problems:**
1. Base value wrong (if CohesionRestStateBaseValue is changed)
2. Discontiguity sign wrong (shows as reducing unrest, actually increases it)
3. Math doesn't add up to the Unrest Limits value shown

---

## Summary Table

| Aspect | Expected | Actual | Status |
|--------|----------|--------|--------|
| **Base Value** | Matches calculation (10.5 or derived) | Shows CohesionRestStateBaseValue | ❌ WRONG |
| **Discontiguity Sign** | Positive (unrest increases) | Negative (misleading) | ❌ WRONG |
| **Calculation Match** | Display adds up to final value | Display doesn't match due to issues | ❌ BROKEN |
| **User Understanding** | Understands effect on unrest | Misunderstands (wrong sign) | ❌ MISLEADING |

---

## Recommendations

### Immediate Fixes Needed:

**Fix 1: Don't Replace Base Value Display**
```csharp
// REMOVE THIS:
// if (oldBaseValue != newBaseValue)
// {
//     __result = __result.Replace(oldBaseValue, newBaseValue);
// }

// The base value should ALWAYS be "10.5" in display
// because that's what the calculation uses
```

**Fix 2: Show Discontiguity with Correct Interpretation**
```csharp
// Instead of:
string discontiguityLine = "FromDiscontiguity: " + formattedValue + "\n";

// Show it as affecting cohesion:
float discontiguityValueForDisplay = -discontiguityImpact;  // Flip sign
string discontiguityLine = "FromDiscontiguity (cohesion): " + 
	discontiguityValueForDisplay.ToString("N1") + "\n";

// This makes it clear it affects cohesion, which inversely affects unrest
```

**Fix 3: Patch unrestRestState Calculation**
```csharp
// Patch TINationState.unrestRestState to use configurable base value
// OR determine unrest base from cohesion base

// This is the REAL fix that makes everything work correctly
```

---

## Verdict

🔴 **DISPLAY IS CURRENTLY INACCURATE AND MISLEADING**

1. Base value replacement is incorrect
2. Discontiguity sign creates misunderstanding
3. Display doesn't reflect actual calculation
4. Players will be confused about their nation's unrest

**Action Required**: Fix the display patch and/or the underlying calculation.

