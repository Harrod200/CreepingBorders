# MissileWeapon

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/MissileWeapon.cs`.*


## Class `MissileWeapon`

```csharp
public class MissileWeapon : Weapon
```

### Fields

| Name | Type |
|---|---|
| `missileTemplate` | public TIMissileTemplate |

### Methods

```csharp
public MissileWeapon(CombatantShipController ship, ModuleDataEntry weaponData)
```

```csharp
public MissileWeapon(CombatHabModuleController habModule, ModuleDataEntry weaponData, int slot)
```

```csharp
public override Vector3 GetPositionToTarget(IDamageable targetToCheck, out bool impossible)
```

```csharp
public override bool TryFire(DateTime currentTime)
```
