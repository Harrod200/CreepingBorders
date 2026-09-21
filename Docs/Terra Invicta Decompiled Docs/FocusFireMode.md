# FocusFireMode

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/FocusFireMode.cs`.*


## Class `FocusFireMode`

```csharp
public class FocusFireMode : TIAttackFireMode, IFireMode
```

### Fields

| Name | Type |
|---|---|
| `displayName` | public virtual string |
| `description` | public virtual string |
| `iconPath` | public virtual string |
| `mode` | public virtual FireMode |

### Methods

```csharp
public FocusFireMode(IWeapon weapon)
```

```csharp
public IDamageable AcquireTarget(DateTime currentTime, out Vector3 targetPosition, out float distance_km)
```
