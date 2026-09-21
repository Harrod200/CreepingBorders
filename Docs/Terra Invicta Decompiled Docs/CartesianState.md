# CartesianState

*Decompiled from `PavonisInteractive/TerraInvicta/CartesianState.cs`.*


## Struct `CartesianState`

```csharp
public struct CartesianState
```

### Fields

| Name | Type |
|---|---|
| `positionDisplay` | public Vector3d |
| `velocityDisplay` | public Vector3d |
| `xzy` | public CartesianState |
| `zero` | public static CartesianState |
| `position` | public Vector3d |
| `velocity` | public Vector3d |

### Methods

```csharp
public CartesianState(Vector3d position, Vector3d velocity)
```

```csharp
public CartesianState(CartesianState a)
```

```csharp
public CartesianState ChangeReferenceFrame(TINaturalSpaceObjectState oldBarycenter, TISpaceObjectState newBarycenter, TIDateTime time)
```

```csharp
public CartesianState ToGlobal(TISpaceObjectState oldBarycenter, TIDateTime time)
```

```csharp
public CartesianState ToLocal(TISpaceObjectState newBarycenter, TIDateTime time)
```

```csharp
public OrbitalElementsState ToOrbitalElementsState(double mu_barycenter, DateTime? dateTime = null)
```
