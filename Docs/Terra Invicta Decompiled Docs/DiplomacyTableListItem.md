# DiplomacyTableListItem

*Decompiled from `PavonisInteractive/TerraInvicta/DiplomacyTableListItem.cs`.*


## Class `DiplomacyTableListItem`

```csharp
public class DiplomacyTableListItem : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `quantityOwnedText` | public TMP_Text |
| `itemDescription` | public TMP_Text |
| `itemIcon` | public Image |
| `quantitySendInput` | public TMP_InputField |
| `itemType` | public TradeItemType |
| `factionResource` | public FactionResource |
| `tooltipTrigger` | public TooltipTrigger |
| `itemFaction` | public TIFactionState |
| `diplomacyController` | public DiplomacyController |
| `orgReference` | public TIOrgState |
| `habReference` | public TIHabState |
| `projectReference` | public TIProjectTemplate |
| `treaty` | public TradeOffer.TreatyType |
| `orgTierText` | public TMP_Text |
| `orgCouncilorIcon` | public Image |
| `originalValue` | public int |

### Methods

```csharp
public void Init(DiplomacyController controller, TIFactionState faction, TIFactionState otherFaction, FactionResource resource)
```

```csharp
public void UpdateResourceLimit()
```

```csharp
public void OnRightClick(bool audio = true)
```

```csharp
public void ShowOrgData(TIOrgState org)
```

```csharp
public void HideOrgData()
```

```csharp
public void Show()
```

```csharp
public void OnValueChanged()
```

```csharp
public void OnDeSelect()
```

```csharp
public void EnableGameobject()
```

```csharp
public void DisableGameobject()
```

```csharp
private void PreventDuplicateResourcesOnTable()
```

```csharp
private void AllowBothResourcesOnTable()
```
