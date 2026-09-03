# Corrected: UnrestRestStateDetail Verification

## Key Insight: Unrest and Cohesion Are Separate

Unrest is its own mechanic with base value **10.5**  
Cohesion is its own mechanic with base value **16**

They're independent. Unrest just happens to use cohesion as one input factor.

---

## Corrected Assessment

### ✅ What's Actually Correct

The vanilla unrest formula:
```csharp
unrestRestState = 10.5 - cohesion - PCGDP + armies + xenoforming + hostile
```

**This is fine as-is.** No changes needed to the calculation itself.

### 🔴 The Actual Problem: Display Patch

**Current Code (Lines 318-319):**
```csharp
string oldBaseValue = 10.5f.ToString("N1");  // "10.5"
string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");  // "20.0"
if (oldBaseValue != newBaseValue)
{
	__result = __result.Replace(oldBaseValue, newBaseValue);
}
```

**What it does:**
- Takes the unrest display string
- Finds "10.5" (unrest base)
- Replaces it with "20.0" (cohesion base)

**Why this is wrong:**
- Unrest base should ALWAYS be 10.5
- Cohesion base has nothing to do with unrest display
- Confuses the player

**Example:**
```
Player sees:                Actual calculation:
Base Value: 20.0 ❌         10.5 ✓
From Cohesion: -12.0        - cohesion_value
...                         ...
```

Player thinks base is 20, but it's actually 10.5.

---

## How Unrest Actually Works

### The Formula:
```
Unrest = 10.5 (always) - cohesion - PCGDP + armies + xenoforming + hostile
```

### How Cohesion Affects It:
- Cohesion base changes (16 → 20) ✓ Fine
- This makes cohesion values higher
- Higher cohesion values in the unrest formula = lower unrest
- This is **expected and correct**

### Example:
```
Scenario A: Cohesion base = 16
  Cohesion = 10 (with impacts)
  Unrest = 10.5 - 10 + other = X

Scenario B: Cohesion base = 20  
  Cohesion = 14 (with impacts, 4 points higher)
  Unrest = 10.5 - 14 + other = X - 4 (4 points lower due to cohesion)

✓ This is CORRECT - higher cohesion naturally lowers unrest
```

### About Discontiguity:
- Reduces cohesion by -1.5
- Unrest formula subtracts cohesion: `- (cohesion - 1.5)`
- Results in +1.5 added to unrest
- This propagates correctly through the formula ✓

**Displaying "FromDiscontiguity: -1.5" is slightly confusing** (shows cohesion impact, not unrest impact), but it's not mathematically wrong.

---

## What Needs to Be Fixed

### 🔴 Critical: Remove Base Value Replacement

**Delete these lines from the display patch (318-322):**
```csharp
string oldBaseValue = 10.5f.ToString("N1");
string newBaseValue = CreepingBordersCls.Settings.CohesionRestStateBaseValue.ToString("N1");
if (oldBaseValue != newBaseValue)
{
	__result = __result.Replace(oldBaseValue, newBaseValue);
}
```

**Why:** Replaces unrest base (10.5) with cohesion base, which is wrong.

**After fix, display will show:**
```
Base Value: 10.5  ✓ (always correct)
From Cohesion: -12.0  ✓ (actual cohesion value, which IS affected by cohesion base)
...
```

### ⚠️ Optional: Clarify Discontiguity Display

Current:
```
FromDiscontiguity: -1.5
```

Could be clarified as:
```
From Discontiguity (affects cohesion): -1.5
```

Or just left as-is since it's showing the value and players will understand.

---

## Revised Findings

### ✅ Correctly Identified:
- Vanilla unrest formula is fine
- Unrest and cohesion are separate
- Changing cohesion base doesn't break unrest
- Discontiguity correctly affects unrest via cohesion

### ❌ The Real Issue:
- Display patch replaces unrest base with cohesion base
- Creates confusion
- One line of wrong code

### 🟡 Minor Clarity Issue:
- Discontiguity display shows cohesion impact, not unrest impact
- Could be confusing but not mathematically wrong

---

## Summary

**The unrest display is MOSTLY CORRECT**, except for one problematic line that replaces the base value display.

**Fix: Remove the base value replacement code.**

After that, the calculations will be correct and the display will accurately reflect them.

