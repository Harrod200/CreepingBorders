# MissileController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/MissileController.cs`.*


## Class `MissileController`

```csharp
public class MissileController : ProjectileController
```

### Fields

| Name | Type |
|---|---|
| `damageableType` | public override IDamageableType |
| `modScale` | private float |
| `maxDisplaySize` | private float |
| `isMissile` | public override bool |
| `missileTemplate` | protected TIMissileTemplate |
| `ignitionDelay_s` | private const float |
| `DV_cheat` | private const float |
| `missileRenderer` | public Renderer |
| `maxRunTime_s` | private float |
| `removedFromLiveProjectiles` | private bool |
| `targetCombatant` | private CombatantController |
| `targetProjectile` | private ProjectileController |
| `prevTargetPosition` | private Vector3 |
| `trackingDisplayObject` | public GameObject |
| `trackingDisplayRenderer` | public SpriteRenderer |
| `trackingDisplayEnvelope` | private float |
| `minDisplaySize` | private float |
| `mainCamT` | private Transform |
| `trackingDisplayTransform` | public Transform |
| `ProjectileDamageSource` | public class MissileDamage : |
| `DamageSource` | public class BurstDamage : |

### Properties

- `public IDamageable target`

### Methods

```csharp
public new void Awake()
```

```csharp
private void FindMissingReferences()
```

```csharp
public void UpdateTrackingDisplay()
```

```csharp
public override bool ThreateningEnemyCombatant(List<CombatantController> combatantList)
```

```csharp
public override void Fire(Vector3 originPosition, Vector3 targetPosition, IDamageable target)
```

```csharp
public void SetNewTargetData(IDamageable newTarget)
```

```csharp
public IDamageable Retarget()
```

```csharp
public override float ApplyDamage(DamageSource source)
```

```csharp
public float GetEstimatedDamage_Points()
```

```csharp
private bool HasHitTarget()
```

```csharp
public void HitByShooter(RaycastHit hit)
```

```csharp
private bool IsAnEnemyWithinAOE(Vector3 pointOfImpact)
```

```csharp
private void DoExplosionAOEDamage(IDamageable alreadyHitDamageable, Vector3 pointOfImpact)
```

```csharp
private void CheckIfHabCoreIsCaughtInNukeBlast(Vector3 pointOfImpact)
```

```csharp
public override void UpdateController()
```

```csharp
protected override void OnPause()
```

```csharp
protected override void OnUnpause()
```

```csharp
private void MissileImpactVFX(Vector3 pointOfImpact, Vector3 normalOfPointOfImpact)
```

```csharp
public override void Destruct(bool isAlreadyRemovedFromLiveProjectiles = false)
```

```csharp
public void OnDrawGizmos()
```

```csharp
public MissileDamage(Vector3 inboundVelocityVector_kps, Vector3 hitPosition, CombatWeaponCarrierState attacker, IDamageable target, TIMissileTemplate missileTemplate, TIFactionState launchingFaction, float warheadMass_kg)
```

```csharp
public BurstDamage(Vector3 origin, Vector3 hitPosition, CombatWeaponCarrierState attacker, IDamageable target, TIMissileTemplate missileTemplate, TIFactionState launchingFaction, float damageValue)
```
