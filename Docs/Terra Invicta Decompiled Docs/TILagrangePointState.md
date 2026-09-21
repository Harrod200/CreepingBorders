# TILagrangePointState

*Decompiled from `PavonisInteractive/TerraInvicta/TILagrangePointState.cs`.*


## Class `TILagrangePointState`

```csharp
public class TILagrangePointState : TINaturalSpaceObjectState
```

### Fields

| Name | Type |
|---|---|
| `template` | public new TINavigableTemplate |
| `objectType` | public override SpaceObjectType |
| `mass_kg` | public override double |
| `isLagrangePointState` | public override bool |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_lagrangePoint` | public override TILagrangePointState |
| `lagrangeValue` | public LagrangeValue |
| `population` | public override ulong |

### Properties

- `public TISpaceBodyState secondaryObject`

### Methods

```csharp
public override bool Colonized()
```

```csharp
public override bool Populous()
```

```csharp
public override void PostGameStateCreateInit_OnCreationOnly_1()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override Vector3d GetGlobalPositionAtTime(TIDateTime time)
```

```csharp
public override CartesianState ToGlobalCartesianStateAtTime(TIDateTime time)
```
