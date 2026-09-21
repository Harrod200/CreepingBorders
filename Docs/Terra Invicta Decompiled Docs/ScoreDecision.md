# ScoreDecision

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/ScoreDecision.cs`.*


## Class `ScoreDecision`

```csharp
internal class ScoreDecision : ScoreDecisionBase
```

### Fields

| Name | Type |
|---|---|
| `Decisions` | public IEnumerable<HabSchematicDecision> |
| `decisions` | private List<HabSchematicDecision> |

### Methods

```csharp
public override IEnumerable<TIHabModuleTemplate> GetChoices(TIFactionState faction, TIGameState location, HabSchematicOrder order)
```

```csharp
public ScoreDecision(IEnumerable<HabSchematicDecision> decisions)
```

```csharp
public ScoreDecision(params HabSchematicDecision[] decisions)
```

```csharp
public ScoreDecision(params ArchetypeDecision.HabModuleArchetype[] archetypes)
```

```csharp
public ScoreDecision(ArchetypeDecision.HabModuleArchetype archetype)
```
