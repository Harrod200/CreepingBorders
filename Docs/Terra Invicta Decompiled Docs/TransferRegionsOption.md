# TransferRegionsOption

*Decompiled from `TransferRegionsOption.cs`.*


## Class `TransferRegionsOption`

```csharp
public class TransferRegionsOption : TIPolicyOptionWithConfirm
```

### Fields

| Name | Type |
|---|---|
| `EnactAgainstRelatedState` | public override bool |
| `PromptName` | public override string |

### Methods

```csharp
public override PolicyType GetPolicyType()
```

```csharp
public override bool WeakensNation()
```

```csharp
public override bool ImprovesRelations()
```

```csharp
public override float AIAgreeChance(TINationState proposingNation, TIGameState targetedRegion)
```

```csharp
public override string GetResponsePrompt(TINationState policyNation, TINationState respondingNation, TIGameState policyTarget)
```

```csharp
public override void PromptPolicyResponse(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override bool Allowed(TINationState nationState)
```

```csharp
public override int Importance(TINationState policyNation, TIGameState target)
```

```csharp
public override string GetConfirmPrompt(TINationState enactingNation, TIGameState target)
```

```csharp
public override IList<TIGameState> GetPossibleTargets(TINationState actingNation)
```

```csharp
public override void OnPassage(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override void EnactPolicy(TINationState enactingNation, TIGameState policyTarget)
```
