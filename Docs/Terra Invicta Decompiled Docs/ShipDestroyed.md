# ShipDestroyed

*Decompiled from `PavonisInteractive/TerraInvicta/ShipDestroyed.cs`.*


## Class `ShipDestroyed`

```csharp
public class ShipDestroyed : GameEvent
```

### Fields

| Name | Type |
|---|---|
| `ship` | public TISpaceShipState |
| `killer` | public TIGameState |
| `killerWeapon` | public TIShipWeaponTemplate |
| `timeOfDeath` | public TIDateTime |

### Methods

```csharp
public ShipDestroyed(TISpaceShipState ship, TIGameState killer = null, TIShipWeaponTemplate killerWeapon = null, TIDateTime timeOfDeath = null)
```
