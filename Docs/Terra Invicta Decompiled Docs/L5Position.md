# L5Position

*Decompiled from `L5Position.cs`.*


## Class `L5Position`

```csharp
public class L5Position : LagrangePosition
```

### Methods

```csharp
public override LagrangeValue GetLagrangePointNumber()
```

```csharp
public override Vector3d GetPosition(Vector3d position, Vector3d barycenterPos, double m1, double m2)
```

```csharp
public override CartesianState GetCartesianState(TISpaceObjectState relatedObject, TIDateTime dateTime = null)
```

```csharp
public override Vector3d GetPosition(TISpaceObjectState relatedObject, TIDateTime dateTime = null, bool display = true)
```
