# FleetTransferPlan

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/FleetTransferPlan.cs`.*


## Struct `FleetTransferPlan`

```csharp
public struct FleetTransferPlan : IComponentData
```

### Fields

| Name | Type |
|---|---|
| `fleet` | public TISpaceFleetState |
| `StartPoint` | public Vector3d |
| `EndPoint` | public Vector3d |
| `TotalSeconds` | public double |
| `StartTime` | public DateTime |
| `EndTime` | public DateTime |
| `TransferSegments` | public List<Orbit> |
| `commonBarycenter` | public TINaturalSpaceObjectState |
| `planningOnly` | public bool |
