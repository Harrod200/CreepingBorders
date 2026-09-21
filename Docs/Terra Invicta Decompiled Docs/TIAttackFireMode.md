# TIAttackFireMode

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/TIAttackFireMode.cs`.*


## Class `TIAttackFireMode`

```csharp
public abstract class TIAttackFireMode
```

### Fields

| Name | Type |
|---|---|
| `weaponTemplate` | protected TIShipWeaponTemplate |
| `weaponClass` | protected WeaponClass |
| `combatant` | protected CombatantController |
| `combatantTransform` | protected Transform |
| `weaponAsset` | protected Weapon |
| `ship` | protected CombatShipController |
| `scaledTargetingRange` | protected float |

### Properties

- `public IWeapon weapon`

### Methods

```csharp
public float GetExpectedDamage(float distance_km, IDamageable target)
```

```csharp
public float GetEfficientWeaponRange_km()
```

```csharp
protected float GetMinimumExpectedDamageToFire(CombatantController target)
```
