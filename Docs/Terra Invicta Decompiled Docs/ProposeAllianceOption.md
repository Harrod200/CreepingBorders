# ProposeAllianceOption

*Decompiled from `ProposeAllianceOption.cs`.*


## Class `ProposeAllianceOption`

```csharp
public class ProposeAllianceOption : TIPolicyOptionWithConfirm
```

### Fields

| Name | Type |
|---|---|
| `relationChange` | public override RelationChange |
| `PromptName` | public override string |

### Methods

```csharp
public override PolicyType GetPolicyType()
```

```csharp
public override bool ImprovesRelations()
```

```csharp
public override bool HandledAtFactionLevel()
```

```csharp
public override IList<TIGameState> GetPossibleTargets(TINationState policyTarget)
```

```csharp
public override void OnPassage(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override void DeclinePolicy(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override float AIAgreeChance(TINationState proposingNation, TIGameState respondingNation)
```
