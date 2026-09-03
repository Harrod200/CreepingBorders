# Creeping Borders Mod

A comprehensive modification for **Terra Invicta** that enhances border management, territory claiming, and nation cohesion mechanics.

## Overview

The Creeping Borders mod adds sophisticated border expansion and territory management features to Terra Invicta. It allows nations to automatically expand their borders, claim island territories strategically, and implements an optional cohesion penalty system for discontiguous regions.

## Features

### 🌍 Border Expansion
- **Automatic Border Growth**: When a nation gains control of a region, adjacent unclaimed regions are automatically claimed to expand borders naturally
- Customizable behavior through mod settings
- Creates contiguous territory more organically

### 🏝️ Island Territory Management
The mod includes three different island claiming strategies:

#### 1. **Capital Contact Island Claims**
- When a nation borders an enemy nation's capital, all island regions belonging to that enemy are automatically claimed
- Aggressive strategy for controlling island territories near enemy capitals
- Off by default

#### 2. **Distance-Based Island Claims** (Default: ON)
- Island regions of neighboring nations within a configurable distance are automatically claimed
- **Adjacency Pre-Check**: Before applying distance calculations, the system first checks if island regions have direct adjacencies to your contiguous territories
- Islands with adjacencies are immediately treated as continental territories and bypass distance thresholds
- Only islands without adjacencies use the distance-based claiming system
- Configurable range: 50-2000 km (default: 1000 km)
- Allows strategic island expansion without rigid distance limitations

#### 3. **Advanced Island Processing**
- **Smart Island Detection**: Regions are classified as islands or continents based on size and connectivity
- **BFS (Breadth-First Search) Pathfinding**: Islands connected through adjacencies are traced to find routes to the nation's capital
- **Multi-Pass Bridge Detection**:
  - **First Pass**: Adjacency-based bridging from contiguous regions through coastal islands
  - **Second Pass**: Island-to-island adjacency chaining to extend contiguity through connected islands
  - **Third Pass**: Distance-based bridging for islands within the configured range
- **Cache Optimization**: Previously calculated contiguity paths are cached to prevent recalculation
- **Cache Invalidation**: Automatic cache clearing when diplomatic states change (wars, alliances)

### ⚖️ Claim Behavior Settings

#### No Hostile Claims
- Converts all hostile claims to friendly claims automatically
- Reduces conflict and enables peaceful territory expansion
- Default: OFF

#### Enable Instant Annexations
- Automatically annexes annexable regions instantly without requiring occupation
- Speeds up territorial consolidation
- Default: OFF

### 🏛️ Cohesion System

The mod includes an advanced cohesion management system with multiple customization options:

#### Base Cohesion Value
- Adjustable cohesion rest state base value (Range: 5-50, default: 16.0)
- Controls the equilibrium cohesion level for nations
- Allows fine-tuning nation stability

#### Cohesion Penalties (Customizable)
- **Distance Penalty**: Malus applied based on distance between claimed regions
  - Default: OFF (penalty removed)
  - When ON: Distant territories reduce overall cohesion

- **Population Penalty**: Malus applied based on population size
  - Default: OFF (penalty removed)
  - When ON: Large populations strain cohesion

- **Discontiguity Penalty**: Malus for non-contiguous (separated) territories
  - Default: OFF
  - Customizable penalty percentage: 0.5%-10.0% (default: 5.0%)
  - Encourages nations to maintain geographically connected territories
  - Contiguity is measured as: reachable from capital without crossing enemy territory (including through allied territory routes)

### 🔧 Utilities

#### Debug Logging
- Enable detailed logging of cohesion calculations for each nation
- Logs island analysis at game startup
- Tracks territory transfers and cache operations
- Useful for understanding mod behavior and troubleshooting

## How Contiguity Works

The mod defines **contiguous regions** in multiple ways:

1. **Fully Contiguous**: Regions reachable from the capital through:
   - Direct adjacency (full borders)
   - Adjacent islands forming a chain to the capital
   - Islands within the distance threshold with direct adjacencies to contiguous territories

