# TIHabModuleState

*Decompiled from `PavonisInteractive/TerraInvicta/TIHabModuleState.cs`.*


## Class `TIHabModuleState`

```csharp
public class TIHabModuleState : TIGameState, CombatWeaponCarrierState, CombatTargetableState
```

### Fields

| Name | Type |
|---|---|
| `isCombatModule` | public bool |
| `empty` | public bool |
| `underConstruction` | public bool |
| `hasModule` | public bool |
| `completed` | public bool |
| `okay` | public bool |
| `functional` | public bool |
| `active` | public bool |
| `present` | public bool |
| `mineLocation` | public bool |
| `sectorNum` | public int |
| `tier` | public int |
| `hab` | public TIHabState |
| `isHabModuleState` | public override bool |
| `ref_faction` | public override TIFactionState |
| `ref_hab` | public override TIHabState |
| `ref_habSite` | public override TIHabSiteState |
| `ref_orbit` | public override TIOrbitState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_spaceObject` | public override TISpaceObjectState |
| `ref_spaceAsset` | public override TISpaceAssetState |
| `ref_habModule` | public override TIHabModuleState |
| `hasMapObject` | public override bool |
| `inSpace` | public override bool |
| `crew` | public int |
| `HabModuleController` | public HabModuleController |
| `priorModuleTemplate` | public TIHabModuleTemplate |
| `pointDefenseWeaponTemplateName` | public string |
| `defenseWeaponTemplate` | public TIShipWeaponTemplate |
| `defenseWeaponTemplate_gun` | public TIShipWeaponTemplate |
| `defenseWeaponTemplate_plasma` | public TIShipWeaponTemplate |
| `PointDefenseWeaponTemplate` | public TIShipWeaponTemplate |
| `armorTemplate` | public TIShipArmorTemplate |
| `StationModuleArmorPoints` | public float |
| `controlPointCapacity` | public int |
| `buildingShip` | public bool |
| `currentShipConstructionQueueItem` | public ShipConstructionQueueItem |
| `baseSTOFireStr` | public string |
| `C0` | public bool |
| `N1` | public bool |
| `N2` | public bool |
| `E1` | public bool |
| `E2` | public bool |
| `W1` | public bool |
| `W2` | public bool |
| `S1` | public bool |
| `S2` | public bool |
| `buildCost` | public TIResourcesCost |
| `shipyardAllowPayFromEarth` | public bool |
| `lastTimeFiredAtShip` | private TIDateTime |
| `_priorModuleTemplate` | private TIHabModuleTemplate |
| `baseBuildDuration_days` | public float |
| `appliedBuildConstructionBonus` | public float |
| `startBuildDate` | public DateTime |
| `MAX_SOLAR_POWER_MULTIPLIER` | public const int |
| `COMET_SOLAR_POWER_MODIFIER` | public const float |
| `antiBombardmentWeapon` | private BeamWeapon |
| `destroyedTime` | public TIDateTime |

### Properties

- `public bool constructionCompleted`
- `public DateTime completionDate`
- `public bool decommissioning`
- `public DateTime decommissionDate`
- `public bool powered`
- `public int slot`
- `public TISectorState sector`
- `public bool destroyed`
- `public string defenseWeaponTemplateName`
- `public string defenseWeaponTemplateName_gun`
- `public string defenseWeaponTemplateName_plasma`
- `public float _spaceCombatValue`
- `public string priorModuleTemplateName`
- `public bool priorModuleCompleted`
- `public TIDateTime priorModuleCompletionDate`
- `public TIDateTime abilityCooldownEnds`
- `public TIHabModuleTemplate moduleTemplate`
- `public TIShipWeaponTemplate defenseWeapon`
- `public TIShipWeaponTemplate defenseWeapon_gun`
- `public TIShipWeaponTemplate defenseWeapon_plasma`
- `public float armorChipped`

### Methods

```csharp
public bool IsAlien()
```

```csharp
public bool isShip()
```

```csharp
public bool isHabModule()
```

```csharp
public TISpaceShipState ref_shipCarrier()
```

```csharp
public TIHabModuleState ref_habModuleCarrier()
```

```csharp
public bool CanUpgrade(TIFactionState faction)
```

```csharp
public int AtrocitiesToDestroy()
```

```csharp
public int AtrocitiesToLose()
```

```csharp
public void InitializeEmpty(TISectorState sector, int slot)
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostInitializationInit_4()
```

```csharp
public bool IsModuleValidForSlot(TIHabModuleTemplate moduleTemplate)
```

```csharp
private void SetModuleTemplate(string newModuleTemplateName)
```

```csharp
public void SetCompletedModule(string moduleTemplateName, bool startup = false)
```

```csharp
public void InitiateConstructModule(string moduleTemplateName, TIResourcesCost cost, double selectedCompletionTime_Days)
```

```csharp
public bool InTransit()
```

```csharp
public float PercentBuilt()
```

```csharp
public void CompleteConstruction(bool startup = false)
```

```csharp
public void ChangeFutureCompletionDate(float days)
```

```csharp
public bool PowerProvider()
```

```csharp
public bool PowerConsumer()
```

```csharp
public int PowerConsumed()
```

```csharp
public void SetSpaceCombatWeapons(TIFactionState faction)
```

```csharp
public float GetSpaceCombatRange()
```

```csharp
public float SpaceCombatValue()
```

```csharp
public float GetCrossSectionalArea_m2(float angle = -3.4028235E+38f)
```

```csharp
public string GetCombatSummary()
```

```csharp
public static string FullSummary(TIHabModuleState habModule, bool includeExtended)
```

```csharp
public float TargetingBonus(TIShipWeaponTemplate weapon, TIHabState alliedHab)
```

```csharp
public float ECMValue(TIFactionState attacker)
```

```csharp
public float ECMValue(TIFactionState attacker, TIHabState alliedHab)
```

```csharp
public float FleetTargetingBonus()
```

```csharp
public float FleetECMBonus()
```

```csharp
public float AntiBombardmentArmor(bool fullCalculation)
```

```csharp
public void ChipBombardmentArmor(float chipDamage)
```

```csharp
public void ResetBombadardmentArmor()
```

```csharp
public bool CanPower()
```

```csharp
public bool CanDepower()
```

```csharp
public bool MeetsPopulationRequirements()
```

```csharp
public void SetPowerStatus(bool powerSetting, bool skipFullResourceUpdate = false)
```

```csharp
public int ModulePower()
```

```csharp
public static int SolarPowerOutput(TIGameState location, float powerValue, TIFactionState faction, int tier, bool skipMirrors = false)
```

```csharp
public static int SolarMirrorBonus(TIGameState location, TIFactionState faction, int tier)
```

```csharp
public static float NaturalSolarPowerMultiplier(TIGameState location)
```

```csharp
public static float AtmosphereSolarModifier(TIGameState location)
```

```csharp
public static float SetLocationSolarPowerMultiplier(TIGameState location)
```

```csharp
public static int EscapeVelocityBasedPowerRequirement(TISpaceBodyState body, TIHabModuleTemplate moduleTemplate, TIFactionState faction)
```

```csharp
public static int EscapeVelocityBasedPowerRequirement(TIHabSiteState site, TIHabModuleTemplate moduleTemplate, TIFactionState faction)
```

```csharp
public static int EscapeVelocityBasedPowerRequirement(TIHabState hab, TIHabModuleTemplate moduleTemplate, TIFactionState faction)
```

```csharp
public void DestroyModule()
```

```csharp
public void SetPrimaryAbilityCooldown(int daysFromNow)
```

```csharp
public bool PrimaryAbilityOnCooldown()
```

```csharp
public bool CanDecommissionModule(bool immediateCancel)
```

```csharp
public TIResourcesCost DecommissionModuleCost()
```

```csharp
public TIResourcesCost DecomissionModuleResourceRefund()
```

```csharp
public void BeginDecomissionModule()
```

```csharp
public float DecommissionDuration_days()
```

```csharp
public void CancelDecommissionModule()
```

```csharp
public void CompleteDecommissionModule(bool clearPriorModule)
```

```csharp
public void InitializeForBombardment()
```

```csharp
public static TISpaceShipState SelectSTOTarget(TIGameState shooter, TIDateTime time, TISpaceFleetState targetFleet = null)
```

```csharp
public bool OnFireMissionOrder(TISpaceShipState target, TIDateTime time)
```

```csharp
public TIGameState GetTargetableState()
```

```csharp
public void AddTargetedProjectile(TISpaceCombatProjectileState projectile)
```

```csharp
public TIFactionState GetFaction()
```

```csharp
public float FireControlFunction()
```

```csharp
public bool WeaponIsOperable(ModuleDataEntry moduleData)
```

```csharp
public bool WeaponCanFire(ModuleDataEntry moduleData)
```

```csharp
public void FireWeapon(ModuleDataEntry module, TISpaceCombatProjectileState targetedProjectile)
```
