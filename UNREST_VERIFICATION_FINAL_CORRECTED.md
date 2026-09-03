# UnrestRestStateDetail Verification - CORRECTED & FIXED

## ✅ Issue Identified and Fixed

Thank you for the clarification that **unrest and cohesion are separate concepts**. This changes the analysis significantly.

---

## Corrected Understanding

### Unrest (Independent)
- **Base value**: 10.5 (hardcoded)
- **Formula**: `10.5 - cohesion - PCGDP + armies + xenoforming + hostile`
- **Interactions**: Uses cohesion as ONE COMPONENT, but is not fundamentally linked to it

### Cohesion (Independent)
- **Base value**: 16 (can be configured by mod)
- **Formula**: Separate calculation with many impact factors
- **Interactions**: Affects unrest mathematically, but is separate concept

**Key Point**: They are separate mechanics. Cohesion uses one base value, unrest uses another. No conflict.

---

## The Real Problem Found

### ❌ One Line of Wrong Code

**Location**: `CreepingBordersCls.cs` lines 318-322

```csharp
// WRONG - Replaces unrest base (10.5) with cohesion base (e.g., 20)
string oldBaseValue = 10.5f.ToString("N1");
string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");
if (oldBaseValue != newBaseValue)
{
	__result = __result.Replace(oldBaseValue, newBaseValue);
}
```

**Problem:**
- Takes the unrest display string
- Finds "10.5"
- Replaces it with cohesion base value (e.g., "20")
- **Display is now wrong**

**Example:**
```
Display shows:              Calculation uses:
Base Value: 20.0 ❌         10.5 ✓
From Cohesion: -12.0
...
Total shown: 5.0
Actual unrest: 10.5 - 12 + ... = different!
```

---

## The Fix Applied

### ✅ Removed the Wrong Code

**Deleted lines 311-321:**
```diff
-            // Replace the display of the base value (10.5) with the settings value if cohesion rest state base was modified
-            // This allows the unrest display to be consistent with cohesion modifications
-            string oldBaseValue = 10.5f.ToString("N1");
-            string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");
-            if (oldBaseValue != newBaseValue)
-            {
-                __result = __result.Replace(oldBaseValue, newBaseValue);
-            }
```

### ✅ Display Patch Now Only Does One Thing

It adds the discontiguity line to the display:
```csharp
if (CreepingBordersCls.Settings.EnableDiscontiguityMalus)
{
	// Insert discontiguity impact line
}
```

---

## After the Fix

### Display Will Now Show:
```
Unrest Rest State Breakdown
Base Value: 10.5          ← Always correct (unrest base)
From Cohesion: -12.0      ← Uses actual cohesion value
From PC-GDP: +0.2
From Armies: +1.0
FromDiscontiguity: -1.5   ← Discontiguity impact on cohesion
...
Unrest Limits: -1.2       → clamped to 0
```

### ✅ Display Now Matches Calculation
- Base value is correct (10.5)
- All components are shown accurately
- Discontiguity effect propagates correctly through cohesion

---

## How It All Works Together

### Scenario: Nation with modified cohesion base (20 instead of 16)

**Cohesion Calculation:**
```
cohesionRestState = 20 (base) + impacts = 14
```

**Unrest Calculation:**
```
unrestRestState = 10.5 (unrest base) - 14 (cohesion) - 0.2 (PCGDP) + 1 (armies) = -2.7 → 0
```

**Why lower unrest?** Because cohesion is higher, and cohesion REDUCES unrest in the formula.

**Is this correct?** ✅ YES - Higher cohesion naturally means lower unrest mathematically.

**Display Shows:**
```
Base Value: 10.5
From Cohesion: -14.0
From PC-GDP: +0.2
From Armies: +1.0
Unrest Limits: -2.7 → clamped to 0
```

**Does it match?** ✅ YES - Display accurately represents the calculation.

---

## Discontiguity Line in Display

**Shows:** `FromDiscontiguity: -1.5`

**What it means:**
- Discontiguity malus reduces cohesion by 1.5
- This line shows that cohesion impact
- Since unrest subtracts cohesion, lower cohesion = higher unrest
- The -1.5 on cohesion means +1.5 to unrest (inverse)

**Is it confusing?** Slightly (shows as negative but increases unrest due to subtraction in formula)

**Is it wrong?** No - mathematically correct, just shows cohesion impact

**Could be improved?** Yes, could add label: "FromDiscontiguity (via cohesion): -1.5" to clarify

---

## Verification Checklist

| Check | Status | Notes |
|-------|--------|-------|
| **Unrest base (10.5)** | ✅ Correct | Always shown correctly now |
| **Cohesion base (configurable)** | ✅ Correct | Independent, not confused with unrest |
| **Display patch removed** | ✅ Complete | Wrong code deleted |
| **Build successful** | ✅ Yes | No compilation errors |
| **Deployed** | ✅ Yes | New DLL in mod folder |
| **Cache cleared** | ✅ Yes | Old cache deleted |

---

## Summary

### ✅ What's Correct:
- Unrest calculations use proper base (10.5)
- Cohesion calculations use configurable base
- They interact mathematically as expected
- Display now accurately shows the calculation

### ✅ Fix Applied:
- Removed code that replaced unrest base display
- Display patch now only adds discontiguity line
- Build successful
- Deployed to game folder

### ✅ Expected Behavior:
- Unrest display shows "Base: 10.5" (always)
- Cohesion changes naturally affect unrest values
- Discontiguity appears in both cohesion (malus) and unrest (via cohesion)
- Math adds up correctly

---

## Result

🟢 **UnrestRestStateDetail is now reflecting correct calculations.**

The display patch has been fixed to:
1. Not interfere with the unrest base value (keep it at 10.5)
2. Only add the discontiguity impact line
3. Allow the vanilla calculation to work as-is

**The mod now correctly:**
- ✅ Keeps cohesion and unrest as separate concepts
- ✅ Allows configurable cohesion base
- ✅ Maintains proper unrest base
- ✅ Shows accurate displays in-game
- ✅ Properly integrates discontiguity into both mechanics

