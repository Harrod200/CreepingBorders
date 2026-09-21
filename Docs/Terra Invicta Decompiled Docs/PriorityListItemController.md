# PriorityListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/PriorityListItemController.cs`.*


## Class `PriorityListItemController`

```csharp
public class PriorityListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private NationInfoController |
| `priorityName` | public TMP_Text |
| `priorityAccumulation` | public TMP_Text |
| `controlPointWeight_PH` | public Image[] |
| `priorityButton` | public Button[] |
| `rightClickButton` | public RightClickHandler[] |
| `helperValue` | public TMP_Text |
| `priorityTip` | public TooltipTrigger |

### Properties

- `public TINationState nation`
- `public PriorityType priority`

### Methods

```csharp
public void Init(NationInfoController controller, PriorityType priority)
```

```csharp
public static Sprite prioritySettingSprite(int weight)
```

```csharp
public static string priorityAccumulationStr(TINationState nation, PriorityType priority)
```

```csharp
public static string colorizePriorityStr(TINationState nation, PriorityType priority, string inputString)
```

```csharp
public static string priorityTipStr(TIFactionState faction, TINationState nation, PriorityType priority, string priorityLine)
```

```csharp
public void SetListItem(TINationState nation, PriorityType priority, TIFactionState viewingFaction)
```

```csharp
public void SetBonusColumnText(TINationState nation)
```

```csharp
private void IncrementPriority(TINationState nationState, PriorityType priority, int cp)
```

```csharp
private void MassIncrementPrioirty(TINationState nation, PriorityType priority)
```

```csharp
private void DecrementPriority(TINationState nation, PriorityType priority, int cp)
```

```csharp
private void MassDecrementPriority(TINationState nation, PriorityType priority)
```

```csharp
public void PriorityButtonPressed(int value)
```

```csharp
public void RightPriorityButtonPressed(int value)
```
