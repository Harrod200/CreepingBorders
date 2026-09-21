# Facing

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/Facing.cs`.*


## Struct `Facing`

```csharp
public struct Facing : IEquatable<Facing>
```

### Fields

| Name | Type |
|---|---|
| `minAngle` | private float |
| `maxAngle` | private float |

### Properties

- `public float facingAngle`
- `public ArmorFacing armorFacing`

### Methods

```csharp
public Facing(float facingAngle, ArmorFacing armorFacing)
```

```csharp
public Facing(float facingAngle, float bounds, ArmorFacing armorFacing)
```

```csharp
public Facing(float facingAngle, float minBound, float maxBound, ArmorFacing armorFacing)
```

```csharp
public bool Equals(Facing other)
```

```csharp
public override bool Equals(object obj)
```

```csharp
public override int GetHashCode()
```

```csharp
public override string ToString()
```

```csharp
public bool Contains(float angle)
```
