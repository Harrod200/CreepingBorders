# MasterTransferPlanner

*Decompiled from `PavonisInteractive/TerraInvicta/MasterTransferPlanner.cs`.*


## Class `MasterTransferPlanner`

```csharp
public class MasterTransferPlanner : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Instance` | public static MasterTransferPlanner |
| `ARRIVAL_TIME_ITERATIONS_PLAYER` | private const int |
| `ARRIVAL_TIME_ITERATIONS_AI` | private const int |
| `ARRIVAL_TIME_ITERATIONS_MIN` | private const int |
| `LAUNCH_TIME_ITERATIONS_PLAYER` | private const int |
| `LAUNCH_TIME_ITERATIONS_AI` | private const int |
| `ARRIVAL_ANOMALY_ITERATIONS_PLAYER` | private const int |
| `ARRIVAL_ANOMALY_ITERATIONS_AI` | private const int |
| `MAX_MICROTHRUST_DURATION` | public const double |
| `MAX_TRANSFER_DURATION` | public const double |
| `MAX_TRANSFER_DURATION_ALIEN` | public const double |
| `queue` | protected static Queue<MasterTransferPlanner.TrajectoryQueue> |
| `request` | protected static AsyncGPUReadbackRequest |
| `requestActive` | protected static bool |
| `s_instance` | private static MasterTransferPlanner |
| `dumpFile` | private const string |
| `TrajectoryQueue` | protected struct |
| `fleet` | public TISpaceFleetState |
| `destination` | public TIGameState |
| `commonBarycenter` | public TINaturalSpaceObjectState |
| `commonBarycenter_mu` | public float |
| `relevantOriginOrbitalElements` | public ITransferTarget |
| `relevantDestinationOrbitalElements` | public ITransferTarget |
| `sweepRange` | public int |
| `callback` | public Action<Trajectory[]> |
| `CalculateImpulseMicrothrustHybridTransfer_Params` | private class |
| `requestSize` | public int |
| `sampleSizeMultiplier` | public double |
| `fleet` | public IMobileAsset |
| `fleetDeltaV_mps` | public double |
| `fleetAcceleration_mps2` | public double |
| `originValue` | public ITransferTarget |
| `sDestination` | public TISpaceGameState |
| `destinationValue` | public ITransferTarget |
| `commonBarycenter` | public TINaturalSpaceObjectState |
| `now` | public TIDateTime |
| `aerobreaking` | public bool |
| `unsafeAerobreaking` | public bool |
| `log` | public StreamWriter |
| `stopOnFirstSuccess` | public bool |
| `HohmannTiming` | protected class |
| `initialHohmannArrivalTime` | public TIDateTime |
| `transferDuration_s` | public double |
| `synodicPeriod_s` | public double |
| `firstHohmannAfterInitial` | public int |
| `lastHohmannAfterInitial` | public int |
| `SimplifiedPositions` | private class |
| `originDistToLocalBarycenter_m` | public double |
| `originLocalBarycenter` | public TINaturalSpaceObjectState |
| `destinationDistToLocalBarycenter_m` | public double |
| `destinationLocalBarycenter` | public TINaturalSpaceObjectState |
| `originDistToCommonBarycenter_m` | public double |
| `destinationDistToCommonBarycenter_m` | public double |
| `commonBarycenter` | public TINaturalSpaceObjectState |
| `IdentifyHybridTransferType_Result` | private class |
| `totalMicrothrustDuration_s` | public double |
| `isMicrothrustOnly` | public bool |
| `isGoingOut` | public bool |
| `outspiralDuration_s` | public double |
| `inspiralDuration_s` | public double |
| `commonMicrothrustRadius_m` | public double |
| `MicrothrustStatistics` | private class |
| `outspiralDuration_s` | public double |
| `inspiralDuration_s` | public double |
| `totalMicrothrustDuration_s` | public double |
| `isMicrothrustOnly` | public bool |
| `isCommonGoingOut` | public bool |
| `commonMicrothrustDuration_s` | public double |
| `commonMicrothrustAnomalyDelta_Rad` | public double |
| `startDepth1MicrothrustDuration_s` | public double |
| `startDepth1MicrothrustAnomalyDelta_Rad` | public double |
| `startDepth1Radius_m` | public double |
| `startDepth2MicrothrustDuration_s` | public double |
| `startDepth2MicrothrustAnomalyDelta_Rad` | public double |
| `startDepth2Radius_m` | public double |
| `endDepth1MicrothrustDuration_s` | public double |
| `endDepth1MicrothrustAnomalyDelta_Rad` | public double |
| `endDepth1Radius_m` | public double |
| `endDepth2MicrothrustDuration_s` | public double |
| `endDepth2MicrothrustAnomalyDelta_Rad` | public double |
| `endDepth2Radius_m` | public double |
| `OrbitPhasingConstraints` | private class |
| `succeeded` | public bool |
| `ourOrbit` | public OrbitalElementsState |
| `destOrbit` | public OrbitalElementsState |
| `earliestLaunchTime` | public TIDateTime |
| `earliestArrivalTime` | public TIDateTime |
| `latestArrivalTime` | public TIDateTime |
| `ourInitialOrbit` | public OrbitalElementsState |
| `ourInitialBarycenter` | public TINaturalSpaceObjectState |
| `destFinalOrbit` | public OrbitalElementsState |
| `destFinalBarycenter` | public TINaturalSpaceObjectState |
| `TransferCalculatorParameters` | private class |
| `origin` | public ITransferTarget |
| `destination` | public ITransferTarget |
| `fleetAcceleration_mps` | public double |
| `fleetDV_mps2` | public double |
| `requestSize` | public int |
| `startTime` | public TIDateTime |
| `arrivalCap` | public TIDateTime |

