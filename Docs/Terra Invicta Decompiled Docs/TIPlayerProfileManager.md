# TIPlayerProfileManager

*Decompiled from `TIPlayerProfileManager.cs`.*


## Class `TIPlayerProfileManager`

```csharp
public class TIPlayerProfileManager : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `lines` | public static string[] |
| `cloudConfigLines` | public static string[] |
| `loadpath` | public static string |
| `configversion` | private static readonly int |
| `checkedV` | private static bool |
| `isCustomQuality` | public static bool |
| `useAlternateSavePath` | public static bool |
| `alternateSavePath` | public static string |
| `checkedAltSavePath` | public static bool |
| `lastLaunch` | public static DateTime |
| `lastCloudLaunch` | public static DateTime |
| `requestedMasterVolume` | public static float |
| `requestedMusicVolume` | public static float |
| `requestedUIVolume` | public static float |
| `requestedEffectsVolume` | public static float |
| `requestedVoiceVolume` | public static float |
| `requestedAmbienceVolume` | public static float |
| `waypointAngleSnap` | public static int |
| `waypointAngleSnapIndex` | public static int |
| `maxShipsInCombat` | public static int |
| `usingWindowsCursor` | public static bool |
| `missionPhaseReportStartOpen` | public static bool |
| `unpauseAfterMissionAssignment` | public static bool |
| `assignmentPhaseCouncilorCameraFocus` | public static bool |
| `alertSpaceTimerNotifications` | public static bool |
| `cycleNextCouncilorWhenAssigningMissions` | public static bool |
| `showMonthlyIncomes` | public static bool |
| `muteInBackground` | public static bool |
| `compressSaves` | public static bool |
| `storedResolution` | public static Vector2 |
| `storedRefreshRate` | public static int |
| `antiAliasingMode` | public static int |
| `confineCursor` | public static bool |
| `vsyncEnabled` | public static bool |
| `displaySystemClock` | public static bool |
| `showHighSpeedOrbitTrails` | public static bool |
| `showEarthLights` | public static bool |
| `useTextureStreaming` | public static bool |
| `uiScaleSetting` | public static int |
| `enableAccessibilityMagnifier` | public static bool |
| `useCouncilorVideo` | public static bool |
| `skyboxVariant` | public static int |
| `tooltipDelayPrimary` | public static float |
| `tooltipDelaySupplemental` | public static float |
| `notificationOverrides` | public static List<TINotificationTemplateOverride> |
| `notificationTemplates` | public static List<TINotificationTemplate> |
| `storedCampaignOptions` | public static TIPlayerProfileManager.StoredCampaignOptions |
| `subscribedMods` | public static Dictionary<string, string> |
| `modsToUninstall` | public static Dictionary<string, string> |
| `storedFullscreenMode` | public static bool |
| `firstGame` | public static bool |
| `useMods` | public static bool |
| `loadingFailureDueToMods` | public static bool |
| `showFPS` | public static bool |
| `KBList` | public static List<string> |
| `KBModifierList` | public static List<string> |
| `fatalError` | public static bool |
| `StoredCampaignOptions` | public class |
| `isValid` | public bool |
| `customFactionStartingNationGroup` | public int |
| `startingCouncilorProfessions` | public List<int> |
| `usePlayerCountryForStartingCouncilor` | public bool |
| `variableProjectUnlocks` | public bool |
| `showTriggeredProjects` | public bool |
| `addAlienAssaultCarrierFleet` | public bool |
| `cinematicCombatRealismDV` | public bool |
| `cinematicCombatRealismScale` | public bool |
| `otherFactionStartingNations` | public bool |
| `canDisableFactions` | public bool |
| `researchSpeedMultiplier` | public int |
| `controlPointMaintenanceFreebieBonus` | public int |
| `controlPointMaintenanceFreebieBonusAI` | public int |
| `missionControlBonus` | public int |
| `missionControlBonusAI` | public int |
| `alienProgressionSpeed` | public int |
| `miningProductivityMultiplier` | public int |
| `nationalIPMultiplier` | public int |
| `averageMonthlyEvents` | public int |
| `miningRatePlayer` | public int |
| `miningRateHumanAI` | public int |
| `miningRateAlien` | public int |
| `habConstructionSpeedPlayer` | public int |
| `habConstructionSpeedHumanAI` | public int |
| `habConstructionSpeedAlien` | public int |
| `shipConstructionSpeedPlayer` | public int |
| `shipConstructionSpeedHumanAI` | public int |
| `shipConstructionSpeedAlien` | public int |

### Properties

- `public static TIInputManager inputManager`

### Methods

```csharp
public static bool canUseMods()
```

```csharp
public static float masterVolumeModifier()
```

```csharp
public static float musicVolumeModifier()
```

```csharp
public static float effectsVolumeModifier()
```

```csharp
public static float ambienceVolumeModifier()
```

```csharp
public static float voiceVolumeModifier()
```

```csharp
public static float uiVolumeModifier()
```

```csharp
public static void CheckConfigVersion()
```

```csharp
public static string savedLanguage()
```

```csharp
public static void GetKBList()
```

```csharp
public static KeyCode savedKeybind(int index)
```

```csharp
public static KeyCode savedKeybindModifier(int index)
```

```csharp
public static bool savedEmptyKeybind(int index)
```

```csharp
public static int savedQualitySetting()
```

```csharp
public static string GetValue(string searchKey)
```

```csharp
public static string GetValueJson(string searchKey)
```

```csharp
public static TINotificationTemplateOverride GetNotificationOverride(string dataName)
```

```csharp
public static float GetFloatByKey(string key, float defaultValue)
```

```csharp
public static int GetIntByKey(string key, int defaultValue)
```

```csharp
public static bool GetBoolByKey(string key, bool defaultValue)
```

```csharp
public static string GetAltSavePathString(string searchKey, string[] textToSearch)
```

```csharp
public static void GetLastLaunch()
```

```csharp
public static void Init()
```

```csharp
public static void CheckAlternateSavePath()
```

```csharp
public static void LoadPlayerConfig(bool modCheck = false)
```

```csharp
public static void ReadPlayerConfig(bool modCheck = false)
```

```csharp
public static void LoadModSettings()
```

```csharp
public static void LoadDefaultGameplaySettings()
```

```csharp
public static void LoadDefaultGraphics()
```

```csharp
public static void LoadNotificationOverrides()
```

```csharp
public static void LoadPreviousCampaignLaunchOptions()
```

```csharp
public static void LoadPreviouslySubscribedWorkshopMods()
```

```csharp
public static void CheckModsToUninstall()
```

```csharp
public static string GetPreviousCampaignLaunchOptionsString()
```

```csharp
public static string GetSubscribedModsString()
```

```csharp
public static string GetModsToUninstallString()
```

```csharp
public static void ClearSubscribedMods()
```

```csharp
public static void SetMipmapMemoryBudget()
```

```csharp
public static void SetCursorConfineMode(bool confine)
```

```csharp
public static void VerifyModDirectories()
```

```csharp
public static void SetCouncilorVideoSetting(bool newConfig = true)
```

```csharp
public static void LoadDefaultAudio()
```

```csharp
public static void CreateDefaultConfigFile()
```

```csharp
public static void SavePlayerConfig()
```

```csharp
public static void HandleModFailure()
```
