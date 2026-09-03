# Discontiguity Malus - Vanilla Cohesion Range Analysis

## Summary
The Discontiguity Malus has been calibrated to fall within vanilla cohesion impact ranges. The setting now defaults to **1.5**, producing a maximum malus of **-1.5 cohesion per 100% discontiguous population**, which is comparable to vanilla population and distance maluses.

---

## Vanilla Cohesion Impact Ranges

### Individual Impacts (Typical Mid-Game Nation)

| Impact Type | Calculation | Range | Example |
|---|---|---|---|
| **Population** | `-Mathf.Pow(population, 0.2)` | -1.0 to -3.0+ | 100M pop ≈ -1.26 |
| **Distance (Regions)** | `-(distance_km × 0.0025)` capped at -7.5 | -1.0 to -7.5 | 2000km ≈ -5.0 |
| **Per Capita GDP** | `(1 - ratio) × -inequality` | 0 to -8.0 | Poor economy ≈ -4 to -8 |
| **Public Opinion Dispersion** | `-0.5 + (ratio - 0.5) × -6` | -0.5 to -3.5 | High dispersion ≈ -3.0 |
| **Public Elite Divide** | `-Vector3.Distance × 2` | -2.0 to -6.0 | Ideological rift ≈ -4.0 |
| **Hostile Claims** | `claims × (democracy/10) × -1` | 0 to -2.0 | Few claims ≈ -0.5 to -1.0 |
| **Rivals** | `min(3, 0.5 × rival_count)` | 0 to -1.5 | 2-3 rivals ≈ -1.0 to -1.5 |
| **Wars** | `min(3, war_count)` | 0 to -3.0 | 1-2 wars ≈ -1.0 to -2.0 |
| **Anocracy (Mid-range)** | `2 × |5 - democracy| - 3` | 0 to -3.0 | Democracy 5.5 ≈ -2.0 |
| **Autocracy (Low)** | `(Pow(3.5, 1.285) - Pow(dem, 1.285)) × (10-unrest)/10` | 0 to -6.0 | Very autocratic ≈ -3.0 to -6.0 |

### Typical Mid-Game Nation Breakdown
- **Base Value**: +16.0
- **Negative Impacts (combined)**: -15.0 to -25.0
- **Net Cohesion Rest State**: 0-5 range (clamped 0-10)

---

## Discontiguity Malus Calibration

### Formula
```
Malus = -percentage_discontiguous_population × DiscontiguityMalusPercentage
```

### Scaling Examples

| Setting Value | 25% Discontiguous | 50% Discontiguous | 75% Discontiguous | 100% Discontiguous |
|---|---|---|---|---|
| **0.5** | -0.125 | -0.25 | -0.375 | -0.5 |
| **1.0** | -0.25 | -0.5 | -0.75 | -1.0 |
| **1.5** (default) | -0.375 | -0.75 | -1.125 | -1.5 |
| **2.0** | -0.5 | -1.0 | -1.5 | -2.0 |
| **3.0** | -0.75 | -1.5 | -2.25 | -3.0 |
| **5.0** | -1.25 | -2.5 | -3.75 | -5.0 |

### Comparison to Vanilla Effects

**Default Setting (1.5):**
- **-1.5 maximum malus** at 100% discontiguous population
- **Similar to**: Population malus for ~150M population nations or distance malus for ~600km spread
- **Comparable to**: Single war (-1 to -2) or 2-3 rivals (-1.0 to -1.5)

**Conservative Setting (0.5):**
- **-0.5 maximum malus** at 100% discontiguous population
- **Similar to**: Modest hostile claims or partial rival penalty
- **Use when**: Discontiguity is desired but shouldn't heavily limit expansion

**Aggressive Setting (3.0):**
- **-3.0 maximum malus** at 100% discontiguous population
- **Similar to**: Distance malus for very far-flung nations or autocracy penalty
- **Use when**: Strongly encouraging territorial consolidation

**Extreme Setting (5.0):**
- **-5.0 maximum malus** at 100% discontiguous population
- **Similar to**: Maximum distance cap or severe autocracy
- **Use when**: Forcing tight territorial control

---

## Design Rationale

### Why 1.5 as Default?
1. **Reasonable magnitude**: Falls in the -1 to -3 range of typical maluses
2. **Encouraging but not punitive**: Still allows scattered claims, but with meaningful cost
3. **Comparable impact**: Similar to having 1-2 wars or maintaining 2-3 rival tensions
4. **Tunable**: Easy to adjust up (aggressive consolidation) or down (permissive expansion)

### Implementation Details

The malus is calculated by:
1. **Finding contiguous regions** via BFS from capital (full adjacency only)
2. **Validating island chains** within `ClaimIslandsDistanceKM` distance threshold
3. **Summing population** in contiguous + valid island regions vs. total population
4. **Scaling by setting** to produce final malus value

### Considerations

- **No penalty for hostile claims**: Only owned regions count toward discontiguity
- **Compatible with vanilla settings**: Works with or without `NoDistanceCohesionMalus`
- **Island-aware**: Respects the `ClaimIslandsWithinDistance` mechanics
- **Performance**: BFS runs once per nation per cohesion calculation (cached in typical game loops)

---

## Recommendations

### For Island-Heavy Nations
- **Default 1.5**: Encourages but doesn't forbid scattered claims
- **Increase to 2.5-3.0**: If you want island chains to require consolidation

### For Compact Nations
- **Use 0.5-1.0**: Most land borders are already contiguous
- **Minimal penalty**: Discontiguity only occurs when claiming far-off regions

### For Large Expansionist Nations
- **Use 3.0-5.0**: Encourages staged expansion and consolidation
- **High penalty**: Forces difficult choices between expansion speed and cohesion

### Balancing with Other Mods
- **With NoDistanceCohesionMalus ON**: Use 1.5-3.0 to re-introduce territory penalties
- **With NoDistanceCohesionMalus OFF**: Use 0.5-1.5 to add nuance without overwhelming

---

## Testing Notes

The implementation:
- ✅ Calculates correctly for nations with no capital (returns 0)
- ✅ Respects `EnableDiscontiguityMalus` toggle
- ✅ Ignores hostile claims (only counts owned `nation.regions`)
- ✅ Works with all island distance settings
- ✅ Integrates seamlessly into cohesion calculation chain
