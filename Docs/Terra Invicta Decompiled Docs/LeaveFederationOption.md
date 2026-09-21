# LeaveFederationOption

*Decompiled from `LeaveFederationOption.cs`.*


## Class `LeaveFederationOption`

```csharp
public class LeaveFederationOption : TIPolicyOptionWithConfirm
```

### Fields

| Name | Type |
|---|---|
| `PromptName` | public override string |
| `TargetsMyFederation` | public override bool |

### Methods

```csharp
public override PolicyType GetPolicyType()
```

```csharp
public override bool DegradesRelations()
```

```csharp
public override bool RequiresTargets()
```

```csharp
public override bool Allowed(TINationState nationState)
```

```csharp
public override float AIAgreeChance(TINationState proposingNation, TIGameState fedLeader)
```

```csharp
public override IList<TIGameState> GetPossibleTargets(TINationState policyTarget)
```

```csharp
public override string GetResponsePrompt(TINationState policyNation, TINationState respondingNation, TIGameState policyTarget)
```

```csharp
public override void OnPassage(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override void PromptPolicyResponse(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override void DeclinePolicy(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override void EnactPolicy(TINationState enactingNation, TIGameState policyTarget)
```
