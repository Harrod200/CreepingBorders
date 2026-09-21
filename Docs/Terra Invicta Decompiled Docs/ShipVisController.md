# ShipVisController

*Decompiled from `PavonisInteractive/TerraInvicta/ShipVisController.cs`.*


## Class `ShipVisController`

```csharp
public class ShipVisController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `ModelController` | public ShipModelController |
| `shipState` | public TISpaceShipState |
| `fleetVisController` | public FleetVisController |
| `strategyShipController` | public StrategyShipController |
| `modelLink` | private GameObject |

### Properties

- `public ShipUIController UIController`
- `public bool UIVisualizationOnly`

### Methods

```csharp
public void InitializeModelOnly(TISpaceShipTemplate shipTemplate)
```

```csharp
public void InitializeShipVisualizer(TISpaceShipTemplate shipTemplate, TISpaceShipState ship, FleetVisController fleetVisController, StrategyShipController strategyShipController, bool fullVersion)
```

```csharp
public void SetAsUIVisualization(TISpaceShipState shipState, bool copiedFleet)
```

```csharp
public void DisableAllThrusterFX()
```

```csharp
private void EnterCombat(ShipEntersCombat e)
```

```csharp
private void PostCombat(ShipLeavesCombat e)
```

```csharp
public IEnumerator FireRandomRCSFX()
```

```csharp
private void Update()
```

```csharp
private void OnDestroy()
```
