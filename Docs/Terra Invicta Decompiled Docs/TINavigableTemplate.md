# TINavigableTemplate

*Decompiled from `TINavigableTemplate.cs`.*


## Class `TINavigableTemplate`

```csharp
public class TINavigableTemplate : TINaturalSpaceObjectTemplate
```

### Fields

| Name | Type |
|---|---|
| `ModelScale` | public override float |
| `ModelResource` | public override string |
| `relatedObjectState` | private TISpaceBodyState |
| `SemiMajorAxis_m` | public override double |
| `Eccentricity` | public override double |
| `Inclination_Rad` | public override double |
| `LongitudeAscendingNode_Rad` | public override double |
| `ArgumentPeriapsis_Rad` | public override double |
| `MeanAnomalyAtEpoch_Rad` | public override double |
| `Epoch_floatJYears` | public override double |
| `relatedObject` | public string |
| `lagrangeValue` | public LagrangeValue |
| `positionCalculator` | public TINavigablePosition |
| `_relatedObjectState` | private TISpaceBodyState |

### Methods

```csharp
public override TIGameState CreateGameState()
```
