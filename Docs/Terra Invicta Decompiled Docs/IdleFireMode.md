# IdleFireMode

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/IdleFireMode.cs`.*


## Class `IdleFireMode`

```csharp
public class IdleFireMode : IFireMode
```

### Fields

| Name | Type |
|---|---|
| `mode` | public FireMode |
| `displayName` | public string |
| `description` | public string |
| `iconPath` | public string |

### Properties

- `public IWeapon weapon`

### Methods

```csharp
public IdleFireMode(IWeapon weapon)
```

```csharp
public IDamageable AcquireTarget(DateTime currentTime, out Vector3 targetLocation, out float distance_km)
```
