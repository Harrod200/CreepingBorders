# SimulatedCombat

*Decompiled from `PavonisInteractive/TerraInvicta/SimulatedCombat.cs`.*


## Class `SimulatedCombat`

```csharp
public class SimulatedCombat
```

### Fields

| Name | Type |
|---|---|
| `AllShips` | public IEnumerable<SimulatedCombat.SimulatedShip> |
| `CombatantsA` | public IEnumerable<SimulatedCombat.SimulatedCombatant> |
| `CombatantsB` | public IEnumerable<SimulatedCombat.SimulatedCombatant> |
| `AllCombatants` | public IEnumerable<SimulatedCombat.SimulatedCombatant> |
| `Factions` | public IEnumerable<TIFactionState> |
| `DeadSimulatedOfficers` | public Dictionary<TISpaceShipState, List<TIOfficerState>> |
| `SimulatedOfficerDeathsRecord` | public Dictionary<TIFactionState, List<string>> |
| `ShipsA` | public HashSet<SimulatedCombat.SimulatedShip> |
| `ShipsB` | public HashSet<SimulatedCombat.SimulatedShip> |
| `Hab` | public TIHabState |
| `CombatHabModules` | public HashSet<SimulatedCombat.SimulatedCombatHabModule> |
| `HabSupportsA` | public bool |
| `Formations` | public List<SimulatedCombat.SimulatedFormation> |
| `MaxDuration_s` | private float |
| `ElapsedTime_s` | public float |
| `SimulatedAttack` | public class |
| `Damage` | public Damage |
| `IsInstant` | public bool |
| `Acceleration_mps2` | public float |
| `DeltaVelocity_kps` | public float |
| `DistanceToTarget_km` | public float |
| `Attacker` | public SimulatedCombat.SimulatedCombatant |
| `Target` | public SimulatedCombat.SimulatedCombatant |
| `Weapon` | public SimulatedCombat.SimulatedWeapon |
| `DamageSource` | public DamageSource |
| `SpawnTime` | public float |
| `SpawnDistance_km` | public float |
| `SpawnVelocity_kps` | public float |
| `SimulatedWeapon` | public abstract class |
| `UsesAmmo` | public bool |
| `IsDefending` | public bool |
| `IsAttacking` | public bool |
| `Frequency` | public float |
| `IsOnCooldown` | public bool |
| `MuzzleVelocity_kps` | public float |
| `ImpactVelocity_kps` | public float |
| `Ammo` | public override int |
| `set` | protected |
| `IsDamaged` | public override bool |
| `Ship` | public SimulatedCombat.SimulatedShip |
| `Ammo` | public override int |
| `set` | protected |
| `IsDamaged` | public override bool |
| `SimulatedFormation` | public class |
| `Acceleration` | public float |
| `Combatants` | public HashSet<SimulatedCombat.SimulatedCombatant> |
| `formationStartingDistances` | private Dictionary<SimulatedCombat.SimulatedFormation, float> |
| `cachedFormationDistances` | private Dictionary<SimulatedCombat.SimulatedFormation, float> |
| `clearCacheMoment` | private float |
| `AssumedStartingRelativeVelocity_kps` | public const float |
| `CombatWeaponCarrierState` | public abstract class SimulatedCombatant : IDamageable, |
| `Formation` | public SimulatedCombat.SimulatedFormation |
| `AlliedHab` | public TIHabState |
| `ExpectedAcceleration_mps2` | public float |
| `IsMobile` | public bool |
| `Destroyer` | public SimulatedCombat.SimulatedCombatant |
| `position` | public Vector3 |
| `velocityVector` | public Vector3 |
| `velocityVector_kps` | public Vector3 |
| `accelerationVector` | public Vector3 |
| `accelerationVector_kps` | public Vector3 |
| `hitColliders` | public List<Collider> |
| `combatTargetableState` | public CombatTargetableState |
| `ref_projectile` | public TISpaceCombatProjectileState |
| `damageableTransform` | public Transform |
| `transform` | public Transform |
| `formation` | private SimulatedCombat.SimulatedFormation |
| `alliedHab` | private TIHabState |
| `alliedHabWasSet` | private bool |
| `OriginalGameState` | public override TIGameState |
| `damageableType` | public override IDamageableType |
| `Acceleration_mps2` | public override float |
| `Function` | public override float |
| `isDestroyed` | public override bool |
| `Weapons` | public override IEnumerable<SimulatedCombat.SimulatedWeapon> |
| `ExpectedCombatRange_km` | public override float |
| `weapons` | private List<SimulatedCombat.SimulatedHabWeapon> |
| `faction` | private TIFactionState |
| `moduleTemplate` | private TIHabModuleTemplate |
| `armorTemplate` | private TIShipArmorTemplate |
| `hitPoints` | private float |
| `remainingHitPoints` | private float |
| `remainingArmor` | private float |
| `irradiatedMultiplier` | private float |
| `OriginalGameState` | public override TIGameState |
| `damageableType` | public override IDamageableType |
| `Acceleration_mps2` | public override float |
| `Function` | public override float |
| `isDestroyed` | public override bool |
| `DeadSimulatedOfficers` | public IEnumerable<TIOfficerState> |
| `Weapons` | public override IEnumerable<SimulatedCombat.SimulatedWeapon> |
| `ExpectedCombatRange_km` | public override float |
| `dummyHull` | private Hull |
| `weapons` | private List<SimulatedCombat.SimulatedShipWeapon> |
| `CopyShip` | public TISpaceShipState |
| `OriginalShip` | public TISpaceShipState |
| `SimulatedOfficersToRealOfficers` | public Dictionary<TIOfficerState, TIOfficerState> |

