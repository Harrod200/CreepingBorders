# TIUtilities

*Decompiled from `PavonisInteractive/TerraInvicta/TIUtilities.cs`.*


## Class `TIUtilities`

```csharp
public static class TIUtilities
```

### Fields

| Name | Type |
|---|---|
| `IsInCombatMode` | public static bool |
| `IsInSolarSystemMode` | public static bool |
| `IsTimeFlowing` | public static bool |
| `IsThereUnresolvedCombats` | public static bool |
| `separator` | public static string |
| `random` | private static global::System.Random |
| `storedRandomStack` | private static Stack<global::System.Random> |
| `blackstr` | public const string |
| `greenstr` | public const string |
| `redstr` | public const string |
| `cyanstr` | public const string |
| `bluestr` | public const string |
| `purplestr` | public const string |
| `yellowstr` | public const string |
| `goldstr` | public const string |
| `dimmedGrayTextStr` | public const string |
| `textHighlightStr` | public const string |
| `headerTextColor` | public const string |
| `textColor` | public const string |
| `closecolor` | public const string |
| `UITextColor` | public static readonly Color |
| `UITextColorTransluscent` | public static readonly Color |
| `UIRedTextColor` | public static readonly Color |
| `UIHighlightColor` | public static readonly Color |
| `UIDisabled` | public static readonly Color |
| `UIColorIndicatorNeutral` | public static readonly Color |
| `UIColorIndicatorPositive` | public static readonly Color |
| `UIColorIndicatorNegative` | public static readonly Color |
| `UIColorIndicatorPipUnfilled` | public static readonly Color |
| `UIColorIndicatorTimePipEmpty` | public static readonly Color |
| `assetLoader` | public static AssetLoader |
| `camera` | public static CameraManager |
| `defaultScalingForEarth` | private const float |
| `defaultScalingForSmallEarthRegions` | private const float |
| `defaultScalingForNaturalSpaceObjects` | private const float |
| `defaultScalingForOrbits` | private const float |
| `defaultScalingForHabs` | private const float |
| `defaultScalingForFleets` | private const float |
| `sb` | private static readonly StringBuilder |
| `_threadSafeRandom` | private static global::System.Random |
| `_storedRandomStack` | private static Stack<global::System.Random> |
| `mainThread` | private static Thread |

### Methods

```csharp
public static bool GetBoolValue(string strValue)
```

```csharp
public static float GetFloatValue(string strValue)
```

```csharp
public static double GetDoubleValue(string strValue)
```

```csharp
public static int GetIntValue(string strValue)
```

```csharp
public static T GetTemplateValue<T>(string strValue) where T : TIDataTemplate
```

```csharp
public static string GetDebugString(this TIGameState gameState, bool embedLinks = false)
```

```csharp
public static string GetLocationDebugString(this TIGameState gameState, bool embedLinks = false)
```

```csharp
public static string GetTrajectoryDebugString(this Trajectory trajectory, bool embedLinks = false)
```

```csharp
public static TIGameState ObjectToSupraLocation(TIGameState state)
```

```csharp
public static TIGameState ObjectToExactLocation(TIGameState state)
```

```csharp
public static TIGameState ObjectToScannableLocation(TIGameState state)
```

```csharp
public static bool GameStateHasLatLong(TIGameState state)
```

```csharp
public static Vector2 GameStateLatLong(TIGameState state)
```

```csharp
private static TISpaceObjectState ObjectToSpaceObject(TIGameState state, bool landedFleetUICall)
```

```csharp
public static bool IsIrradiated(this TIGameState gameState)
```

```csharp
public static float IrradiatedMultiplier(TIGameState gameState)
```

```csharp
public static void GotoGameState(TIFactionState faction, bool select = false)
```

```csharp
public static void GotoGameState(TIGlobalResearchState research, bool select = false)
```

```csharp
public static void GotoGameState(TIGlobalValuesState values, bool select = false)
```

```csharp
public static void GotoGameState(TIMissionPhaseState phase, bool select = false)
```

```csharp
public static void GotoGameState(TICouncilorState councilor, bool moveCamera = true, bool launchUI = true, bool triggerSelectionEvent = true)
```

```csharp
public static void GotoGameState(CouncilorView councilorView, bool basicDataVisible, bool moveCamera = true, bool launchUI = true, bool triggerSelectionEvent = true)
```

