# FactionPeriodicUpdate

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/PeriodicUpdates/FactionPeriodicUpdate.cs`.*


## Class `FactionPeriodicUpdate`

```csharp
public class FactionPeriodicUpdate : StrategyLayerComponentSystem
```

### Fields

| Name | Type |
|---|---|
| `gameTime` | private GameTimeManager |
| `daily0000Condition` | private GameTimeCondition |
| `daily0300Condition` | private GameTimeCondition |
| `daily0600Condition` | private GameTimeCondition |
| `daily0900Condition` | private GameTimeCondition |
| `daily1500Condition` | private GameTimeCondition |
| `daily1800Condition` | private GameTimeCondition |
| `daily2100Condition` | private GameTimeCondition |
| `daily2300Condition` | private GameTimeCondition |
| `monthlyCondition` | private GameTimeCondition |
| `midMonthlyCondition` | private GameTimeCondition |
| `global` | private TIGlobalValuesState |
| `factionStates` | private TIFactionState[] |
| `FactionGroup` | public struct |
| `Length` | public readonly int |
| `Faction` | public ComponentDataArray<Faction> |

### Properties

- `public AIDailyFactionPlanner factionPlanner`

### Methods

```csharp
public override void Initialize()
```

```csharp
protected override void OnUpdate()
```

```csharp
private void OnDaily0000Update()
```

```csharp
private void OnDaily0300Update()
```

```csharp
private void OnDaily0600Update()
```

```csharp
private void OnDaily0900Update()
```

```csharp
private void OnDaily1500Update()
```

```csharp
private void OnDaily1800Update()
```

```csharp
private void OnDaily2100Update()
```

```csharp
private void OnDaily2300Update()
```

```csharp
private void OnAnnualUpdate()
```

```csharp
private void OnMonthlyUpdate()
```

```csharp
private void OnMidMonthlyUpdate()
```
