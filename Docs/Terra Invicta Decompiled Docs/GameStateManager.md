# GameStateManager

*Decompiled from `PavonisInteractive/TerraInvicta/GameStateManager.cs`.*


## Class `GameStateManager`

```csharp
public static class GameStateManager
```

### Fields

| Name | Type |
|---|---|
| `HasGamestates` | public static bool |
| `currentID` | private static GameStateID |
| `gamestates` | private static Dictionary<Type, Dictionary<GameStateID, TIGameState>> |
| `templateCache` | private static readonly Dictionary<Type, Dictionary<string, TIGameState>> |
| `nations` | private static TINationState[] |
| `regions` | private static TIRegionState[] |
| `factions` | private static TIFactionState[] |
| `humanFactions` | private static TIFactionState[] |
| `spaceBodies` | private static TISpaceBodyState[] |
| `lagrangePoints` | private static TILagrangePointState[] |
| `naturalSpaceObjects` | private static TINaturalSpaceObjectState[] |
| `orbits` | private static TIOrbitState[] |
| `regionAlienEntities` | private static TIRegionAlienEntityState[] |
| `regionLookup` | private static Dictionary<string, TIRegionState> |
| `nationLookup` | private static Dictionary<string, TINationState> |
| `mapRegionLookup` | private static Dictionary<string, TIRegionState> |
| `supraRegionMembers` | private static Dictionary<SupraRegion, List<TIRegionState>> |
| `globalResearch` | private static TIGlobalResearchState |
| `globalValues` | private static TIGlobalValuesState |
| `notificationQueue` | private static TINotificationQueueState |
| `promptQueue` | private static TIPromptQueueState |
| `time` | private static TITimeState |
| `effects` | private static TIEffectsState |
| `missionPhase` | private static TIMissionPhaseState |
| `metaData` | private static TIMetadataState |
| `alienNation` | private static TINationState |
| `solState` | private static TISpaceBodyState |
| `mercury` | private static TISpaceBodyState |
| `venus` | private static TISpaceBodyState |
| `earth` | private static TISpaceBodyState |
| `luna` | private static TISpaceBodyState |
| `mars` | private static TISpaceBodyState |
| `ceres` | private static TISpaceBodyState |
| `jupiter` | private static TISpaceBodyState |
| `saturn` | private static TISpaceBodyState |
| `uranus` | private static TISpaceBodyState |
| `neptune` | private static TISpaceBodyState |
| `planets` | private static List<TISpaceBodyState> |
| `sunOrbitingLagrangePoints` | private static List<TILagrangePointState> |
| `innerSystemAsteroids` | private static List<TISpaceBodyState> |
| `innerAsteroidBelt` | private static List<TISpaceBodyState> |
| `midAsteroidBelt` | private static List<TISpaceBodyState> |
| `outerAsteroidBelt` | private static List<TISpaceBodyState> |
| `centaurs` | private static List<TISpaceBodyState> |
| `kuiperBeltObjects` | private static List<TISpaceBodyState> |
| `lowEarthOrbitStates` | private static List<TIOrbitState> |
| `nearEarthOrbitStates` | private static List<TIOrbitState> |
| `activeIdeologies` | private static List<TIFactionIdeologyTemplate> |
| `activeHumanIdeologies` | private static List<TIFactionIdeologyTemplate> |
| `undecidedIdeology` | private static TIFactionIdeologyTemplate |
| `alienFaction` | private static TIFactionState |
| `alienProxyFaction` | private static TIFactionState |
| `alienAppeaserFaction` | private static TIFactionState |

### Methods

```csharp
public static bool CampaignHasAlienFaction()
```

```csharp
public static bool CampaignHasAlienProxy()
```

```csharp
public static bool CampaignHasAlienAppeaser()
```

```csharp
public static void ClearAllGameStates()
```

```csharp
public static TISpaceBodyState Mercury()
```

```csharp
public static TISpaceBodyState Venus()
```

```csharp
public static TISpaceBodyState Earth()
```

```csharp
public static TISpaceBodyState Luna()
```

```csharp
public static TISpaceBodyState Mars()
```

```csharp
public static TISpaceBodyState Ceres()
```

```csharp
public static TISpaceBodyState Jupiter()
```

```csharp
public static TISpaceBodyState Saturn()
```

```csharp
public static TISpaceBodyState Uranus()
```

```csharp
public static TISpaceBodyState Neptune()
```

```csharp
public static List<TISpaceBodyState> Planets()
```

```csharp
public static List<TILagrangePointState> SunOrbitingLangragePoints()
```

```csharp
public static List<TISpaceBodyState> InnerSystemAsteroids(bool includeSatellites)
```

```csharp
public static List<TISpaceBodyState> InnerAsteroidBelt(bool includeSatellites)
```

```csharp
public static List<TISpaceBodyState> MidAsteroidBelt(bool includeSatellites)
```