### Properties

- `public SimulatedCombat.SimulatedCombatant Combatant`
- `public TIShipWeaponTemplate Template`
- `public FireMode FireMode`
- `public abstract int Ammo`
- `public abstract bool IsDamaged`
- `public float AverageCooldown`
- `public float CooldownMoment`
- `public ModuleDataEntry Module`
- `public SimulatedCombat Combat`
- `public SimulatedCombat Combat`
- `public abstract TIGameState OriginalGameState`
- `public abstract float Acceleration_mps2`
- `public abstract float Function`
- `public abstract bool isDestroyed`
- `public SimulatedCombat.SimulatedWeapon DestroyerWeapon`
- `public abstract IEnumerable<SimulatedCombat.SimulatedWeapon> Weapons`
- `public abstract float ExpectedCombatRange_km`
- `public abstract IDamageableType damageableType`
- `public TIHabModuleState Module`

### Methods

```csharp
public SimulatedCombat(IEnumerable<TISpaceShipState> shipsA, IEnumerable<TISpaceShipState> shipsB, float maxDuration_s, TIHabState hab = null)
```

```csharp
public SimulatedCombat(IEnumerable<TISpaceShipTemplate> shipsA, IEnumerable<TISpaceShipTemplate> shipsB, float maxDuration_s)
```

```csharp
private void SetupFormationDistances(SimulatedCombat.SimulatedFormation shipsAFormation, SimulatedCombat.SimulatedFormation shipsBFormation, SimulatedCombat.SimulatedFormation habFormation = null)
```

```csharp
private float GetLargestOffensiveRange_km()
```

```csharp
public CombatRecord GetCombatRecord(CombatRecord prologue = default(CombatRecord))
```

```csharp
public static DamageSource GetDamageSource(TIFactionState attackerFaction, CombatWeaponCarrierState attacker, TIShipWeaponTemplate weaponTemplate, IDamageable target, Vector3 hitPosition, ArmorFacing armorFacingHit, float distance_km, float finalVelocity_kps)
```

```csharp
public static SimulatedCombat Simulate(TISpaceCombatState combat, float maxDuration_s, Action<SimulatedCombat> Callback = null)
```

