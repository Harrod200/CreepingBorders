# OptionsMenuController

*Decompiled from `PavonisInteractive/TerraInvicta/OptionsMenuController.cs`.*


## Class `OptionsMenuController`

```csharp
public class OptionsMenuController : MenuController
```

### Fields

| Name | Type |
|---|---|
| `loadMenuController` | public LoadMenuController |
| `saveMenuController` | public SaveMenuController |
| `startMenuController` | public StartMenuController |
| `resetTutorialButton` | public GameObject |
| `maxShipsInCombatSlider` | public Slider |
| `tooltipDelayPrimarySlider` | public Slider |
| `tooltipDelaySupplementalSlider` | public Slider |
| `languageSelection` | public TMP_Dropdown |
| `waypointAngleSnapDropdown` | public TMP_Dropdown |
| `missionPhaseSummaryStartsOpen` | public Toggle |
| `customCursorToggle` | public Toggle |
| `unpauseAfterMissionAssignment` | public Toggle |
| `alertSpaceTimerToggle` | public Toggle |
| `monthlyIncomeToggle` | public Toggle |
| `compressSavesToggle` | public Toggle |
| `displaySystemClockToggle` | public Toggle |
| `assignmentPhaseCouncilorCameraFocusToggle` | public Toggle |
| `cycleNextCouncilorWhenAssigningMissionsToggle` | public Toggle |
| `showHighSpeedOrbitTrailsToggle` | public Toggle |
| `showEarthLightsToggle` | public Toggle |
| `languageTitle` | public TMP_Text |
| `waypointSnapAngleTitle` | public TMP_Text |
| `cursorToggleTitle` | public TMP_Text |
| `missionPhaseReportToggleTitle` | public TMP_Text |
| `unpauseAfterMissionAssignmentTitle` | public TMP_Text |
| `maxShipsInCombatTitle` | public TMP_Text |
| `tooltipDelayPrimaryTitle` | public TMP_Text |
| `tooltipDelaySupplementalTitle` | public TMP_Text |
| `alertSpaceTimerTitle` | public TMP_Text |
| `toggleMonthlyIncomeTimerTitle` | public TMP_Text |
| `toggleCompressSavesTitle` | public TMP_Text |
| `toggleDisplaySystemClockTitle` | public TMP_Text |
| `assignmentPhaseCouncilorCameraFocusToggleTitle` | public TMP_Text |
| `cycleNextCouncilorWhenAssigningMissionsToggleTitle` | public TMP_Text |
| `showHighSpeedOrbitTrailsToggleTitle` | public TMP_Text |
| `showEarthLightsToggleTitle` | public TMP_Text |
| `optionsHeader` | public TMP_Text |
| `graphicsHeader` | public TMP_Text |
| `controlsHeader` | public TMP_Text |
| `audioHeader` | public TMP_Text |
| `gameplayHeader` | public TMP_Text |
| `difficultyValue` | public TMP_Text |
| `maxShipsInCombatValue` | public TMP_Text |
| `tooltipDelayPrimaryValue` | public TMP_Text |
| `tooltipDelaySupplementalValue` | public TMP_Text |
| `inGame` | public bool |
| `initSnapAngle` | private bool |
| `saveChanges` | public bool |
| `optionsMenuOpen` | public static bool |
| `_templates` | private List<TILocalizationTemplate> |
| `isInitializing` | private bool |

### Methods

```csharp
private void OnEnable()
```

```csharp
public void OnDisable()
```

```csharp
private void Start()
```

```csharp
public void LoadLocalizedText()
```

```csharp
public void HandleLanguageSelectionInput(int index)
```

```csharp
private void SetLanguageDropdownOptions()
```

```csharp
public void ChangedWaypointAngleSnap(bool dirty = false)
```

```csharp
public void ChangedCursorSetting()
```

```csharp
public void ChangedMissionPhaseReportSetting()
```

```csharp
public void ChangedUnpauseAfterMissionAssignmentSetting()
```

```csharp
public void ChangedAlertSpaceTimerSetting()
```

```csharp
public void ChangedMonthlyIncomeSetting()
```

```csharp
public void ChangedCompressSavesSetting()
```

```csharp
public void ChangedMaxShipsInCombat()
```

```csharp
public void ChangedTooltipDelayPrimary()
```

```csharp
public void ChangedTooltipDelaySupplemental()
```

```csharp
public void ChangedDisplaySystemClock()
```

```csharp
public void ChangedAssignmentPhaseCameraFocus()
```

```csharp
public void ChangedAssignmentPhaseCouncilorCycle()
```

```csharp
public void ChangedShowHighSpeedOrbitTrails()
```

```csharp
public void ChangedShowEarthLights()
```

```csharp
public void PlayOptionsToggleAudio()
```

```csharp
public void PlayOptionsTabAudio()
```