```csharp
public static List<TISpaceBodyState> OuterAsteroidBelt(bool includeSatellites)
```

```csharp
public static List<TISpaceBodyState> FullAsteroidBelt(bool includeSatellites)
```

```csharp
public static List<TISpaceBodyState> Centaurs(bool includeSatellites)
```

```csharp
public static List<TISpaceBodyState> KuiperBeltObjects(bool includeSatellites)
```

```csharp
public static List<List<TISpaceBodyState>> ColonizableSpaceBodiesByRegion()
```

```csharp
public static List<TIOrbitState> LEOStates()
```

```csharp
public static List<TIOrbitState> NEOStates()
```

```csharp
public static TISpaceBodyState Sol()
```

```csharp
public static TIRegionState[] AllRegions()
```

```csharp
public static List<TIRegionState> SupraRegionMembers(SupraRegion supraRegion)
```

```csharp
public static TINationState[] AllNations()
```

```csharp
public static Dictionary<string, TIRegionState> RegionLookup()
```

```csharp
public static TIRegionState MapRegionLookup(string mapRegion)
```

```csharp
public static Dictionary<string, TINationState> NationLookup()
```

```csharp
public static IEnumerable<TINationState> AllExtantNations()
```

```csharp
public static IEnumerable<TINationState> AllExtantHumanNations()
```

```csharp
public static IEnumerable<TINationState> AllNonExtantHumanNations()
```

```csharp
public static IEnumerable<TINationState> AllHumanNations()
```

```csharp
public static TIFactionState[] AllFactions()
```

```csharp
public static TIFactionIdeologyTemplate UndecidedIdeology()
```

```csharp
public static List<TIFactionIdeologyTemplate> ActiveIdeologies()
```

```csharp
public static List<TIFactionIdeologyTemplate> ActiveHumanIdeologies()
```

```csharp
public static TIFactionState[] AllHumanFactions()
```

```csharp
public static TISpaceBodyState[] AllSpaceBodies()
```

```csharp
public static TILagrangePointState[] AllLagrangePoints()
```

```csharp
public static TINaturalSpaceObjectState[] AllSpaceBodiesAndLPoints()
```

```csharp
public static TIOrbitState[] AllOrbits()
```

```csharp
public static TIRegionAlienEntityState[] AllAlienEntities()
```

```csharp
public static TINationState AlienNation()
```

```csharp
public static TIFactionState AlienFaction()
```

```csharp
public static TIFactionState AlienProxy()
```

```csharp
public static TIFactionState AlienAppeaser()
```

```csharp
public static List<TIMissionState> AllActiveMissions()
```

```csharp
public static List<TIControlPoint> AllActiveControlPoints()
```

```csharp
public static TIGlobalResearchState GlobalResearch()
```

```csharp
public static TIGlobalValuesState GlobalValues()
```

```csharp
public static TINotificationQueueState NotificationQueue()
```

```csharp
public static TIPromptQueueState PromptQueue()
```

```csharp
public static TIEffectsState Effects()
```

```csharp
public static TITimeState Time()
```

```csharp
public static TIMissionPhaseState MissionPhase()
```

```csharp
public static TIMetadataState MetaData()
```

```csharp
public static IEnumerable<T> IterateByClass<T>(bool allowChild = false) where T : TIGameState
```

```csharp
public static int GetCount<T>(bool allowChild = true) where T : TIGameState
```

```csharp
public static T[] GetAllGameStates<T>(bool allowChild = true) where T : TIGameState
```

```csharp
public static bool RemoveGameState<T>(GameStateID ID, bool allowChild = false)
```

```csharp
public static T CreateNewGameState<T>() where T : TIGameState
```

```csharp
private static TIGameState CreateNewGameState(Type T)
```

```csharp
private static void AddGameState(TIGameState newGameState, Type type, bool replaceDuplicate = false)
```

```csharp
public static T FindGameState<T>() where T : TIGameState
```

```csharp
public static T FindGameState<T>(GameStateID ID, bool allowChild = false) where T : TIGameState
```

```csharp
public static IEnumerable<T> FindGameStates<T>(IEnumerable<GameStateID> IDs, bool allowChild = false) where T : TIGameState
```

```csharp
public static TIGameState FindGameState(GameStateID ID)
```

```csharp
public static Type FindType(GameStateID ID)
```

```csharp
public static T FindByTemplate<T>(string template, bool allowChild = false) where T : TIGameState
```

```csharp
public static IEnumerable<T> FindByTemplates<T>(IEnumerable<string> templates, bool allowChild = false) where T : TIGameState
```

```csharp
public static bool SaveAllGameStates(string filepath, bool doNotOpenSaveMenu = false)
```

```csharp
public static bool LoadAllGameStates(string filepath)
```

```csharp
public static bool IsValid()
```
