# TISpaceCombatState

*Decompiled from `PavonisInteractive/TerraInvicta/TISpaceCombatState.cs`.*


## Class `TISpaceCombatState`

```csharp
public class TISpaceCombatState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `CurrentActiveCombat` | public static TISpaceCombatState |
| `template` | public TISpaceCombatTemplate |
| `attacker` | public TISpaceFleetState |
| `attackingFaction` | public TIFactionState |
| `defendingFaction` | public TIFactionState |
| `winningFleet` | public TISpaceFleetState |
| `losingFleet` | public TISpaceFleetState |
| `ref_factions` | public override List<TIFactionState> |
| `ref_orbit` | public override TIOrbitState |
| `ref_hab` | public override TIHabState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_lagrangePoint` | public override TILagrangePointState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `inSpace` | public override bool |
| `HaveStancesBeenSelected` | public bool |
| `HaveBidsBeenSubmitted` | public bool |
| `fleeingFleet` | public TISpaceFleetState |
| `chasingFleet` | public TISpaceFleetState |
| `LowestPursuitDVBid_kps` | public float |
| `UseFixedPursuitDistance` | public static bool |
| `AutoresolveSecondsElapsed` | public float |
| `CombatInfo` | public CombatInfo |
| `PURSUIT_DISTANCE_m` | public const float |
| `PURSUIT_DISTANCE_RANGE_MULTIPLIER` | public const float |
| `combatStartDateTime` | public TIDateTime |
| `combatGlobalPosition` | public CartesianState |
| `nearbyNaturalSpaceObject` | public TINaturalSpaceObjectState |
| `fleets` | public TISpaceFleetState[] |
| `hab` | public TIHabState |
| `factions` | public TIFactionState[] |
| `assets` | public Dictionary<TIFactionState, List<TISpaceAssetState>> |
| `dummyFleetStates` | private List<TISpaceFleetState> |
| `active` | public bool |
| `initialFactionFleetStrengths` | public Dictionary<TIFactionState, float> |
| `initialHabStrength` | public float |
| `autoresolve` | public bool |
| `autoDestroyHab` | public bool |
| `shipWaypoints` | public Dictionary<TISpaceShipState, List<TISpaceCombatWaypointState>> |
| `votedEndCombat` | public Dictionary<TIFactionState, bool> |
| `votedEndCombatFirst` | public TIFactionState |
| `shipDestroyedTriggers` | public int |
| `shipDestructionsRecorded` | public int |
| `preservedFleetCompositions` | public Dictionary<TIFactionState, List<PreservedFleetRecord>> |
| `newFleetsCreatedByExtendedPursuit` | private List<TISpaceFleetState> |
| `allowNoAttackingFleetAtInitialization` | public bool |
| `maxDeltaVAvailableForCombat_kps` | public Dictionary<TISpaceShipState, float> |
| `STOFighterPlans` | public Dictionary<TIFactionState, Dictionary<TINationState, PlannedFighters>> |
| `combatLog` | public TIFactionState.CombatLog |
| `combatRecord` | public CombatRecord |
| `officerPromotions` | public Dictionary<TIFactionState, List<TIOfficerState>> |
| `officerDeathsRecord` | public Dictionary<TIFactionState, List<string>> |
| `deadOfficers` | public Dictionary<TISpaceShipState, List<TIOfficerState>> |
| `autoResolveStopwatch` | private Stopwatch |
| `autoresolving` | public bool |
| `mayRejectAutoresolve` | public bool |

### Properties

- `public Dictionary<TIFactionState, CombatStance> stances`
- `public Dictionary<TIFactionState, float> bids_kps`
- `public double precombatDuration_s`
- `public float combatBalance`
- `public bool initialized`
- `public bool fightersInitialized`
- `public TIFactionState winner`
- `public TIFactionState loser`
- `public bool draw`
- `public bool bothSidesDestroyed`
- `public bool oneSideDestroyed`
- `public Dictionary<TIFactionState, List<CombatStance>> allowedStances`
- `public bool requiresBidding`
- `public bool combatOccurs`
- `public TISpaceFleetState cachedFleet1`
- `public TISpaceFleetState cachedFleet2`
- `public TIHabState cachedHab`
- `public SimulatedCombat SimulatedCombat`

### Methods

```csharp
public TIFactionState primaryCombatFaction(TIFactionState faction)
```

```csharp
public TISpaceFleetState GetFleet(TIFactionState faction)
```

```csharp
public TIHabState AlliedHab(CombatWeaponCarrierState combatant)
```

```csharp
public TIHabState AlliedHab(CombatTargetableState combatant)
```

