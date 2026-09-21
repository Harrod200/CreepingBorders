# TIMissionTargeting_CouncilorSector

*Decompiled from `TIMissionTargeting_CouncilorSector.cs`.*


## Class `TIMissionTargeting_CouncilorSector`

```csharp
public class TIMissionTargeting_CouncilorSector : TIMissionTargeting
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
private void SectorSelectedForTargeting(SectorSelectedEvent e)
```

```csharp
private void CouncilorSelectedForTargeting(CouncilorMapItemSelected e)
```
