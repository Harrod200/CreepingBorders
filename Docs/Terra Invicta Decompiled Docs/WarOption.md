# WarOption

*Decompiled from `WarOption.cs`.*


## Class `WarOption`

```csharp
public class WarOption : TIPolicyOption
```

### Methods

```csharp
public override PolicyType GetPolicyType()
```

```csharp
public override bool DegradesRelations()
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
public override void EnactPolicy(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override string GetConfirmPrompt(TINationState enactingNation, TIGameState target)
```

```csharp
public override int Importance(TINationState policyNation, TIGameState target)
```
