# ProjectileWeapon

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/ProjectileWeapon.cs`.*


## Class `ProjectileWeapon`

```csharp
public class ProjectileWeapon : Weapon
```

### Methods

```csharp
public ProjectileWeapon(CombatantShipController ship, ModuleDataEntry weaponData)
```

```csharp
public ProjectileWeapon(CombatHabModuleController habModule, ModuleDataEntry weaponData, int slot)
```

```csharp
public override Vector3 GetPositionToTarget(IDamageable targetToCheck, out bool impossible)
```

```csharp
public override bool TryFire(DateTime currentTime)
```