### Methods

```csharp
public void Start()
```

```csharp
public void LateUpdate()
```

```csharp
public static bool FleetQueuedForTrajectories(TISpaceFleetState fleet)
```

```csharp
private static double GetStartDuration_s(TISpaceObjectState source, TISpaceObjectState destination, double acceleration_mps2, double deltaV_mps, double min_Distance_m, TrajectoryModel trajectoryModel)
```

```csharp
public static double GetEstimatedTransferTime_s(TISpaceAssetState asset, TISpaceObjectState destination, double acceleration_mps2, double deltaV_mps, out bool impossible)
```

```csharp
private static float GetLinearDuration_s(TISpaceAssetState asset, TISpaceObjectState destination, double acceleration_mps2, double deltaV_mps)
```

```csharp
public static List<TrajectoryModel> GetTrajectoryModelsForConditions(IMobileAsset fleet, TIGameState destination, bool forcePlaceholder, double acc_mps2, double DV_mps, out TINaturalSpaceObjectState commonBarycenter, out ITransferTarget originValue, out ITransferTarget destinationValue)
```

```csharp
private static bool DoesOrbitMatch(IMobileAsset origin, TIOrbitState destination)
```

```csharp
private static bool IsInMicrothrustDomain(ITransferTarget target, double fleetAcceleration_mps2, TINaturalSpaceObjectState commonBarycenter, TIFactionState ourFaction)
```

```csharp
public static TransferResult RequestTrajectories(IMobileAsset fleet, TIGameState destination, int requestSize, Action<Trajectory[]> callback, out double lowestDVFound_kps, bool usePlaceholderTrajectories = false, bool stopOnFirstSuccess = false, double sampleSizeMultiplier = 1.0)
```

```csharp
private static double microthrustDelays(TINaturalSpaceObjectState barycenter, double semiMajorAxis_m, double fleetAcceleration_mps2)
```

```csharp
public static bool DoWeKnowThatFleetIsTransfering(TISpaceFleetState fleet, TIFactionState ourFaction)
```

```csharp
protected static void AddRemnantsOfExistingTransfer(Trajectory_Patched trajectory, Trajectory_Patched oldTrajectory)
```

```csharp
private static TransferResult CalculateImpulseMicrothrustHybridTransfers(ref List<Trajectory> candidateTrajectories, ref double lowestDVFound_kps, MasterTransferPlanner.CalculateImpulseMicrothrustHybridTransfer_Params param)
```

```csharp
public static void GetOriginOrbitalElementsState(ITransferTarget originValue, TIDateTime time, out OrbitalElementsState orbitalElements, out TINaturalSpaceObjectState barycenter, out bool meanAnomalyIsGood)
```

