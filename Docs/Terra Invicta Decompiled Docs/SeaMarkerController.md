# SeaMarkerController

*Decompiled from `PavonisInteractive/TerraInvicta/SeaMarkerController.cs`.*


## Class `SeaMarkerController`

```csharp
public class SeaMarkerController : SingleMarkerController
```

### Fields

| Name | Type |
|---|---|
| `Armies` | public IEnumerable<TIArmyState> |
| `ArmyHandlers` | public IEnumerable<TIGameState> |
| `HandlerFactions` | public IEnumerable<TIFactionState> |
| `HandlerNations` | public IEnumerable<TINationState> |
| `localArmies` | private List<TIArmyState> |
| `transportMarkers` | private Dictionary<TIGameState, MarkerController> |
| `markerDataDirty` | private bool |
| `frozenMarker` | private MarkerController |

### Methods

```csharp
public MarkerController GetMarkerController(TIFactionState faction)
```

```csharp
public MarkerController GetMarkerController(TINationState nation)
```

```csharp
public TIArmyState GetTopArmy(TIFactionState faction)
```

```csharp
public TIArmyState GetTopArmy(TINationState nation)
```

```csharp
public void MoveToFront(TIArmyState army)
```

```csharp
public override void InitializeWithRegion(RegionController regionController, MarkerContainerController container)
```

```csharp
public void Update()
```

```csharp
public void AttemptUpdateMarker()
```

```csharp
private void AddArmyToSeaZone(TIArmyState army)
```

```csharp
private void RemoveArmyFromSeaZone(TIArmyState army)
```

```csharp
private void OnSeaTransitCancelled(ArmySeaTransitCancelled e)
```

```csharp
private void OnArmyUpdated(ArmyMajorStatusUpdate e)
```

```csharp
private void OnArmyEmbarks(TimeEventStart e)
```

```csharp
private void OnArmyTransitsIn(TimeEventStart e)
```

```csharp
private void OnArmyTransitsOut(ArmySeaTransits e)
```

```csharp
private void OnArmyArrivesOnLand(ArmyArrivesInRegion e)
```

```csharp
private void UpdateMarker(MapActivationChangedEvent e)
```

```csharp
public override void UpdateMarker()
```

```csharp
private void OnMonthlyUpdate(TimeEventStart e)
```

```csharp
private void UpdateIceMarker()
```

```csharp
private string SeaMarkertooltip(TIFactionState faction)
```

```csharp
private void OnSeaTransportClick(MarkerController controller)
```
