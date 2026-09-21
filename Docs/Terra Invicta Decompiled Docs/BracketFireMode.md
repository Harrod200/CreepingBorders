# BracketFireMode

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/BracketFireMode.cs`.*


## Class `BracketFireMode`

```csharp
public class BracketFireMode : IFireMode
```

### Fields

| Name | Type |
|---|---|
| `mode` | public FireMode |
| `displayName` | public string |
| `description` | public string |
| `iconPath` | public string |
| `offense` | private readonly OffenseFireMode |
| `priorTarget` | private IDamageable |
| `shotCycler` | private int |

### Properties

- `public IWeapon weapon`

### Methods

```csharp
public BracketFireMode(IWeapon weapon)
```

```csharp
public IDamageable AcquireTarget(DateTime currentTime, out Vector3 targetPosition, out float distanceToTarget_km)
```
