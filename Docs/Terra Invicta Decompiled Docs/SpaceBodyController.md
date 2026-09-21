# SpaceBodyController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceBodyController.cs`.*


## Class `SpaceBodyController`

```csharp
public class SpaceBodyController : SolarSysModelController
```

### Fields

| Name | Type |
|---|---|
| `template` | protected TISpaceBodyTemplate |
| `habSiteControllers` | public List<HabSiteController> |
| `spaceBodyCollider` | private SphereCollider |
| `eventInstance` | private EventInstance |
| `activeShotEffects` | private Dictionary<BeamWeaponController, SpaceBodyController.ActiveSTOEffect> |
| `ActiveSTOEffect` | private struct |
| `Prefab` | public GameObject |
| `Instance` | public GameObject |
| `TargetShip` | public TISpaceShipState |
| `ModelState` | public TISpaceObjectState |
| `Origin` | public Func<TISpaceFleetState, Vector3> |

### Properties

- `public TISpaceBodyState spaceBody`

### Methods

```csharp
public override void InitializeModel(SpaceObjectController container)
```

```csharp
public BeamWeaponController RequestSTOBeam(Func<TISpaceFleetState, Vector3> origin, TIRegionState originState, TISpaceShipState targetShip, TISpaceObjectState modelState, TIDateTime time, TIBeamWeaponTemplate weaponTemplate)
```

```csharp
public void ReleaseSTOBeamController(BeamWeaponController controller)
```

```csharp
public void OnMouseEnter()
```

```csharp
public void OnMouseExit()
```

```csharp
public void LateUpdate()
```

```csharp
private bool OrbitValidation(IList<TIGameState> targetList, List<TIOrbitState> orbitList)
```

```csharp
private bool TryGetInActiveSTOBeamInstance(out GameObject beamEffect)
```
