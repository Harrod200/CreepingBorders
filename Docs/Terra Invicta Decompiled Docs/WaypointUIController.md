# WaypointUIController

*Decompiled from `PavonisInteractive/TerraInvicta/WaypointUIController.cs`.*


## Class `WaypointUIController`

```csharp
public class WaypointUIController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `mainCamera` | public Camera |
| `dvText` | public TMP_Text |
| `collisionText` | public TMP_Text |
| `UIcanvas` | public Canvas |
| `waypointVisual` | public WaypointVisual |
| `altWaypointSelection` | public Image |
| `_altWaypointSelectionButton` | private Button |
| `altWaypointOnScreen` | private bool |
| `maxDisplayDistance` | public float |
| `maxDisplayDistanceSqr` | private float |
| `minDisplayDistance` | public float |
| `minDisplayDistanceSqr` | private float |
| `baseRadius` | public float |
| `maxRadius` | public float |
| `startRadiusAdjustDistance` | public float |
| `startRadiusAdjustDistanceSqr` | private float |
| `stopRadiusAdjustDistance` | public float |
| `stopRadiusAdjustDistanceSqr` | private float |
| `_incrementRadians` | private float |
| `normalIcon_0` | public Sprite |
| `hoverIcon_0` | public Sprite |
| `normalIcon_1` | public Sprite |
| `hoverIcon_1` | public Sprite |
| `normalIcon_2` | public Sprite |
| `hoverIcon_2` | public Sprite |
| `normalIcon_3` | public Sprite |
| `hoverIcon_3` | public Sprite |
| `normalIcon_4` | public Sprite |
| `hoverIcon_4` | public Sprite |
| `normalIcon_5` | public Sprite |
| `hoverIcon_5` | public Sprite |
| `collisionWarningFlag` | private bool |
| `position` | private Vector2 |
| `showingDVText` | public bool |

### Methods

```csharp
private void Start()
```

```csharp
public void Initialize(WaypointVisual wayPointVisual, TISpaceShipState shipState)
```

```csharp
public void OnDestroy()
```

```csharp
public void ToggleVisibility(bool show)
```

```csharp
public void ToggleDVText(bool show)
```

```csharp
public void ToggleCollisionWarning(bool show)
```

```csharp
public void SetCollisionWarningFlag(bool on)
```

```csharp
private void LateUpdate()
```

```csharp
private void OnWaypointCycled(WaypointsCycled e)
```

```csharp
private void UpdateButtonSprites(int baseColorIndex)
```