```csharp
private static List<TIDateTime> FindFutureApsidesTimes(Trajectory trajectory, TIDateTime earliestTime, TIDateTime latestTime)
```

```csharp
private static ValueTuple<AerobreakInfo, AerobreakInfo> AerocaptureToOrbit(MasterTransferPlanner.CalculateImpulseMicrothrustHybridTransfer_Params param, TIDateTime launchTime, TIDateTime proposedArrivalTime, TISpaceBodyState aerocaptureBarycenter, TINaturalSpaceObjectState commonBarycenter, CartesianState initialCartesian, CartesianState aerocaptureCartesian, OrbitalElementsState destinationOrbitalElements)
```

```csharp
private static bool AerobreakPrecalculator(MasterTransferPlanner.CalculateImpulseMicrothrustHybridTransfer_Params param, TIDateTime launchTime, TIDateTime proposedArrivalTime, [TupleElementNames(new string[]
```

```csharp
private static ValueTuple<AerobreakInfo, AerobreakInfo> AerocaptureToFixedMeanAnomaly(MasterTransferPlanner.CalculateImpulseMicrothrustHybridTransfer_Params param, TIDateTime launchTime, TIDateTime proposedArrivalTime, TISpaceBodyState aerocaptureBarycenter, TINaturalSpaceObjectState commonBarycenter, CartesianState initialCartesian, CartesianState aerocaptureCartesian, OrbitalElementsState destinationOrbitalElementsAroundAerocaptureBarycenter, TIOrbitState destinationOrbitAroundMoon = null, OrbitalElementsState destinationOrbitalElementsAroundMoon = default(OrbitalElementsState))
```

```csharp
private static bool isAerobreakingBetterThanHohmann(double initialRadius_m, double finalRadius_m, double aerobreakRadius_m)
```

```csharp
private static TIDateTime BestLaunchTimeFromActiveTrajectory(Trajectory trajectory, TIDateTime earliestTime, TIDateTime latestTime)
```

```csharp
private static List<TIDateTime> LaunchTimesToTestOnActiveTrajectory(Trajectory trajectory, TIDateTime now, TIDateTime arrivalTime)
```

```csharp
private static double LagrangeOnlyMaxDuration_s(double accleration_mps2, double distance_m, double DV_mps)
```

```csharp
private static ValueTuple<TINaturalSpaceObjectState, double> GetBarycenterAndRadiusOfFleetAtArrival(TISpaceFleetState fleet)
```

```csharp
private static double GetCommonSemiMajorAxis_m([TupleElementNames(new string[]
```

```csharp
private static double GetRadiusFromGameState(TISpaceGameState state)
```

```csharp
private static TIDateTime GetBestHohmannArrivalTime(OrbitalElementsState startLocalOrbit, OrbitalElementsState endLocalOrbit, TINaturalSpaceObjectState startBarycenter, TINaturalSpaceObjectState endBarycenter, TIDateTime now, double fleetAcceleration_mps2, TIFactionState faction, out MasterTransferPlanner.HohmannTiming laterHohmannTransfers)
```

```csharp
private static double GetMaxDurationOfTransfer(ITransferTarget start, ITransferTarget end, double fleetAcceleration_mps2, TIDateTime now)
```

```csharp
private static double GetMaxDurationOfTransfer(TINaturalSpaceObjectState startBarycenter, double startRadius_m, TINaturalSpaceObjectState endBarycenter, double endRadius_m, double fleetAcceleration_mps2, bool includeSynodicPeriod)
```

```csharp
private static double GetMeanAnomalyAtTime(ITransferTarget targetValue, TIDateTime time)
```

```csharp
private static TIDateTime TimeWhenAtMeanAnomaly(TIDateTime approximateTime, double targetAnomaly_Rad, ITransferTarget targetValue)
```

```csharp
private static TIDateTime TimeWhenAtMeanAnomaly(TIDateTime approximateTime, double targetAnomaly_Rad, double anomalyAtApproximateTime_Rad, double orbitPeriod_d)
```

```csharp
private static TIDateTime AdvanceTimePastDeadlineInIncrements(TIDateTime time, TIDateTime deadline, double increment_s)
```

