# DisarmNuclearWeaponsOption

*Decompiled from `DisarmNuclearWeaponsOption.cs`.*


## Class `DisarmNuclearWeaponsOption`

```csharp
public class DisarmNuclearWeaponsOption : TIPolicyOption
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
public override bool RequiresTargets()
```

```csharp
public override void OnPassage(TINationState enactingNation, TIGameState policyTarget)
```
