# TIHabTemplate

*Decompiled from `TIHabTemplate.cs`.*


## Class `TIHabTemplate`

```csharp
public class TIHabTemplate : TISpaceAssetTemplate
```

### Fields

| Name | Type |
|---|---|
| `habSiteState` | public TIHabSiteState |
| `naturalSpaceObject` | public TINaturalSpaceObjectState |
| `simpleBenefitsString` | public string |
| `habType` | public HabType |
| `tier` | public int |
| `alien` | public bool |
| `habSite` | public string |
| `sectors` | public SectorTemplate[] |

### Methods

```csharp
public void SetDisplayName(string set)
```

```csharp
public override TIGameState CreateGameState()
```

```csharp
public List<TIHabModuleTemplate> AllModuleTemplates(bool uniquesOnly)
```
