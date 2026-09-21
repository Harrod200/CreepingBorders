# RightClickHandler

*Decompiled from `PavonisInteractive/TerraInvicta/RightClickHandler.cs`.*


## Class `RightClickHandler`

```csharp
public class RightClickHandler : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
```

### Fields

| Name | Type |
|---|---|
| `leftClick` | public UnityEvent |
| `middleClick` | public UnityEvent |
| `rightClick` | public UnityEvent |
| `pointerEnter` | public UnityEvent |
| `pointerExit` | public UnityEvent |
| `associatedButton` | private Button |

### Methods

```csharp
public void Awake()
```

```csharp
public void OnPointerClick(PointerEventData eventData)
```

```csharp
public void OnPointerEnter(PointerEventData eventData)
```

```csharp
public void OnPointerExit(PointerEventData eventData)
```
