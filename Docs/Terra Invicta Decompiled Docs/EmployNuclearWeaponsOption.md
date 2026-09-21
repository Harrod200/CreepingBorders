# EmployNuclearWeaponsOption

*Decompiled from `EmployNuclearWeaponsOption.cs`.*


## Class `EmployNuclearWeaponsOption`

```csharp
public class EmployNuclearWeaponsOption : TIPolicyOption
```

### Methods

```csharp
public override PolicyType GetPolicyType()
```

```csharp
public override bool Allowed(TINationState nationState)
```

```csharp
public override bool HandledAtFactionLevel()
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
