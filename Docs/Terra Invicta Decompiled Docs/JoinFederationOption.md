# JoinFederationOption

*Decompiled from `JoinFederationOption.cs`.*


## Class `JoinFederationOption`

```csharp
public class JoinFederationOption : TIPolicyOptionWithConfirm
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
public override IList<TIGameState> GetPossibleTargets(TINationState policyNation)
```

```csharp
public override void OnPassage(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override string GetResponsePrompt(TINationState policyNation, TINationState respondingNation, TIGameState policyTarget)
```

```csharp
public override float AIAgreeChance(TINationState proposingNation, TIGameState respondingPolity)
```
