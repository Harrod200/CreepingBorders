# TISpaceAssetState

*Decompiled from `PavonisInteractive/TerraInvicta/TISpaceAssetState.cs`.*


## Class `TISpaceAssetState`

```csharp
public abstract class TISpaceAssetState : TISpaceObjectState, ITransferTarget
```

### Fields

| Name | Type |
|---|---|
| `isSpaceAssetState` | public override bool |
| `ref_spaceAsset` | public override TISpaceAssetState |
| `semiMajorAxis_m` | public override double |
| `ecc` | public override double |
| `inclination_Rad` | public override double |
| `longAscendingNode_Rad` | public override double |
| `argPeriapsis_Rad` | public override double |
| `meanAnomalyAtEpoch_Rad` | public override double |
| `epoch_JYears` | public override double |
| `meanLongitude_Rad` | public override double |
| `location` | public virtual TISpaceGameState |
| `localEscapeVelocity_kps` | public double |
| `localGravity` | public double |
| `MEAN_ANOMALY_PRECISION_AI` | private const int |
| `MEAN_ANOMALY_PRECISION_PLAYER` | private const int |
| `MEAN_ANOMALY_PRECISION_MAXIMUM` | private const int |
| `inCombat` | public bool |
| `_meanAnomalyAtEpoch_Rad` | protected double |
| `_epoch_JYears` | protected double |
| `spaceAssetModelScale_Hab` | public const float |
| `spaceAssetModelScale_Ship` | public const float |
| `MeanAnomalyPrecision` | public enum |

### Properties

- `public TIFactionState faction`
- `public TIOrbitState orbitState`

### Methods

```csharp
public abstract bool IsAlien()
```

```csharp
public abstract float CombatRange_km()
```

```csharp
public abstract float SpaceCombatValue()
```

```csharp
public abstract float AssaultCombatValue(bool defense)
```

```csharp
public virtual double common_a_m(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public virtual double common_i_rad(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public virtual double common_M_rad(TINaturalSpaceObjectState commonBarycenter, TIDateTime time)
```

```csharp
public double relevant_orbit_m(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public virtual bool tryToGetLocalCartesianState(TIDateTime time, out CartesianState cartesianState, out TINaturalSpaceObjectState barycenter)
```

```csharp
public virtual TINaturalSpaceObjectState localBarycenter(TIDateTime time)
```

```csharp
public virtual void getOrbitalElementsState(TIDateTime time, out OrbitalElementsState orbitalElementsState, out TINaturalSpaceObjectState barycenter, out bool meanAnomalyIsGood)
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void SetDisplayName(string newName)
```

```csharp
public static string GetRandomAssetName(TIGameState asset, TIFactionState faction)
```

```csharp
protected void SetNewOrbitalElements(OrbitalElementsState orbitalElements)
```

```csharp
protected void SetNewOrbitalElements(double meanAnomalyAtEpoch_Rad, TIDateTime epoch)
```

```csharp
private void AssumeOrbit(TIOrbitState orbitState)
```

```csharp
public void AssumeMatchingOrbitFromState(TISpaceAssetState matchingAsset, bool docking)
```

```csharp
public void AssumeOrbitFromState(TIOrbitState orbitState, double meanAnomalyAtEpoch_Rad = 0.0, TIDateTime epoch = null)
```

```csharp
public void AssumeOrbitStateGivenMeanAnomalyAtEpoch(TIOrbitState newOrbit, TIDateTime epoch, double meanAnomalyAtEpoch_Rad)
```

```csharp
public void AssumeOrbitStateFromPosition(TIOrbitState newOrbit, Vector3d globalPosition, Vector3d barycenterPosition, TIDateTime time, TISpaceAssetState.MeanAnomalyPrecision precision)
```

```csharp
public static double CalculateMeanAnomalyFromPosition(ITransferTarget transferTarget, Vector3d localPosition, TIDateTime time, bool isPlayer)
```

```csharp
public static double CalculateMeanAnomalyFromPosition(ITransferTarget transferTarget, Vector3d localPosition, TIDateTime time, TISpaceAssetState.MeanAnomalyPrecision precision)
```

```csharp
public static double CalculateMeanAnomalyFromPosition(OrbitalElementsState orbit, TINaturalSpaceObjectState barycenter, Vector3d localPosition, TIDateTime time, bool isPlayer)
```

```csharp
public static double CalculateMeanAnomalyFromPosition(OrbitalElementsState orbit, TINaturalSpaceObjectState barycenter, Vector3d localPosition, TIDateTime time, TISpaceAssetState.MeanAnomalyPrecision precision)
```

```csharp
private static double ScoreMeanAnomaly(OrbitalElementsState orbit, TINaturalSpaceObjectState barycenter, Vector3d targetPosition, double meanAnomalyAtEpoch_Rad, TIDateTime time)
```

```csharp
public void SetRandomizedOrbitFromState(TIOrbitState orbitState, bool variableAxisAndInclination = true)
```

```csharp
public bool VisibleToFaction(TIFactionState faction)
```

```csharp
public bool UndercoverCouncilorsVisibleToFaction(TIFactionState faction)
```

```csharp
public virtual TINaturalSpaceObjectState GetSphereOfInfluence(bool exact = false)
```

```csharp
public bool SamePlanetarySystem(TISpaceObjectState spaceObject)
```

```csharp
public float IntelOnCreation(TIFactionState detectingFaction, TIFactionState owningFaction)
```

```csharp
public float BaselineIntelOnAlienAsset(TIFactionState detectingFaction)
```

```csharp
public abstract List<TISpaceFleetState> GetNearbyIdleAlliedFleets(TIDateTime time = null)
```