```csharp
private static ValueTuple<TIDateTime, TIDateTime, TIDateTime> CalculateLaunchTiming(MasterTransferPlanner.CalculateImpulseMicrothrustHybridTransfer_Params param, TIDateTime arrivalTime, TINaturalSpaceObjectState commonBarycenter, MasterTransferPlanner.IdentifyHybridTransferType_Result hybridTransferType)
```

```csharp
private static ValueTuple<TIDateTime, TIDateTime, TIDateTime> CalculateLaunchTimingWhenDestinationIsTransferingFleet(MasterTransferPlanner.CalculateImpulseMicrothrustHybridTransfer_Params param, TIDateTime arrivalTime, TINaturalSpaceObjectState commonBarycenter, [TupleElementNames(new string[]
```

```csharp
private static ValueTuple<TIDateTime, TIDateTime, TIDateTime> CalculateLaunchTiming(TIDateTime now, TIDateTime arrivalTime, double hohmannDuration_s, double expectedMicrothrustDelays_s, double synodicPeriod_s)
```

```csharp
private static ValueTuple<Vector3d, Vector3d> CalculateIdealOrbitalVelocitiesForLambert(MasterTransferPlanner.CalculateImpulseMicrothrustHybridTransfer_Params param, TIDateTime launchTime, TIDateTime arrivalTime)
```

```csharp
private static ValueTuple<double, double, bool> TerminalSpiralAnomaly_Rad(ITransferTarget transferTarget, double fleetAcceleration_mps2)
```

```csharp
private static ValueTuple<double, double, bool> TerminalSpiralAnomaly_Rad(TINaturalSpaceObjectState targetBarycenter, double targetSemiMajorAxis_m, double fleetAcceleration_mps2)
```

```csharp
private static double GetMeanAnomalyWhenFurthestFromOrClosestToParentBarycenter(ITransferTarget transferTarget, TIDateTime time, bool furthest, bool isPlayer)
```

```csharp
private static ValueTuple<Vector3d, Vector3d> CalculateIdealOrbitalVelocitiesForTorch(ITransferTarget start, ITransferTarget destination, TINaturalSpaceObjectState commonBarycenter, TIDateTime launchTime, TIDateTime arrivalTime)
```

```csharp
private static ValueTuple<Vector3d, Vector3d> CalculateIdealOrbitalVelocitiesForTorch(OrbitalElementsState startOrbit, TINaturalSpaceObjectState startBarycenter, OrbitalElementsState destinationOrbit, TINaturalSpaceObjectState destinationBarycenter, TINaturalSpaceObjectState commonBarycenter, TIDateTime launchTime, TIDateTime arrivalTime)
```

```csharp
private static Vector3d CalculateIdealOrbitalVelocitiesForTorch(Vector3d orbitNormal, Vector3d idealDirection, Vector3d residualVelocity, double orbitSpeed)
```

```csharp
private static Vector3d RodrequesRotationFormula(Vector3d originalVector, Vector3d rotationAxis, double angle_Rad)
```

```csharp
private static double EstimateMeanAnomalyWhenMotionIsClosestToGivenVelocity(Vector3d velocity, ITransferTarget transferTarget, TIDateTime time, bool isPlayer)
```

```csharp
private static double EstimateMeanAnomalyWhenMotionIsClosestToGivenVelocity(Vector3d velocity, OrbitalElementsState orbitalElements, TINaturalSpaceObjectState barycenter, TIDateTime time, bool isPlayer)
```

```csharp
private static MasterTransferPlanner.SimplifiedPositions GetSimplifiedPositions(ITransferTarget origin, ITransferTarget destination, TIDateTime time = null, TIDateTime arrivalTime = null)
```

```csharp
private static List<Trajectory_Patched> LoopOverArrivalTimes(int totalTests, double sampleSizeMultiplier, TIDateTime earliestTime, TIDateTime latestTime, List<TIDateTime> timesThatMustBeTested, MasterTransferPlanner.HohmannTiming additionalHohmannTimesToTest, double maxDV_mps, bool stopOnFirstSuccess, TIFactionState faction, out TransferResult result, out double lowestDVfound_mps, [TupleElementNames(new string[]
```

