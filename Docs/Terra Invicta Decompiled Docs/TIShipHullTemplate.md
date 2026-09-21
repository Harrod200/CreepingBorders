# TIShipHullTemplate

*Decompiled from `TIShipHullTemplate.cs`.*


## Class `TIShipHullTemplate`

```csharp
public class TIShipHullTemplate : TIShipModuleTemplate
```

### Fields

| Name | Type |
|---|---|
| `description` | public override string |
| `allowedSlots` | public override List<ShipModuleSlotType> |
| `volume_m3` | public float |
| `capSurfaceArea_m2` | public float |
| `largeHull` | public bool |
| `smallHull` | public bool |
| `hugeHull` | public bool |
| `mediumHull` | public bool |
| `maxNoseArmorDepth_m` | public float |
| `maxTailArmorDepth_m` | public float |
| `maxLateralArmorDepth_m` | public float |
| `baseArmorCapAngleCoverage_deg_realisticScaling` | public float |
| `noseHardpoints` | public int |
| `hullHardpoints` | public int |
| `internalModules` | public int |
| `length_m` | public float |
| `width_m` | public float |
| `thrusterMultiplier` | public int |
| `structuralIntegrity` | public int |
| `monthlyIncome_Money` | public float |
| `missionControl` | public int |
| `alien` | public bool |
| `baseConstructionTime_days` | public float |
| `consTier` | public int |
| `maxOfficers` | public int |
| `simpleHull` | public bool |
| `noShipyardBuild` | public bool |
| `path1` | public string[] |
| `path2` | public string[] |
| `shipyardyOffset` | public float[] |
| `modelResource` | public new string[] |
| `combatUIpath` | public new string[] |
| `shipModuleSlots` | public List<TIShipHullTemplate.ShipModuleSlot> |
| `ShipModuleSlot` | public struct |
| `slotPosition` | public Vector2Int |
| `weaponSlot` | public bool |
| `armorSlot` | public bool |
| `x` | public int |
| `y` | public int |
| `moduleSlotType` | public ShipModuleSlotType |

### Methods

```csharp
public int slotIndex(TIShipHullTemplate.ShipModuleSlot shipModuleSlot)
```

```csharp
public float noShipyardConstructionTime_Days(TIFactionState faction)
```

```csharp
public float constructionTime_Days(TIHabModuleState shipyard)
```

```csharp
public float constructionTime_Days(int shipyardTier, TIFactionState faction)
```

```csharp
public string combatUINosePath_OK(int idx)
```

```csharp
public string combatUINosePath_Damaged(int idx)
```

```csharp
public string combatUINosePath_Destroyed(int idx)
```

```csharp
public string combatUIMidPath_OK(int idx)
```

```csharp
public string combatUIMidPath_Damaged(int idx)
```

```csharp
public string combatUIMidPath_Destroyed(int idx)
```

```csharp
public string combatUITailPath_OK(int idx)
```

```csharp
public string combatUITailPath_Damaged(int idx)
```

```csharp
public string combatUITailPath_Destroyed(int idx)
```

```csharp
public string combatUINoseArmorPath_OK(int idx)
```

```csharp
public string combatUINoseArmorPath_Destroyed(int idx)
```

```csharp
public string combatUIPortArmorPath_OK(int idx)
```

```csharp
public string combatUIPortArmorPath_Destroyed(int idx)
```

```csharp
public string combatUIStarboardArmorPath_OK(int idx)
```

```csharp
public string combatUIStarboardArmorPath_Destroyed(int idx)
```

```csharp
public string combatUITailArmorPath_OK(int idx)
```

```csharp
public string combatUITailArmorPath_Destroyed(int idx)
```

```csharp
public string largeCombatUIPath(int idx)
```

```csharp
public string noseUIResourcePath(int idx)
```

```csharp
public string midUIResourcePath(int idx)
```

```csharp
public string tailUIResourcePath(int idx)
```

```csharp
public Vector2Int GetUniqueSlotCoordinates(ShipModuleSlotType slotType)
```

```csharp
public int GetUniqueSlotIndex(ShipModuleSlotType slotType)
```

```csharp
public TIShipHullTemplate.ShipModuleSlot GetSlotByCoordinates(int x, int y)
```

```csharp
public TIShipHullTemplate.ShipModuleSlot GetSlotByCoordinates(Vector2 coordinates)
```

```csharp
public Vector2 GetCoordinatesForSlot(int slot)
```

```csharp
public List<TIShipHullTemplate.ShipModuleSlot> GetAllSlotsOfType(ShipModuleSlotType slotType)
```

```csharp
public TIShipHullTemplate.ShipModuleSlot AdjacentRightSlot(TIShipHullTemplate.ShipModuleSlot testModuleSlot)
```

```csharp
public TIShipHullTemplate.ShipModuleSlot AdjacentDownSlot(TIShipHullTemplate.ShipModuleSlot testModuleSlot)
```

```csharp
public TIShipHullTemplate.ShipModuleSlot AdjacentHorizNoseSlot(TIShipHullTemplate.ShipModuleSlot testModuleSlot)
```

```csharp
public List<TIShipHullTemplate.ShipModuleSlot> WeaponSlotSet(TIShipHullTemplate.ShipModuleSlot coreSlot, Mount mount)
```

```csharp
public List<List<TIShipHullTemplate.ShipModuleSlot>> ValidBigWeaponSlotSets(Mount mount)
```

```csharp
public static TIShipHullTemplate.ShipModuleSlot AssignCoreSlotOnMultiMountPlacement(TISpaceShipTemplate ship, TIShipWeaponTemplate weapon, int droppedSlot)
```

```csharp
public string GetLocalizedMaximums(TISpaceShipTemplate ship, ShipModuleSlotType slot)
```

```csharp
public override string GetDescriptionData(TISpaceShipState ship = null, TISpaceShipTemplate shipTemplate = null, bool prospective = false, ShipModuleSlotType slot = ShipModuleSlotType.None, bool splitFireModes = false)
```
