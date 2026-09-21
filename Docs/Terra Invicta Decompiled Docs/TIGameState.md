# TIGameState

*Decompiled from `PavonisInteractive/TerraInvicta/TIGameState.cs`.*


## Class `TIGameState`

```csharp
public abstract class TIGameState : TIDataClass, IEquatable<TIGameState>, IComparable<TIGameState>
```

### Fields

| Name | Type |
|---|---|
| `operator` | public static bool |
| `deleted` | public bool |
| `isRegionState` | public virtual bool |
| `isNationState` | public virtual bool |
| `isFactionState` | public virtual bool |
| `isHabState` | public virtual bool |
| `isHabSiteState` | public virtual bool |
| `isOrbitState` | public virtual bool |
| `isSpaceFleetState` | public virtual bool |
| `isCouncilorState` | public virtual bool |
| `isArmyState` | public virtual bool |
| `isSpaceObjectState` | public virtual bool |
| `isSpaceGameState` | public virtual bool |
| `isNaturalSpaceObjectState` | public virtual bool |
| `isSpaceBodyState` | public virtual bool |
| `isLagrangePointState` | public virtual bool |
| `isSpaceAssetState` | public virtual bool |
| `isSpaceShipState` | public virtual bool |
| `isHabModuleState` | public virtual bool |
| `isControlPointState` | public virtual bool |
| `isRegionAlienEntity` | public virtual bool |
| `isRegionSpaceFacility` | public virtual bool |
| `isRegionAlienAsset` | public virtual bool |
| `isRegionUFOCrashdown` | public virtual bool |
| `isRegionXenoformingState` | public virtual bool |
| `isRegionLandedUFO` | public virtual bool |
| `isRegionAlienFacility` | public virtual bool |
| `isRegionAlienActivity` | public virtual bool |
| `isWarState` | public virtual bool |
| `isOrgState` | public virtual bool |
| `isOfficerState` | public virtual bool |
| `searchable` | public virtual Searchable |
| `ref_gameState` | public TIGameState |
| `ref_region` | public virtual TIRegionState |
| `ref_nation` | public virtual TINationState |
| `ref_faction` | public virtual TIFactionState |
| `ref_factions` | public virtual List<TIFactionState> |
| `ref_hab` | public virtual TIHabState |
| `ref_habSite` | public virtual TIHabSiteState |
| `ref_orbit` | public virtual TIOrbitState |
| `ref_fleet` | public virtual TISpaceFleetState |
| `ref_councilor` | public virtual TICouncilorState |
| `ref_army` | public virtual TIArmyState |
| `ref_spaceObject` | public virtual TISpaceObjectState |
| `ref_naturalSpaceObject` | public virtual TINaturalSpaceObjectState |
| `ref_lagrangePoint` | public virtual TILagrangePointState |
| `ref_spaceBody` | public virtual TISpaceBodyState |
| `ref_spaceAsset` | public virtual TISpaceAssetState |
| `ref_ship` | public virtual TISpaceShipState |
| `ref_habModule` | public virtual TIHabModuleState |
| `ref_controlPoint` | public virtual TIControlPoint |
| `ref_regionAlienEntity` | public virtual TIRegionAlienEntityState |
| `ref_regionSpaceFacility` | public virtual TIRegionSpaceFacilityState |
| `ref_regionAlienAsset` | public virtual TIRegionAlienAssetState |
| `ref_xenoforming` | public virtual TIRegionXenoformingState |
| `ref_UFOLanding` | public virtual TIRegionUFOLandingState |
| `ref_UFOCrashdown` | public virtual TIRegionUFOCrashdownState |
| `ref_alienFacility` | public virtual TIRegionAlienFacilityState |
| `ref_regionAlienActivity` | public virtual TIRegionAlienActivityState |
| `ref_org` | public virtual TIOrgState |
| `ref_officer` | public virtual TIOfficerState |
| `ref_system` | public TISpaceBodyState |
| `ref_war` | public virtual TIWarState |
| `hasMapObject` | public virtual bool |
| `hasEarthMapObject` | public virtual bool |
| `inSpace` | public virtual bool |
| `templateName` | public string |
| `displayName` | public string |
| `template` | private TIDataTemplate |

### Properties

- `public bool archived`
- `public GameStateID ID`
- `public bool exists`
- `public virtual int finderSortOverride`

### Methods

```csharp
public TIGameState()
```

```csharp
public TIGameState(GameStateID ID)
```

```csharp
public virtual bool Initialize()
```

```csharp
public void SetTemplate<T>(TIDataTemplate template) where T : TIDataTemplate
```

```csharp
public virtual T GetMyTemplate<T>() where T : TIDataTemplate
```

```csharp
public TIDataTemplate GetMyTemplate()
```

```csharp
public virtual void InitWithTemplate(TIDataTemplate template)
```

```csharp
public virtual string GetDisplayName(TIFactionState faction)
```

```csharp
public virtual void PostGameStateCreateInit_OnCreationOnly_1()
```

```csharp
public virtual void PostGlobalGameStateCreateInit_2()
```

```csharp
public virtual void PostCanvasManagerCreateInit_3()
```

```csharp
public virtual void PostInitializationInit_4()
```

```csharp
public virtual void PostAllStartUpInit_5()
```

```csharp
public virtual void PostVisualizerCreationInit_6()
```

```csharp
public virtual void PostVisualizerCreationInit_7()
```

```csharp
public virtual void PostEverythingSaveRepair_8()
```

```csharp
public override string ToString()
```

```csharp
public void DeArchiveState()
```

```csharp
public void ArchiveState(bool trigger = true)
```

```csharp
public virtual void SetDisplayName(string name)
```

```csharp
public bool Equals(TIGameState other)
```

```csharp
public int CompareTo(TIGameState other)
```

```csharp
public override bool Equals(object obj)
```

```csharp
public override int GetHashCode()
```

```csharp
public static bool Valid(TIGameState gameState)
```
