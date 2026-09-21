# OrbitPosition

*Decompiled from `OrbitPosition.cs`.*


## Class `OrbitPosition`

```csharp
public abstract class OrbitPosition : TINavigablePosition
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
| `gameTime` | private readonly GameTimeManager |

### Methods

```csharp
protected OrbitPosition()
```

```csharp
public override Vector3d GetPosition(TISpaceObjectState relatedObject, TIDateTime dateTime = null, bool display = true)
```
