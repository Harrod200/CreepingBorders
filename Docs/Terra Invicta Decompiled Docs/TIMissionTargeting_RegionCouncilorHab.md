# TIMissionTargeting_RegionCouncilorHab

*Decompiled from `TIMissionTargeting_RegionCouncilorHab.cs`.*


## Class `TIMissionTargeting_RegionCouncilorHab`

```csharp
public class TIMissionTargeting_RegionCouncilorHab : TIMissionTargeting
```

### Fields

| Name | Type |
|---|---|
| `actingCouncilor` | private TICouncilorState |

### Methods

```csharp
public override List<Type> TargetedGameStates()
```

```csharp
public override void Activate()
```

```csharp
public override void Shutdown()
```

```csharp
public override TIGameState GetDefaultTarget()
```

```csharp
private void HabSelectedForTargeting(HabSelectedEvent e)
```

```csharp
private void CouncilorSelectedForTargeting(CouncilorMapItemSelected e)
```

```csharp
private void RegionSelectedForTargeting(RegionStateSelected e)
```
