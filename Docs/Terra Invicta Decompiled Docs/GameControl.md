# GameControl

*Decompiled from `GameControl.cs`.*


## Class `GameControl`

```csharp
public class GameControl : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `scenarioTemplate` | public TIMetaTemplate |
| `canvasStack` | public static CanvasManager |
| `eventManager` | public static EventManager |
| `assetLoader` | public static AssetLoader |
| `solarSystem` | public static SolarSystemControl |
| `playerManager` | public static PlayerManager |
| `spaceCombat` | public static SpaceCombatManager |
| `namelists` | public static NamelistManager |
| `_canvasStack` | internal CanvasManager |
| `_eventManager` | private EventManager |
| `_assetLoader` | internal AssetLoader |
| `_solarSystem` | private SolarSystemControl |
| `_playerManager` | private PlayerManager |
| `_spaceCombat` | private SpaceCombatManager |
| `_namelists` | private NamelistManager |
| `mainCamera` | public Camera |
| `mainCameraTransform` | public Transform |
| `skirmishMode` | public bool |
| `startupTutorialActive` | public bool |
| `startupDifficulty` | public int |
| `scenarioCustomizationsStartup` | public ScenarioCustomizations |
| `bootstrapFinished` | public static bool |
| `initialized` | public static bool |
| `loadcycle100` | public static bool |
| `frameFinishedLoading` | public static int |
| `gameStartedUnloading` | public static bool |
| `handlingException` | public static bool |
| `needToViewSpaceCombat` | public static bool |
| `loadScreenWidget` | public LoadScreenWidget |
| `loadStartTimeStamp` | public float |
| `_scenarioMetaTemplate` | private TIMetaTemplate |
| `resolutionChangeCount` | private static int |
| `Storefront` | public enum |

### Properties

- `public ViewControl viewMgr`
- `public static GameControl control`
- `public TIFactionState activePlayer`
- `public static bool DLCValidated`

### Methods

```csharp
public static void LoadGlobalGameStates()
```

```csharp
public static void SetActivePlayer(TIFactionState faction)
```

```csharp
public static void Stop()
```

```csharp
public static void StartSimulationAction(SimulationAction action)
```

```csharp
public void SetScenarioMetaTemplate(string metaTemplate)
```

```csharp
public void Initialize(bool loadingSave, IScenario scenario)
```

```csharp
public static void CreateAndDestroyStartupGameStates()
```

```csharp
public void CompleteInit(bool loadingSave, IScenario scenario)
```

```csharp
public static IEnumerator PassErrorToStartScreen(string header, string desc)
```

```csharp
public static void ResetLoadingState()
```

```csharp
public IEnumerator InitCanvas()
```

```csharp
public void CheckDLCLicense()
```

```csharp
public void ValidateDLC()
```

```csharp
public void UpdateLoading(float value)
```

```csharp
public void LoadLoadingIllustration()
```

```csharp
public void LogTotalLoadTime()
```

```csharp
private void Update()
```

```csharp
private void OnApplicationQuit()
```
