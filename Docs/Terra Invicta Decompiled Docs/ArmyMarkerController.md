# ArmyMarkerController

*Decompiled from `PavonisInteractive/TerraInvicta/ArmyMarkerController.cs`.*


## Class `ArmyMarkerController`

```csharp
public class ArmyMarkerController : SingleMarkerController
```

### Fields

| Name | Type |
|---|---|
| `defendingMarker` | public MarkerController |
| `topDefendingArmy` | public TIArmyState |
| `defendingArmies` | public List<TIArmyState> |
| `topDefendingArmyIndex` | public int |
| `attackingMarker` | public MarkerController |
| `topAttackingArmy` | public TIArmyState |
| `attackingArmies` | public List<TIArmyState> |
| `topAttackingArmyIndex` | public int |
| `alienMegafaunaMarker` | public MarkerController |
| `topMegafaunaArmy` | public TIArmyState |
| `megafaunaArmies` | public List<TIArmyState> |
| `topMegafaunaArmyIndex` | public int |
| `armyDataDirty` | private bool |
| `defendingArmyDataDirty` | private bool |
| `attackingArmyDataDirty` | private bool |
| `megafaunaArmyDataDirty` | private bool |
| `topMarker` | private MarkerController |
| `rotationInitialized` | private bool |

### Methods

```csharp
private string ambientSFXPath(TIArmyState army)
```

```csharp
public override void InitializeWithRegion(RegionController regionController, MarkerContainerController container)
```

```csharp
private void Update()
```

```csharp
private void AttemptUpdateMarker()
```

```csharp
private void UpdateMarker(MapActivationChangedEvent e)
```

```csharp
private void UpdateMarker(TimeEventStart e)
```

```csharp
private void UpdateMarker(ArmyArrivesInRegion e)
```

```csharp
private void UpdateMarker(RegionControlChanged e)
```

```csharp
private void UpdateMarker(ForceAllArmyUpdateInRegion e)
```

```csharp
private void UpdateMarker(ArmySeaTransitCancelled e)
```

```csharp
private void UpdateMarker(OccupationStatusChange e)
```

```csharp
public override void UpdateMarker()
```

```csharp
private void VisualizeBattle(MarkerController marker)
```

```csharp
private void VisualizeAttackingArmyDamage(ArmyTakesDamage e)
```

```csharp
private void VisualizeDefendingArmyDamage(ArmyTakesDamage e)
```

```csharp
private void VisualizeMegafaunaArmyDamage(ArmyTakesDamage e)
```

```csharp
private void FrontNewAttackingArmy()
```

```csharp
private void FrontNewDefendingArmy()
```

```csharp
private void FrontNewMegaFaunaArmy()
```

```csharp
public void MoveToFront(TIArmyState army)
```

```csharp
private string ArmyStackTooltip(IList<TIArmyState> armies, TIArmyState top)
```

```csharp
private void UpdateTopArmyInfo(MarkerController marker, TIArmyState army, int stackSize)
```

```csharp
public static Vector3 GetHeading(TIArmyState army)
```

```csharp
private void UpdateHeading(MarkerController marker, TIArmyState army)
```

```csharp
private void OnAttackingArmyStatusUpdate(ArmyStatusUpdate e)
```

```csharp
private void UpdateAttackingArmyMarker()
```

```csharp
private void OnDefendingArmyStatusUpdate(ArmyStatusUpdate e)
```

```csharp
private void UpdateDefendingArmyMarker()
```

```csharp
private void OnAlienMegafaunaArmyStatusUpdate(ArmyStatusUpdate e)
```

```csharp
private void UpdateMegafaunaArmyMarker()
```

```csharp
private void OnArmyButtonClick(MarkerController controller)
```
