# CORRECTION: Unrest vs Cohesion - Separate Concepts

## Important Clarification

**Unrest and Cohesion are SEPARATE, INDEPENDENT concepts.**

They are not two sides of the same mechanic. They're distinct nation states with their own base values and calculations.

---

## Revised Understanding

### Vanilla Formulas (Independent)

**Cohesion:**
```csharp
cohesionRestState = 16 + impacts (clamped 0-10)
```

**Unrest:**
```csharp
unrestRestState = 10.5 - cohesion - PCGDP + armies + xenoforming + hostile (clamped 0-10)
```

**Key:** Cohesion has its own base (16) and calculations.  
**Key:** Unrest has its own base (10.5) and calculations.

They are NOT inverses. They are separate mechanics that happen to have **one interaction point**: Unrest formula includes `- cohesion` as one component.

---

## What This Means

### ✅ Cohesion Can Be Independently Modified
- Changing cohesion base value (16 → 20) is FINE
- It only affects cohesion calculations
- It doesn't need to affect unrest base (10.5)

### ❌ Display Patch Is Still Wrong
The current display patch:
```csharp
string oldBaseValue = 10.5f.ToString("N1");  // "10.5" (UNREST base)
string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");  // e.g., "20.0" (COHESION base)
__result = __result.Replace(oldBaseValue, newBaseValue);
```

**Problem:** Replaces UNREST base display with COHESION base value
- Display shows: "Base Value: 20.0"
- But calculation uses: 10.5
- **These are from different concepts!**

### ✅ Cohesion Changing DOES Affect Unrest (As Component)
Because unrest formula includes `- cohesion`:
- Higher cohesion → Lower unrest (mathematically)
- Discontiguity reduces cohesion → Increases unrest (as a component)

**This interaction is CORRECT and EXPECTED.**

### ⚠️ Discontiguity Sign Still Needs Review

In unrest display:
```
FromDiscontiguity: -1.5
```

This shows the value from cohesion (negative), but **doesn't clarify** that it means +1.5 unrest impact due to the subtraction in the formula.

---

## Revised Issue Assessment

### 🔴 Issue 1: Wrong Value Replacement (STILL CRITICAL)

**Code:**
```csharp
__result = __result.Replace("10.5", CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1"));
```

**Problem:**
- Replaces UNREST base (10.5) with COHESION base (20)
- These are from completely different concepts
- Display is now WRONG

**Example:**
```
Display shows:              Calculation uses:
Base Value: 20.0 ❌          10.5 ✓
From Cohesion: -9.0          - cohesion
From Armies: +1.0            + armies
...
Total: X                      Actual unrest = 10.5 - cohesion - ...
```

**Fix:** Don't replace the unrest base value display
```csharp
// REMOVE THIS ENTIRE BLOCK:
// string oldBaseValue = 10.5f.ToString("N1");
// string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");
// if (oldBaseValue != newBaseValue)
// {
//     __result = __result.Replace(oldBaseValue, newBaseValue);
// }
```

### ⚠️ Issue 2: Discontiguity Sign Confusion (STILL MISLEADING)

**What happens:**
1. Discontiguity malus: -1.5 on cohesion
2. Unrest formula includes: `- cohesion`
3. Result: `- (cohesion - 1.5)` = `- cohesion + 1.5` → +1.5 to unrest

**Current display:**
```
FromDiscontiguity: -1.5
```

**Problem:** User sees -1.5 and thinks it reduces unrest, but it actually increases it (because of the minus sign in the formula).

**Fix:** Either:
- Option A: Show it as affecting cohesion (keep -1.5, clarify it's cohesion impact)
- Option B: Show it as affecting unrest (+1.5, flipped sign)
- Option C: Just show the cohesion impact and skip the discontiguity line in unrest display

---

## Revised Findings Summary

### ✅ What's Now Correct:
1. Cohesion base can be changed independently
2. Unrest base can stay at 10.5
3. They're separate concepts
4. Unrest uses cohesion AS ONE COMPONENT (normal)

### ❌ What's Still Wrong:
1. **Display patch replaces 10.5 with cohesion base** - This is confusing and wrong
2. **Discontiguity sign** - Still confusing in the context of unrest impact

### 🔴 Critical Fix Needed:
**Remove or fix the base value replacement in the display patch.**

The display should show:
```
Unrest Rest State Breakdown
Base Value: 10.5  ← Always this (independent from cohesion base)
From Cohesion: -9.0  ← Reflects current cohesion value
From PC-GDP: +0.2
From Armies: +1.0
FromDiscontiguity: -1.5  ← Reflects cohesion impact
...
```

NOT:
```
Base Value: 20.0  ← WRONG! This is cohesion base, not unrest base
```

---

## Conclusion

The main issue is simpler than I initially thought:

**The display patch is trying to replace the unrest base value with the cohesion base value.**

This is wrong because they are separate concepts.

**Fix:** Remove the base value replacement code. Discontiguity sign remains a minor UI clarity issue but less critical now that we understand the concepts are separate.

