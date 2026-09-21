# DiplomacyBankListItem

*Decompiled from `PavonisInteractive/TerraInvicta/DiplomacyBankListItem.cs`.*


## Class `DiplomacyBankListItem`

```csharp
public class DiplomacyBankListItem : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `quantityText` | public TMP_Text |
| `tabText` | public TMP_Text |
| `itemIcon` | public Image |
| `dealTableLink` | public GameObject |
| `itemType` | public TradeItemType |
| `tooltipTrigger` | public TooltipTrigger |
| `button` | public Button |
| `diplomacyController` | public DiplomacyController |
| `isValid` | public bool |
| `orgTierText` | public TMP_Text |
| `orgCouncilorIcon` | public Image |

### Methods

```csharp
public void OnLeftClick()
```

```csharp
public void ShowOrgData(TIOrgState org)
```

```csharp
public void HideOrgData()
```

```csharp
private void AddNoAudio()
```

```csharp
public void AddToTable(float value, bool playAudio = true)
```
