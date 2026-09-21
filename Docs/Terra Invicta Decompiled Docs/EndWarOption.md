# EndWarOption

*Decompiled from `EndWarOption.cs`.*


## Class `EndWarOption`

```csharp
public class EndWarOption : TIPolicyOptionWithConfirm
```

### Fields

| Name | Type |
|---|---|
| `PromptName` | public override string |
| `EnactAgainstRelatedState` | public override bool |

### Methods

```csharp
public override PolicyType GetPolicyType()
```

```csharp
public override bool ImprovesRelations()
```

```csharp
public override float AIAgreeChance_Prospective(TINationState proposingNation, TIGameState respondingState)
```

```csharp
public override void OnConfirm(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override void EnactPolicy(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override bool Allowed(TINationState nation)
```

```csharp
public override IList<TIGameState> GetPossibleTargets(TINationState policyTarget)
```

```csharp
public override void OnPassage(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override void PromptPolicyResponse(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override string GetConfirmPrompt(TINationState enactingNation, TIGameState target)
```

```csharp
public override string GetResponsePrompt(TINationState policyNation, TINationState respondingNation, TIGameState policyTarget)
```

```csharp
public override int Importance(TINationState policyNation, TIGameState target)
```

```csharp
public override float AIAgreeChance(TINationState proposingNation, TIGameState war)
```
