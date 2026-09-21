# Weapon

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/Weapon.cs`.*


## Class `Weapon`

```csharp
public abstract class Weapon : BaseComponent, IWeapon, IComponent
```

### Fields

| Name | Type |
|---|---|
| `position` | public Vector3 |
| `weaponSlot` | private int |
| `OnTarget` | private bool |
| `currentCooldownDuration_s` | private TimeSpan |
| `cooldownDuration_s` | private TimeSpan |
| `intraSalvoCooldownDuration_s` | private TimeSpan |
| `defensiveCooldown_s` | private TimeSpan |
| `gameTime` | protected GameTimeManager |
| `shotsFiredThisSalvo` | protected int |
| `targetedPosition` | public Vector3 |
| `defensiveFireCooldownModifier` | public const float |
| `FleetECMDefeatSharing` | private const bool |

### Properties

- `public CombatantController combatant`
- `public Transform combatantTransform`
- `public IList<IFireMode> fireModes`
- `public ShipWeaponVisController weaponVisualization`
- `public ShipWeaponVisController altWeaponVisualization`
- `public ModuleDataEntry weaponData`
- `public TIShipWeaponTemplate weaponTemplate`
- `public IFireMode currentFireMode`
- `private protected DateTime lastFiredAt`
- `public bool bollixed`
- `public IDamageable target`

### Methods

```csharp
public Weapon(CombatantShipController ship, ModuleDataEntry weaponData)
```

```csharp
public Weapon(CombatantShipController ship, ModuleDataEntry weaponData, ComponentMap map)
```

```csharp
public Weapon(CombatHabModuleController habModule, ModuleDataEntry weaponData, int slot)
```

```csharp
public Weapon(TIGameState surfaceState, ModuleDataEntry weaponData)
```

```csharp
private void SetFireModes(TIShipWeaponTemplate weaponTemplate, TISpaceShipTemplate shipTemplate, TIFactionState faction)
```

```csharp
public void OnShipSystemDamaged(ShipSystemDamageChange e)
```

```csharp
public void OnShipOfficerKilled(ShipOfficerKilled e)
```

```csharp
public static void GetAdjustedCooldownValues(CombatWeaponCarrierState combatantState, TIShipWeaponTemplate weaponTemplate, out float adjustedCooldownDuration_s, out float adjustedDefensiveCooldownDuration_s, out float adjustedIntraSalvoCooldownDuration_s)
```

```csharp
public void UpdateCooldownValues()
```

```csharp
public bool OnCooldown(DateTime currentTime)
```

```csharp
public bool InArc(Vector3 targetPosition, Vector3 targetVelocity, Vector3 targetAcceleration)
```

```csharp
public void EnterCooldown(bool downFired = false, bool cooldownByBollix = false, bool cooldownByDisable = false, int overrideDuration_s = 0)
```

```csharp
public ShipWeaponVisController SelectWeaponVisualization(Vector3 targetedPosition)
```

```csharp
public void SetTarget_Strategy(IDamageable newTarget, Vector3d position)
```

```csharp
public float TargetChance(CombatTargetableState target, TIShipWeaponTemplate weapon, float distance_km, int ECMDefeats)
```

```csharp
public bool AcquireTarget(DateTime currentTime)
```

```csharp
public virtual Vector3 GetPositionToTarget(IDamageable targetToCheck, out bool impossible)
```

```csharp
public bool TryFireCommon(DateTime currentTime)
```

```csharp
public abstract bool TryFire(DateTime currentTime)
```

```csharp
public int GetSTOShotCount(float shooterLongitude, TISpaceShipState target, float secondsSinceLastFiring)
```