```csharp
public TIHabState AlliedHab(TIFactionState faction)
```

```csharp
public override bool Initialize()
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostInitializationInit_4()
```

```csharp
public bool STOFighterEligibleCombat(TIFactionState faction)
```

```csharp
public bool CanContributeSTOFightersToCombat(TIFactionState faction)
```

```csharp
public void AddFightersToCombat(TIFactionState faction, Dictionary<TINationState, PlannedFighters> fighterPlan)
```

```csharp
public void CreateFighterGameStates()
```

```csharp
public void CleanUpFighterGameStates()
```

```csharp
public void CacheCombatValues()
```

```csharp
public void SetRequiresBidding()
```

```csharp
public static bool OnTieBidDoesTheFirstFleetWin(TISpaceFleetState fleet0, TISpaceFleetState fleet1)
```

```csharp
public static bool OnTieBidDoesTheFirstFleetWin(float fleet0_accel_mps2, float fleet0_DV_mps, float fleet1_accel_mps2, float fleet1_DV_mps, float distancePursuitCovers_m)
```

```csharp
public static List<TISpaceShipState> PursuerSubsetThatCanCatchEnemyFleet(TISpaceFleetState pursuingFleet, TISpaceFleetState fleeingFleet, out bool envelopment)
```

```csharp
public void RemoveShipsFromBattleInExtendedPursuit(List<TISpaceShipState> shipsStayingInBattle, TISpaceFleetState battleFleet)
```

```csharp
private bool Approximately(float a, float b)
```

```csharp
public void SetRequiresCombat()
```

```csharp
public bool IncludesFaction(TIFactionState faction)
```

```csharp
public TISpaceFleetState FleetFor(TIFactionState faction)
```

```csharp
public TISpaceFleetState FleetAgainst(TIFactionState faction)
```

```csharp
public void CacheCombatAssets(TISpaceFleetState fleet1, TISpaceFleetState fleet2, TIHabState hab)
```

```csharp
public void StartCombatFromStrategyLayer()
```

```csharp
public bool InitializeCombat(TISpaceFleetState fleet1, TISpaceFleetState fleet2, TIHabState hab)
```

```csharp
public void UpdateMaxDeltaVForShip(TISpaceShipState ship)
```

```csharp
public static float GetPursuitDistance_m(TISpaceFleetState fleet1, TISpaceFleetState fleet2)
```

```csharp
public float MaxDVBidForPursuit_mps(TISpaceFleetState myFleet, TISpaceFleetState otherFleet)
```

```csharp
protected static float MaxDVBidForPursuit_mps(float fleet0_accel_mps2, float fleet0_DV_mps, float fleet1_accel_mps2, float fleet1_DV_mps, float distancePursuitCovers_m)
```

```csharp
public static float ExtendedDVBurn_kps(List<TISpaceShipState> extendingShips, TISpaceFleetState chasingFleet, TISpaceFleetState fleeingFleet, bool envelop)
```

```csharp
public static float DVBurnToEnvelop_kps(List<TISpaceShipState> envelopingShips, TISpaceFleetState chasingFleet, TISpaceFleetState fleeingFleet)
```

```csharp
public float PrecombatDVSpend_kps(TISpaceShipState ship, TISpaceFleetState chasingFleet, TISpaceFleetState fleeingFleet, TISpaceFleetState extendingFleet)
```

```csharp
public float PrecombatDVSpend_kps(TISpaceShipState ship, TISpaceFleetState chasingFleet, TISpaceFleetState fleeingFleet, List<TISpaceShipState> extendingFleet)
```

```csharp
public void HandlePrecombat()
```

```csharp
public void SetPrecombatDuration(double precombatDuration_s)
```

```csharp
public void GainCombatFactionHate(TISpaceAssetState victim, TIFactionState causingFaction, float value)
```

```csharp
public void RecordOfficerKilled(TIOfficerState officer)
```

```csharp
public void RecordShipDisengaged(TISpaceShipState disengagedShip)
```

```csharp
public void RecordShipDestroyed(TISpaceShipState destroyedShip, TIGameState killer, TIFactionState killerFaction, TIShipWeaponTemplate killerWeapon)
```

```csharp
public void RecordSurvivors()
```

```csharp
public void SetWinnerAndLoser()
```

```csharp
public void EndCombatForStrategyGame(double combatDuration_s)
```

```csharp
public void CancelCombat()
```

```csharp
public TIGameState GetLocation(TIFactionState faction)
```

```csharp
public void Autoresolve()
```

```csharp
public void ApplySimulatedCombat()
```
