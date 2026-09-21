# Trajectory_Patched

*Decompiled from `PavonisInteractive/TerraInvicta/Trajectory_Patched.cs`.*


## Class `Trajectory_Patched`

```csharp
public class Trajectory_Patched : Trajectory
```

### Fields

| Name | Type |
|---|---|
| `GetTrajectoryModel` | public override TrajectoryModel |
| `DV_mps` | public override double |
| `Segments` | public List<Trajectory_Patched.IPatchSegment> |
| `ThrustPhase` | public enum |
| `IPatchSegment` | public interface |
| `DV_mps` | public override double |
| `endEccentricity` | public double |
| `endAscendingNode_rad` | public double |
| `endInclination_rad` | public double |
| `endArgP_rad` | public double |
| `startRadiusCorrection_m` | public double |
| `endRadiusCorrection_m` | public double |
| `startAnomalyCorrection_rad` | public double |
| `endAnomalyCorrection_rad` | public double |
| `startAnomalySpeedCorrectionControlPoint_rad` | public double |
| `endAnomalySpeedCorrectionControlPoint_rad` | public double |
| `trueFleetAccleration_mps2` | public double |
| `isAscending` | public bool |
| `boostDV_mps` | public double |
| `decelDV_mps` | public double |
| `DV_mps` | public virtual double |
| `epochTime` | public TIDateTime |
| `eccentricity` | public double |
| `ascendingNode_rad` | public double |
| `inclination_rad` | public double |
| `argP_rad` | public double |
| `initialVelocity_mps` | public double |
| `initialMeanAnomaly_rad` | public double |
| `fleetCruiseAcceleration_mps2` | public double |
| `boostDV_mps` | public double |
| `decelDV_mps` | public double |
| `DV_mps` | public double |
| `interruptible` | public bool |
| `initialOrbit` | public OrbitalElementsState |
| `finalOrbit` | public OrbitalElementsState |
| `boostDV_mps` | public double |
| `decelDV_mps` | public double |
| `DV_mps` | public double |
| `interruptible` | public bool |
| `orbit` | public OrbitalElementsState |
| `boostDV_mps` | public virtual double |
| `decelDV_mps` | public virtual double |
| `DV_mps` | public virtual double |
| `endTime` | public TIDateTime |
| `burnDuration_s` | public double |
| `fleetAccel_mps2` | public double |
| `isBoost` | public bool |
| `burnDescription` | public BurnBezierDescription |
| `DV_mps` | public override double |
| `boostDV_mps` | public override double |
| `decelDV_mps` | public override double |
| `boostDV_mps` | public double |
| `decelDV_mps` | public double |
| `DV_mps` | public double |
| `interruptible` | public bool |
| `duration_s` | public double |
| `startPosition` | public Vector3d |
| `endPosition` | public Vector3d |

### Properties

- `public TIDateTime startTime`
- `public TIDateTime endTime`
- `public TINaturalSpaceObjectState barycenter`
- `public bool isImpulse`
- `public bool isTorch`
- `public bool isOrbitPhasing`
- `public bool interruptible`
- `public TIDateTime startTime`
- `public TIDateTime endTime`
- `public TINaturalSpaceObjectState barycenter`
- `public bool isImpulse`
- `public bool isTorch`
- `public bool isOrbitPhasing`
- `public TIDateTime startTime`
- `public TINaturalSpaceObjectState barycenter`
- `public bool isImpulse`
- `public bool isTorch`
- `public bool isOrbitPhasing`
- `public TIDateTime startTime`
- `public bool isImpulse`
- `public bool isTorch`
- `public bool isOrbitPhasing`
- `public bool interruptible`
- `public TINaturalSpaceObjectState barycenter`
- `public TIDateTime startTime`
- `public TINaturalSpaceObjectState barycenter`
- `public bool isImpulse`
- `public bool isTorch`
- `public bool isOrbitPhasing`

### Methods