```csharp
public static void GotoGameState(TIGameState gameState, bool moveCamera = true, bool launchUI = true, bool triggerGlobalSelectionEvent = true, bool zoomCamera = true, bool selectSpaceObject = false, float defaultScalingForEarthOverride = -1f)
```

```csharp
public static void TriggerSelectionEvent(TIGameState gameState)
```

```csharp
public static void LookAtGameState(TIGameState gameState)
```

```csharp
public static void GotoSelectedStateUI(TIGameState gameState, bool setAsGlobalSelectedState)
```

```csharp
public static float Median<T>(this IEnumerable<T> elements, Func<T, float> GetValue)
```

```csharp
public static IEnumerable<U> SelectSansNulls<T, U>(this IEnumerable<T> elements, Func<T, U> Selector)
```

```csharp
public static string FormatBigOrSmallNumber(float value, int bigCap = 1, int smallCap = 7, int smallExtend = 0, bool useSmallPrefixes = false, bool emptyZero = false)
```

```csharp
public static string FormatBigOrSmallNumber(double value, int bigCap = 1, int smallCap = 7, int smallExtend = 0, bool useSmallPrefixes = false, bool emptyZero = false)
```

```csharp
public static string FormatBigNumber(double value, int cap = 1, bool emptyZero = false)
```

```csharp
public static string FormatSmallNumber(float value, int decimalCap = 7, int extend = 0, bool avoidPrefix = true, bool emptyZero = false)
```

```csharp
public static string FormatSmallNumber(double value, int decimalCap = 7, int extend = 0, bool avoidPrefix = true, bool emptyZero = false)
```

```csharp
public static string FormatSmallNumber_prefix(double value, int cap = 4, int extend = 0, bool includingMilli = false)
```

```csharp
public static string LocalizeGW(string keyGW, float GW)
```

```csharp
public static string DecimalPlaces(double value, int cap = 7, int forceExtend = 0)
```

```csharp
public static string DecimalPlaces_P(double value, int cap = 7, int forceExtend = 0)
```

```csharp
public static string ForceValueSign(float value, string stringToModify, bool dollars = false, bool colorize = false, NationInfoController.WhatIsGood whatIsGood = NationInfoController.WhatIsGood.upIsGood)
```

```csharp
public static string ForceValueSign(float value, bool dollars = false, bool percent = false, string decimalOverride = "")
```

```csharp
public static string GetStateDisplayName(TIGameState target, TIFactionState targetingFaction = null, bool sentenceForm = false, bool capitalize = false, bool includeArticle = false, bool colorFactionName = false, bool councilorFromMemory = true)
```

```csharp
public static string GetLocationString(TIGameState location, bool expandedLocationString, bool sentenceForm)
```

```csharp
public static string StripDiacriticsFromString(string inputString)
```

```csharp
public static string StripInvalidPathCharsFromString(string filename)
```

```csharp
public static string CombineStrings(params string[] strings)
```

```csharp
public static string LocalizedNamelistIDX(string idx)
```

```csharp
public static string ConstructTextList(List<TIGameState> gameStates, bool noConjuction = false, bool orConjunction = false)
```

```csharp
public static string ConstructTextList(List<TIDataTemplate> templates, bool noConjuction = false, bool orConjunction = false)
```

```csharp
public static string ConstructTextList(List<string> strings, bool noConjuction = false, bool orConjunction = false)
```

```csharp
public static string GetPriorityString(PriorityType priority, bool icon = false)
```

```csharp
public static string GetColorString(Color color)
```

```csharp
public static string GetResourceString(FactionResource resource)
```

```csharp
public static string GetAttributeString(CouncilorAttribute attribute)
```

```csharp
public static string GetControlPointString(ControlPointType CP)
```

```csharp
public static string RedLine(string str)
```

```csharp
public static string GreenLine(string str)
```

```csharp
public static string CyanLine(string str)
```

```csharp
public static string HeaderCyanLine(string str)
```

```csharp
public static string BlueLine(string str)
```

```csharp
public static string BlackLine(string str)
```

```csharp
public static string PurpleLine(string str)
```

```csharp
public static string YellowLine(string str)
```

```csharp
public static string GoldLine(string str)
```

```csharp
public static string GrayLine(string str)
```

