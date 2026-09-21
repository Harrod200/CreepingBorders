# uMyGUI_Draggable

*Decompiled from `LapinerTools/uMyGUI/uMyGUI_Draggable.cs`.*


## Class `uMyGUI_Draggable`

```csharp
public class uMyGUI_Draggable : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
```

### Fields

| Name | Type |
|---|---|
| `IsResetRotationWhenDragged` | public bool |
| `IsSnapBackOnEndDrag` | public bool |
| `IsTopInHierarchyWhenDragged` | public bool |
| `DisableBlocksRaycastsOnDrag` | public CanvasGroup |
| `IsDragged` | public bool |
| `m_isResetRotationWhenDragged` | private bool |
| `m_isSnapBackOnEndDrag` | private bool |
| `m_isTopInHierarchyWhenDragged` | private bool |
| `m_disableBlocksRaycastsOnDrag` | private CanvasGroup |
| `m_isDragged` | private bool |
| `m_onBeginDrag` | public EventHandler<uMyGUI_Draggable.DragEvent> |
| `m_onDrag` | public EventHandler<uMyGUI_Draggable.DragEvent> |
| `m_onEndDrag` | public EventHandler<uMyGUI_Draggable.DragEvent> |
| `m_initialParentTransform` | private RectTransform |
| `m_canvasTransform` | private RectTransform |
| `m_transform` | private RectTransform |
| `m_initialSiblingIndex` | private int |
| `m_initialPosition` | private Vector3 |
| `m_initialRotation` | private Quaternion |
| `m_dragOffset` | private Vector3 |
| `EventArgs` | public class DragEvent : |
| `m_event` | public readonly PointerEventData |

### Methods

```csharp
public void OnBeginDrag(PointerEventData p_event)
```

```csharp
public void OnDrag(PointerEventData p_event)
```

```csharp
public void OnEndDrag(PointerEventData p_event)
```

```csharp
private void Start()
```

```csharp
public DragEvent(PointerEventData p_event)
```
