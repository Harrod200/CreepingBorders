# DefenseFireMode

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/DefenseFireMode.cs`.*


## Class `DefenseFireMode`

```csharp
public class DefenseFireMode : IFireMode
```

### Fields

| Name | Type |
|---|---|
| `mode` | public FireMode |
| `displayName` | public string |
| `description` | public string |
| `iconPath` | public string |
| `weaponAsset` | private Weapon |
| `weaponTemplate` | private TIShipWeaponTemplate |
| `effectiveRange_u` | private readonly float |
| `weaponClass` | private WeaponClass |
| `firingState` | private CombatWeaponCarrierState |
| `combatantTransform` | private Transform |
| `faction` | private TIFactionState |
| `saturationValue` | private int |
| `saturatedTargetableProjectiles` | private List<DefenseFireMode.TargetingData> |
| `SaturationValues` | private readonly Dictionary<WeaponClass, int> |
| `TargetingData` | private struct |
| `possibleTargetProjectile` | public ProjectileController |
| `scaledDistance` | public float |
| `candidateTargetPosition` | public Vector3 |
| `distance_km` | public float |

### Properties

- `public IWeapon weapon`

### Methods

```csharp
public DefenseFireMode(IWeapon weapon)
```

```csharp
public bool SufficientDamageToFire(float distance_km, float minDamage)
```

```csharp
public float GetExpectedDamage(float distance_km, IDamageable target)
```

```csharp
public IDamageable AcquireTarget(DateTime currentTime, out Vector3 targetPosition, out float distanceToTarget_km)
```

```csharp
public TargetingData(ProjectileController possibleTargetProjectile, float scaledDistance, Vector3 candidateTargetPosition, float distance_km)
```
