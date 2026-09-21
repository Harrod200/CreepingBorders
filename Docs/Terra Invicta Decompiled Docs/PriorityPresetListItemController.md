# PriorityPresetListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/PriorityPresetListItemController.cs`.*


## Class `PriorityPresetListItemController`

```csharp
public class PriorityPresetListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private NationInfoController |
| `priorityName` | public TMP_Text |
| `setting` | public Image |
| `tooltip` | public TooltipTrigger |
| `percentageDetail` | public TMP_Text |

### Properties

- `public PriorityType priority`

### Methods

```csharp
public void Init(NationInfoController controller, PriorityType priority)
```

```csharp
public void UpdateListItem(int proposedValue, int totalWeights)
```

```csharp
public void OnLeftClickPreset()
```

```csharp
public void OnRightClickPreset()
```
