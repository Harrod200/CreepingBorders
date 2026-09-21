# TIMissionTargeting_CouncilorHab

*Decompiled from `TIMissionTargeting_CouncilorHab.cs`.*


## Class `TIMissionTargeting_CouncilorHab`

```csharp
public class TIMissionTargeting_CouncilorHab : TIMissionTargeting
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
