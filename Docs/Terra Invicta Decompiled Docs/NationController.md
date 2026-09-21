# NationController

*Decompiled from `PavonisInteractive/TerraInvicta/NationController.cs`.*


## Class `NationController`

```csharp
public class NationController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `regionControllerPrefab` | public GameObject |
| `nationStateID` | public GameStateID |
| `nationState` | public TINationState |
| `mapVisualizer` | public MapController |
| `regionVisualizers` | public List<RegionController> |
| `is3D` | public bool |

### Methods

```csharp
public void Initialize(TIGameState gamestate, MapController mapVis)
```

```csharp
public void SetOutlineWidth(float newWidth)
```

```csharp
public void SetLiftValue(float newLift)
```

```csharp
public void UpdateRegionsTextures()
```

```csharp
public void FlashNation(NationFlashEvent e)
```

```csharp
public void OnNationSelected(NationStateSelected e)
```

```csharp
public void OnNationDeselected(CurrentOtherStateDeselected e)
```

```csharp
public bool GetCouncilorLocation(TIRegionState region, out Vector3 location)
```
