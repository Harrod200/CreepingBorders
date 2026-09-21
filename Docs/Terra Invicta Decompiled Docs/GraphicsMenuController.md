# GraphicsMenuController

*Decompiled from `GraphicsMenuController.cs`.*


## Class `GraphicsMenuController`

```csharp
public class GraphicsMenuController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `qualitySettingsDropdown` | public TMP_Dropdown |
| `textureSettingsDropdown` | public TMP_Dropdown |
| `antiAliasingSettingsDropdown` | public TMP_Dropdown |
| `antiAliasingModeDropdown` | public TMP_Dropdown |
| `resolutionSettingsDropdown` | public TMP_Dropdown |
| `skyboxVariantDropdown` | public TMP_Dropdown |
| `qualitySettingsDropdownLabel` | public TextMeshProUGUI |
| `textureSettingsDropdownLabel` | public TextMeshProUGUI |
| `antiAliasingSettingsDropdownLabel` | public TextMeshProUGUI |
| `antiAliasingModeDropdownLabel` | public TextMeshProUGUI |
| `resolutionSettingsDropdownLabel` | public TextMeshProUGUI |
| `qualityTitle` | public TextMeshProUGUI |
| `textureTitle` | public TextMeshProUGUI |
| `antiAliasingTitle` | public TextMeshProUGUI |
| `antiAliasingModeTitle` | public TextMeshProUGUI |
| `resolutionTitle` | public TextMeshProUGUI |
| `fullscreenTitle` | public TextMeshProUGUI |
| `confineCursorTitle` | public TextMeshProUGUI |
| `applyChangesTitle` | public TextMeshProUGUI |
| `enableVSyncTitle` | public TextMeshProUGUI |
| `textureStreamingTitle` | public TextMeshProUGUI |
| `accessibilityMagnifierTitle` | public TextMeshProUGUI |
| `skyboxVariantTitle` | public TextMeshProUGUI |
| `useCouncilorVideoTitle` | public TextMeshProUGUI |
| `UIScaleTitle` | public TextMeshProUGUI |
| `UIScaleValue` | public TextMeshProUGUI |
| `qualityLevelLabel` | public TextMeshProUGUI |
| `enableVSyncToggle` | public Toggle |
| `fullscreenSettingToggle` | public Toggle |
| `confineCursorToggle` | public Toggle |
| `textureStreamingToggle` | public Toggle |
| `accessibilityMagnifierToggle` | public Toggle |
| `useCouncilorVideoToggle` | public Toggle |
| `uiScaleSlider` | public Slider |
| `textureStreamingTT` | public TooltipTrigger |
| `uiScaleTT` | public TooltipTrigger |
| `accessibilityMagnifierTT` | public TooltipTrigger |
| `councilorVideoTT` | public TooltipTrigger |
| `RadeonAAWarningTT` | public TooltipTrigger |
| `RadeonAAWarningObject` | public GameObject |
| `mainCameraPostProcessingLayer` | private PostProcessLayer |
| `fullscreenModeSetting` | private bool |
| `qualityDirty` | private bool |
| `textureDirty` | private bool |
| `antiAliasingDirty` | private bool |
| `antiAliasingModeDirty` | private bool |
| `resolutionDirty` | private bool |
| `fullscreenDirty` | private bool |
| `confineCursorDirty` | private bool |
| `vsyncDirty` | private bool |
| `textureStreamingDirty` | private bool |
| `useLargeUIScaleDirty` | private bool |
| `useAccessibilityMagnifierDirty` | private bool |
| `skyboxVariantDirty` | private bool |
| `useCouncilorVideoDirty` | private bool |
| `isInitializing` | private bool |

### Methods

```csharp
private void Start()
```

```csharp
private void DisplayDefaults()
```

```csharp
private void LoadValidResolutions()
```

```csharp
public void ChangeQualitySettings()
```

```csharp
public void ChangeTextureSettings()
```

```csharp
public void ChangeAntiAliasingSettings()
```

```csharp
public void ChangeAntiAliasingMode()
```

```csharp
public void ChangeSkyboxVariant()
```

```csharp
public void ChangeCouncilorVideoToggle()
```

```csharp
public void ChangeResolutionSettings()
```

```csharp
public void ToggleFullscreenMode()
```

```csharp
public void ToggleCursorConfineMode()
```

```csharp
public void ToggleVSyncMode()
```

```csharp
public void ToggleTextureStreaming()
```

```csharp
public void ChangedLargeUIScale()
```

```csharp
public void ToggleAccessibilityMagnifier()
```

```csharp
public void UpdateAntiAliasingText()
```

```csharp
public void UpdateAntiAliasingMode(int mode)
```

```csharp
public void LoadLocalizedText()
```

```csharp
public void UpdateQualitySettings()
```

```csharp
private void UpdateUIScaleSetting()
```

```csharp
private void UpdateAccessibilityMagnifierSetting()
```

```csharp
private void UpdateCanIncreaseUIScale()
```

```csharp
private IEnumerator HandleWindowedFixedResolutionChange(int x, int y, int refreshRate)
```

```csharp
private void OnLanguageChangedEvent()
```
