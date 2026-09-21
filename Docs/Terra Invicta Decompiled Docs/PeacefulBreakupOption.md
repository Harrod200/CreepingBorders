# PeacefulBreakupOption

*Decompiled from `PeacefulBreakupOption.cs`.*


## Class `PeacefulBreakupOption`

```csharp
public class PeacefulBreakupOption : TIPolicyOption
```

### Methods

```csharp
public override PolicyType GetPolicyType()
```

```csharp
public override bool WeakensNation()
```

```csharp
public override bool Allowed(TINationState nationState)
```

```csharp
public override IList<TIGameState> GetPossibleTargets(TINationState policyTarget)
```

```csharp
public override void OnPassage(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override int Importance(TINationState policyNation, TIGameState target)
```
