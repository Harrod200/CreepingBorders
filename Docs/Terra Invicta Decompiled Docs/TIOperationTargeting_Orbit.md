# TIOperationTargeting_Orbit

*Decompiled from `TIOperationTargeting_Orbit.cs`.*


## Class `TIOperationTargeting_Orbit`

```csharp
public abstract class TIOperationTargeting_Orbit : TIOperationTargeting
```

### Fields

| Name | Type |
|---|---|
| `barycenter` | private TISpaceObjectState |

### Methods

```csharp
public override List<Type> TargetedGameStates()
```

```csharp
public override void Init(IOperation operationType, TIGameState actorState, TIGameState defaultTarget)
```

```csharp
public void OrbitSelectedForTargeting(OrbitSelectedEvent e)
```

```csharp
public override void Activate(TIGameState forceTarget = null)
```

```csharp
public override void Shutdown()
```

```csharp
public override TIGameState GetDefaultTarget()
```
