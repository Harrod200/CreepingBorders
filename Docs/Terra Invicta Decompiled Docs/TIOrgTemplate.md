# TIOrgTemplate

*Decompiled from `TIOrgTemplate.cs`.*


## Class `TIOrgTemplate`

```csharp
public class TIOrgTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `requiredTechTemplate` | public TITechTemplate |
| `projectGranted` | public TIProjectTemplate |
| `requiredTraitTemplates` | public List<TITraitTemplate> |
| `prohibitedTraitTemplates` | public List<TITraitTemplate> |
| `displayName` | public override string |
| `displayNameWithArticle` | public string |
| `missionsGranted` | public List<TIMissionTemplate> |
| `randomized` | public bool |
| `orgType` | public OrgType |
| `tier` | public int |
| `takeoverDefense` | public float |
| `homeRegionMapTemplateName` | public string |
| `requiresNationality` | public bool |
| `requiredOwnerTraits` | public string[] |
| `prohibitedOwnerTraits` | public string[] |
| `requiredTechName` | public string |
| `allowedOnMarket` | public bool |
| `affinities` | public List<FactionIdeology> |
| `restricted` | public List<FactionIdeology> |
| `costMoney` | public float |
| `randCostMoney` | public int |
| `costInfluence` | public float |
| `randCostInfluence` | public int |
| `costOps` | public float |
| `randCostOps` | public int |
| `costBoost` | public float |
| `randCostBoost` | public int |
| `chanceIncomeMoney` | public float |
| `incomeMoney` | public float |
| `randIncomeMoney` | public int |
| `chanceIncomeInfluence` | public float |
| `incomeInfluence` | public float |
| `randIncomeInfluence` | public int |
| `chanceIncomeOps` | public float |
| `incomeOps` | public float |
| `randIncomeOps` | public int |
| `chanceIncomeBoost` | public float |
| `incomeBoost` | public float |
| `randIncomeBoost` | public int |
| `chanceIncomeMissionControl` | public float |
| `incomeMissionControl` | public float |
| `randIncomeMissionControl` | public int |
| `chanceIncomeResearch` | public float |
| `incomeResearch` | public float |
| `randIncomeResearch` | public int |
| `projectsGranted` | public int |
| `XPModifier` | public float |
| `chancePersuasion` | public float |
| `persuasion` | public int |
| `randPersuasion` | public int |
| `chanceCommand` | public float |
| `command` | public int |
| `randCommand` | public int |
| `chanceInvestigation` | public float |
| `investigation` | public int |
| `randInvestigation` | public int |
| `chanceEspionage` | public float |
| `espionage` | public int |
| `randEspionage` | public int |
| `chanceAdministration` | public float |
| `administration` | public int |
| `randAdministration` | public int |
| `chanceScience` | public float |
| `science` | public int |
| `randScience` | public int |
| `chanceSecurity` | public float |
| `security` | public int |
| `randSecurity` | public int |
| `chanceEconomyBonus` | public float |
| `economyBonus` | public float |
| `randEconomyBonus` | public float |
| `chanceWelfareBonus` | public float |
| `welfareBonus` | public float |
| `randWelfareBonus` | public float |
| `chanceEnvironmentBonus` | public float |
| `environmentBonus` | public float |
| `randEnvironmentBonus` | public float |
| `chanceKnowledgeBonus` | public float |
| `knowledgeBonus` | public float |
| `randKnowledgeBonus` | public float |
| `chanceGovernmentBonus` | public float |
| `governmentBonus` | public float |
| `randGovernmentBonus` | public float |
| `chanceUnityBonus` | public float |
| `unityBonus` | public float |
| `randUnityBonus` | public float |
| `chanceMilitaryBonus` | public float |
| `militaryBonus` | public float |
| `randMilitaryBonus` | public float |
| `chanceOppressionBonus` | public float |
| `oppressionBonus` | public float |
| `randOppressionBonus` | public float |
| `chanceSpoilsBonus` | public float |
| `spoilsBonus` | public float |
| `randSpoilsBonus` | public float |
| `chanceSpaceDevBonus` | public float |
| `spaceDevBonus` | public float |
| `randSpaceDevBonus` | public float |
| `chanceSpaceflightBonus` | public float |
| `spaceflightBonus` | public float |
| `randSpaceflightBonus` | public float |
| `chanceMCBonus` | public float |
| `MCBonus` | public float |
| `randMCBonus` | public float |
| `chanceMiningBonus` | public float |
| `miningBonus` | public float |
| `randMiningBonus` | public float |
| `techBonuses` | public TechBonus[] |
| `missionsGrantedNames` | public string[] |
| `grantsMarked` | public bool |
| `projectGrantedName` | public string |
| `iconResource` | public string |

### Methods

```csharp
public override TIGameState CreateGameState()
```

```csharp
public override bool IsValid(out string error)
```

```csharp
public bool CanSpawn()
```
