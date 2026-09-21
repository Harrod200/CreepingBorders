# ScoreDecisionBase

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/ScoreDecisionBase.cs`.*


## Class `ScoreDecisionBase`

```csharp
internal abstract class ScoreDecisionBase : HabSchematicDecision
```

### Fields

| Name | Type |
|---|---|
| `Score` | public virtual Func<TIFactionState, TIGameState, TIHabModuleTemplate, HabSchematicOrder, float> |
| `firstChoice` | private TIHabModuleTemplate |

### Properties

- `public bool ChooseRandomly`

### Methods

```csharp
public ScoreDecisionBase Randomize()
```

```csharp
public abstract IEnumerable<TIHabModuleTemplate> GetChoices(TIFactionState faction, TIGameState location, HabSchematicOrder order)
```

```csharp
public override IEnumerable<TIHabModuleTemplate> Decide(TIFactionState faction, TIGameState location, HabSchematicOrder order)
```
