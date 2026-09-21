# FactionGoal_FleetCouncilorGoal

*Decompiled from `PavonisInteractive/TerraInvicta/FactionGoal_FleetCouncilorGoal.cs`.*


## Class `FactionGoal_FleetCouncilorGoal`

```csharp
public abstract class FactionGoal_FleetCouncilorGoal : FactionGoal_Fleet
```

### Fields

| Name | Type |
|---|---|
| `FleetCouncilorGoal` | public override bool |
| `WantsAdditionalCouncilors` | public virtual bool |
| `assignedCouncilors` | public List<TICouncilorState> |

### Properties

- `public TIGameState councilorDestination`

### Methods

```csharp
public virtual bool ShouldUnassignCouncilor(TICouncilorState councilor)
```

```csharp
public virtual TIGameState WhereShouldThisCouncilorBe(TICouncilorState councilor)
```

```csharp
public virtual IEnumerable<TIMissionTemplate> GetUltimateMissionOptions()
```

```csharp
public virtual TIGameState GetMissionTarget(TIMissionTemplate mission)
```

```csharp
public virtual IEnumerable<ValueTuple<TIMissionTemplate, TIGameState>> GetMissionOptions(TICouncilorState councilor)
```