```csharp
public bool BuildInterimTrajectory(TISpaceFleetState fleet, Trajectory_Patched oldTrajectory, Trajectory_Patched newTrajectory, TIDateTime startOfInterimTrajectory, TIDateTime middleOfBurn, double burnDuration_s, OrbitalElementsState orbitAtStart, TINaturalSpaceObjectState barycenter, double fleetAcceleration_mps2)
```

```csharp
public bool BuildInterimTrajectory(TISpaceFleetState fleet, Trajectory_Patched oldTrajectory, OrbitalElementsState newOrbit, TIDateTime startOfInterimTrajectory, TIDateTime middleOfBurn, double burnDuration_s, OrbitalElementsState orbitAtStart, TINaturalSpaceObjectState barycenter, double fleetAcceleration_mps2)
```

```csharp
public static Trajectory BuildTruncatedTrajectory(TISpaceFleetState fleet, Trajectory_Patched oldTrajectory, TIDateTime removeEverythingBeforeThisTime)
```

```csharp
private bool BuildInterimTrajectory_Common(TISpaceFleetState fleet, Trajectory_Patched oldTrajectory, TIDateTime startOfBurn, TIDateTime endOfBurn, CartesianState cartesianBeforeBurn, CartesianState cartesianAfterBurn, TIDateTime startOfInterimTrajectory, OrbitalElementsState orbitAtStart, TINaturalSpaceObjectState barycenter, double fleetAcceleration_mps2, TISpaceGameState destination)
```

```csharp
public bool BuildCoastTrajectory(TISpaceFleetState fleet, Trajectory oldTrajectory, TIDateTime timeCoastStarts, OrbitalElementsState orbitAtStart, TINaturalSpaceObjectState barycenterAtStart)
```

```csharp
private ValueTuple<TINaturalSpaceObjectState, OrbitalElementsState, TIDateTime, bool, bool> BuildCoastTrajectoryAroundBarycenter(Trajectory oldTrajectory, TIDateTime startTime, OrbitalElementsState orbit, TINaturalSpaceObjectState barycenter)
```

```csharp
public void BuildSingleOrbitPhasingTrajectory(IMobileAsset fleet, TISpaceGameState destination, ITransferTarget originValue, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter, OrbitPhasingTransfer solver, double fleetAcceleration_mps2, OrbitalElementsState originOrbit, OrbitalElementsState destOrbit, TINaturalSpaceObjectState originBarycenter, TINaturalSpaceObjectState destBarycenter)
```

```csharp
public void BuildEmptyTrajectory(IMobileAsset fleet, TIDateTime transferTime, TISpaceGameState destination = null)
```

```csharp
public void BuildSingleTrajectory(IMobileAsset fleet, TISpaceGameState destination, ITransferTarget originValue, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter, InclinationChangeTransfer solver, double fleetAcceleration_mps2)
```

```csharp
public override void BuildSingleTrajectory(IMobileAsset fleet, TISpaceGameState destination, ITransferTarget originValue, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter, TrajectorySolver solver, double fleetCruiseAcceleration_mps2)
```

```csharp
public void RecalculateCommonBarycenter()
```

```csharp
private void CorrectLaunchAndArrivalTime(TIDateTime newLaunchTime, TIDateTime newArrivalTime, TIFactionState ourFaction)
```

```csharp
private double OrbitPeriod_s(double a, double mu)
```

```csharp
private ValueTuple<TIDateTime, TIDateTime> GetBurnTimeBounds(PatchedTransfer patchedSolver, int segmentIndex, ITransferTarget destinationValue)
```

```csharp
private ValueTuple<double, double> GetOrbitPeriodsBeforeAndAfterSegment(PatchedTransfer patchedSolver, int segmentIndex, ITransferTarget destinationValue)
```

```csharp
private void UpdateDestinationOrbitWhenTargetingFleetInMotion()
```

