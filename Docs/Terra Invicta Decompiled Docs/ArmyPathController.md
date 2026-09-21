# ArmyPathController

*Decompiled from `PavonisInteractive/TerraInvicta/ArmyPathController.cs`.*


## Class `ArmyPathController`

```csharp
public class ArmyPathController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Segments` | private IEnumerable<BezierLineController> |
| `ShouldHide` | private bool |
| `ShouldDisplayProspectivePath` | private bool |
| `lastPath` | private List<TIRegionState> |
| `MarkerController` | public MarkerController |
| `SegmentPrefab` | public BezierLineController |
| `SegmentPrefab_Water` | public BezierLineController |

### Methods

```csharp
private void Update()
```

```csharp
private void OnEnable()
```

```csharp
private void ResetVisualization()
```

```csharp
public void UpdateVisualization(bool updatePath)
```
