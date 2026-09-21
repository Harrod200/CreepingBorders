# OffenseFireMode

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/OffenseFireMode.cs`.*


## Class `OffenseFireMode`

```csharp
public class OffenseFireMode : TIAttackFireMode, IFireMode
```

### Fields

| Name | Type |
|---|---|
| `mode` | public FireMode |
| `displayName` | public string |
| `description` | public string |
| `iconPath` | public string |

### Methods

```csharp
public OffenseFireMode(IWeapon weapon)
```

```csharp
public virtual IDamageable AcquireTarget(DateTime currentTime, out Vector3 targetPosition, out float distanceToTarget_km)
```