```csharp
public IEnumerator Simulate(Action<SimulatedCombat> Callback = null)
```

```csharp
private static float GetDistanceTraveled_m(float startingVelocity_mps, float acceleration_mps2, float time_s)
```

```csharp
private static float GetDistance_m(float startingDistance_m, float startingVelocity_mps, float accelerationA_mps2, float deltaVelocityA_mps, float accelerationB_mps2, float deltaVelocityB_mps, float time_s)
```

```csharp
private static float GetDistance_km(float startingDistance_km, float startingVelocity_kps, float accelerationA_mps2, float deltaVelocityA_kps, float accelerationB_mps2, float deltaVelocityB_kps, float time_s)
```

```csharp
public SimulatedAttack(SimulatedCombat.SimulatedCombatant attacker, SimulatedCombat.SimulatedCombatant target, SimulatedCombat.SimulatedWeapon weapon)
```

```csharp
public float GetCurrentVelocity_kps(float currentTime)
```

```csharp
public float GetCurrentVelocity_mps(float currentTime)
```

```csharp
public float GetDistanceFromEnemyCombatant(SimulatedCombat.SimulatedCombatant enemyCombatant)
```

```csharp
public float GetTimeRequiredToTravelGivenDistance_s(float distance_km)
```

```csharp
public float GetChanceToHit()
```

```csharp
private ArmorFacing GetArmorFacingHit()
```

```csharp
private DamageSource GetDamageSource()
```

```csharp
public override string ToString()
```

```csharp
public SimulatedWeapon(SimulatedCombat.SimulatedCombatant combatant, TIShipWeaponTemplate template, FireMode fireMode)
```

```csharp
public virtual bool CanFire()
```

```csharp
public virtual bool TryFire(SimulatedCombat.SimulatedCombatant target, out SimulatedCombat.SimulatedAttack attack)
```

```csharp
public SimulatedCombat.SimulatedAttack Fire(SimulatedCombat.SimulatedCombatant target = null)
```

```csharp
protected virtual float ComputeAverageCooldown()
```

```csharp
public bool IsInRange(SimulatedCombat.SimulatedCombatant enemyCombatant)
```

```csharp
public SimulatedHabWeapon(SimulatedCombat.SimulatedCombatant combatant, TIShipWeaponTemplate template, FireMode fireMode)
```

```csharp
public SimulatedShipWeapon(SimulatedCombat.SimulatedShip ship, ModuleDataEntry module, FireMode fireMode)
```

```csharp
public override bool CanFire()
```

```csharp
public override bool TryFire(SimulatedCombat.SimulatedCombatant target, out SimulatedCombat.SimulatedAttack attack)
```

```csharp
protected override float ComputeAverageCooldown()
```

```csharp
public SimulatedFormation(SimulatedCombat combat, IEnumerable<SimulatedCombat.SimulatedCombatant> combatants)
```

```csharp
public void AddStartingDistance(SimulatedCombat.SimulatedFormation otherFormation, float startingDistance)
```

```csharp
public float GetDistance_km(SimulatedCombat.SimulatedFormation otherFormation)
```

```csharp
public bool IsAlly(SimulatedCombat.SimulatedFormation otherFormation)
```

```csharp
public bool IsEnemy(SimulatedCombat.SimulatedFormation otherFormation)
```

```csharp
public abstract TIFactionState GetFaction()
```

```csharp
public SimulatedCombatant(SimulatedCombat combat)
```

```csharp
public SimulatedCombatant()
```

```csharp
public bool IsAlly(SimulatedCombat.SimulatedCombatant otherCombatant)
```

```csharp
public bool IsEnemy(SimulatedCombat.SimulatedCombatant otherCombatant)
```

```csharp
public abstract float GetChanceToEvade(SimulatedCombat.SimulatedAttack attack)
```

```csharp
public abstract float GetECMValue()
```

```csharp
public float GetTargetingBonus(SimulatedCombat.SimulatedWeapon weapon)
```

