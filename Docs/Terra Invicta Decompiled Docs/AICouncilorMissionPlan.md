# AICouncilorMissionPlan

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/AICouncilorMissionPlan.cs`.*


## Class `AICouncilorMissionPlan`

```csharp
public class AICouncilorMissionPlan
```

### Fields

| Name | Type |
|---|---|
| `selectedMissions` | public readonly IReadOnlyList<AIMissionEntry> |
| `faction` | public readonly TIFactionState |
| `councilorPolicy` | public readonly IReadOnlyDictionary<TICouncilorState, PolicyOptionWithTarget> |
| `totalWeights` | public readonly IReadOnlyDictionary<TICouncilorState, float> |
| `highestScore` | public readonly IReadOnlyDictionary<TICouncilorState, AIMissionEntry> |

### Methods

```csharp
public AICouncilorMissionPlan(IReadOnlyList<AIMissionEntry> selectedMissions, TIFactionState faction, IReadOnlyDictionary<TICouncilorState, PolicyOptionWithTarget> councilorPolicy, IReadOnlyDictionary<TICouncilorState, float> totalWeights = null, IReadOnlyDictionary<TICouncilorState, AIMissionEntry> highestScore = null)
```
