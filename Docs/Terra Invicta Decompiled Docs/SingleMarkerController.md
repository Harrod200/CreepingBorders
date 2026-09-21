# SingleMarkerController

*Decompiled from `PavonisInteractive/TerraInvicta/SingleMarkerController.cs`.*


## Class `SingleMarkerController`

```csharp
public abstract class SingleMarkerController : MonoBehaviour, IMarkerControl
```

### Fields

| Name | Type |
|---|---|
| `nation` | protected TINationState |
| `globalCurrentTarget` | protected TIGameState |

### Properties

- `private protected TIFactionState activePlayer`
- `private protected RegionController regionController`
- `private protected TIRegionState region`
- `private protected MarkerContainerController container`
- `private protected CameraManager cameraManager`

### Methods

```csharp
public virtual void InitializeWithRegion(RegionController regionController, MarkerContainerController container)
```

```csharp
public abstract void UpdateMarker()
```

```csharp
public void SetActivePlayer(bool startup)
```
