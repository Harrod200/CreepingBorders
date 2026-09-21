# PathFindingTestScript

*Decompiled from `PathFindingTestScript.cs`.*


## Class `PathFindingTestScript`

```csharp
public class PathFindingTestScript : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `COUNT` | public int |
| `DEPTH` | public int |
| `_pointA` | public Transform |
| `_pointB` | public Transform |
| `SquareUnitCount` | public int |
| `BaseUnitSize` | public float |
| `DrawDebug` | public bool |
| `ForceDrawAll` | public bool |
| `_tree` | private OcTree |
| `_pathFinder` | private Pathfinding |
| `_positions` | private Vector3[] |

### Methods

```csharp
private void Start()
```

```csharp
public void ClearMap()
```

```csharp
public void ResetMap()
```

```csharp
public void StressTest()
```

```csharp
private void OnDrawGizmos()
```
