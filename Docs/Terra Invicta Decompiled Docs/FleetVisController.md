# FleetVisController

*Decompiled from `PavonisInteractive/TerraInvicta/FleetVisController.cs`.*


## Class `FleetVisController`

```csharp
public class FleetVisController : SolarSysModelController
```

### Fields

| Name | Type |
|---|---|
| `shipPrefab` | public GameObject |
| `init` | private bool |

### Properties

- `public TISpaceFleetState fleetState`
- `public List<GameObject> shipStratControllerObjects`

### Methods

```csharp
public override void InitializeModel(SpaceObjectController container)
```

```csharp
public void InitializeForUIAppearanceOnly(TISpaceFleetState fleet)
```

```csharp
private void OnFleetDisbanded(FleetDisbanded e)
```

```csharp
private void OnDisable()
```

```csharp
private void OnEnable()
```
