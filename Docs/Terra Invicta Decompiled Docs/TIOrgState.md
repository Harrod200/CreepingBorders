# TIOrgState

*Decompiled from `PavonisInteractive/TerraInvicta/TIOrgState.cs`.*


## Class `TIOrgState`

```csharp
public class TIOrgState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `adjustedIncomeMoney_month` | public float |
| `adjustedIncomeInfluence_month` | public float |
| `adjustedIncomeOps_month` | public float |
| `adjustedIncomeBoost_month` | public float |
| `adjustedIncomeResearch_month` | public float |
| `grantsMarked` | public bool |
| `isOrgState` | public override bool |
| `searchable` | public override Searchable |
| `ref_faction` | public override TIFactionState |
| `ref_nation` | public override TINationState |
| `ref_region` | public override TIRegionState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_councilor` | public override TICouncilorState |
| `ref_org` | public override TIOrgState |
| `hasMapObject` | public override bool |
| `hasEarthMapObject` | public override bool |
| `template` | public TIOrgTemplate |
| `techBonuses` | public TechBonus[] |
| `hasCouncilor` | public bool |
| `hasFactionbutNoCouncilor` | public bool |
| `projectGranted` | public TIProjectTemplate |
| `orgType` | public OrgType |
| `requiresNationInterest` | public bool |
| `unassignedCouncil` | public TIFactionState |
| `homeNation` | public TINationState |
| `displayNameWithArticleCapitalized` | public string |
| `icon` | public Sprite |
| `requiredNationInterest` | public TINationState |
| `restrictiveOwnership` | public bool |
| `miningFaction` | public TIFactionState |
| `tierStars` | public string |
| `tierStarsInline` | public string |
| `smallTierStarsInline` | public string |
| `innateDefenses` | private float |
| `minTier` | public const int |
| `maxTier` | public const int |
| `tier` | public int |
| `takeoverDefense` | public float |
| `costMoney` | public float |
| `costInfluence` | public float |
| `costOps` | public float |
| `costBoost` | public float |
| `incomeMoney_month` | private float |
| `incomeInfluence_month` | private float |
| `incomeOps_month` | private float |
| `incomeBoost_month` | private float |
| `incomeResearch_month` | private float |
| `incomeMissionControl` | public float |
| `projectCapacityGranted` | public int |
| `persuasion` | public int |
| `command` | public int |
| `investigation` | public int |
| `espionage` | public int |
| `administration` | public int |
| `science` | public int |
| `security` | public int |
| `economyBonus` | public float |
| `welfareBonus` | public float |
| `environmentBonus` | public float |
| `knowledgeBonus` | public float |
| `governmentBonus` | public float |
| `unityBonus` | public float |
| `militaryBonus` | public float |
| `oppressionBonus` | public float |
| `spoilsBonus` | public float |
| `spaceDevBonus` | public float |
| `spaceflightBonus` | public float |
| `MCBonus` | public float |
| `miningBonus` | public float |
| `XPModifier` | public float |
| `gameStateSubjectCreated` | private bool |
| `missionsGranted` | public List<TIMissionTemplate> |
| `affinities` | private List<FactionIdeology> |
| `restrictedIdeologies` | private List<FactionIdeology> |
| `_icon` | private Sprite |
| `orgNegativeResources` | public static readonly FactionResource[] |
| `killMe` | private bool |

### Properties

- `public string orgIconTemplateName`
- `public string orgIconPath`
- `public string displayNameWithArticle`
- `public bool applyingBonuses`
- `public TICouncilorState assignedCouncilor`
- `public TIFactionState factionOrbit`
- `public TIOrgIconTemplate orgIconTemplate`
- `public List<TITraitTemplate> requiredOwnerTraits`
- `public List<TITraitTemplate> prohibitedOwnerTraits`
- `public TIRegionState homeRegion`

### Methods

```csharp
public override void InitWithTemplate(TIDataTemplate rawTemplate)
```

```csharp
public override void PostGameStateCreateInit_OnCreationOnly_1()
```

```csharp
public void SetHomeRegion(TIRegionState overrideRegion = null)
```

```csharp
public TIRegionState SelectHomeRegion()
```

```csharp
public void InitRunTimeValues()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostCanvasManagerCreateInit_3()
```

```csharp
public override void PostVisualizerCreationInit_7()
```

```csharp
public override void PostEverythingSaveRepair_8()
```

```csharp
public int GetStatBonus(CouncilorAttribute stat)
```

```csharp
public TIResourcesCost GetPurchaseCost(TIFactionState faction)
```

```csharp
public TIResourcesCost GetSalePrice(bool negative = false)
```

```csharp
public TIResourcesCost GetTransferCost()
```

```csharp
public TIResourcesCost GetPurchaseOrTransferCost(TIFactionState faction)
```

```csharp
public void SetFactionOrbit(TIFactionState faction)
```

```csharp
public void ClearFactionOrbit()
```

```csharp
public void AssignCouncilor(TICouncilorState councilor)
```

```csharp
public void UnassignCouncilor(TICouncilorState councilor)
```

```csharp
public float AvailabilityModifier(TIFactionState faction)
```

```csharp
public bool AllowedOnFactionMarket(TIFactionState faction)
```

```csharp
public bool HasRequiredTech()
```

```csharp
public bool IsEligibleForFaction(TIFactionState faction)
```

```csharp
private bool MeetsIdeologyRequirement(TIFactionState faction)
```

```csharp
private bool MeetsNationInterestRequirement(TIFactionState faction)
```

```csharp
private bool HasAllRequiredTraits(TICouncilorState councilor)
```

```csharp
private bool HasNoProhibitedTraits(TICouncilorState councilor)
```

```csharp
public bool IsEligibleForCouncilor(TICouncilorState councilor)
```

```csharp
public string IneligibleReasonString(TICouncilorState councilor)
```

```csharp
public bool CouncilorCanAcquire(TICouncilorState councilor)
```

```csharp
public void SetOrgActivationStatus(bool activate)
```

```csharp
public string QuickDescription(bool insertSpaces = false)
```

```csharp
public string description(bool includeDisplayName, TIFactionState viewingFaction, bool includeOwnership = false, bool includeCost = false)
```

```csharp
public string descriptionTruncated()
```

```csharp
public float GetMonthlyIncome(FactionResource resource)
```

```csharp
public float GetDailyIncome(FactionResource resource)
```
