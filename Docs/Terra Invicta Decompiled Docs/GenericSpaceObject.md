# GenericSpaceObject

*Decompiled from `PavonisInteractive/TerraInvicta/GenericSpaceObject.cs`.*


## Class `GenericSpaceObject`

```csharp
public class GenericSpaceObject
```

### Fields

| Name | Type |
|---|---|
| `barycenter` | private TINaturalSpaceObjectState |
| `semiMajorAxis_m` | private double |

### Properties

- `public TIGameState trueState`

### Methods

```csharp
public void AssignData(TIGameState state)
```

```csharp
public TINaturalSpaceObjectState FindCommonBarycenter(GenericSpaceObject genericSpaceObject)
```

```csharp
public double GetRelevantSemimajorAxis_m(TISpaceObjectState testBarycenter)
```

```csharp
public double GetRelevantEccentricity(TISpaceObjectState testBarycenter)
```

```csharp
public double GetRelevantInclination_Rad(TISpaceObjectState testBarycenter)
```

```csharp
public double GetRelevantArgPeriapsis_Rad(TISpaceObjectState testBarycenter)
```

```csharp
public double GetRelevantMeanAnomaly_Rad(TISpaceObjectState testBarycenter)
```

```csharp
public double GetRelevantOrbitalVelocity_mps(TISpaceObjectState testBarycenter)
```
