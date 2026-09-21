# TISpaceCombatProjectileState

*Decompiled from `PavonisInteractive/TerraInvicta/TISpaceCombatProjectileState.cs`.*


## Class `TISpaceCombatProjectileState`

```csharp
public class TISpaceCombatProjectileState : TIGameState, CombatTargetableState
```

### Fields

| Name | Type |
|---|---|
| `effectiveMass_kg` | public float |
| `ref_faction` | public override TIFactionState |
| `ref_fleet` | public override TISpaceFleetState |
| `thrustersEnabled` | public bool |
| `thrustAmount` | public float |
| `position` | public Vector3 |
| `originPosition` | public Vector3 |
| `expectedTargetPosition` | public Vector3 |
| `velocityVector_kps` | public Vector3 |
| `deltaV` | public float |
| `launchTime` | public TIDateTime |
| `origin` | public CombatWeaponCarrierState |
| `originWeapon` | public TIProjectileWeaponTemplate |
| `shootingFaction` | public TIFactionState |
| `shootingTeam` | public TIFactionState |
| `gameTime` | private GameTimeManager |
| `massDamage_kg` | public float |

### Properties

- `public List<CombatWeaponCarrierState> enemiesTargetingMe`

### Methods

```csharp
public TIGameState GetTargetableState()
```

```csharp
public bool IsAlien()
```

```csharp
public override bool Initialize()
```

```csharp
private void FireCommon(CombatWeaponCarrierState origin, TIDateTime launchTime, Vector3 originPosition, Vector3 originVelocity_kps, Vector3 expectedTargetPosition)
```

```csharp
public void Fire(CombatWeaponCarrierState origin, TIGunTypeWeaponTemplate originWeapon, TIDateTime launchTime, Vector3 originPosition, Vector3 expectedTargetPosition, Vector3 originVelocity_kps)
```

```csharp
public void Fire(CombatWeaponCarrierState origin, TIMissileTemplate originWeapon, TIDateTime launchTime, Vector3 originPosition, Vector3 expectedTargetPosition, Vector3 originVelocity_kps)
```

```csharp
public float ECMValue(TIFactionState attacker, TIHabState alliedHab = null)
```

```csharp
public Vector3 ProjectedLinearPositionAtTime_FromOrigin(DateTime dateTime)
```

```csharp
public Vector3 ProjectedLinearPositionAtTime_FromCurrent(DateTime dateTime)
```

```csharp
public void UpdatePosition(Vector3 position)
```

```csharp
public void EnemyTargetsMe(CombatWeaponCarrierState shooter)
```

```csharp
public void RemoveFromLiveProjectiles()
```

```csharp
public void OnDestroyed()
```

```csharp
public static float CrossSectionalArea_m2(TIShipWeaponTemplate weaponTemplate, float angle_degrees = -3.4028235E+38f)
```

```csharp
public float CrossSectionalArea_m2(float angle_degrees = -3.4028235E+38f)
```

```csharp
public bool WillHitSphere_Old(Vector3 targetPosition, Vector3 targetVelocity, IDamageableType targetType, CombatantController targetController)
```

```csharp
public bool WillHitSphere(Vector3 targetPosition, Vector3 targetVelocity, IDamageableType targetType, CombatantController targetController)
```

```csharp
public static Vector3 FirstOrderInterceptPosition(Vector3 shooterPosition, Vector3 shooterVelocity_u, float shotSpeed_u, Vector3 targetPosition, Vector3 targetVelocity_u, out bool impossible)
```

```csharp
private static double FirstOrderInterceptTime(double shotSpeed, Vector3 targetRelativePosition, Vector3 targetRelativeVelocity)
```

```csharp
private static bool SolveQuadratic(double a, double b, double c, out double t1, out double t2)
```

```csharp
public static Vector3 SecondOrderInterceptPosition(Vector3 shooterPosition, Vector3 shooterVelocity_u, float shotSpeed_u, Vector3 targetPosition, Vector3 targetVelocity_u, Vector3 targetAcceleration_u, float shootercooldown_s, out bool impossible)
```

```csharp
public static bool FirstOrderInterceptPosition(Vector3 chaserPosition, float chaserSpeed, Vector3 runnerPosition, Vector3 runnerVelocity, out Vector3 collisionPoint)
```
