# AssignOrbitalTransfer

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/AssignOrbitalTransfer.cs`.*


## Class `AssignOrbitalTransfer`

```csharp
public class AssignOrbitalTransfer : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `fleetID` | private GameStateID |
| `targetID` | private GameStateID |
| `transfer` | private readonly IOrbitalTransfer |

### Methods

```csharp
public AssignOrbitalTransfer(TISpaceFleetState fleet, IOrbitalTransfer transfer, TISpaceObjectState target)
```

```csharp
public override void Execute()
```

```csharp
private TIDateTime BinarySearchFindDateTime(IOrbitalTransfer transfer, TISpaceObjectState target, double targetDistance)
```

```csharp
private double DeltaDistance(IOrbitalTransfer transfer, TISpaceObjectState target, TIDateTime time)
```
