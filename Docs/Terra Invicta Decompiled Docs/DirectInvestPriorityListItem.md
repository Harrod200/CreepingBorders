# DirectInvestPriorityListItem

*Decompiled from `PavonisInteractive/TerraInvicta/DirectInvestPriorityListItem.cs`.*


## Class `DirectInvestPriorityListItem`

```csharp
public class DirectInvestPriorityListItem : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private NationInfoController |
| `nation` | private TINationState |
| `priorityName` | public TMP_Text |
| `perIPCost` | public TMP_Text |
| `resourcesToSpend` | public TMP_Text |
| `priorityQuickDescription` | public TMP_Text |
| `inputFieldIPs` | public TMP_InputField |
| `increaseButton` | public Button |
| `decreaseButton` | public Button |
| `DITooltip` | public TooltipTrigger |

### Properties

- `public PriorityType priority`

### Methods

```csharp
public void Init(NationInfoController controller, PriorityType priority)
```

```csharp
public void SetListItem(TINationState nation)
```

```csharp
public void OnEditValue()
```

```csharp
public void OnSelectInputField()
```

```csharp
public void OnDeSelectInputField()
```

```csharp
public void ClearValue()
```

```csharp
public void OnPressIncrease()
```

```csharp
public void OnPressDecrease()
```

```csharp
private void UpdateDIData()
```

```csharp
public void UpdateDIButtonsInteractable()
```
