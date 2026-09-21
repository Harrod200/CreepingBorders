# TIAdHocOrbitState

*Decompiled from `PavonisInteractive/TerraInvicta/TIAdHocOrbitState.cs`.*


## Class `TIAdHocOrbitState`

```csharp
internal class TIAdHocOrbitState : TIOrbitState
```

### Fields

| Name | Type |
|---|---|
| `template` | public override TIOrbitTemplate |
| `eccentricity` | public override double |
| `inclination_Rad` | public override double |
| `longitudeAscendingNode_Rad` | public override double |
| `argPeriapsis_Rad` | public override double |
| `stationCapacity` | public override int |
| `isAdHocOrbit` | public override bool |
| `irradiated` | public override bool |
| `amat_ugpy` | public override float |
| `_semimajorAxis_m` | private double |
| `_eccentricity` | private double |
| `_inclination_rad` | private double |
| `_longitudeAscendingNode_rad` | private double |
| `_argumentPeriapsis_rad` | private double |
| `_irradiated` | private bool |

### Methods

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostAllStartUpInit_5()
```

```csharp
private void SetRunTimeData()
```

```csharp
public static TIAdHocOrbitState CreateAdHocOrbitState(TINaturalSpaceObjectState barycenter, double semimajorAxis_m, double eccentricity, double inclination_Rad, double longitudeAscendingNode_Rad, double argumentPeriapsis_Rad, TISpaceFleetState foundingFleet)
```

```csharp
public static TIAdHocOrbitState CreateAdHocOrbitState(TINaturalSpaceObjectState barycenter, OrbitalElementsState orbitalElements, TISpaceFleetState foundingFleet)
```
