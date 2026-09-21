# ShipArmorFacingStruckInCombat

*Decompiled from `PavonisInteractive/TerraInvicta/ShipArmorFacingStruckInCombat.cs`.*


## Class `ShipArmorFacingStruckInCombat`

```csharp
public class ShipArmorFacingStruckInCombat : GameEvent
```

### Fields

| Name | Type |
|---|---|
| `ship` | public TISpaceShipState |
| `armorFacing` | public ArmorFacing |
| `weapon` | public TIShipWeaponTemplate |
| `rawDamage` | public float |
| `penetratedDamage` | public float |
| `radiationDamage` | public float |

### Methods

```csharp
public ShipArmorFacingStruckInCombat(TISpaceShipState ship, ArmorFacing armorFacing, TIShipWeaponTemplate weapon, float rawDamage, float penetratedDamage, float radiationDamage)
```
