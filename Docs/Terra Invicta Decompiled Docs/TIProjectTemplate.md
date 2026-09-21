# TIProjectTemplate

*Decompiled from `TIProjectTemplate.cs`.*


## Class `TIProjectTemplate`

```csharp
public class TIProjectTemplate : TIGenericTechTemplate
```

### Fields

| Name | Type |
|---|---|
| `TechCategory` | public TechCategory |
| `ref_project` | public override TIProjectTemplate |
| `summary` | public override string |
| `associatedBilaterals` | public List<TIBilateralTemplate> |
| `associatedClaims` | public List<TIBilateralTemplate> |
| `OrgGranted` | public TIOrgTemplate |
| `ShipPartUnlocks` | public List<TIShipPartTemplate> |
| `requiredObjective` | private TIObjectiveTemplate |
| `altRequiredObjective` | private TIObjectiveTemplate |
| `requiredNationState` | public TINationState |
| `factionAvailableChance` | public float |
| `factionAlways` | public string |
| `initialUnlockChance` | public float |
| `deltaUnlockChance` | public float |
| `maxUnlockChance` | public float |
| `requiredObjectiveName` | public string |
| `altRequiredObjectiveName` | public string |
| `requiredMilestone` | public new CampaignMilestone |
| `requiresNation` | public string |
| `oneTimeGlobally` | public bool |
| `repeatable` | public bool |
| `orgGranted` | public string |
| `factionPrereq` | public List<string> |
| `resourcesGranted` | public List<ResourceValue> |
| `AI_projectRole` | public ProjectRole |
| `_associatedBilatals` | private List<TIBilateralTemplate> |
| `_associatedClaims` | private List<TIBilateralTemplate> |
| `_habModuleUnlocks` | private List<TIHabModuleTemplate> |
| `_shipPartUnlocks` | private List<TIShipPartTemplate> |
| `_childShipPartUnlocks` | private List<TIShipPartTemplate> |

### Methods

```csharp
public override bool isGlobalTech()
```

```csharp
public override bool isProject()
```

```csharp
public bool SomeoneHasDoneIt()
```

```csharp
public override float GetResearchCost(TIFactionState faction)
```

```csharp
public string AllUnlocksDetails(bool includeHeader, bool truncateDescriptions = false)
```

```csharp
protected override string filteredDescription(TechBenefitsContext context)
```

```csharp
public override string GetCompletedIllustrationPath()
```

```csharp
public TIObjectiveTemplate FulfillsObjective(TIFactionState faction, bool ignoreLocked)
```

```csharp
public bool IsVictoryRelated(TIFactionState faction)
```

```csharp
public override string WarningsDescription(TIFactionState faction, TechBenefitsContext context)
```

```csharp
public override bool ShouldHide(TIFactionState faction)
```

```csharp
public bool HasUncompletedXenologyInChain(TIFactionState faction)
```

```csharp
public bool HasUncompletedMilestoneInChain(TIFactionState faction)
```

```csharp
public override string BenefitsDescription(TIFactionState faction, TechBenefitsContext benefitsContext, TIOrgState newOrg = null)
```

```csharp
public List<TIHabModuleTemplate> HabModuleUnlocks()
```

```csharp
public List<TIShipPartTemplate> ChildProjectShipPartUnlocks(TIFactionState faction)
```

```csharp
public List<TITraitTemplate> CyberneticUnlocks()
```

```csharp
public bool ObjectivePrereqsSatisfied(TIFactionState faction)
```

```csharp
public bool FactionPrereqsSatisfied(TIFactionState faction)
```

```csharp
public override bool IsEverAvailableToFaction(TIFactionState faction)
```

```csharp
public bool TechPrereqsSatisfied(List<TITechTemplate> finishedTechs, List<TIProjectTemplate> finishedProjects)
```

```csharp
public bool MilestoneReqsSatisfied(TIFactionState faction)
```

```csharp
public bool UniquenessReqsSatisfied()
```

```csharp
public bool PrereqsSatisfied(List<TITechTemplate> finishedTechs, List<TIProjectTemplate> finishedProjects, TIFactionState faction)
```
