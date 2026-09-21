# WaypointPathRendering

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/WaypointPathRendering.cs`.*


## Class `WaypointPathRendering`

```csharp
public class WaypointPathRendering : IRenderPath
```

### Fields

| Name | Type |
|---|---|
| `_name` | private readonly string |
| `_pathSegmentPool` | private readonly Stack<WaypointPathRendering.PathSegment> |
| `_activePathSegmentMap` | private readonly Dictionary<int, List<WaypointPathRendering.PathSegment>> |
| `_highlightedPathSegments` | private readonly HashSet<int> |
| `_invalidPlacementPathSegments` | private readonly HashSet<int> |
| `_isRenderingWithDefaultColor` | private bool |
| `_isPathRendering` | private bool |
| `PathSegment` | private class |
| `s_lineCount` | private static int |
| `_defaultColor` | private readonly Color |
| `_line` | private VectorLine |
| `_color` | private Color |
| `baseWidth` | private const float |
| `highlightWidth` | private const float |

### Methods

```csharp
public WaypointPathRendering(string name)
```

```csharp
public void ClearActivePathsToRender()
```

```csharp
public void SubmitPathToRender(List<Vector3> points, Color pathColor, int waypointID)
```

```csharp
public void SubmitPathToRender(List<Vector3> points, Color pathColor, Vector2 alphaBlend, int waypointID)
```

```csharp
private WaypointPathRendering.PathSegment ObtainPathSegment()
```

```csharp
private void MapPathSegmentToId(WaypointPathRendering.PathSegment pathSegment, int waypointID)
```

```csharp
public void TogglePathRendering()
```

```csharp
public void ToggleDefaultColorPathRender()
```

```csharp
public void EnableHighlightSegment(int segmentWaypointId, bool shouldRenderAsInvalidPlacement)
```

```csharp
public void DisableHighlightSegment(int segmentWaypointId)
```

```csharp
private void ToggleHighlightSegment(int segmentWaypointId, bool shouldHighlight, bool shouldRenderAsInvalidPlacement)
```

```csharp
private void RegisterSegmentHighlightState(int segmentWaypointId, bool shouldHighlight, bool shouldRenderAsInvalidPlacement)
```

```csharp
private void UpdateSegmentHighlightState(int segmentWaypointId, bool shouldHighlight, bool shouldRenderAsInvalidPlacement)
```

```csharp
public void Destroy()
```

```csharp
public PathSegment(string name)
```

```csharp
public void ToggleRenderState(bool shouldRender)
```

```csharp
public void ToggleRenderPathDefaultColor(bool shouldRenderDefault)
```

```csharp
public void ToggleRenderPathHighlight(bool shouldRenderHighlight, bool shouldRenderAsInvalidPlacement)
```

```csharp
public void RenderPath(List<Vector3> pathPoints, Color color)
```

```csharp
public bool RenderPath(List<Vector3> pathPoints, Color color, Vector2 alphaBlend)
```

```csharp
public void ClearLine()
```

```csharp
public void Destroy()
```
