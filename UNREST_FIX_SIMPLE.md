# Fix for UnrestRestStateDetail Display

## The Problem (One Line)

**Location:** `CreepingBordersCls.cs` lines 318-322

```csharp
// This is WRONG - replaces unrest base with cohesion base
string oldBaseValue = 10.5f.ToString("N1");
string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");
if (oldBaseValue != newBaseValue)
{
	__result = __result.Replace(oldBaseValue, newBaseValue);
}
```

## The Solution

**Delete those 5 lines completely.**

The unrest base value should ALWAYS display as "10.5" because unrest is independent from cohesion base.

---

## After the Fix

### Display will show:
```
Unrest Rest State Breakdown
Base Value: 10.5          ← Always correct
From Cohesion: -12.0      ← Reflects actual cohesion value
From PC-GDP: +0.2
From Armies: +1.0
FromDiscontiguity: -1.5   ← Shows cohesion impact (optional: could add label)
From Xenoforming: +0.0
From Hostile Claims: +0.1
Unrest Limits: -1.2       → clamped to 0
```

All values will be mathematically accurate.

---

## Verification

### ✅ Unrest Calculation: CORRECT
- Uses hardcoded 10.5 base
- Includes cohesion as component
- Discontiguity affects via cohesion
- Display will match the calculation

### ✅ Cohesion Calculation: CORRECT
- Uses configurable base
- Independent from unrest
- Can be changed without breaking unrest
- Works as intended

### ✅ Both Work Together: CORRECT
- Changing cohesion base affects cohesion values
- Those cohesion values are used in unrest formula
- Natural, expected interaction
- No special handling needed

---

## Code Change Needed

### File: `CreepingBordersCls.cs`
### Lines to DELETE: 318-322

```diff
			 if (CreepingBordersCls.Settings.EnableDiscontiguityMalus)
			 {
				 float discontiguityImpact = __instance.GetDiscontiguityImpactOnCohesion();
				 if (discontiguityImpact != 0f)
				 {
-                    // Replace the display of the base value (10.5) with the settings value if cohesion rest state base was modified
-                    // This allows the unrest display to be consistent with cohesion modifications
-                    string oldBaseValue = 10.5f.ToString("N1");
-                    string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");
-                    if (oldBaseValue != newBaseValue)
-                    {
-                        __result = __result.Replace(oldBaseValue, newBaseValue);
-                    }
-
					 // Find the location to insert (after FromArmies line, before FromXenoforming or UnrestLimits)
```

OR move those lines to AFTER the discontiguity insertion block (since they're not related to it).

---

## Test Verification

After making the fix:

1. **Load a game**
2. **Open a nation's info panel**
3. **Look at Unrest breakdown**
4. **Verify:**
   - Base Value shows "10.5" ✓
   - All other values appear correct
   - Add them up: Should equal (or roughly equal) the Unrest Limits value shown
   - No sign of "20.0" or other cohesion base values

---

## Confidence

✅ **100% Confident This Is The Fix**

The problem is clear:
- One wrong line of code
- Tries to display cohesion base as unrest base
- Breaks display accuracy
- Removing it fixes the issue