```csharp
private List<Trajectory_Patched.MicrothrustSegment> CreateMicrothrustSegmentsForOrbitPhasing(OrbitalElementsState orbitAtTerminalTime, TINaturalSpaceObjectState barycenterAtTerminalTime, TIDateTime terminalTime, TINaturalSpaceObjectState commonBarycenter, double fleetAcceleration_mps2, bool isGoingOut, out CartesianState cartesianStateWithRespectToCommonBarycenter, out TIDateTime centralEndOfMicrothrustTime)
```

```csharp
private Trajectory_Patched.MicrothrustSegment CreateMicrothrustSegment(MicrothrustTransferSegment segment, TIDateTime prevBurnEndTime)
```

```csharp
private Trajectory_Patched.MicrothrustLERPSegment CreateMicrothrustLERPSegment(MicrothrustTransferSegmentLERP segment, TIDateTime prevBurnEndTime)
```

```csharp
private ValueTuple<TIDateTime, double> EarliestBurnStartTimeGivenExistingSegments(TIDateTime earliestStartTime)
```

```csharp
private List<Trajectory_Patched.IPatchSegment> CreateImpulseSegments(ImpulseTransferSegment segment, List<IPatchedTransferSegment> rawSegments, ref int segmentIndex, ITransferTarget originValue, ITransferTarget destinationValue, ref TIDateTime prevBurnEndTime, [TupleElementNames(new string[]
```

```csharp
private List<Trajectory_Patched.IPatchSegment> AdjustImpulseTrajectoryToReachPeriapsis(List<Trajectory_Patched.BurnSegment> boostSegments, Trajectory_Patched.IPatchSegment orbitSegment, List<Trajectory_Patched.BurnSegment> decelSegments)
```

```csharp
private List<Trajectory_Patched.BurnSegment> AdjustBurnSegmentToAvoidCollision(Trajectory_Patched.BurnSegment originalBurnSegment, TINaturalSpaceObjectState collisionObject)
```

```csharp
private List<Trajectory_Patched.IPatchSegment> CreateBurnSegments(BurnTransferSegment segment, List<IPatchedTransferSegment> rawSegments, ref int segmentIndex, ITransferTarget originValue, ITransferTarget destinationValue, ref TIDateTime prevBurnEndTime)
```

```csharp
private List<Trajectory_Patched.IPatchSegment> CreateThreeImpulseTransferSegments(ThreeImpulseTransferSegment segment, List<IPatchedTransferSegment> rawSegments, ref int segmentIndex, ITransferTarget originValue, ITransferTarget destinationValue, ref TIDateTime prevBurnEndTime, [TupleElementNames(new string[]
```

```csharp
private List<Trajectory_Patched.IPatchSegment> CreateTorchSegments(TorchTransferSegment segment, Vector3d globalStartPosition, Trajectory_Patched.MicrothrustSegment nextSegment, ITransferTarget destinationValue, TINaturalSpaceObjectState sourceBarycenter)
```

```csharp
private List<Trajectory_Patched.IPatchSegment> CreateTorchSegments(TorchTransferSegment segment, Vector3d globalStartPosition, CartesianState globalEndState, TINaturalSpaceObjectState sourceBarycenter, TINaturalSpaceObjectState destinationBarycenter)
```

```csharp
public void AddRemnantsOfExistingTransfer(Trajectory_Patched oldTrajectory)
```

```csharp
public override bool isPlausible()
```

```csharp
public override string GetDisplayName()
```

```csharp
public override TINaturalSpaceObjectState GetBarycenterAtTime(TIDateTime time)
```

```csharp
public override OrbitalElementsState GetOrbitalElementsAtTime(TIDateTime time, TISpaceAssetState.MeanAnomalyPrecision precision)
```

```csharp
public override bool isInMicrothrust(TIDateTime time = null)
```

```csharp
public override List<ValueTuple<TIDateTime, Trajectory.TrajectoryDomain>> GetTrajectoryDomainsOverTime()
```

