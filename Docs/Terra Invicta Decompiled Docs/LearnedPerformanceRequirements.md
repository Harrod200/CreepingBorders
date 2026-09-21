# LearnedPerformanceRequirements

*Decompiled from `PavonisInteractive/TerraInvicta/LearnedPerformanceRequirements.cs`.*


## Class `LearnedPerformanceRequirements`

```csharp
public class LearnedPerformanceRequirements
```

### Fields

| Name | Type |
|---|---|
| `minimumDVByLocation_kps` | private Dictionary<TISpaceGameState, float> |
| `minimumChaseAcceleration_mps2` | private float |
| `minimumChaseDV_kps` | private float |

### Methods

```csharp
public void GiveChaseAccelerationLowerBound(float newChaseAccelerationLowerBound_mps2)
```

```csharp
public void GiveChaseDVLowerBound(float newChaseDVLowerBound_kps)
```

```csharp
public void ClearChaseRequirements()
```

```csharp
public bool MeetsRequirements(float dv_kps, float acceleration_mps2, TISpaceGameState location)
```

```csharp
public bool MeetsRequirements(TISpaceShipTemplate shipTemplate, TISpaceGameState location)
```

```csharp
public bool MeetsRequirements(TISpaceShipState ship, TISpaceGameState location = null)
```

```csharp
public bool MeetsRequirements(TISpaceFleetState fleet, TISpaceGameState location = null)
```

```csharp
private TISpaceGameState GetAdjustedLocation(TISpaceGameState location)
```

```csharp
public void RegisterDVRequirement(TISpaceGameState location, float requiredDV_kps)
```

```csharp
public float GetMinimumDV_kps(TISpaceGameState location)
```
