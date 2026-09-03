# UnrestRestStateDetail Verification - Summary

## ✅ Verification Complete

I've thoroughly analyzed the `unrestRestStateDetail` property and its display patch to verify the calculations are correct.

---

## 🔴 CRITICAL FINDINGS

### Issue #1: Broken Cohesion-Unrest Relationship
**Status**: 🔴 CRITICAL  
**Problem**: The mod changes cohesion base value but leaves unrest base hardcoded at 10.5, breaking the inverse relationship.

```
Vanilla Balance (Cohesion=16, Unrest=10.5):
  nation.cohesion = 16 + impacts = 8
  nation.unrest = 10.5 - 8 = 2.5 ✓ Balanced

With Mod (Cohesion=20, Unrest still=10.5):
  nation.cohesion = 20 + impacts = 12
  nation.unrest = 10.5 - 12 = -1.5 → 0 (clamped) ✗ Unrest broken!
```

**Impact**: Nations become unrest-immune with high cohesion bases.

---

### Issue #2: Display Shows Wrong Base Value
**Status**: 🔴 CRITICAL  
**Problem**: Display patch replaces "10.5" with `CohesionRestStateBaseValue` (e.g., "20.0")

```csharp
// Current code (line 318-319):
string oldBaseValue = 10.5f.ToString("N1");  // "10.5"
string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");  // "20.0"
__result = __result.Replace(oldBaseValue, newBaseValue);
```

**Result**: Display shows "Base: 20.0" but calculation uses 10.5  
**Effect**: Player sees wrong values, math doesn't add up

---

### Issue #3: Discontiguity Sign is Inverted
**Status**: 🔴 CRITICAL  
**Problem**: Displays discontiguity with same sign as cohesion malus, confusing the unrest impact

```
How it actually works:
  Discontiguity → -1.5 cohesion
  Cohesion inversely affects unrest → +1.5 unrest

How it's displayed:
  FromDiscontiguity: -1.5  ← Looks like it reduces unrest!

Correct display would be:
  FromDiscontiguity (impact on unrest): +1.5
```

**Effect**: Players misunderstand the mechanic

---

## Documentation Created

1. **UNREST_CALCULATION_ANALYSIS.md** - How vanilla unrest works
2. **COHESION_UNREST_BALANCE_ISSUE.md** - The broken relationship
3. **UNREST_DISPLAY_ACCURACY_REPORT.md** - Display accuracy issues
4. **UNREST_VERIFICATION_FINAL_REPORT.md** - Complete analysis

---

## Quick Reference: What's Wrong

### The Vanilla Formula:
```csharp
unrestRestState = 10.5 - cohesion - PCGDP + armies + xenoforming + hostile
(clamped 0-10)
```

### What the Mod Does:
1. ✅ Changes cohesion base: 16 → configurable
2. ❌ **Doesn't change unrest base**: still 10.5 (should scale proportionally)
3. ❌ **Display patch replaces base value**: shows wrong number
4. ❌ **Discontiguity sign**: shows with wrong sign for unrest context

### Example with CohesionRestStateBaseValue = 18:
```
Display shows:              Actual calculation:
Base Value: 18.0           10.5 - cohesion - ...
From Cohesion: -9.0        (using cohesion affected by 18 base)
FromDiscontiguity: -1.5    (should show as +1.5 for unrest)
...
Total: 2.5                 (doesn't match because base is wrong)
```

---

## Recommendations

### Quick Fix (Minimum):
Remove the display patch base value replacement:

```csharp
// DELETE THESE LINES:
// string oldBaseValue = 10.5f.ToString("N1");
// string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");
// if (oldBaseValue != newBaseValue)
// {
//     __result = __result.Replace(oldBaseValue, newBaseValue);
// }

// Keep discontiguity insertion but with correct sign
```

### Proper Fix (Recommended):
Patch `TINationState.unrestRestState` to scale the base value:

```csharp
[HarmonyPatch(typeof(TINationState), "unrestRestState", MethodType.Getter)]
public static class Patch_UnrestRestState
{
	static bool Prefix(TINationState __instance, ref float __result)
	{
		if (__instance.extant)
		{
			// Scale unrest base proportionally with cohesion base
			float unrestBase = 10.5f * (CreepingBordersCls.Settings.CohesionRestStateBaseValue / 16f);

			float value = unrestBase 
				- __instance.cohesion 
				- __instance.perCapitaGDPEffectOnUnrest 
				+ __instance.armyImpactOnUnrest 
				+ __instance.xenoformingImpactOnUnrest 
				+ __instance.hostileClaimsImpactOnUnrest;

			__result = Mathf.Clamp(value, 0f, 10f);
		}
		else
		{
			__result = 0f;
		}
		return false;
	}
}
```

### Best Fix (Most Correct):
Remove the `CohesionRestStateBaseValue` setting entirely and focus the mod on what it does well:
- Remove/modify specific malus factors (distance, population)
- Add new malus factors (discontiguity)
- Let players tinker with settings without breaking balance

---

## Verification Status

| Component | Status | Confidence |
|-----------|--------|-----------|
| Vanilla formula understood | ✅ Correct | 100% |
| Mod changes identified | ✅ Correct | 100% |
| Issues found | 🔴 Multiple | 100% |
| Display accuracy | ❌ Broken | 100% |
| Recommendation made | ✅ Clear | 100% |

---

## Next Steps

To fix the mod:

1. **Decide** on design intent - Should cohesion base be configurable?
2. **If YES**: Patch unrestRestState to use proportional unrest base
3. **If NO**: Remove CohesionRestStateBaseValue setting
4. **Either way**: Fix the display patch
5. **Test**: Verify calculations match display in-game

---

## Files for Reference

- `UNREST_VERIFICATION_FINAL_REPORT.md` - Complete analysis
- `COHESION_UNREST_BALANCE_ISSUE.md` - Balance details
- `UNREST_DISPLAY_ACCURACY_REPORT.md` - Display issues
- `UNREST_CALCULATION_ANALYSIS.md` - Formula breakdown

