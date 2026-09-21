# DiplomacyController

*Decompiled from `PavonisInteractive/TerraInvicta/DiplomacyController.cs`.*


## Class `DiplomacyController`

```csharp
public class DiplomacyController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `activePlayer` | private TIFactionState |
| `playerBankCashItem` | public DiplomacyBankListItem |
| `playerBankInfluenceItem` | public DiplomacyBankListItem |
| `playerBankOpsItem` | public DiplomacyBankListItem |
| `playerBankBoostItem` | public DiplomacyBankListItem |
| `playerBankWaterItem` | public DiplomacyBankListItem |
| `playerBankVolatilesItem` | public DiplomacyBankListItem |
| `playerBankBaseMetalsItem` | public DiplomacyBankListItem |
| `playerBankNobleMetalsItem` | public DiplomacyBankListItem |
| `playerBankFissilesItem` | public DiplomacyBankListItem |
| `playerBankAntimatterItem` | public DiplomacyBankListItem |
| `playerBankExoticsItem` | public DiplomacyBankListItem |
| `playerBankTreatyItem` | public DiplomacyBankListItem |
| `playerBankNAPItem_Info` | public DiplomacyBankListItem |
| `playerBankIntelItem_Info` | public DiplomacyBankListItem |
| `playerBankTruceItem_Info` | public DiplomacyBankListItem |
| `playerBankExchangeIntelItem` | public DiplomacyBankListItem |
| `aiBankCashItem` | public DiplomacyBankListItem |
| `aiBankInfluenceItem` | public DiplomacyBankListItem |
| `aiBankOpsItem` | public DiplomacyBankListItem |
| `aiBankBoostItem` | public DiplomacyBankListItem |
| `aiBankWaterItem` | public DiplomacyBankListItem |
| `aiBankVolatilesItem` | public DiplomacyBankListItem |
| `aiBankBaseMetalsItem` | public DiplomacyBankListItem |
| `aiBankNobleMetalsItem` | public DiplomacyBankListItem |
| `aiBankFissilesItem` | public DiplomacyBankListItem |
| `aiBankAntimatterItem` | public DiplomacyBankListItem |
| `aiBankExoticsItem` | public DiplomacyBankListItem |
| `aiBankTreatyItem` | public DiplomacyBankListItem |
| `aiBankNAPItem_Info` | public DiplomacyBankListItem |
| `aiBankIntelItem_Info` | public DiplomacyBankListItem |
| `aiBankTruceItem_Info` | public DiplomacyBankListItem |
| `aiBankExchangeIntelItem` | public DiplomacyBankListItem |
| `playerTableCashItem` | public DiplomacyTableListItem |
| `playerTableInfluenceItem` | public DiplomacyTableListItem |
| `playerTableOpsItem` | public DiplomacyTableListItem |
| `playerTableBoostItem` | public DiplomacyTableListItem |
| `playerTableWaterItem` | public DiplomacyTableListItem |
| `playerTableVolatilesItem` | public DiplomacyTableListItem |
| `playerTableBaseMetalsItem` | public DiplomacyTableListItem |
| `playerTableNobleMetalsItem` | public DiplomacyTableListItem |
| `playerTableFissilesItem` | public DiplomacyTableListItem |
| `playerTableAntimatterItem` | public DiplomacyTableListItem |
| `playerTableExoticsItem` | public DiplomacyTableListItem |
| `playerTableTreatyItem` | public DiplomacyTableListItem |
| `playerTableExchangeIntelItem` | public DiplomacyTableListItem |
| `aiTableCashItem` | public DiplomacyTableListItem |
| `aiTableInfluenceItem` | public DiplomacyTableListItem |
| `aiTableOpsItem` | public DiplomacyTableListItem |
| `aiTableBoostItem` | public DiplomacyTableListItem |
| `aiTableWaterItem` | public DiplomacyTableListItem |
| `aiTableVolatilesItem` | public DiplomacyTableListItem |
| `aiTableBaseMetalsItem` | public DiplomacyTableListItem |
| `aiTableNobleMetalsItem` | public DiplomacyTableListItem |
| `aiTableFissilesItem` | public DiplomacyTableListItem |
| `aiTableAntimatterItem` | public DiplomacyTableListItem |
| `aiTableExoticsItem` | public DiplomacyTableListItem |
| `aiTableTreatyItem` | public DiplomacyTableListItem |
| `aiTableHateReductionItem` | public DiplomacyTableListItem |
| `aiTableExchangeIntelItem` | public DiplomacyTableListItem |
| `tradeBodyObject` | public GameObject |
| `playerTableItemsContent` | public GameObject |
| `aiTableItemsContent` | public GameObject |
| `playerBankItemsContent` | public GameObject |
| `aiBankItemsContent` | public GameObject |
| `bankItemPrefab` | public GameObject |
| `tableItemPrefab` | public GameObject |
| `playerFactionIcon` | public Image |
| `aiFactionIcon` | public Image |
| `playerFactionIconLarge` | public Image |
| `aiFactionIconLarge` | public Image |
| `playerFactionGradient` | public Image |
| `aiFactionGradient` | public Image |
| `playerFactionText` | public TMP_Text |
| `aiFactionText` | public TMP_Text |
| `aiFactionAttitudeText` | public TMP_Text |
| `playerResourcesTab` | public DiplomacyBankListItem |
| `aiResourcesTab` | public DiplomacyBankListItem |
| `playerOrgTab` | public DiplomacyBankListItem |
| `aiOrgTab` | public DiplomacyBankListItem |
| `playerHabsTab` | public DiplomacyBankListItem |
| `aiHabsTab` | public DiplomacyBankListItem |
| `playerCPsTab` | public DiplomacyBankListItem |
| `aiCPsTab` | public DiplomacyBankListItem |
| `playerProjectsTab` | public DiplomacyBankListItem |
| `aiProjectsTab` | public DiplomacyBankListItem |
| `tradeCanvas` | public Canvas |
| `aiFeedbackDialogText` | public TMP_Text |
| `executeTradeButton` | public Button |
| `minimizeTradeWindowButton` | public Button |
| `hateModifier` | private float |
| `playerOrgsVisible` | private bool |
| `aiOrgsVisible` | private bool |
| `playerResourcesVisible` | private bool |
| `aiResourcesVisible` | private bool |
| `playerHabsVisible` | private bool |
| `aiHabsVisible` | private bool |
| `playerProjectsVisible` | private bool |
| `aiProjectsVisible` | private bool |
| `playerTradeOffer` | private TradeOffer |
| `aiTradeOffer` | private TradeOffer |
| `touchedAIOffer` | public bool |
| `isThisAnAIOffer` | private bool |
| `notificationController` | private NotificationScreenController |
| `tradingFaction` | public TIFactionState |
| `testingAITrade` | private bool |

### Methods

```csharp
public void Setup(TIFactionState targetFaction, NotificationScreenController controller, bool isAIOffer = false)
```

```csharp
public void ResetDealTable()
```

```csharp
private bool IsTableEmpty()
```

```csharp
public static void LogAITradeDetails(TradeOffer wantOffer, TradeOffer giveOffer)
```

```csharp
private static string TradeOfferDetailString(TradeOffer offer)
```

```csharp
public void PreFillTable(TradeOffer aiOffer, TradeOffer playerOffer)
```

```csharp
public void OnClickTradeButton()
```

```csharp
private void CleanupOldTradeItems()
```

```csharp
public void OnClickClear()
```

```csharp
public void ToggleHabs(bool player)
```

```csharp
public void ToggleProjects(bool player)
```

```csharp
public void ToggleOrgs(bool player)
```

```csharp
public void ToggleResources(bool player)
```

```csharp
public void ToggleTreaties(bool player = false)
```

```csharp
private void ToggleTradeItems(bool player, TradeItemType tradeItemType)
```

```csharp
private void UpdateImproveRelations()
```

```csharp
public void EvaluateTrade()
```

```csharp
private void LoadBankValues()
```

```csharp
private void SetNoIntelReason()
```

```csharp
public void OnHabDecommissioned(HabDecommissionStatusChange e)
```

```csharp
public void OnHabModuleConstructionStatusChange(HabModuleConstructionStatusChange e)
```

```csharp
public void OnHabModuleDecommissionStatusChange(HabModuleDecommissionStatusChange e)
```

```csharp
public void OnResourcesUpdated(FactionResourcesUpdated e)
```

```csharp
public void CouncilorValuesChanged(CouncilorValuesChanged e)
```

```csharp
private void RevalidateHabsInTrade()
```

```csharp
private void HideLockedResources(bool playerResourcesVisible = true, bool aiResourcesVisible = true)
```

```csharp
public void MinimizeTradeWindowPressed()
```

```csharp
private void MaximizeTradeWindow()
```

```csharp
private void UpdateTradeWindowMinimizeStatus()
```

```csharp
public void CleanupListeners()
```
