# ArmyDetailController

*Decompiled from `PavonisInteractive/TerraInvicta/ArmyDetailController.cs`.*


## Class `ArmyDetailController`

```csharp
public class ArmyDetailController : CanvasControllerBase
```

### Fields

| Name | Type |
|---|---|
| `myArmy` | public TIArmyState |
| `myArmyInfoPanel` | public Canvas |
| `myArmyHeaderText` | public TMP_Text |
| `myArmyIllustration` | public Image |
| `myArmyName` | public TMP_Text |
| `myArmyNavalImage` | public Image |
| `myArmyNavalTooltip` | public TooltipTrigger |
| `myArmyImage` | public Image |
| `myArmyImageBackground` | public Image |
| `myArmyFlagContainer` | public GameObject |
| `myArmyFlag` | public Image |
| `myArmyFaction` | public Image |
| `myArmyFactionGradient` | public Image |
| `myArmyNationName` | public TMP_Text |
| `myArmyTechLevel` | public TMP_Text |
| `myArmyStrength` | public TMP_Text |
| `myArmyHabsIcon` | public Image |
| `myArmyHabsBonus` | public TMP_Text |
| `myArmyHabsBonusTip` | public TooltipTrigger |
| `myArmyAdviserIcon` | public Image |
| `myArmyAdviserBonus` | public TMP_Text |
| `myArmyAdviserTooltip` | public TooltipTrigger |
| `myArmyHomeRegionIcon` | public Image |
| `myArmyHomeRegion` | public TMP_Text |
| `myArmyLocation` | public TMP_Text |
| `myArmyOperationIcon` | public Image |
| `myArmyOperation` | public TMP_Text |
| `myArmyStandingOrders` | public Image |
| `myArmyStandingOrdersTip` | public TooltipTrigger |
| `otherArmy` | public TIArmyState |
| `otherArmyInfoPanel` | public Canvas |
| `otherArmyHeaderText` | public TMP_Text |
| `otherArmyIllustration` | public Image |
| `otherArmyName` | public TMP_Text |
| `otherArmyNavalImage` | public Image |
| `otherArmyNavalTooltip` | public TooltipTrigger |
| `otherArmyImage` | public Image |
| `otherArmyImageBackground` | public Image |
| `otherArmyFlagContainer` | public GameObject |
| `otherArmyFlag` | public Image |
| `otherArmyFaction` | public Image |
| `otherArmyFactionGradient` | public Image |
| `otherArmyNationName` | public TMP_Text |
| `otherArmyTechLevel` | public TMP_Text |
| `otherArmyStrength` | public TMP_Text |
| `otherArmyHabsIcon` | public Image |
| `otherArmyHabsBonus` | public TMP_Text |
| `otherArmyHabsBonusTip` | public TooltipTrigger |
| `otherArmyAdviserIcon` | public Image |
| `otherArmyAdviserBonus` | public TMP_Text |
| `otherArmyAdviserTooltip` | public TooltipTrigger |
| `otherArmyHomeRegion` | public TMP_Text |
| `otherArmyHomeRegionIcon` | public Image |
| `otherArmyLocation` | public TMP_Text |
| `otherArmyOperationIcon` | public Image |
| `otherArmyOperation` | public TMP_Text |
| `renameMyArmyPanel` | public GameObject |
| `nameInputField` | public TMP_InputField |
| `myArmyDataDirty` | private bool |
| `otherArmyDataDirty` | private bool |

### Properties

- `public static ArmyDetailController Singleton`

### Methods

```csharp
public override void Initialize()
```

```csharp
public override void Show()
```

```csharp
public override void Hide()
```

```csharp
public override void Refresh()
```

```csharp
public void OnClickRename()
```

```csharp
public void OnClickRevertRename()
```

```csharp
public void RevertRename()
```

```csharp
public void OnClickSaveName()
```

```csharp
public void ShowRenameMyArmyPanel()
```

```csharp
public void OnSelectInputBox()
```

```csharp
public void OnDeSelectInputBox()
```

```csharp
private void OnMyArmyUpdated(ArmyStatusUpdate e)
```

```csharp
private void OnOtherArmyUpdated(ArmyStatusUpdate e)
```

```csharp
private void ArmySelected(TIArmyState army)
```

```csharp
private void ArmySelected(ArmyMapItemSelected e)
```

```csharp
private void OnInfoScreenOpened(InfoScreenOpened e)
```

```csharp
private void RestoreArmyDetailCanvas(InfoScreenClosed e)
```

```csharp
private void OnMyArmyDestroyed(ArmyMajorStatusUpdate e)
```

```csharp
private void OnOtherArmyDestroyed(ArmyMajorStatusUpdate e)
```

```csharp
private void AddMyArmyListeners()
```

```csharp
private void RemoveMyArmyListeners()
```

```csharp
private void AddOtherArmyListeners()
```

```csharp
private void RemoveOtherArmyListeners()
```

```csharp
private void SetArmyPanelHeader(TIArmyState army, TMP_Text textItem)
```

```csharp
private void SetIllustration(TIArmyState army, Image illustrationImage)
```

```csharp
private void SetArmyName(TIArmyState army, TMP_Text textItem)
```

```csharp
private void SetNavalImage(TIArmyState army, Image imageItem)
```

```csharp
private void SetNationFlag(TIArmyState army, Image flagImage, GameObject flagContainer)
```

```csharp
private void SetArmyNationText(TIArmyState army, TMP_Text textItem)
```

```csharp
private void SetArmyFactionControlIcon(TIArmyState army, Image factionImage, Image factionGradientImage)
```

```csharp
private void SetArmyForeground(TIArmyState army, Image foregroundImage)
```

```csharp
private void SetArmyMiltech(TIArmyState army, TMP_Text textItem)
```

```csharp
private void SetHQRegionText(TIArmyState army, TMP_Text textItem, Image HQIcon)
```

```csharp
private void SetStrengthText(TIArmyState army, TMP_Text textItem)
```

```csharp
private void SetLocationText(TIArmyState army, TMP_Text textItem)
```

```csharp
private string SetHabTooltip(TIArmyState army)
```

```csharp
private void SetHabBonus(TIArmyState army, Image habImage, TMP_Text textItem, TooltipTrigger tooltip)
```

```csharp
private string SetAdviserTooltip(TIArmyState army)
```

```csharp
private void SetAdviserBonus(TIArmyState army, Image adviserImage, TMP_Text textItem, TooltipTrigger tooltip)
```

```csharp
private void SetOperationData(TIArmyState army, Image opIcon, TMP_Text textItem)
```

```csharp
private void UpdateMyArmyDisplay()
```

```csharp
private void UpdateOtherArmyDisplay()
```

```csharp
public void OnClickOtherArmyFlag()
```

```csharp
public void OnClickOtherArmyGoto()
```

```csharp
public void OnClickMyArmyFlag()
```

```csharp
public void OnClickMyArmyGoto()
```

```csharp
public void OnClickCloseMyArmyDisplay()
```

```csharp
public void CloseMyArmyDisplay()
```

```csharp
public void OnClickExitOtherArmyDisplay()
```

```csharp
public void CloseOtherArmyDisplay()
```

```csharp
public void CheckForCanvasShutdown()
```
