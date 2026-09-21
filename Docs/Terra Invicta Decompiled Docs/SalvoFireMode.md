# SalvoFireMode

*Decompiled from `PavonisInteractive/TerraInvicta/Ship/SalvoFireMode.cs`.*


## Class `SalvoFireMode`

```csharp
public class SalvoFireMode : FocusFireMode
```

### Fields

| Name | Type |
|---|---|
| `displayName` | public override string |
| `description` | public override string |
| `iconPath` | public override string |
| `mode` | public override FireMode |
| `_totalSalvo` | private int |
| `_shotsFired` | private int |

### Methods

```csharp
public SalvoFireMode(IWeapon weapon)
```

```csharp
private void OnWeaponModeChanged(ShipWeaponModeChanged e)
```

```csharp
private void OnWeaponFired(ShipWeaponFired e)
```
