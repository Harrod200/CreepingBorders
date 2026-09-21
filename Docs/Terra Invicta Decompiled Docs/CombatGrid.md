# CombatGrid

*Decompiled from `PavonisInteractive/TerraInvicta/CombatGrid.cs`.*


## Class `CombatGrid`

```csharp
public class CombatGrid : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `cursorPosition` | public Vector3 |
| `gridCollider` | private Collider |
| `plane` | private Plane |
| `mainCamera` | private Camera |
| `gridLines` | private Line[] |

### Methods

```csharp
private void Awake()
```

```csharp
private void Start()
```

```csharp
private void Update()
```

```csharp
public Vector3 CursorPositionRelativeToPlaneAt(Vector3 position, Vector3 normal, Vector3 mousePixelCoord)
```

```csharp
public void GetDistanceToPointOfIntersection(Ray ray, out float distance)
```

```csharp
public void ToggleGrid()
```
