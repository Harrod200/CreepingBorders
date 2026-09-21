# LagrangePosition

*Decompiled from `LagrangePosition.cs`.*


## Class `LagrangePosition`

```csharp
public abstract class LagrangePosition : TINavigablePosition
```

### Fields

| Name | Type |
|---|---|
| `center` | protected CartesianState |
| `state` | protected CartesianState |
| `centerpos` | protected Vector3d |
| `relpos` | protected Vector3d |
| `pos` | protected Vector3d |
| `vel` | protected Vector3d |
| `M1` | protected double |
| `M2` | protected double |
| `gameTime` | private GameTimeManager |

### Methods

```csharp
public abstract LagrangeValue GetLagrangePointNumber()
```

```csharp
public virtual CartesianState GetCartesianState(TISpaceObjectState relatedObject, TIDateTime dateTime = null)
```

```csharp
protected LagrangePosition()
```

```csharp
public void GetStates(TISpaceObjectState relatedObject, TIDateTime dateTime = null)
```

```csharp
public double GetHillRadius()
```

```csharp
protected double HillRadius(double d, double m1, double m2)
```
