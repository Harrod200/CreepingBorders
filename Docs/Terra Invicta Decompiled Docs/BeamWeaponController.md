# BeamWeaponController

*Decompiled from `BeamWeaponController.cs`.*


## Class `BeamWeaponController`

```csharp
public class BeamWeaponController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `maxLength` | private float |
| `hasTarget` | private bool |
| `beamScaling` | public static float |
| `beamEffectController` | private BeamEffectController |
| `initialized` | private bool |
| `_collisionMask` | private LayerMask |
| `shooter` | private TIGameState |
| `target` | public IDamageable |
| `targetCombatant` | private CombatantController |
| `targetProjectile` | private ProjectileController |
| `strategyLayerTarget` | private TIGameState |
| `shotTime` | private TIDateTime |

### Methods

```csharp
public void Initialize(IDamageable target)
```

```csharp
public void Initialize(TIGameState shooter, TIGameState stratLayerTarget, TIDateTime time, int mask)
```

```csharp
public void OnEnable()
```

```csharp
public void OnDisable()
```

```csharp
private void LateUpdate()
```

```csharp
private void UpdateVisualization()
```

```csharp
public void DisableLaser()
```

```csharp
public void EnableLaser()
```
