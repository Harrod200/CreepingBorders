# InitiateRivalryOption

*Decompiled from `InitiateRivalryOption.cs`.*


## Class `InitiateRivalryOption`

```csharp
public class InitiateRivalryOption : TIPolicyOption
```

### Fields

| Name | Type |
|---|---|
| `relationChange` | public override RelationChange |

### Methods

```csharp
public override PolicyType GetPolicyType()
```

```csharp
public override bool DegradesRelations()
```

```csharp
public override bool HandledAtFactionLevel()
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