```csharp
public override bool CantManeuver(TIDateTime time = null)
```

```csharp
public override bool isInImpulse(TIDateTime time = null)
```

```csharp
public override double getDistFromBarycenterAtTime_m(TIDateTime timeToCheck, out TINaturalSpaceObjectState barycenter)
```

```csharp
public override double RemainingDVatTime_mps(TIDateTime time)
```

```csharp
public override CartesianState ToGlobalCartesianStateAtTime(TIDateTime timeToCheck)
```

```csharp
public override Vector3d PositionAtTime(TIDateTime timeToCheck, bool setPosition, out bool arrived)
```

```csharp
private TIDateTime Min(TIDateTime a, TIDateTime b)
```

```csharp
private void UpdateThrustPhase(ref Trajectory_Patched.ThrustPhase thrustPhase, Trajectory_Patched.ThrustPhase newThrustPhase)
```

```csharp
private void UpdateFleetAccelerationPhaseStatus(Trajectory_Patched.ThrustPhase thrustPhase, bool finishedTransfer)
```

```csharp
public override string deepDump()
```

```csharp
public string DumpSegments()
```

```csharp
public override TIDateTime getOrbitEndTime()
```

```csharp
public override OrbitalElementsState OrbitalElementsAtTime(TIDateTime timeToCheck)
```

```csharp
public override double DVConsumedByTime(TIDateTime timeToCheck)
```

```csharp
public override Trajectory_Patched.ISupportsReducedCopy ReducedCopy(TIDateTime newStartTime, TIDateTime newEndTime)
```

```csharp
public override bool isPlausible(IMobileAsset fleet)
```

```csharp
public override string DumpSegment()
```

```csharp
public override string deepDump()
```

```csharp
public virtual Trajectory_Patched.ISupportsReducedCopy ReducedCopy(TIDateTime newStartTime, TIDateTime newEndTime)
```

```csharp
public Vector3d GlobalPositionAtTime(TIDateTime timeToCheck)
```

```csharp
public virtual CartesianState GlobalCartesianStateAtTime(TIDateTime timeToCheck)
```

```csharp
public CartesianState CartesianStateAtTime(TIDateTime timeToCheck, TISpaceObjectState barycenter)
```

```csharp
public CartesianState LocalCartesianStateAtTime(TIDateTime timeToCheck)
```

```csharp
public virtual OrbitalElementsState OrbitalElementsAtTime(TIDateTime timeToCheck)
```

```csharp
public double getDistFromBarycenterAtTime_m(TIDateTime timeToCheck, out TINaturalSpaceObjectState barycenter)
```

```csharp
public virtual double DVConsumedByTime(TIDateTime timeToCheck)
```

```csharp
public Trajectory_Patched.ThrustPhase GetThrustPhaseAtTime(TIDateTime timeToCheck)
```

```csharp
public virtual bool isPlausible(IMobileAsset fleet)
```

```csharp
public virtual string DumpSegment()
```

```csharp
public virtual string deepDump()
```

```csharp
private double FourthPower(double x)
```

```csharp
public Vector3d GlobalPositionAtTime(TIDateTime timeToCheck)
```

```csharp
public CartesianState GlobalCartesianStateAtTime(TIDateTime timeToCheck)
```

```csharp
public CartesianState CartesianStateAtTime(TIDateTime timeToCheck, TISpaceObjectState barycenter)
```

```csharp
public CartesianState TrueCartesianStateAtTime(TIDateTime timeToCheck, TISpaceObjectState barycenter)
```

```csharp
public CartesianState TrueGlobalCartesianStateAtTime(TIDateTime timeToCheck)
```

```csharp
public OrbitalElementsState OrbitalElementsAtTime(TIDateTime time)
```

```csharp
public double getDistFromBarycenterAtTime_m(TIDateTime timeToCheck, out TINaturalSpaceObjectState barycenter)
```

