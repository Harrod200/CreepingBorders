# ProjectileJobContainer

*Decompiled from `PavonisInteractive/TerraInvicta/Jobs/ProjectileJobContainer.cs`.*


## Class `ProjectileJobContainer`

```csharp
public class ProjectileJobContainer : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `_projectiles` | private List<Transform> |
| `_projectileData` | private List<ProjectileJobData> |
| `_projectileReferences` | private List<ProjectileReferences> |
| `_projectilesNativeArray` | private TransformAccessArray |
| `_projectileDataNativeArray` | private NativeArray<ProjectileJobData> |
| `_jobHandle` | private JobHandle |
| `_projectileMovementJob` | private ProjectilMovementJob |
| `_lastUpdateTime` | private TIDateTime |
| `gameTime` | private GameTimeManager |

### Methods

```csharp
public void AddProjectile(ProjectileController controller, Transform projectile, ProjectileJobData.MovementType type, TISpaceCombatProjectileState state, float dv, float maxAcceleration, float terminalVelocity, global::UnityEngine.Vector3 velocityVector, global::UnityEngine.Vector3 originPosition, IDamageable target, float manuverAngle_deg, float thrustRamp_s, float turnRamp_s, float turnRate_deg_s)
```

```csharp
public void RemoveProjectile(Transform projectile)
```

```csharp
public void SetProjectileTarget(Transform projectile, IDamageable target)
```

```csharp
public void ClearAllJobs()
```

```csharp
private void Awake()
```

```csharp
public void UpdateControllers()
```

```csharp
private void Update()
```

```csharp
private void LateUpdate()
```

```csharp
private void OnDestroy()
```
