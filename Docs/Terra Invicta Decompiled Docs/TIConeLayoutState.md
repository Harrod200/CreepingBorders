# TIConeLayoutState

*Decompiled from `TIConeLayoutState.cs`.*


## Class `TIConeLayoutState`

```csharp
public class TIConeLayoutState
```

### Fields

| Name | Type |
|---|---|
| `WidthRange` | private const float |
| `HeightRange` | private const float |
| `PivotPadding` | private const float |
| `IndexPadding` | private const float |
| `_width` | private int |
| `_height` | private int |
| `_depth` | private int |
| `_worldPosition` | private Vector3d |
| `_worldRotation` | private Quaternion |
| `_itemList` | private List<object> |

### Methods

```csharp
public TIConeLayoutState(in Vector3d position, in Quaternion rotation, in int width = 2, in int height = 2, in int depth = 0)
```

```csharp
public void SetOrientation(in Vector3d position, in Quaternion rotation)
```

```csharp
public bool TryAddItem(object item, out Vector3d position)
```

```csharp
public void RemoveItem(object item)
```

```csharp
private bool GetAvailableIndex(out int index)
```

```csharp
private void GetPositionForIndex(int index, out Vector3d position)
```
