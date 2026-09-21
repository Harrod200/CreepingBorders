# VectorManager

*Decompiled from `Vectrosity/VectorManager.cs`.*


## Class `VectorManager`

```csharp
public class VectorManager
```

### Fields

| Name | Type |
|---|---|
| `arrayCount` | public static int |
| `arrayCount2` | public static int |
| `minBrightnessDistance` | public static float |
| `maxBrightnessDistance` | public static float |
| `brightnessLevels` | private static int |
| `distanceCheckFrequency` | public static float |
| `fogColor` | private static Color |
| `useDraw3D` | public static bool |
| `vectorLines` | private static List<VectorLine> |
| `objectNumbers` | private static List<RefInt> |
| `_arrayCount` | public static int |
| `vectorLines2` | private static List<VectorLine> |
| `objectNumbers2` | private static List<RefInt> |
| `_arrayCount2` | private static int |
| `transforms3` | private static List<Transform> |
| `vectorLines3` | private static List<VectorLine> |
| `oldDistances` | private static List<int> |
| `colors` | private static List<Color> |
| `objectNumbers3` | private static List<RefInt> |
| `_arrayCount3` | private static int |
| `meshTable` | private static Dictionary<string, Mesh> |

### Methods

```csharp
public static void SetBrightnessParameters(float fadeOutDistance, float fullBrightDistance, int levels, float frequency, Color color)
```

```csharp
public static float GetBrightnessValue(Vector3 pos)
```

```csharp
public static void ObjectSetup(GameObject go, VectorLine line, Visibility visibility, Brightness brightness)
```

```csharp
public static void ObjectSetup(GameObject go, VectorLine line, Visibility visibility, Brightness brightness, bool makeBounds)
```

```csharp
private static void ResetLinePoints(VisibilityControlStatic vcs, VectorLine line)
```

```csharp
public static void VisibilityStaticSetup(VectorLine line, out RefInt objectNum)
```

```csharp
public static void VisibilityStaticRemove(int objectNumber)
```

```csharp
public static void VisibilitySetup(Transform thisTransform, VectorLine line, out RefInt objectNum)
```

```csharp
public static void VisibilityRemove(int objectNumber)
```

```csharp
public static void CheckDistanceSetup(Transform thisTransform, VectorLine line, Color color, RefInt objectNum)
```

```csharp
public static void DistanceRemove(int objectNumber)
```

```csharp
public static void CheckDistance()
```

```csharp
public static void SetOldDistance(int objectNumber, int val)
```

```csharp
public static void SetDistanceColor(int i)
```

```csharp
public static void DrawArrayLine(int i)
```

```csharp
public static void DrawArrayLine2(int i)
```

```csharp
public static void DrawArrayLines()
```

```csharp
public static void DrawArrayLines2()
```

```csharp
public static Bounds GetBounds(VectorLine line)
```

```csharp
public static Bounds GetBounds(List<Vector3> points3)
```

```csharp
private static Mesh MakeBoundsMesh(Bounds bounds)
```

```csharp
public static void SetupBoundsMesh(GameObject go, VectorLine line)
```
