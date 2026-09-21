# ShipConstructionQueueItem

*Decompiled from `ShipConstructionQueueItem.cs`.*


## Class `ShipConstructionQueueItem`

```csharp
public class ShipConstructionQueueItem
```

### Fields

| Name | Type |
|---|---|
| `shipDesign` | public TISpaceShipTemplate |
| `set` | private |
| `refit_originalShipDesign` | public TISpaceShipTemplate |
| `durationInDays` | public float |
| `progressFraction` | public float |
| `shipDesignTemplateName` | public string |
| `startDate` | public TIDateTime |
| `shipyard` | public TIHabModuleState |
| `daysToCompletion` | public float |
| `resourcesCost` | public TIResourcesCost |
| `resourcesRefund` | public TIResourcesCost |
| `costPaid` | public bool |
| `_shipDesign` | private TISpaceShipTemplate |
| `AIFactionGoal` | public FactionGoal_Fleet |
| `isRefit` | public bool |
| `refit_originalShipDesignTemplateName` | public string |
| `_originalShipDesign` | private TISpaceShipTemplate |
| `originalSpaceShipState` | public TISpaceShipState |
| `originalShipDesign` | public TISpaceShipTemplate |

### Methods

```csharp
public ShipConstructionQueueItem(TISpaceShipTemplate shipDesign, TIHabModuleState shipyard, TIDateTime startDate, TIResourcesCost resourcesCost, FactionGoal_Fleet goal, bool isRefit = false, TISpaceShipTemplate originalShipDesign = null, TISpaceShipState originalSpaceShipState = null, TIResourcesCost refundCost = null)
```

```csharp
public void UpdateResourcesCost(TIResourcesCost cost)
```
