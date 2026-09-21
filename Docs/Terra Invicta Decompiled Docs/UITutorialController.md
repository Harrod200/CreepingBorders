# UITutorialController

*Decompiled from `UITutorialController.cs`.*


## Class `UITutorialController`

```csharp
public class UITutorialController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `uiTutorialTip` | public List<UITutorial> |
| `tutorialTipObject` | private GameObject |
| `tutorialTip` | private TutorialTip |
| `tutorialMilestone` | public static CampaignMilestone |
| `disallowHidingTutorialTipObject` | public static bool |
| `prereqMilestone` | public CampaignMilestone |
| `is3D` | public bool |
| `findTipTarget` | public List<UITutorialController.FindTipTarget> |
| `transitionToTutorial` | public UITutorialController |
| `transitionToMilestone` | public CampaignMilestone |
| `dontShowAgain` | public bool |
| `generalControlsController` | private GeneralControlsController |
| `closeTutorialAction` | public UITutorialActionType |
| `CanHoldTutorials` | public static bool |
| `FindTipTarget` | public enum |

### Methods

```csharp
private void Start()
```

```csharp
public static void SetTutorialMilestone(CampaignMilestone milestone)
```

```csharp
public void InitTutorialTip(CampaignMilestone milestone)
```

```csharp
public void ResetTutorial(bool showImmediate = false)
```

```csharp
public void HoldTutorial(CampaignMilestone milestone, bool overrideMilestone = false, bool nextFrame = true)
```

```csharp
public void CompleteTutorial(bool dontShowAgain = false)
```

```csharp
public void ShowTutorialTips(CampaignMilestone milestone, bool overrideMilestone = false, bool nextFrame = true)
```

```csharp
public void FindAndDisplay3DTipTarget()
```

```csharp
public void HideTutorial()
```

```csharp
private void ClearHeldTutorial()
```
