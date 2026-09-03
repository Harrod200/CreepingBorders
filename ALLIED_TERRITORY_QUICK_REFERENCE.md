# Quick Reference: Allied Territory Discontiguity Amendment

## What Changed

### New Method
**`GetDiscontiguousRegionsReachableThroughAllies(nation, discontiguousRegions)`**
- BFS through own + allied territory
- Returns regions reachable via allies
- Returns empty set if no allies

### Modified Method
**`GetDiscontiguityImpactOnCohesion(nation)`**
- Now calls helper to identify ally-reachable regions
- Splits penalty into two tiers:
  - **Unreachable through allies:** Full penalty
  - **Reachable through allies:** Half penalty (0.5×)
- Enhanced debug logging

---

## Penalty Examples

### With 3% Discontiguity Malus Setting

| Scenario | Population | Reachable | Penalty |
|----------|-----------|-----------|---------|
| Island (no allies) | 1M | 0% | -3.00 |
| Partial connection | 1M | 50% | -2.25 |
| Full connection | 1M | 100% | -1.50 |
| Multiple isolated | 1M | 0% | -3.00 |

---

## How It Works

### Step 1: Find Discontiguous Regions
Normal BFS from capital through own regions only
→ Identifies truly isolated territory

### Step 2: Check Allied Access
Expanded BFS through own + allied regions
→ Identifies which isolated regions ARE accessible via allies

### Step 3: Calculate Split Penalty
- Portion unreachable through allies: Full penalty
- Portion reachable through allies: Half penalty
- Total: Weighted combination

### Step 4: Apply to Cohesion
Final penalty added to nation's cohesion calculation

---

## Debug Output

**Enable:** `EnableDebugLogging = true` in mod settings

**Output:**
```
[Discontiguity] Total Population: 2,500,000, 
Full Penalty Pop: 1,200,000, Half Penalty Pop: 1,300,000, 
Full Penalty: -3.60, Half Penalty: -1.95, Total Penalty: -5.55
```

**Interpretation:**
- Total discontiguous: 2.5M population
- Only reachable via allies: 1.3M (-1.95 penalty)
- Completely isolated: 1.2M (-3.60 penalty)
- Total impact: -5.55 cohesion penalty

---

## Edge Cases

| Situation | Behavior |
|-----------|----------|
| No allies | No reduction (empty ally list) |
| No discontiguous regions | No penalty (returns 0f) |
| Only 1 region | No penalty (early return) |
| All regions reachable | 50% penalty reduction |
| War with allies | Treated as discontiguous (enemies are blockers) |

---

## Code Snippets

### Getting Ally-Reachable Regions
```csharp
var allyReachable = GetDiscontiguousRegionsReachableThroughAllies(
	nation, 
	discontiguousRegions
);
```

### Calculating Split Penalty
```csharp
float fullPenalty = -(fullPop / 1000000f) * malusPercentage;
float halfPenalty = -(halfPop / 1000000f) * malusPercentage * 0.5f;
float total = fullPenalty + halfPenalty;
```

---

## Testing

### Quick Test
1. Enable debug logging
2. Play a game with multi-nation alliance
3. Create discontiguous territory in one nation
4. Check log shows split penalties
5. Verify cohesion display shows reduced penalty

### Thorough Test
1. No allies scenario - penalty should be same as before
2. Full ally connection - penalty should be ~50% of isolated
3. Partial ally connection - penalty should be between
4. War with ally - no access through them (treated as enemy)

---

## Performance Impact

- **New BFS:** Only on discontiguous regions (small subset)
- **Complexity:** O(d × n) where d = discontiguous, n = neighbors
- **Cost:** Negligible (runs once per cohesion calculation)
- **Scaling:** Minimal even for large nations

---

## Related Configuration

### Mod Settings
- `EnableDiscontiguityMalus` - Enable/disable feature
- `DiscontiguityMalusPercentage` - Base penalty percentage
- `EnableDebugLogging` - Show calculation details

### Vanilla Integration
- `nation.allies` - List of allied nations
- `ally.regions` - Regions owned by ally
- `region.IsAdjacent()` - Adjacency checks
- `TIFrameCounter` - Frame counting

---

## Compatibility Notes

✅ **Backward Compatible** - No breaking changes
✅ **Vanilla Alignment** - Uses standard TINationState properties
✅ **No Conflicts** - Isolated to cohesion calculation
✅ **Extensible** - Easy to modify reduction percentage if needed

---

## Common Questions

**Q: Why half penalty and not no penalty?**
A: Alliances can be broken. Still incentivizes good territorial planning while rewarding diplomacy.

**Q: Do enemy regions block ally routes?**
A: Yes. Enemies are treated as barriers just like in direct contiguity check.

**Q: What about vassals or other allies types?**
A: Currently only checks `nation.allies`. Could be extended if needed.

**Q: Does this apply to island regions?**
A: Yes, if island can be reached through allied territory, it gets reduced penalty.

**Q: Can penalty be reduced below -10?**
A: No, clamped to -10 minimum (same as before).

---

## Implementation Checklist

- [x] Helper method created
- [x] Main method modified
- [x] Debug logging added
- [x] Code compiles successfully
- [x] Documentation complete
- [ ] Tested in-game
- [ ] Verified with debug logs
- [ ] No regressions detected

---

## Key Files

**File:** `CreepingBordersCls.cs`

**Methods:**
- `GetDiscontiguousRegionsReachableThroughAllies()` - NEW
- `GetDiscontiguityImpactOnCohesion()` - MODIFIED
- `GetTrueContiguousRegions()` - UNCHANGED (uses for first pass)
- `ColorCohesionRestStateValue()` - UNCHANGED (uses for UI)

**Related:**
- Cohesion patch at lines ~610 (unchanged)
- Settings class with `EnableDiscontiguityMalus` (unchanged)

---

## Next Steps

1. **Test in-game:**
   - Create alliance with discontiguous territory
   - Enable debug logging
   - Verify penalty reduction

2. **Optional enhancements:**
   - Config option for reduction percentage
   - Different percentages per tier
   - UI indicator for ally-connected regions

3. **Documentation:**
   - Update mod description if published
   - Document new behavior for users
   - Include in changelog
