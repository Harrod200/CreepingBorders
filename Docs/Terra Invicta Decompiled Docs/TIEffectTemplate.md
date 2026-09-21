# TIEffectTemplate

*Decompiled from `TIEffectTemplate.cs`.*


## Class `TIEffectTemplate`

```csharp
public class TIEffectTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `InitialFactions` | public List<TIFactionState> |
| `contexts` | public List<Context> |
| `instantEffect` | public InstantEffect |
| `stackable` | public bool |
| `operation` | public StatModSetOperation |
| `value` | public float |
| `instantRnd` | public float |
| `strValue` | public string |
| `effectTarget` | public EffectTargetType |
| `effectSecondaryTarget` | public EffectSecondaryStateType |
| `effectDuration` | public EffectDuration |
| `duration_months` | public float |
| `initialFactionsStr` | public List<string> |
| `showTotal` | public TotalEffectDisplayBehavior |
| `_contexts` | private List<Context> |

### Methods

```csharp
public override bool IsValid(out string error)
```

```csharp
public List<Context> GetContexts()
```

```csharp
public string description(TIGameState state1, TIGameState state2)
```

```csharp
public string allDescription(int code)
```
