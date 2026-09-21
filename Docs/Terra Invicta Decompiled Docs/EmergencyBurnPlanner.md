# EmergencyBurnPlanner

*Decompiled from `PavonisInteractive/TerraInvicta/EmergencyBurnPlanner.cs`.*


## Class `EmergencyBurnPlanner`

```csharp
public class EmergencyBurnPlanner
```

### Fields

| Name | Type |
|---|---|
| `MIN_ALTITUDE_m` | public const double |
| `EmergencyBurnSolution` | public class |
| `abandonedShips` | public List<TISpaceShipState> |
| `rescueTrajectory` | public Trajectory_Patched |
| `outcome` | public int |

### Methods

```csharp
public static EmergencyBurnPlanner.EmergencyBurnSolution Solve(TISpaceFleetState fleet, Trajectory_Patched doomedTrajectory)
```

```csharp
private static double LocalMaximumSafeSpeed(Vector3d startPosition, TINaturalSpaceObjectState barycenter, TIDateTime time)
```

```csharp
private static ValueTuple<TINaturalSpaceObjectState, TINaturalSpaceObjectState, TINaturalSpaceObjectState> GetBarycenters(TINaturalSpaceObjectState barycenter)
```

```csharp
private static TIDateTime TryToGetNextTimeAtPeriapsis(Trajectory_Patched trajectory, TIDateTime now)
```

```csharp
private static double ScoreSolution(EmergencyBurnPlanner.EmergencyBurnSolution solution, TISpaceFleetState fleet)
```

```csharp
private static ValueTuple<double, double> GetConicSectionGivenPeriapsisAndAnotherPoint(Vector3d periapsis, Vector3d otherPoint)
```

```csharp
private static OrbitalElementsState GetMaxEccentricitySolarAbortOrbit(OrbitalElementsState originalSolarOrbit, CartesianState originalCartesian, TIDateTime time, TINaturalSpaceObjectState sun)
```
