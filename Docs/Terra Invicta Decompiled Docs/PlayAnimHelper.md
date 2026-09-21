# PlayAnimHelper

*Decompiled from `RainbowArt/PlayAnimHelper.cs`.*


## Class `PlayAnimHelper`

```csharp
public class PlayAnimHelper : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerEnterHandler, IPointerExitHandler
```

### Fields

| Name | Type |
|---|---|
| `triggerAnimType` | public TriggerAnimType |
| `mAnimator` | private Animator |
| `mAnimStarted` | private bool |

### Methods

```csharp
private void Start()
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
