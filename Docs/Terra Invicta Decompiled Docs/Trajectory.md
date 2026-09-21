# Trajectory

*Decompiled from `PavonisInteractive/TerraInvicta/Trajectory.cs`.*


## Class `Trajectory`

```csharp
public abstract class Trajectory
```

### Fields

| Name | Type |
|---|---|
| `fleet` | public IMobileAsset |
| `finalArrivalTime` | public TIDateTime |
| `endsInCrash` | public bool |
| `destroyOnArrival` | public bool |
| `straightLineDistance_m` | public double |
| `duration_h` | public double |
| `duration_d` | public double |
| `duration_w` | public double |
| `duration_s` | public double |
| `durationFromLaunchToFinalArrival_s` | public double |
| `flightDuration_s` | public double |
| `DV_mps` | public virtual double |
| `DV_kps` | public double |
| `targetingFleet` | public bool |
| `targetingStation` | public bool |
| `targetingOrbit` | public bool |
| `fleetAsSpaceFleetState` | public TISpaceFleetState |
| `_fleet` | private IMobileAsset |
| `launched` | public bool |
| `involuntary` | public bool |
| `collisionTarget` | public TISpaceBodyState |
| `exitsSolarSystem` | public bool |
| `SOLAR_SYSTEM_EXIT_m` | public const double |
| `MAX_ABORT_SOLAR_ALTITUDE_m` | public const double |
| `MIN_SOLAR_PERIAPSIS_m` | public const double |
| `originalDestinationSunOrbiter` | public TISpaceObjectState |
| `destinationOrbitMeanAnomalyAtEpoch` | public double? |
| `destinationOrbitEpoch` | public TIDateTime |
| `nextTrajectory` | public Trajectory |
| `loiterDuration_s` | protected double |
| `prepositionDuration_s` | protected double |
| `boostDuration_s` | protected double |
| `coastDuration_s` | protected double |
| `decelDuration_s` | protected double |
| `captureDuration_s` | protected double |
| `_straightLineDistance_m` | private double |
| `distanceToDestinationHillSphere_m` | public double |
| `DV_targetFleet_mps` | public double |
| `MAX_PLAUSIBLE_SPEED_mps` | protected const double |
| `MAX_PLAUSIBLE_ACCELERATION_MULTIPLIER` | protected const double |
| `MAX_PLAUSIBLE_VERTICAL_MICROTHRUST_RATIO` | protected const double |
| `CANT_MANEUVER_IF_IN_MICROTHRUST` | protected const bool |
| `CANT_MANEUVER_IF_IN_IMPULSE` | protected const bool |
| `CANT_MANEUVER_IF_IN_FINAL_BURN` | protected const bool |
| `CANT_MANEUVER_IF_IN_ANY_BURN` | protected const bool |
| `CANT_MANEUVER_IF_WITHIN_BURN_DURATION_OF_FINAL_BURN` | protected const bool |
| `CANT_MANEUVER_WHILE_ORBIT_PHASING` | protected const bool |
| `TrajectoryDomain` | public enum |

### Properties

- `public TINaturalSpaceObjectState commonBarycenter`
- `public TIOrbitState originOrbit`
- `public TIOrbitState destinationOrbit`
- `public TISpaceFleetState destinationFleet`
- `public TISpaceFleetState prevDestinationFleet`
- `public TIHabState destinationStation`
- `public TISpaceGameState destination`
- `public Trajectory destinationFleetTrajectory`
- `public double fleetCruiseAcceleration_mps2`
- `public virtual double boostDV_mps`
- `public virtual double decelDV_mps`
- `public TIDateTime assignedTime`
- `public TIDateTime launchTime`
- `public TIDateTime arrivalTime`
- `public Vector3d launchPosition`
- `public Vector3d destinationPosition`
- `public bool aerocapture`
- `public bool flyby`
- `public bool resupplyOnArrival`
- `public bool interceptTrajectory`
- `public TimeSpan duration`
- `public abstract TrajectoryModel GetTrajectoryModel`

### Methods

```csharp
public virtual bool HasOrbitalElements()
```

```csharp
public abstract string GetDisplayName()
```

```csharp
public Trajectory ShallowCopy(IMobileAsset newFleet = null)
```

```csharp
public virtual double RemainingDVatTime_mps(TIDateTime time)
```

```csharp
protected double PostTransferDVfromTargetFleet_mps()
```

```csharp
public abstract bool isPlausible()
```

```csharp
public abstract string deepDump()
```

```csharp
public void appendCommonDeepDump(ref string output)
```

```csharp
public void appendCommonDeepDumpPostscript(ref string output)
```

```csharp
public ValueTuple<TIOrbitState, TIDateTime> getFinalOrbitAndArrivalTime()
```

```csharp
public void DestinationDestroyed()
```

```csharp
public void ChangeDestinationFleet(TISpaceFleetState newDestination)
```

```csharp
public void DeTargetFleet()
```

```csharp
public void EnsureConsistentDestinationOrbitOnLoad()
```

