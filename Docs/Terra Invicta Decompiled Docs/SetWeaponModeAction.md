# SetWeaponModeAction

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/SetWeaponModeAction.cs`.*


## Class `SetWeaponModeAction`

```csharp
public class SetWeaponModeAction : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `shipID` | private GameStateID |
| `weapon` | private readonly Weapon |
| `mode` | private readonly FireMode |

### Methods

```csharp
public SetWeaponModeAction(TISpaceShipState ship, Weapon weapon, FireMode mode)
```

```csharp
public override void Execute()
```
