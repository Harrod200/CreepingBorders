# ProjectileController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/ProjectileController.cs`.*


## Class `ProjectileController`

```csharp
public abstract class ProjectileController : MonoBehaviour, IDamageable
```

### Fields

| Name | Type |
|---|---|
| `damageableType` | public virtual IDamageableType |
| `combatTargetableState` | public CombatTargetableState |
| `accelerationVector` | public Vector3 |
| `accelerationVector_kps` | public Vector3 |
| `v3_accelerationVector_kps` | public Vector3 |
| `weaponTemplate` | protected TIProjectileWeaponTemplate |
| `warheadMass_kg` | public float |
| `ref_projectile` | public TISpaceCombatProjectileState |
| `velocityVector_kps` | public Vector3 |
| `position` | public Vector3 |
| `isDestroyed` | public bool |
| `isMissile` | public virtual bool |
| `_collisionMask` | protected LayerMask |
| `gameTime` | protected GameTimeManager |
| `projectileCollider` | public Collider |
| `projectileParticleSystem` | protected ParticleSystem |
| `projectileParticleTransform` | protected Transform |
| `projectileParticleDefaultScale` | protected Vector3 |
| `currentImpactPrefabResource` | protected string |
| `currentDestructionPrefabResource` | protected string |
| `currentImpactSoundResource` | protected string |
| `impactObject` | protected GameObject |
| `impactParticleSystem` | protected ParticleSystem |
| `eventInstance` | protected EventInstance |
| `destructionObject` | protected GameObject |
| `destructionParticleSystem` | protected ParticleSystem |
| `timeUntilDestroy` | protected float |
| `DestroyTime` | protected float |
| `_container` | protected ProjectileJobContainer |
| `raycastHitsArray` | protected RaycastHit[] |
| `originPosition` | protected Vector3 |
| `v3_accelerationVector` | public Vector3 |
| `CLEAR_LAUNCHER_DELAY_s` | protected const float |
| `isPaused` | public bool |

### Properties

- `public TISpaceCombatProjectileState projectileState`
- `public Transform projectileTransform`
- `public List<Collider> hitColliders`
- `public ShipWeaponVisController weaponController`
- `public bool clearedLauncher`
- `public bool hasHit`
- `public bool beenDestroyed`
- `public Vector3 velocityVector`

### Methods

```csharp
public float GetCrossSectionalArea_m2(float angle)
```

```csharp
public Vector3 positionAtTime(DateTime currentTime)
```

```csharp
public abstract void Fire(Vector3 originPosition, Vector3 targetPosition, IDamageable target = null)
```

```csharp
public virtual bool ThreateningEnemyCombatant(List<CombatantController> combatantList)
```

```csharp
public void Awake()
```

```csharp
private void Update()
```

```csharp
public abstract void UpdateController()
```

```csharp
protected abstract void OnPause()
```

```csharp
protected abstract void OnUnpause()
```

```csharp
public void Initialize(ProjectileJobContainer container, ShipWeaponVisController weaponController, TISpaceCombatProjectileState projectileState)
```

```csharp
private void SetImpactPrefab(TIProjectileWeaponTemplate weaponTemplate)
```

```csharp
private void SetDestructionPrefab(string resource)
```

```csharp
private void ReturnImpactVFXObject()
```

```csharp
private void ReturnDestructionVFXObject()
```

```csharp
private void OnDisable()
```

```csharp
private void OnDestroy()
```

```csharp
private void Destroy()
```

```csharp
public virtual float ApplyDamage(DamageSource source)
```

```csharp
public virtual void Destruct(bool isAlreadyRemovedFromLiveProjectiles = false)
```

```csharp
public void Impact(Vector3 position, Vector3 eulerAngles)
```

```csharp
protected RaycastHit FilterRaycastsForHits(List<RaycastHit> raycastHitsList, out IDamageable hitDamageable)
```
