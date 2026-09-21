# DragItem

*Decompiled from `PavonisInteractive/TerraInvicta/UI/DragItem.cs`.*


## Class `DragItem`

```csharp
public class DragItem : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
```

### Fields

| Name | Type |
|---|---|
| `singular` | protected bool |
| `dragItemType` | protected DragItemType |
| `parentWhileDragging` | protected Transform |
| `canvasGroup` | protected CanvasGroup |
| `startParent` | protected Transform |
| `startSiblingIndex` | protected int |
| `listManager` | protected ListManagerBase |
| `pausingClock` | protected bool |
| `dragging` | protected bool |
| `draggable` | public bool |

### Methods

```csharp
protected virtual void Awake()
```

```csharp
public virtual void Drop(Transform parent)
```

```csharp
public virtual void OnBeginDrag(PointerEventData eventData)
```

```csharp
public virtual void OnDrag(PointerEventData eventData)
```

```csharp
public virtual void OnEndDrag(PointerEventData eventData)
```

```csharp
public void EndDragCleanup()
```

```csharp
public void Reset()
```
