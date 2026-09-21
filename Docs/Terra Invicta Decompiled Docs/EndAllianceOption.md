# EndAllianceOption

*Decompiled from `EndAllianceOption.cs`.*


## Class `EndAllianceOption`

```csharp
public class EndAllianceOption : TIPolicyOption
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
public override IList<TIGameState> GetPossibleTargets(TINationState policyNation)
```

```csharp
public override void OnPassage(TINationState enactingNation, TIGameState policyTarget)
```
