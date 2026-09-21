# BeamWeapon

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/BeamWeapon.cs`.*


## Class `BeamWeapon`

```csharp
public class BeamWeapon : Weapon
```

### Fields

| Name | Type |
|---|---|
| `beamWeapon` | public TIBeamWeaponTemplate |
| `DamageSource` | public class Beam : |

### Methods

```csharp
public BeamWeapon(CombatantShipController ship, ModuleDataEntry weaponData)
```

```csharp
public BeamWeapon(CombatHabModuleController module, ModuleDataEntry weaponData, int slot)
```

```csharp
public BeamWeapon(TIGameState dummy, ModuleDataEntry weaponData)
```

```csharp
public override bool TryFire(DateTime currentTime)
```

```csharp
public BeamWeapon.Beam GetDamageSource(CombatWeaponCarrierState attacker, float distance_km)
```

```csharp
public Beam(IDamageable target, Vector3 start, Vector3 end, TIBeamWeaponTemplate weaponTemplate, CombatWeaponCarrierState attacker)
```

```csharp
public Beam(IDamageable target, float distance_km, Vector3 hitPosition_, TIBeamWeaponTemplate weaponTemplate, CombatWeaponCarrierState attacker)
```

```csharp
public Beam(IDamageable target, float distance_km, TIBeamWeaponTemplate weaponTemplate, CombatWeaponCarrierState attacker)
```
