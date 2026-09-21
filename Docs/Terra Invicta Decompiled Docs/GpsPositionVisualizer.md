# GpsPositionVisualizer

*Decompiled from `GpsPositionVisualizer.cs`.*


## Class `GpsPositionVisualizer`

```csharp
public class GpsPositionVisualizer : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Longitude_POI` | private static float |
| `Latitude_POI` | private static float |
| `ParentRadius` | private static float |
| `ParentCenter` | private static Vector3 |
| `ParenRotation` | private static Quaternion |
| `s_instance` | private static GpsPositionVisualizer |
| `ShowParentAsWireframe` | public bool |
| `SizeOfPoi` | public float |
| `SizeOfGridPoint` | public float |
| `NumberOfLongitudePoints` | public int |
| `NumberOfLatitudePoints` | public int |
| `_gridPositions` | private List<Vector3> |

### Methods

```csharp
public static void ShowPoint(float longitude, float latitude)
```

```csharp
public static void ShowPoint(float longitude, float latitude, Quaternion parentRotation)
```

```csharp
public static void ShowPoint(float longitude, float latitude, Quaternion parentRotation, float parentBodyRadius)
```

```csharp
public static void ShowPoint(float longitude, float latitude, Quaternion parentRotation, float parentBodyRadius, Vector3 parentBodyWorldPosition)
```

```csharp
private void CalculatePoints()
```

```csharp
private void OnValidate()
```

```csharp
private void OnDrawGizmos()
```
