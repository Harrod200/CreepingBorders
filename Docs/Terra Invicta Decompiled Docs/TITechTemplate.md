# TITechTemplate

*Decompiled from `TITechTemplate.cs`.*


## Class `TITechTemplate`

```csharp
public class TITechTemplate : TIGenericTechTemplate
```

### Fields

| Name | Type |
|---|---|
| `TechCategory` | public TechCategory |
| `description` | protected override string |
| `ref_tech` | public override TITechTemplate |
| `quote` | private string |
| `orgTypeUnlocks` | public List<string> |
| `year` | public int |
| `endGameTech` | public bool |
| `_orgDataNameUnlocks` | private List<string> |

### Methods

```csharp
public override bool isGlobalTech()
```

```csharp
public override bool isProject()
```

```csharp
public override float GetResearchCost(TIFactionState faction)
```

```csharp
public override string GetCompletedIllustrationPath()
```

```csharp
public bool FinishedBeforeCampaignStart(int startYear)
```

```csharp
public bool TechPrereqsSatisfied(List<TITechTemplate> finishedTechs)
```

```csharp
public override bool IsEverAvailableToFaction(TIFactionState faction)
```

```csharp
public override string BenefitsDescription(TIFactionState faction, TechBenefitsContext benefitsContext, TIOrgState newOrg = null)
```
