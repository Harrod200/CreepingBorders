# NationPeriodicUpdate

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/PeriodicUpdates/NationPeriodicUpdate.cs`.*


## Class `NationPeriodicUpdate`

```csharp
public class NationPeriodicUpdate : StrategyLayerComponentSystem
```

### Fields

| Name | Type |
|---|---|
| `nations` | private NationPeriodicUpdate.NationGroup |
| `gameTime` | private GameTimeManager |
| `dailyCondition1` | private GameTimeCondition |
| `dailyCondition2` | private GameTimeCondition |
| `midMonthlyCondition` | private GameTimeCondition |
| `monthlyCondition` | private GameTimeCondition |
| `earthNightLightShaderDriver` | private EarthNightLightShaderDriver |
| `NationGroup` | private struct |
| `Length` | public readonly int |
| `Nation` | public ComponentDataArray<Nation> |

### Methods

```csharp
public override void Initialize()
```

```csharp
protected override void OnUpdate()
```

```csharp
private void OnDailyUpdate()
```

```csharp
private void OnDailyUpdate2()
```

```csharp
private void OnMonthlyUpdate()
```

```csharp
private void OnMidMonthlyUpdate()
```

```csharp
protected void OnQuarterlyUpdate()
```

```csharp
private void PeriodicNationUpdateTask(TINationState nation)
```

```csharp
private void LaunchDeployArmyOperation(TIArmyState army, TIGameState destination)
```

```csharp
private void LaunchArmyOperation(TIArmyState army, IOperation operation, TIGameState target)
```

```csharp
private void DailyNationUpdateTask(TINationState nation)
```

```csharp
private EarthNightLightShaderDriver GetEarthNightLightShaderDriverComponent()
```