```csharp
private static ValueTuple<ValueTuple<TransferResult, PatchedTransfer, TINaturalSpaceObjectState>, TIDateTime> BestTransferResult([TupleElementNames(new string[]
```

```csharp
private static ValueTuple<TransferResult, Trajectory_Patched, double> OptimizeLaunchTime(TIDateTime expectedBestLaunchTime, TIDateTime earliestLaunchTime, TIDateTime latestLaunchTime, TIDateTime arrivalTime, [TupleElementNames(new string[]
```

```csharp
private static ValueTuple<TransferResult, PatchedTransfer, TINaturalSpaceObjectState> TryGetTransfer(TIDateTime attemptedLaunchTime, TIDateTime arrivalTime, TIDateTime earliestLaunchTime, MasterTransferPlanner.CalculateImpulseMicrothrustHybridTransfer_Params param, string transferType, double stepSize_s, [TupleElementNames(new string[]
```

```csharp
private static CartesianState GlobalToLocal(CartesianState state, TINaturalSpaceObjectState localBarycenter, TIDateTime time)
```

```csharp
private static ValueTuple<TIDateTime, TIDateTime, OrbitalElementsState, TIDateTime, TIDateTime, OrbitalElementsState> CreateTransferParamsForOptimizeArrivalMeanAnomaly(TIDateTime launchTime, TIDateTime arrivalTime, double meanAnomaly, ITransferTarget destination, [TupleElementNames(new string[]
```

```csharp
private static void TestArrivalMeanAnomaly([TupleElementNames(new string[]
```

```csharp
private static ValueTuple<Trajectory_Patched, double> OptimizeArrivalMeanAnomaly(TIDateTime launchTime, TIDateTime arrivalTime, MasterTransferPlanner.CalculateImpulseMicrothrustHybridTransfer_Params param, string transferType, [TupleElementNames(new string[]
```

```csharp
private static double TransferDurationHardCap(TIFactionState faction)
```

```csharp
private static ValueTuple<TINaturalSpaceObjectState, TINaturalSpaceObjectState, TINaturalSpaceObjectState> GetRelevantBarycentersAtTime(ITransferTarget source, ITransferTarget destination, TIDateTime launchTime, TIDateTime arrivalTime)
```

```csharp
public static double NormalizeAngleNearZero_Rad(double angle)
```

```csharp
public static double NormalizeAngleNearPi_Rad(double angle)
```

```csharp
private static double MeanAnomalyToSeconds(double meanAnomaly_Rad, double orbitalPeriod_s)
```

```csharp
private static double FindMeanAnomalyWhereOrbitVelocityMatchesThrustDirection(OrbitalElementsState orbit, Vector3d thrustVector, TINaturalSpaceObjectState barycenter, TIDateTime time, bool isPlayer)
```

```csharp
private static ValueTuple<double, double> EstimateIdealLocalMeanAnomalies(TIDateTime launchTime, TIDateTime arrivalTime, double commonMeanAnomalyAtArrival_Rad, MasterTransferPlanner.CalculateImpulseMicrothrustHybridTransfer_Params param)
```

```csharp
private static void UpdateMicrothrustStatisticsForBarycenter(out double microthrustDuration_s, out double microthrustAnomalyDelta_Rad, out double microthrustRadius_m, TINaturalSpaceObjectState barycenter, double relevantSemiMajorAxis_m, double fleetAccleration_mps2)
```

```csharp
private static MasterTransferPlanner.IdentifyHybridTransferType_Result IdentifyHybridTransferType(MasterTransferPlanner.SimplifiedPositions simplified, double fleetAcceleration_mps2)
```

```csharp
private static MasterTransferPlanner.IdentifyHybridTransferType_Result IdentifyHybridTransferType(double startSemiMajorAxis_m, TINaturalSpaceObjectState startBarycenter, double endSemiMajorAxis_m, TINaturalSpaceObjectState endBarycenter, TINaturalSpaceObjectState commonBarycenter, double fleetAcceleration_mps2)
```

