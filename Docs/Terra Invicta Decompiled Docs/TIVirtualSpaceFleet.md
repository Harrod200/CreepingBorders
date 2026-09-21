# TIVirtualSpaceFleet

*Decompiled from `PavonisInteractive/TerraInvicta/TIVirtualFleetState/TIVirtualSpaceFleet.cs`.*


## Class `TIVirtualSpaceFleet`

```csharp
public class TIVirtualSpaceFleet : IMobileAsset, ITransferTarget
```

### Fields

| Name | Type |
|---|---|
| `ships` | public List<TISpaceShipState> |
| `epoch_DateTime` | public TIDateTime |
| `_orbit` | private OrbitalElementsState |
| `_barycenter` | private TINaturalSpaceObjectState |

### Properties

- `public TIOrbitState ref_orbit`
- `public float cruiseAcceleration_mps2`
- `public float currentDeltaV_mps`
- `public TIFactionState faction`
- `public FleetTrajectoryData fleetTrajectoryData`
- `public bool transferAssigned`

### Methods

```csharp
public TIVirtualSpaceFleet(TISpaceFleetState fleetToCopy)
```

```csharp
public TIVirtualSpaceFleet(IMobileAsset fleetToCopy, TIFactionState faction = null)
```

```csharp
public TIVirtualSpaceFleet(TISpaceAssetState assetToStartAt, float acceleration_mps2, float deltaV, TIFactionState faction = null)
```

```csharp
public TIVirtualSpaceFleet(TIOrbitState orbitToStartAt, float acceleration_mps2, float deltaV, TIFactionState faction, TIDateTime epoch = null, double meanAnomalyAtEpoch = 0.0)
```

```csharp
public double meanAnomaly_Rad(TIDateTime time)
```

```csharp
public double M0_rad()
```

```csharp
public double a_m()
```

```csharp
public double e()
```

```csharp
public double i_rad()
```

```csharp
public double L0_rad()
```

```csharp
public double t0_jy()
```

```csharp
public double μ()
```

```csharp
public double Ω_rad()
```

```csharp
public double ω_rad()
```

```csharp
public TINaturalSpaceObjectState barycenter()
```

```csharp
public TINaturalSpaceObjectState barycenterBarycenter()
```

```csharp
public TINaturalSpaceObjectState barycenterBarycenterBarycenter()
```

```csharp
public double common_a_m(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public double common_e(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public double common_i_rad(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public double common_L0_rad(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public double common_M0_rad(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public double common_M_rad(TINaturalSpaceObjectState commonBarycenter, TIDateTime time)
```

```csharp
public double common_period_days(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public Vector3d GetGlobalPositionAtTime(TIDateTime time)
```

```csharp
public void getOrbitalElementsState(TIDateTime time, out OrbitalElementsState orbitalElementsState, out TINaturalSpaceObjectState barycenter, out bool meanAnomalyIsGood)
```

```csharp
public Vector3d globalPositionValue(TISpaceFleetState forFleet, TIDateTime time)
```

```csharp
public TINaturalSpaceObjectState localBarycenter(TIDateTime time)
```

```csharp
public double period_days()
```

```csharp
public CartesianState relevantGlobalCartesianState(TINaturalSpaceObjectState commonBarycenter, TIDateTime time)
```

```csharp
public double relevant_escapeVelocity_mps(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public double relevant_orbit_m(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public TIGameState selfState()
```

```csharp
public void SetAccelerationPhaseStatus(bool inPhase, bool forceRotation = false, bool forceStop = false)
```

```csharp
public void SetDecelerationPhaseStatus(bool inPhase, bool forceRotation = false, bool forceStop = false)
```

```csharp
public CartesianState ToGlobalCartesianStateAtTime(TIDateTime time)
```

```csharp
public bool tryToGetLocalCartesianState(TIDateTime time, out CartesianState cartesianState, out TINaturalSpaceObjectState barycenter)
```

```csharp
public Vector3 visualizationPositionValue()
```

```csharp
public double common_Ω_rad(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public double common_ω_rad(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public double common_t0_jy(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public double common_μ(TINaturalSpaceObjectState commonBarycenter)
```

```csharp
public TINaturalSpaceObjectState FindCommonBarycenter(TIGameState secondSpaceObject)
```
