# TIConeLayoutGroup

*Decompiled from `TIConeLayoutGroup.cs`.*


## Class `TIConeLayoutGroup`

```csharp
public class TIConeLayoutGroup : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `WidthRange` | private float |
| `HeightRange` | private float |
| `PivotPadding` | private float |
| `IndexPadding` | private float |
| `Width` | private int |
| `Height` | private int |
| `Depth` | private int |
| `_width` | private int |
| `_height` | private int |
| `_depth` | private int |
| `_itemList` | private List<object> |

### Methods

```csharp
public void AddItem(object item, out Vector3 position)
```

```csharp
public void RemoveItem(object item)
```

```csharp
private bool GetAvailableIndex(out int index)
```

```csharp
private void GetPositionForIndex(int index, out Vector3 position)
```
