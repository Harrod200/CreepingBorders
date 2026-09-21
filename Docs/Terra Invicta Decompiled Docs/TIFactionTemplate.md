# TIFactionTemplate

*Decompiled from `TIFactionTemplate.cs`.*


## Class `TIFactionTemplate`

```csharp
public class TIFactionTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `AdjustedHabPreferences` | public HabPreferences |
| `brightColor` | public Color |
| `inlineColorString` | public string |
| `brightInlineColorString` | public string |
| `capitalizedFactionName` | public string |
| `capitalizedFactionNameCurrent` | public string |
| `adjective` | public string |
| `leaderAddress` | public string |
| `campaignPlayerIntroPath` | public string |
| `campaignStartHeadline` | public string |
| `leaderName` | public string |
| `leaderBorn` | public string |
| `leaderBackground` | public string |
| `introduction` | public string |
| `goal` | public string |
| `victory` | public string |
| `quote` | public string |
| `victoryAnnouncement` | public string |
| `winIllustration` | public string |
| `fleetNameBase` | public string |
| `leaderAppearance` | public TICouncilorAppearanceTemplate |
| `fleetIcon1Resource` | public string |
| `fleetIcon2Resource` | public string |
| `fleetIcon3Resource` | public string |
| `leaderDescription` | public string |
| `color` | public Color |
| `colorIntensity` | public float |
| `backgroundColor` | public string |
| `ideologyName` | public string |
| `isAlien` | public bool |
| `activePlayerAllowed` | public bool |
| `tutorialAllowed` | public bool |
| `allowedSoleAntiAlien` | public bool |
| `defaultAntiAlien` | public bool |
| `victoryTemplateName` | public string |
| `spaceOrg` | public string |
| `winningOrg` | public string |
| `hullSkinBase` | public string |
| `armySkinBase` | public string |
| `leaderDataname` | public string |
| `defaultPresetName` | public string |
| `difficulty` | public int |
| `playerMood` | public int |
| `encMood` | public int |
| `hullIndex_default` | public int |
| `hullIndex_chem` | public int |
| `hullIndex_electric` | public int |
| `hullIndex_fission` | public int |
| `hullIndex_fusion` | public int |
| `hullIndex_fusion_adv` | public int |
| `hullIndex_amat` | public int |
| `councilIcon64` | public string |
| `councilIcon64_ui` | public string |
| `councilIcon128` | public string |
| `councilIcon128_ui` | public string |
| `councilIcon256` | public string |
| `councilIcon256_ui` | public string |
| `fleetIcon` | public string |
| `stationIcon` | public string |
| `baseIcon` | public string |
| `genericCouncilorIcon` | public string |
| `habSectorIcon` | public string |
| `cursorPath` | public string |
| `cinematicsPath` | public string |
| `gradientPath` | public string |
| `winMissionPath` | public string |
| `fanfarePath` | public string |
| `shipMaterialBundlePath` | public string |
| `startingResources` | public List<ResourceValue> |
| `baseAnnualIncomes` | public List<ResourceValue> |
| `AIValues` | public List<AIValues> |
| `smallShipNameListIdx` | public string |
| `mediumShipNameListIdx` | public string |
| `largeShipNameListIdx` | public string |
| `habNameListIdx` | public string |
| `guaranteedMissions` | public List<List<string>> |
| `firstTechNames` | public List<string> |
| `winnerTechNames` | public List<string> |
| `habPreferences` | public HabPreferences |
| `adjustedHabPreferences` | private HabPreferences |

### Methods

```csharp
public override TIGameState CreateGameState()
```

```csharp
public float GetStartingResource(FactionResource resource)
```

```csharp
public static string GetShipMaterialSuffix(TIFactionState designingFaction)
```

```csharp
public string GetShipMaterialBundlePath(int hullIndex)
```