```csharp
private static TransferResult CalculateMicrothrustTransfer(ref List<Trajectory> candidateTrajectories, ref double lowestDVFound_kps, IMobileAsset fleet, double fleetDeltaV_mps, double fleetAcceleration_mps2, ITransferTarget originValue, TISpaceGameState sDestination, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter, TIDateTime now)
```

```csharp
private static void CalculateImpulseTransfers(ref List<Trajectory> candidateTrajectories, ref double lowestDVFound_kps, int requestSize, IMobileAsset fleet, double fleetDeltaV_mps, double fleetAcceleration_mps2, ITransferTarget originValue, TISpaceGameState sDestination, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter, double minAllowedDuration_s, bool useCap, TIDateTime capDate, bool orbitWalking, bool stopOnFirstSuccess = false)
```

```csharp
private static void CalculateTorchTransfers(ref List<Trajectory> candidateTrajectories, ref double lowestDVFound_kps, int requestSize, IMobileAsset fleet, double fleetDeltaV_mps, double fleetAcceleration_mps2, ITransferTarget originValue, TISpaceGameState sDestination, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter, double minAllowedDuration_s, bool useCap, TIDateTime capDate, bool stopOnFirstSuccess = false)
```

```csharp
private static TransferResult CalculateOrbitPhasingTransfers(ref List<Trajectory> candidateTrajectories, ref double lowestDVFound_kps, int requestSize, IMobileAsset fleet, double fleetDeltaV_mps, double fleetAcceleration_mps2, ITransferTarget originValue, TISpaceGameState sDestination, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter, bool stopAfterFirstSuccess = false)
```

```csharp
private static MasterTransferPlanner.OrbitPhasingConstraints OrbitPhasing_GetPhasingOrbitsAndTiming(IMobileAsset fleet, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter)
```

```csharp
private static TransferResult CalculateOrbitPhasingTransfers_(ref List<Trajectory> candidateTrajectories, ref double lowestDVFound_kps, int requestSize, IMobileAsset fleet, double fleetDeltaV_mps, double fleetAcceleration_mps2, ITransferTarget originValue, TISpaceGameState sDestination, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter, bool stopAfterFirstSuccess = false)
```

```csharp
private static TransferResult CalculateInclinationChangeTransfers(ref List<Trajectory> candidateTrajectories, ref double lowestDVFound_kps, double sampleSizeMultiplier, IMobileAsset fleet, double fleetDeltaV_mps, double fleetAcceleration_mps2, ITransferTarget originValue, TISpaceGameState sDestination, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter, bool stopOnFirstSuccess = false)
```

```csharp
private static double HohmannFirstBurnDuration_s(IMobileAsset fleet, ITransferTarget originValue, ITransferTarget destinationValue, TINaturalSpaceObjectState commonBarycenter)
```

```csharp
private static double HohmannFirstBurnDuration_s(double fleetAcceleration_mps, double startOrbitalRadius_m, double destinationSemiMajorAxis_m, double mu)
```

```csharp
private static double HohmannFirstBurnDV_mps(double startOrbitalRadius_m, double destinationSemiMajorAxis_m, double mu)
```

```csharp
private static double HohmannFinalBurnDV_mps(double startOrbitalRadius_m, double destinationSemiMajorAxis_m, double mu)
```

```csharp
public static double HohmannTotalDV_mps(double startOrbitalRadius_m, double destinationSemiMajorAxis_m, double mu)
```

```csharp
private static double HohmannDuration_s(double startSemiMajorAxis_m, double endSemiMajorAxis_m, double mu)
```

```csharp
private static double HohmannDuration_s(MasterTransferPlanner.SimplifiedPositions simplified)
```

```csharp
public static double SynodicPeriod_s(double semiMajorAxis1_m, double semiMajorAxis2_m, double mu)
```

```csharp
public TrajectoryQueue(TISpaceFleetState fleet, TIGameState destination, TINaturalSpaceObjectState commonBarycenter, ITransferTarget relevantOriginOrbitalElements, ITransferTarget relevantDestinationOrbitalElements, int sweepRange, Action<Trajectory[]> callback)
```

```csharp
public List<ValueTuple<TIDateTime, TIDateTime>> GetHohmannTimings(double sampleSizeMultiplier)
```

```csharp
public bool Verify()
```