```csharp
public virtual TINaturalSpaceObjectState GetExactBarycenterAtTime(TIDateTime time)
```

```csharp
private bool IsInsideBarycenterSOI(TINaturalSpaceObjectState barycenter, Vector3d fleetGlobalPosition, TIDateTime time)
```

```csharp
public virtual TINaturalSpaceObjectState GetBarycenterAtTime(TIDateTime time)
```

```csharp
public virtual bool isInMicrothrust(TIDateTime time = null)
```

```csharp
public virtual bool CantManeuver(TIDateTime time = null)
```

```csharp
public virtual bool isInImpulse(TIDateTime time = null)
```

```csharp
public abstract List<ValueTuple<TIDateTime, Trajectory.TrajectoryDomain>> GetTrajectoryDomainsOverTime()
```

```csharp
public OrbitalElementsState GetOrbitalElementsAtTime(TIDateTime time)
```

```csharp
public virtual OrbitalElementsState GetOrbitalElementsAtTime(TIDateTime time, TISpaceAssetState.MeanAnomalyPrecision precision)
```

```csharp
public virtual double getDistFromBarycenterAtTime_m(TIDateTime timeToCheck, out TINaturalSpaceObjectState barycenter)
```

```csharp
public double DVConsumedOnTrajectory_mps(TIDateTime timeToCheck)
```

```csharp
public Vector3d DestinationPositionAtTime(TIDateTime time, TIFactionState ourFaction)
```

```csharp
public TrajectoryPhase GetTrajectoryPhase(TIDateTime assignedTime, TIDateTime trajectoryLaunchTime, TIDateTime timeToCheck, bool settingPosition, out double timeSinceStarted_s, out double timeSinceLaunch_s)
```

```csharp
public void BuildSingleTrajectory_Common(IMobileAsset fleet, TISpaceGameState destination, TINaturalSpaceObjectState commonBarycenter, TIDateTime launchTime, double transitDuration_s, bool forceImmediateLaunch = false)
```

```csharp
public TimeSpan BuildSingleTrajectory_SetDuration(double duration_s)
```

```csharp
public virtual Vector3d DesiredOrientationVector_Acceleration()
```

```csharp
public virtual Vector3d DesiredOrientationVector_Deceleration()
```

```csharp
public abstract void BuildSingleTrajectory(IMobileAsset fleet, TISpaceGameState destination, ITransferTarget originValue, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter, TrajectorySolver solver, double fleetCruiseAcceleration_mps2)
```

```csharp
public abstract Vector3d PositionAtTime(TIDateTime timeToCheck, bool setPosition, out bool arrived)
```

```csharp
public abstract CartesianState ToGlobalCartesianStateAtTime(TIDateTime timeToCheck)
```

```csharp
public CartesianState DestinationCartesianStateAtTime(TIDateTime timeToCheck)
```

```csharp
public double getDestinationMeanAnomalyAtArrival()
```

```csharp
private double getDestinationMeanAnomalyAtArrival(TISpaceAssetState.MeanAnomalyPrecision precision)
```

```csharp
public virtual TIDateTime getOrbitEndTime()
```

```csharp
public bool NeedsPincerToCatchTargetFleet()
```

```csharp
public void ReconstructMissingDestinationOrbit()
```

```csharp
public void ReconstructMissingOriginOrbit()
```

```csharp
public ValueTuple<TIOrbitState, TIDateTime, double> EstimateMissingDestinationOrbit()
```

```csharp
public ValueTuple<TIOrbitState, TIDateTime, double> EstimateMissingDestinationOrbit(TINaturalSpaceObjectState barycenter, CartesianState localCartesianAtArrival)
```

```csharp
public void SetResupplyPlan(bool resupply)
```

```csharp
public void SetAsIntercept(bool intercept)
```

```csharp
public static void GetDestinationOrbitalElementsAroundLocalBarycenterAtTime(out OrbitalElementsState orbitalElements, out TINaturalSpaceObjectState localBarycenter, ITransferTarget destination, TIDateTime time, TIFactionState ourFaction, TIDateTime now = null, double meanAnomalyOfDestination = 0.0)
```

```csharp
public static void GetDestinationCartesianAroundLocalBarycenterAtTime(out CartesianState localCartesianState, out TINaturalSpaceObjectState localBarycenter, ITransferTarget destination, TIDateTime time, TIFactionState ourFaction, TIDateTime now = null, double meanAnomalyOfDestination = 0.0)
```

```csharp
public static CartesianState GetDestinationCartesianAroundCommonBarycenterAtTime(ITransferTarget destination, TIDateTime time, TINaturalSpaceObjectState commonBarycenter, TIFactionState ourFaction, TIDateTime now = null, double meanAnomalyOfDestination = 0.0)
```

```csharp
public static ValueTuple<OrbitalElementsState, TINaturalSpaceObjectState, bool> GetDestinationLocalOrbitalElementsAtTime(ITransferTarget destination, TIFactionState factionThatIsAsking, TIDateTime time, TIDateTime now = null, double meanAnomalyOfDestination = 0.0)
```