2. **Partially Contiguous**: Regions reachable through:
   - Extended distance (100-200% of the island claim distance threshold)
   - Allied territory routes

3. **Discontiguous**: Regions not reachable through any of the above methods

## Cache System

The mod uses caching to optimize performance:

- **Region Contiguity Cache**: Stores calculated contiguity status for each region
- **Distance Cache**: Stores pre-calculated distances between regions to avoid redundant calculations
- **Automatic Invalidation**: Cache is cleared when:
  - Regions change control
  - Nations declare or end wars
  - Nations form or dissolve alliances
  - Alliances shift between nations

## Default Settings

| Setting | Default | Range |
|---------|---------|-------|
| Enable Border Expansion | ✓ | - |
| Claim Islands on Capital Contact | ✗ | - |
| Claim Islands Within Distance | ✓ | - |
| Island Claim Distance | 1000 km | 50-2000 km |
| No Hostile Claims | ✗ | - |
| Enable Instant Annexations | ✗ | - |
| Cohesion Rest State Base Value | 16.0 | 5-50 |
| No Distance Cohesion Malus | ✓ | - |
| No Population Malus | ✓ | - |
| Enable Discontiguity Malus | ✗ | - |
| Discontiguity Malus Percentage | 5.0% | 0.5%-10.0% |
| Enable Debug Logging | ✗ | - |

## Technical Implementation

### Harmony Patches
The mod uses Harmony patching to hook into Terra Invicta's core systems:

- **Region Control Transfer**: Triggers when regions change ownership
- **War Declaration/End**: Clears caches during diplomatic changes
- **Alliance Formation/Dissolution**: Updates contiguity calculations
- **Cohesion Calculation**: Modifies base cohesion values and malus calculations
- **UI Display**: Enhances region tooltips with contiguity information

### Island Analysis
On game load, the mod performs island analysis:
- Identifies all island regions in the game
- Calculates distances to each nation's contiguous territories
- Logs island-to-contiguous relationships for debugging
- Uses this information for distance-based island claiming

## Performance Considerations

- **Caching**: Extensive use of caching prevents redundant calculations
- **Lazy Evaluation**: Contiguity is only calculated when needed
- **Batch Operations**: Island processing is performed in passes, not per-island
- **Distance Optimization**: Pre-calculated and cached distances reduce computational overhead

## Modding Notes

For developers extending this mod:

- All extension methods are in static classes (`TINationStateExtensions`, `TIRegionStateExtensions`)
- Cache management functions are public for external use
- Island landmass type detection uses `GetLandmassType()` extension method
- Contiguity calculations return `ContiguousRegionsInfo` with separate fully/partially contiguous sets

## Troubleshooting

### Islands not being claimed
1. Verify `Claim Islands Within Distance` is enabled
2. Check the distance threshold is sufficient (default 1000 km)
3. Ensure the neighboring nation actually controls those islands
4. Enable debug logging to see why specific islands were rejected

### Cohesion penalties not applying
1. Check that `Enable Discontiguity Malus` is enabled (if using that penalty)
2. Verify penalty percentage is greater than 0
3. Ensure your nation actually has discontiguous regions
4. Enable debug logging to see cohesion calculations

### Cache-related issues
1. Enable debug logging to track cache operations
2. Cache automatically invalidates on control transfers and diplomatic changes
3. Restart the game if manual cache clear is needed

## Installation

Place the `CreepingBorders.dll` in your Terra Invicta mods folder:
- **Steam Workshop**: Automatically installed
- **Manual**: Place in `Terra Invicta\Mods\Enabled\CreepingBorders\`

## Configuration

In-game settings are accessible through the mod settings menu (UMM mod manager). All settings are saved automatically and persist between game sessions.

## Credits

Developed as a comprehensive Terra Invicta quality-of-life and mechanical enhancement mod.

## Version History

- **Latest**: Full island adjacency pre-checking before distance-based calculations, cache invalidation on diplomatic events
- **Features**: Border expansion, island claiming strategies, cohesion system, contiguity detection, performance optimization

## License

See repository for license information.