```csharp
public float GetDistance_km(SimulatedCombat.SimulatedCombatant otherCombatant)
```

```csharp
public float GetClosingVelocity(SimulatedCombat.SimulatedCombatant enemyCombatant)
```

```csharp
public abstract float ApplyDamage(DamageSource source)
```

```csharp
public abstract float GetCrossSectionalArea_m2(float angle = 3.4028235E+38f)
```

```csharp
public virtual void SimulatePassageOfCombatTime(float time_s)
```

```csharp
public Vector3 positionAtTime(DateTime timeToProject)
```

```csharp
public bool isShip()
```

```csharp
public bool isHabModule()
```

```csharp
public abstract TISpaceShipState ref_shipCarrier()
```

```csharp
public abstract TIHabModuleState ref_habModuleCarrier()
```

```csharp
public abstract bool WeaponIsOperable(ModuleDataEntry module)
```

```csharp
public virtual bool WeaponCanFire(ModuleDataEntry module)
```

```csharp
public abstract float FireControlFunction()
```

```csharp
public abstract float TargetingBonus(TIShipWeaponTemplate weapon, TIHabState alliedHab)
```

```csharp
public TIGameState GetTargetableState()
```

```csharp
public void FireWeapon(ModuleDataEntry module, TISpaceCombatProjectileState targetedProjectile = null)
```

```csharp
public void AddTargetedProjectile(TISpaceCombatProjectileState projectile)
```

```csharp
public override string ToString()
```

```csharp
public override TISpaceShipState ref_shipCarrier()
```

```csharp
public override TIHabModuleState ref_habModuleCarrier()
```

```csharp
public SimulatedCombatHabModule(SimulatedCombat combat, TIHabModuleState combatHabModule)
```

```csharp
public SimulatedCombatHabModule(TIFactionState faction, TIHabModuleTemplate template, TIShipArmorTemplate armor, float hitPoints, float armorPoints, float irradiatedMultiplier, IEnumerable<TIShipWeaponTemplate> weaponTemplates)
```

```csharp
public override float ApplyDamage(DamageSource source)
```

```csharp
public override float GetCrossSectionalArea_m2(float angle = 3.4028235E+38f)
```

```csharp
public override float GetChanceToEvade(SimulatedCombat.SimulatedAttack attack)
```

```csharp
public override float GetECMValue()
```

```csharp
public override float TargetingBonus(TIShipWeaponTemplate weaponTemplate, TIHabState alliedHab)
```

```csharp
public override bool WeaponIsOperable(ModuleDataEntry module)
```

```csharp
public override float FireControlFunction()
```

```csharp
public override TIFactionState GetFaction()
```

```csharp
public override string ToString()
```

```csharp
public override TISpaceShipState ref_shipCarrier()
```

```csharp
public override TIHabModuleState ref_habModuleCarrier()
```

```csharp
public SimulatedShip(SimulatedCombat combat, TISpaceShipState ship)
```

```csharp
public SimulatedShip(SimulatedCombat combat, TISpaceShipTemplate shipTemplate)
```

```csharp
public override void SimulatePassageOfCombatTime(float time_s)
```

```csharp
public override TIFactionState GetFaction()
```

```csharp
public override float GetChanceToEvade(SimulatedCombat.SimulatedAttack attack)
```

```csharp
public override float GetECMValue()
```

```csharp
public override float TargetingBonus(TIShipWeaponTemplate weaponTemplate, TIHabState alliedHab)
```

```csharp
public ArmorFacing GetStruckFacing(DamageSource source, out float struckAngle)
```

```csharp
public ArmorFacing GetStruckFacing(DamageSource source)
```

```csharp
public override float ApplyDamage(DamageSource source)
```

```csharp
public override float GetCrossSectionalArea_m2(float angle = 3.4028235E+38f)
```

```csharp
public override bool WeaponIsOperable(ModuleDataEntry module)
```

```csharp
public override float FireControlFunction()
```
