# PlannedResupplyAndRepair

*Decompiled from `PavonisInteractive/TerraInvicta/PlannedResupplyAndRepair.cs`.*


## Class `PlannedResupplyAndRepair`

```csharp
public class PlannedResupplyAndRepair
```

### Fields

| Name | Type |
|---|---|
| `duration_days` | public float |
| `ship` | public TISpaceShipState |
| `resupplyCost` | public TIResourcesCost |
| `repairCost` | public TIResourcesCost |
| `startDate` | public TIDateTime |
| `shipSystemsToRepair` | public List<ShipSystem> |
| `modulesToRepair` | public List<DamagedShipPartData> |
| `propellantToReload` | public float |
| `ammoToReload` | public Dictionary<ModuleDataEntry, int> |
| `armorToRepair` | public List<ArmorFacing> |
| `active` | public bool |

### Methods

```csharp
public void SetStartDate(TIDateTime startDate)
```

```csharp
public void AddtoResupplyCost(TIResourcesCost totalCost)
```

```csharp
public void AddtoRepairCost(TIResourcesCost totalCost)
```

```csharp
public bool OnlyRefueling(bool freeOnly)
```

```csharp
public void AddPropellantToReload(float propellant_tons)
```

```csharp
public void AddSystemToRepair(ShipSystem system)
```

```csharp
public void AddModuleToRepair(DamagedShipPartData damagedPart)
```

```csharp
public void AddAmmoOrder(ModuleDataEntry weapon, int valueToReload)
```

```csharp
public void AddArmorFacingToRepair(ArmorFacing facing)
```

```csharp
public void ProcessResupplyAndRepair(TISpaceShipState ship)
```

```csharp
public void CancelResupply(TIFactionState faction)
```

```csharp
public void CancelRepair(TIFactionState faction)
```

```csharp
public void ClearAllResupplyAndRepair()
```
