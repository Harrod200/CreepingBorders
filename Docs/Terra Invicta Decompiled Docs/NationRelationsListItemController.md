# NationRelationsListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/NationRelationsListItemController.cs`.*


## Class `NationRelationsListItemController`

```csharp
internal class NationRelationsListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private NationInfoController |
| `proposedRelationsChanges` | private Dictionary<TINationState, RelationChange> |
| `nationFlag` | public Image |
| `nationName` | public TMP_Text |
| `allyToggle` | public Toggle |
| `normalToggle` | public Toggle |
| `rivalToggle` | public Toggle |
| `allyTip` | public TooltipTrigger |
| `normalizeTip` | public TooltipTrigger |
| `rivalTip` | public TooltipTrigger |
| `allyCheckmark` | public Image |
| `normalCheckmark` | public Image |
| `rivalCheckmark` | public Image |
| `warImage` | public Image |
| `warFlagImage` | public Image |
| `numArmies` | public TMP_Text |
| `numNavies` | public TMP_Text |
| `notesText` | public TMP_Text |
| `listenToggle` | private bool |
| `myNation` | public TINationState |
| `otherNation` | public TINationState |
| `allyChance` | public TMP_Text |
| `endRivalryChance` | public TMP_Text |
| `proposeAllianceArrow` | public Image |
| `endAllianceArrow` | public Image |
| `proposeEndRivalryArrow` | public Image |
| `initiateRivalryArrow` | public Image |
| `nationRelationsPaneController` | private NationRelationsPaneController |

### Methods

```csharp
public void SetListItem(TINationState myNation, TINationState otherNation, NationRelationsPaneController nationRelationsPaneController)
```

```csharp
public void UpdateListItem()
```

```csharp
public void OnAllyToggle()
```

```csharp
public void AllyToggleChange()
```

```csharp
public void OnNormalToggle()
```

```csharp
public void NormalToggleChange()
```

```csharp
public void OnRivalToggle()
```

```csharp
public void RivalToggleChange()
```

```csharp
public string AllyButtonTip(TINationState nation, TINationState otherNation)
```

```csharp
public string NormalizeButtonTip(TINationState nation, TINationState otherNation)
```

```csharp
public string RivalryButtonTip(TINationState nation, TINationState otherNation)
```
