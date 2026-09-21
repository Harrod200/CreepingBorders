# CancelOption

*Decompiled from `CancelOption.cs`.*


## Class `CancelOption`

```csharp
public class CancelOption : TIPolicyOption
```

### Methods

```csharp
public override PolicyType GetPolicyType()
```

```csharp
public override bool Allowed(TINationState nationState)
```

```csharp
public override string GetDescription()
```

```csharp
public override IList<TIGameState> GetPossibleTargets(TINationState policyTarget)
```

```csharp
public override void OnPassage(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override bool RequiresTargets()
```

```csharp
public override int Importance(TINationState policyNation, TIGameState target)
```
