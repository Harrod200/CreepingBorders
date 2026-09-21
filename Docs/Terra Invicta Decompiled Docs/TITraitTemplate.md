# TITraitTemplate

*Decompiled from `TITraitTemplate.cs`.*


## Class `TITraitTemplate`

```csharp
public class TITraitTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `requiresProject` | public bool |
| `requiredTraitForUpgrade` | public TITraitTemplate |
| `description` | public string |
| `isGovernmentTrait` | public bool |
| `isCriminalTrait` | public bool |
| `incomeTrait` | public bool |
| `RestrictedMissions` | public List<TIMissionTemplate> |
| `MissionsGranted` | public List<TIMissionTemplate> |
| `fullTraitSummary` | public string |
| `grouping` | public int? |
| `XPCost` | public int |
| `moneyCost` | public int |
| `influenceCost` | public int |
| `opsCost` | public int |
| `boostCost` | public int |
| `projectDataName` | public string |
| `upgradesFrom` | public string |
| `incomeMoney` | public float |
| `incomeInfluence` | public float |
| `incomeOps` | public float |
| `incomeBoost` | public float |
| `incomeResearch` | public float |
| `incomeProjects` | public int |
| `detectionInvBonus` | public int |
| `detectionEspBonus` | public int |
| `XPModifier` | public float |
| `rerollTrait` | public string |
| `rerollTraitBonus` | public float |
| `randomCouncilorsOnly` | public bool |
| `statMods` | public StatModifier[] |
| `missionsGrantedNames` | public List<string> |
| `restrictedMissionNames` | public List<string> |
| `baseChance` | public float? |
| `restrictedLocations` | public RestrictedLocations |
| `techBonuses` | public List<TechBonus> |
| `priorityBonuses` | public List<PriorityBonus> |
| `classChance` | public List<ClassChance> |
| `easilyVisible` | public bool |
| `specialTraitRule` | public SpecialTraitRule |
| `specialTraitRuleValue` | public float |
| `tags` | public List<string> |
| `alwaysGrantFromEffect` | public bool |
| `_restrictedMissions` | private List<TIMissionTemplate> |
| `_missionsGranted` | private List<TIMissionTemplate> |

### Methods

```csharp
public bool CouncilorCanAddByAugment(TICouncilorState councilor)
```

```csharp
public bool CouncilorCanRemoveByAugment(TICouncilorState councilor)
```

```csharp
public bool CouncilorCanHave(TICouncilorState councilor, TIFactionState forFaction, bool grantedByEffect = false)
```

```csharp
public bool IsMatchingProject(TIProjectTemplate project)
```

```csharp
public bool RerollTrait(TICouncilorState councilor, TIFactionState forFaction)
```

```csharp
public string GetPerValueString(StatModVariable statModVariable)
```

```csharp
public static string RestrictedLocationString(TITraitTemplate trait)
```

```csharp
public static void ProcessLoyaltyChangeFromTraits(TIFactionState faction, SpecialTraitRule rule, int multiplier = 1)
```

```csharp
public static void ProcessPropagandaFromTraits(TIFactionState faction, SpecialTraitRule rule, float value)
```

```csharp
public static void ProcessLoyaltyChangeFromTraits(TICouncilorState councilor, SpecialTraitRule rule, int multiplier = 1)
```

```csharp
private StatModVariable GetStatModVariable(StatModifier statModifier)
```

```csharp
public int ApplyTraitStatValue(CouncilorAttribute attribute, TICouncilorState councilorWithTrait, TIFactionState viewingFaction, WhichStatModifier whichStatModifier, bool missionTargeting, TIGameState missionTarget = null)
```
