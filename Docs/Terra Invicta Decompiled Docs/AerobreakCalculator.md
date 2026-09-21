# AerobreakCalculator

*Decompiled from `PavonisInteractive/TerraInvicta/AerobreakCalculator.cs`.*


## Class `AerobreakCalculator`

```csharp
public class AerobreakCalculator
```

### Fields

| Name | Type |
|---|---|
| `aerobreakTime` | public TIDateTime |
| `arrivalBurnTime` | public TIDateTime |

### Properties

- `public OrbitalElementsState hohmannOrbit`
- `public double arrivalBurnDV_mps`
- `public double hohmannDuration_s`

### Methods

```csharp
public void Solve(TINaturalSpaceObjectState destinationBarycenter, OrbitalElementsState destinationOrbit, Vector3d approachVelocity, double? targetMeanAnomalyAtAerobreakTime_Rad, TIDateTime aerobreakTime, bool isPlayer = false)
```
