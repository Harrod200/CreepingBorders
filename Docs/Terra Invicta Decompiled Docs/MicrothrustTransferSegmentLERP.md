# MicrothrustTransferSegmentLERP

*Decompiled from `PavonisInteractive/TerraInvicta/MicrothrustTransferSegmentLERP.cs`.*


## Class `MicrothrustTransferSegmentLERP`

```csharp
public class MicrothrustTransferSegmentLERP : IPatchedTransferSegment
```

### Fields

| Name | Type |
|---|---|
| `DV_mps` | public double |
| `anomalyDelta_Rad` | public double |
| `start` | public MicrothrustTransferLERPvalues |
| `end` | public MicrothrustTransferLERPvalues |
| `effectiveFleetAcceleration_mps2` | public double |
| `trueFleetAcceleration_mps2` | public double |

### Properties

- `public TIDateTime startTime`
- `public TIDateTime endTime`
- `public TINaturalSpaceObjectState barycenter`

### Methods

```csharp
public MicrothrustTransferSegmentLERP Copy()
```
