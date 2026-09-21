# GuardianFireMode

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/GuardianFireMode.cs`.*


## Class `GuardianFireMode`

```csharp
public class GuardianFireMode : IFireMode
```

### Fields

| Name | Type |
|---|---|
| `mode` | public FireMode |
| `displayName` | public string |
| `description` | public string |
| `iconPath` | public string |
| `weaponAsset` | private readonly Weapon |
| `weaponTemplate` | private readonly TIShipWeaponTemplate |
| `IsAI` | private bool |
| `cachedTarget` | private IDamageable |
| `cachedDistanceToTarget_km` | private float |
| `cachedTargetPosition` | private Vector3 |
| `offense` | private readonly OffenseFireMode |
| `defense` | private readonly DefenseFireMode |

### Properties

- `public IWeapon weapon`

### Methods

```csharp
public GuardianFireMode(IWeapon weapon, bool isAI)
```

```csharp
public void SetAIManagement(bool setting)
```

```csharp
public IDamageable AcquireTarget(DateTime currentTime, out Vector3 targetPosition, out float distanceToTarget_km)
```
