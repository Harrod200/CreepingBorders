# MetadataScreenController

*Decompiled from `PavonisInteractive/TerraInvicta/MetadataScreenController.cs`.*


## Class `MetadataScreenController`

```csharp
public class MetadataScreenController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `metaDataLayoutObject` | public GameObject |
| `objectiveImage` | public Image |
| `factionIcon` | public Image |
| `factionGradient` | public Image |
| `modsActiveObject` | public GameObject |
| `DLCActiveObject` | public GameObject |
| `ModsActiveText` | public TMP_Text |
| `campaignSettingsText` | public TMP_Text |
| `saveNameText` | public TMP_Text |
| `saveDateText` | public TMP_Text |
| `playerFactionNameText` | public TMP_Text |
| `lastObjectiveNameText` | public TMP_Text |
| `difficultyText` | public TMP_Text |
| `researchSpeedTitleText` | public TMP_Text |
| `miningProductivityTitleText` | public TMP_Text |
| `alienProgressionTitleText` | public TMP_Text |
| `nationalIPMultiplierTitleText` | public TMP_Text |
| `mcBonusTitleText` | public TMP_Text |
| `mcBonusAITitleText` | public TMP_Text |
| `cpBonusTitleText` | public TMP_Text |
| `cpBonusAITitleText` | public TMP_Text |
| `monthlyEventTitleText` | public TMP_Text |
| `researchSpeedText` | public TMP_Text |
| `miningProductivityText` | public TMP_Text |
| `alienProgressionText` | public TMP_Text |
| `nationalIPMultiplierText` | public TMP_Text |
| `mcBonusText` | public TMP_Text |
| `mcBonusAIText` | public TMP_Text |
| `cpBonusText` | public TMP_Text |
| `cpBonusAIText` | public TMP_Text |
| `monthlyEventText` | public TMP_Text |
| `cachedMetaData` | private TIMetadataState |
| `cachedSaveName` | private string |

### Methods

```csharp
public void RefreshUIWithMetaData(TIMetadataState metaData, string saveName)
```

```csharp
public void ClearUI()
```

```csharp
private void Start()
```

```csharp
private void LoadLocalizedText()
```

```csharp
private void OnLanguageChangedEvent()
```

```csharp
private void OnDestroy()
```
