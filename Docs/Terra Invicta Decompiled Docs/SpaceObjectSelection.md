# SpaceObjectSelection

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/SolarSystem/SpaceObjectSelection.cs`.*


## Class `SpaceObjectSelection`

```csharp
public class SpaceObjectSelection : StrategyLayerComponentSystem
```

### Fields

| Name | Type |
|---|---|
| `ObjectSelected` | public GameObject |
| `HasSelection` | public bool |
| `SelectionLayer` | private const int |
| `objectHovered` | private GameObject |
| `SpaceObjectController` | public SpaceObjectController |
| `hit` | private RaycastHit |
| `camera` | private CameraManager |
| `gameTime` | private GameTimeManager |
| `BlockThisFrame` | public bool |
| `wasShowingDisplayName` | private bool |

### Properties

- `public TISpaceObjectState spaceObjectStateSelected`

### Methods

```csharp
protected override void OnUpdate()
```

```csharp
public static void BlockSelectionFrame()
```

```csharp
public static TISpaceObjectState GetSelectedSpaceObject()
```

```csharp
public static void SelectSpaceObject(GameObject selection, bool setAsGlobalSelectedGameState, bool blockFrame = false, bool barycenterFallback = false)
```

```csharp
public void SelectObject(GameObject newSelection, bool setAsGlobalSelectedGameState, bool barycenterFallback = false)
```

```csharp
private void SetHoverObject(GameObject go)
```

```csharp
private void ToggleHover(bool isHovered)
```
