# CombatantController

*Decompiled from `PavonisInteractive/TerraInvicta/CombatantController.cs`.*


## Class `CombatantController`

```csharp
public abstract class CombatantController : MonoBehaviour, IDamageable
```

### Fields

| Name | Type |
|---|---|
| `isDestroyed` | public bool |
| `position` | public Vector3 |
| `localPosition` | public Vector3 |
| `ref_projectile` | public TISpaceCombatProjectileState |
| `faction` | public TIFactionState |
| `ref_shipController` | public virtual CombatShipController |
| `ref_habModuleController` | public virtual CombatHabModuleController |
| `GetDamageableTransform` | public virtual Transform |
| `alliedCombatants` | public List<CombatantController> |
| `enemyCombatants` | public List<CombatantController> |
| `ECMDefeats` | public List<IDamageable> |

### Properties

- `public abstract List<Collider> hitColliders`
- `public abstract Vector3 velocityVector`
- `public abstract Vector3 velocityVector_kps`
- `public abstract IDamageableType damageableType`
- `public CombatWeaponCarrierState WeaponCarrierState`
- `public bool destructionTriggered`
- `public Transform combatantTransform`
- `public SpaceCombatManager combatMgr`
- `public abstract Vector3 accelerationVector`
- `public abstract Vector3 accelerationVector_kps`
- `public abstract CombatTargetableState combatTargetableState`
- `public bool isMissileSaturated`

### Methods

```csharp
public abstract SpaceCombatAssetUIController UIController()
```

```csharp
public abstract CombatTargetableState GetCombatantState()
```

```csharp
public abstract IDamageableType GetCombatantType()
```

```csharp
public abstract Vector3 positionAtTime(DateTime currentTime)
```

```csharp
public abstract float ApplyDamage(DamageSource source)
```

```csharp
public bool IsFriendlyTo(CombatantController combatant)
```

```csharp
public abstract float GetCrossSectionalArea_m2(float angle)
```
