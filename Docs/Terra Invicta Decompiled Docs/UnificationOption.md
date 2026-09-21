# UnificationOption

*Decompiled from `UnificationOption.cs`.*


## Class `UnificationOption`

```csharp
public class UnificationOption : TIPolicyOptionWithConfirm
```

### Fields

| Name | Type |
|---|---|
| `PromptName` | public override string |

### Methods

```csharp
public override PolicyType GetPolicyType()
```

```csharp
public override bool ImprovesRelations()
```

```csharp
public override bool Allowed(TINationState nationState)
```

```csharp
public override IList<TIGameState> GetPossibleTargets(TINationState policyTarget)
```

```csharp
public override void EnactPolicy(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override void OnPassage(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override int Importance(TINationState policyNation, TIGameState target)
```

```csharp
public override float AIAgreeChance(TINationState proposingNation, TIGameState respondingNation)
```
