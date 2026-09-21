# OperationButtonController

*Decompiled from `PavonisInteractive/TerraInvicta/OperationButtonController.cs`.*


## Class `OperationButtonController`

```csharp
public class OperationButtonController : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
```

### Fields

| Name | Type |
|---|---|
| `foregroundImage` | public Image |
| `highlightImage` | public Image |
| `controller` | private OperationCanvasController |
| `operationType` | public IOperation |
| `interactable` | public bool |

### Methods

```csharp
public void Init(OperationCanvasController controller)
```

```csharp
public void SetOperationData(IOperation operation, TIGameState actingState, bool buttonInteractible, TIGameState baseTarget = null)
```

```csharp
public void OnButtonPressed()
```

```csharp
public void OnPointerEnter(PointerEventData eventData)
```

```csharp
public void OnPointerExit(PointerEventData eventData)
```
