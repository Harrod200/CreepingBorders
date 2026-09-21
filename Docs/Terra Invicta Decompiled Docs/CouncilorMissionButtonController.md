# CouncilorMissionButtonController

*Decompiled from `PavonisInteractive/TerraInvicta/CouncilorMissionButtonController.cs`.*


## Class `CouncilorMissionButtonController`

```csharp
public class CouncilorMissionButtonController : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
```

### Fields

| Name | Type |
|---|---|
| `missionTT` | public TooltipTrigger |
| `foregroundImage` | public Image |
| `highlightImage` | public Image |
| `interactable` | public bool |
| `controller` | private CouncilorMissionCanvasController |
| `missionType` | public TIMissionTemplate |

### Methods

```csharp
public void Init(CouncilorMissionCanvasController controller)
```

```csharp
public void SetMissionData(TIMissionTemplate mission, TICouncilorState councilor)
```

```csharp
private string NoMissionFeedback(TICouncilorState councilor, TIMissionTemplate mission, bool specific = true)
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