```csharp
public double DVConsumedByTime(TIDateTime timeToCheck)
```

```csharp
public Trajectory_Patched.ThrustPhase GetThrustPhaseAtTime(TIDateTime timeToCheck)
```

```csharp
public bool isPlausible(IMobileAsset fleet)
```

```csharp
public string DumpSegment()
```

```csharp
public virtual string deepDump()
```

```csharp
public override double getDistFromBarycenterAtTime_m(TIDateTime timeToCheck, out TINaturalSpaceObjectState barycenter)
```

```csharp
public override bool isPlausible(IMobileAsset fleet)
```

```csharp
public override string DumpSegment()
```

```csharp
public override string deepDump()
```

```csharp
public Vector3d GlobalPositionAtTime(TIDateTime timeToCheck)
```

```csharp
public CartesianState GlobalCartesianStateAtTime(TIDateTime timeToCheck)
```

```csharp
public CartesianState CartesianStateAtTime(TIDateTime timeToCheck, TISpaceObjectState barycenter)
```

```csharp
public OrbitalElementsState OrbitalElementsAtTime(TIDateTime _)
```

```csharp
public virtual double getDistFromBarycenterAtTime_m(TIDateTime timeToCheck, out TINaturalSpaceObjectState barycenter)
```

```csharp
public double DVConsumedByTime(TIDateTime timeToCheck)
```

```csharp
public Trajectory_Patched.ThrustPhase GetThrustPhaseAtTime(TIDateTime timeToCheck)
```

```csharp
public virtual bool isPlausible(IMobileAsset fleet)
```

```csharp
public virtual string DumpSegment()
```

```csharp
public virtual string deepDump()
```

```csharp
public Trajectory_Patched.ISupportsReducedCopy ReducedCopy(TIDateTime newStartTime, TIDateTime newEndTime)
```

```csharp
public CartesianState GlobalCartesianStateAtTime(TIDateTime timeToCheck)
```

```csharp
public Vector3d GlobalPositionAtTime(TIDateTime timeToCheck)
```

```csharp
public virtual double DVConsumedByTime(TIDateTime timeToCheck)
```

```csharp
public Trajectory_Patched.ThrustPhase GetThrustPhaseAtTime(TIDateTime timeToCheck)
```

```csharp
public OrbitalElementsState OrbitalElementsAtTime(TIDateTime timeToCheck)
```

```csharp
public double getDistFromBarycenterAtTime_m(TIDateTime timeToCheck, out TINaturalSpaceObjectState barycenter)
```

```csharp
public virtual bool isPlausible(IMobileAsset fleet)
```

```csharp
public virtual string DumpSegment()
```

```csharp
public virtual string deepDump()
```

```csharp
public override double DVConsumedByTime(TIDateTime timeToCheck)
```

```csharp
public override string DumpSegment()
```

```csharp
public override bool isPlausible(IMobileAsset fleet)
```

```csharp
public override string deepDump()
```

```csharp
public double DVConsumedByTime(TIDateTime timeToCheck)
```

```csharp
public Trajectory_Patched.ThrustPhase GetThrustPhaseAtTime(TIDateTime timeToCheck)
```

```csharp
public CartesianState GlobalCartesianStateAtTime(TIDateTime timeToCheck)
```

```csharp
public Vector3d GlobalPositionAtTime(TIDateTime timeToCheck)
```

```csharp
public OrbitalElementsState OrbitalElementsAtTime(TIDateTime timeToCheck)
```

```csharp
private Vector3d LocalVelocity()
```

```csharp
private Vector3d LocalPositionAtTime(TIDateTime timeToCheck)
```

```csharp
public double getDistFromBarycenterAtTime_m(TIDateTime timeToCheck, out TINaturalSpaceObjectState barycenter)
```

```csharp
public bool isPlausible(IMobileAsset fleet)
```

```csharp
public string DumpSegment()
```

```csharp
public string deepDump()
```
