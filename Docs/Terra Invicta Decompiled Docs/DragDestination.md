# DragDestination

*Decompiled from `PavonisInteractive/TerraInvicta/UI/DragDestination.cs`.*


## Class `DragDestination`

```csharp
public class DragDestination : MonoBehaviour, IDropHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
```

### Fields

| Name | Type |
|---|---|
| `dragItemType` | protected DragItemType |
| `dragTarget` | protected Transform |

### Methods

```csharp
public virtual void SetControllerBase(CanvasControllerBase canvasControllerBase)
```

```csharp
public virtual void OnDrop(PointerEventData eventData)
```

```csharp
public virtual void OnPointerEnter(PointerEventData eventData)
```

```csharp
public virtual void OnPointerExit(PointerEventData eventData)
```

```csharp
protected virtual bool CanDropItemHere()
```
