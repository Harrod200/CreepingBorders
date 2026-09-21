# TISpaceDefensesFacilityState

*Decompiled from `PavonisInteractive/TerraInvicta/TISpaceDefensesFacilityState.cs`.*


## Class `TISpaceDefensesFacilityState`

```csharp
public class TISpaceDefensesFacilityState : TIRegionSpaceFacilityState, CombatWeaponCarrierState
```

### Fields

| Name | Type |
|---|---|
| `descriptor` | public override string |
| `description` | public override string |
| `weaponTemplate` | public TILaserWeaponTemplate |
| `weaponTemplateName` | public string |
| `weapon` | private BeamWeapon |
| `lastTimeFired` | private TIDateTime |

### Methods

```csharp
public override float GetAIValuation()
```

```csharp
public override string GetDisplayName(TIFactionState faction)
```

```csharp
public override bool Extant()
```

```csharp
public override int GetSize()
```

```csharp
public override Sprite GetIcon(TIFactionState faction)
```

```csharp
public override string GetIconResourcePath(TIFactionState faction)
```

```csharp
public override string GetIllustrationPath(TIFactionState faction)
```

```csharp
public void SetLaserDefenseWeaponTemplate()
```

```csharp
public TIGameState GetTargetableState()
```

```csharp
public TIFactionState GetFaction()
```

```csharp
public bool WeaponIsOperable(ModuleDataEntry weaponData)
```

```csharp
public bool WeaponCanFire(ModuleDataEntry weaponData)
```

```csharp
public void FireWeapon(ModuleDataEntry module, TISpaceCombatProjectileState targetedProjectile = null)
```

```csharp
public void AddTargetedProjectile(TISpaceCombatProjectileState projectile)
```

```csharp
public float FireControlFunction()
```

```csharp
public TISpaceShipState ref_shipCarrier()
```

```csharp
public TIHabModuleState ref_habModuleCarrier()
```

```csharp
public bool isShip()
```

```csharp
public bool isHabModule()
```

```csharp
public float TargetingBonus(TIShipWeaponTemplate weapon, TIHabState alliedHab)
```

```csharp
public override void PostInitializationInit_4()
```

```csharp
public static bool STOShouldShootBack(TIRegionState shooter, TIGameState bombardmentTarget)
```

```csharp
public static TISpaceShipState SelectEarthSTOTarget(TIRegionState shooter, TIDateTime time, TISpaceFleetState targetFleet = null, bool lineOfSightEstablished = false)
```

```csharp
public void OnFireMissionOrder(TISpaceShipState target, TIDateTime currentTime)
```
