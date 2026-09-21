# DisbandArmyOption

*Decompiled from `DisbandArmyOption.cs`.*


## Class `DisbandArmyOption`

```csharp
public class DisbandArmyOption : TIPolicyOption
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
public override void EnactPolicy(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override void OnPassage(TINationState enactingNation, TIGameState policyTarget)
```