```csharp
public static string HighlightLine(string str)
```

```csharp
public static string FactionLine(string str, TIFactionState faction)
```

```csharp
public static string TechCategoryLine(string str, TechCategory techCategory)
```

```csharp
public static string BuildResourceValueString(ResourceValue[] resourceValues)
```

```csharp
public static Sprite GetStateIcon(TIFactionState faction, TIGameState state, bool detail)
```

```csharp
public static string GetStateIconPath(TIFactionState faction, TIGameState state, bool detail)
```

```csharp
public static string PathResourceIcon(FactionResource resource)
```

```csharp
public static string InlineResourceStr(FactionResource resource)
```

```csharp
public static string PathAttributeIcon(CouncilorAttribute attribute)
```

```csharp
public static string InlineAttributeStr(CouncilorAttribute attribute)
```

```csharp
public static string InlineKeyboardModifierStr(KeyCode keycode)
```

```csharp
public static string InlineMouseClickStr(int button)
```

```csharp
public static string GetSaveFileExtension()
```

```csharp
public static string GetSaveFilePath(string filename)
```

```csharp
public static string GetMostRecentSave()
```

```csharp
public static string GetContentBundleSuffix(int idx)
```

```csharp
public static string ContentBundleShipAbbreviation(int idx)
```

```csharp
public static int GetHullAppearanceIndex(int index)
```

```csharp
public static float GetScreenRatio()
```

```csharp
public static float GetAspectRatio(float width, float height)
```

```csharp
public static bool CanIncreaseUIScale(float width, float height)
```

```csharp
public static float UIScaleFactor()
```

```csharp
public static float GetMouseHeightRelativeToRectTransformBounds(RectTransform rt)
```

```csharp
public static Component CopyComponent(Component original, GameObject destination)
```

```csharp
public static void UpdateButtonSpritesPlusMinus(Button button, bool plus, bool gold = false)
```

```csharp
public static void UpdateButtonSpritesPlusMinusAlt(Button button, bool plus)
```

```csharp
public static string RemoveWorkshopTags(string dirtyText)
```

```csharp
public static bool HasRadeonGPU()
```

```csharp
public static bool IsSteamDeck()
```

```csharp
private static extern string wine_get_version()
```

```csharp
public static bool IsLinux()
```

```csharp
public static void InitRandom(int seed = 478154)
```

```csharp
public static void PushRandomState(int? newSeed = null)
```

```csharp
public static void PopRandomState()
```

```csharp
public static double RandomDouble(double min, double max)
```

```csharp
public static float RandomFloatValue()
```

```csharp
public static int RandomRange(int minInclusive, int maxExclusive)
```

```csharp
public static float RandomRange(float minInclusive, float maxExclusive)
```

```csharp
public static void SetMainThread(Thread thread)
```

```csharp
public static bool IsMainThread(Thread thread)
```

```csharp
public static void TryPrepareVideo(VideoPlayer videoToPrepare)
```

```csharp
public static void TryPlayVideo(VideoPlayer videoToPlay)
```

```csharp
public static void PromptPlayerForBugReport(string message, bool recommendReload = true)
```

```csharp
public static float GetUnityRadius_Plane(Vector3d globalPosition, float radius_m)
```

```csharp
public static float GetUnityRadiusFromAngularDiameter_Plane(Vector3d globalPosition, float angularDiameter)
```

```csharp
public static float GetUnityRadiusFromAngularDiameter_Plane(float unityDistance, float angularDiameter)
```

```csharp
public static AccelerationConstraints GetAccelerationConstraintsForGroup(List<CombatShipController> ships, bool conserveDV)
```

```csharp
public static bool WillHitSphere(Vector3 myPosition, Vector3 myVelocity, Vector3 projectilePosition, Vector3 projectileVelocity_u, float diameter_m)
```

```csharp
public static bool MovingTowardsTarget(Vector3 myPos, Vector3 myVelocity, Vector3 targetPos, Vector3 targetVelocity)
```

```csharp
public static List<RaycastHit> SimpleConeCastAll(Vector3 orgin, Vector3 direction, Vector3 directionRight, int numberOfRays, float angle_deg, float maxDistance, int LayerMask)
```

```csharp
public static void OpenWebURL(string webURL)
```

```csharp
public static void OpenFileSystemURL(string fileSystemURL)
```
