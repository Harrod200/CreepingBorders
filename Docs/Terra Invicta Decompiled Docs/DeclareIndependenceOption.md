# DeclareIndependenceOption

*Decompiled from `DeclareIndependenceOption.cs`.*


## Class `DeclareIndependenceOption`

```csharp
public class DeclareIndependenceOption : TIPolicyOption
```

### Methods

```csharp
public override bool DegradesRelations()
```

```csharp
public override PolicyType GetPolicyType()
```

```csharp
public override bool Allowed(TINationState nationState)
```

```csharp
public override bool RequiresTargets()
```

```csharp
public override int Importance(TINationState policyNation, TIGameState target)
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
