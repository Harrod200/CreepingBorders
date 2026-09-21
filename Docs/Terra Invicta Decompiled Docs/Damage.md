# Damage

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/Damage.cs`.*


## Struct `Damage`

```csharp
public struct Damage : IEquatable<Damage>
```

### Fields

| Name | Type |
|---|---|
| `operator` | public static bool |
| `randomizer` | public const float |
| `None` | public static readonly Damage |

### Properties

- `public TIFactionState applyingFaction`
- `public TIShipWeaponTemplate weapon`
- `public float range_km`
- `public DamageType type`
- `public float amount`
- `public float chippingAmount`
- `public int shreddingAmount`

### Methods

```csharp
private float RandomizedDamageAmount(float damageValue)
```

```csharp
public Damage(TIShipWeaponTemplate weapon, float range_km, DamageType type, float amount, float chippingAmount, int shreddingAmount, TIFactionState applyingFaction)
```

```csharp
public override bool Equals(object other)
```

```csharp
public override int GetHashCode()
```

```csharp
public override string ToString()
```

```csharp
public bool Equals(Damage other)
```

```csharp
public static bool operator <(Damage lhs, float rhs)
```

```csharp
public static bool operator >(Damage lhs, float rhs)
```
