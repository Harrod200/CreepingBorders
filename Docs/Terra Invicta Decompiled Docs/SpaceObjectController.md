# SpaceObjectController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceObjectController.cs`.*


## Class `SpaceObjectController`

```csharp
public class SpaceObjectController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `SpaceBodyRotationComponent` | public SpaceBodyRotationComponent |
| `HasSpaceBodyRotation` | public bool |
| `SpaceBodyRotation` | public SpaceBodyRotation |
| `SpaceObjectComponent` | public SpaceObjectComponent |
| `HasSpaceObject` | public bool |
| `SpaceObject` | public SpaceObject |
| `HasSymbol` | public bool |
| `HasMap` | public bool |
| `radius_gameUnits` | public float |
| `spaceObjectState` | public TISpaceObjectState |
| `modelLink` | public GameObject |
| `symbolLink` | public GameObject |
| `symbolTransform` | public Transform |
| `mapLink` | public GameObject |
| `mapTransform` | public Transform |
| `orbitTrailLink` | public GameObject |
| `modelController` | public SolarSysModelController |
| `symbolController` | public SpaceObjectSymbolController |
| `mapController` | public MapController |
| `sphereCollider` | public SphereCollider |
| `spaceObjectControllerTransform` | public Transform |
| `CometControllerPrefab` | public CometController |
| `eventInstance` | public EventInstance |
| `thrusterAudio` | public bool |
| `initialized` | public bool |

### Methods

```csharp
private int LagrangePointIndex()
```

```csharp
private void OnDisable()
```

```csharp
public void SetAmbientAudioClip()
```

```csharp
public void TurnOffAmbientAudio()
```

```csharp
public void TurnOnAmbientAudio()
```

```csharp
public void ToggleAmbientAudioClipState()
```

```csharp
public void Initialize(TIGameState state)
```

```csharp
public void DestroyThis()
```

```csharp
private void AddSpaceBodyListeners()
```

```csharp
private void RemoveSpaceBodyListeners()
```

```csharp
private void OnForceUpdateSpaceBodyModel(ForceUpdateSpaceBodyModel e)
```

```csharp
private void AddFleetListeners()
```

```csharp
private void RemoveFleetListeners()
```

```csharp
public void UpdateOrbitComponentForAsset(bool destroyOnly = false)
```

```csharp
private void OnCombatBegin(CombatStarts e)
```

```csharp
public void UpdateFleetComposition(ShipsRemovedFromFleet e)
```

```csharp
public void UpdateFleetComposition(ShipsAddedToFleet e)
```

```csharp
public void UpdateFleetComposition(TISpaceFleetState fleetToUpdate, TISpaceFleetState newFocusFleet)
```

```csharp
public void AddShipVisualizerToFleet(FleetVisController fleetController, StrategyShipController stratShipController)
```

```csharp
public void OnFleetFormationReset()
```

```csharp
public void OnFleetFormationReset(ResetFleetFormationVisuals e)
```

```csharp
public void OnDestroy()
```
