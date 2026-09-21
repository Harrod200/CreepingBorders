# AddShipDesignToConstructionQueueAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/AddShipDesignToConstructionQueueAction.cs`.*


## Class `AddShipDesignToConstructionQueueAction`

```csharp
public class AddShipDesignToConstructionQueueAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `shipyard` | private TIHabModuleState |
| `ship` | private TISpaceShipTemplate |
| `allowPayFromEarth` | private bool |
| `resourceFraction` | private float |
| `goal` | private FactionGoal_Fleet |
| `isRefit` | private bool |
| `originalShipDesign` | public TISpaceShipTemplate |
| `originalShipState` | public TISpaceShipState |

### Methods

```csharp
public AddShipDesignToConstructionQueueAction(TIHabModuleState shipyard, TISpaceShipTemplate ship, bool allowPayFromEarth, float resourceFraction, FactionGoal_Fleet goal, bool isRefit = false, TISpaceShipTemplate originalShipDesign = null, TISpaceShipState originalShipState = null)
```

```csharp
public override void Execute()
```
