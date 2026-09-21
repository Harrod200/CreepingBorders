# TIVictoryTemplate

*Decompiled from `TIVictoryTemplate.cs`.*


## Class `TIVictoryTemplate`

```csharp
public class TIVictoryTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `victoryConditions` | public List<TIVictoryTemplate.VictoryCondition> |
| `victoryEffect` | public TIVictoryTemplate.VictoryEffectType |
| `defeatAllHabsCondition` | private readonly List<TIVictoryTemplate.VictoryConditionType> |
| `defeatAllBasesCondition` | private readonly List<TIVictoryTemplate.VictoryConditionType> |
| `defeatAllFleetsCondition` | private readonly List<TIVictoryTemplate.VictoryConditionType> |
| `defeatAlienHomeworldCondition` | private readonly List<TIVictoryTemplate.VictoryConditionType> |
| `VictoryConditionType` | public enum |
| `VictoryCondition` | public struct |
| `conditionType` | public TIVictoryTemplate.VictoryConditionType |
| `value` | public float |
| `VictoryEffectType` | public enum |

### Properties

- `private readonly List<TIVictoryTemplate.VictoryConditionType> spaceAssetConstructionCondition = new List<TIVictoryTemplate.VictoryConditionType>`

### Methods

```csharp
public bool AllVictoryConditionsMet(TIFactionState faction)
```

```csharp
public string SingleVictoryConditionDescriptionWithScore(TIFactionState faction, TIVictoryTemplate.VictoryCondition condition, out List<TISpaceAssetState> failingAssets)
```

```csharp
public float VictoryConditionNumerator(TIFactionState faction, TIVictoryTemplate.VictoryCondition condition)
```

```csharp
public float VictoryConditionDenominator(TIVictoryTemplate.VictoryCondition condition)
```

```csharp
public List<TISpaceBodyState> GetMajorBuildablePlanetRegions()
```

```csharp
public List<TISpaceBodyState> GetMajorPlanetRegions(TIVictoryTemplate.VictoryCondition condition)
```

```csharp
protected bool SingleVictoryConditionMet(TIFactionState faction, TIVictoryTemplate.VictoryCondition condition)
```

```csharp
private bool MySpaceAssetRegion(TIFactionState faction, TIVictoryTemplate.VictoryConditionType condition, TISpaceBodyState keySpaceBody, int tier)
```

```csharp
private bool FreePlanetRegion(TIFactionState faction, TIVictoryTemplate.VictoryConditionType condition, TISpaceBodyState keySpaceBody, int tier, bool collectList, out List<TINaturalSpaceObjectState> bodiesToSurvey, out List<TIHabState> failingHabs, out List<TIFactionState> factions)
```

```csharp
private bool FreeFleetRegion(TIFactionState faction, TIVictoryTemplate.VictoryConditionType condition, TISpaceBodyState keySpaceBody, float combatScore, bool collectList, out List<TINaturalSpaceObjectState> bodiesToSurvey, out List<TISpaceFleetState> failingFleets, out List<TIFactionState> factions)
```

```csharp
public List<TISpaceAssetState> GetConditionBlockingSpaceAssets(TIFactionState faction)
```
