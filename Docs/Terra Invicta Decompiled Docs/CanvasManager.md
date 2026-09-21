# CanvasManager

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/UI/CanvasManager.cs`.*


## Class `CanvasManager`

```csharp
public class CanvasManager : ManagerSystem
```

### Fields

| Name | Type |
|---|---|
| `ActiveInfoScreen` | public IInfoScreen |
| `UICamera` | private Camera |
| `OptionsScreen` | public ICanvas |
| `NationInfo` | public ICanvas |
| `Notifications` | public ICanvas |
| `Codex` | public ICanvas |
| `SpaceObjectDetail` | public ICanvas |
| `StrategyHud` | public IHud |
| `CombatHud` | public IHud |
| `CouncilorMissionController` | public ICanvas |
| `OperationCanvasController` | public ICanvas |
| `ArmyDetail` | public ICanvas |
| `PrecombatControllerCanvas` | public ICanvas |
| `canvasGOs` | private readonly Dictionary<string, GameObject> |
| `canvases` | private readonly Dictionary<string, ICanvas> |
| `canvasesByType` | private readonly Dictionary<Type, ICanvas> |
| `infoScreens` | private readonly Dictionary<Type, IInfoScreen> |
| `activeInfoScreen` | private IInfoScreen |
| `activeAssetPanel` | private AssetPanel |
| `activeInfoPanel` | private InfoPanel |
| `disableInfoPanelOrders` | public Dictionary<InfoPanel, List<Action>> |
| `disableAssetPanelOrders` | public Dictionary<AssetPanel, List<Action>> |

### Properties

- `public bool initted`

### Methods

```csharp
public void Initialize()
```

```csharp
protected override void OnUpdate()
```

```csharp
public void RefreshUIScaling()
```

```csharp
public void RefreshUltraWideScaling()
```

```csharp
public T Canvas<T>() where T : ICanvas
```

```csharp
public void HideStrategyLayerUIs()
```

```csharp
public void RestoreStrategyLayerUIs()
```

```csharp
public void ResetActivePlayerDuringRunTime()
```

```csharp
public bool IsShowingInfoScreen()
```

```csharp
public bool IsShowingInfoScreen<T>() where T : IInfoScreen
```

```csharp
public void ToggleInfoScreen<T>() where T : IInfoScreen
```

```csharp
public IInfoScreen ShowInfoScreen<T>() where T : IInfoScreen
```

```csharp
public T GetInfoScreen<T>() where T : class, IInfoScreen
```

```csharp
public void HideInfoScreen<T>(bool toggle = false) where T : IInfoScreen
```

```csharp
public void OnInfoPanelOpened(InfoPanelOpened e)
```

```csharp
public void OnAssetPanelOpened(MyAssetPanelOpened e)
```

```csharp
public void CloseActiveInfoScreen()
```

```csharp
public void ClearCanvas(ICanvas canvas)
```

```csharp
public void RegisterInfoPanelDisableOrder(InfoPanel infoPanel, Action disableOrder)
```

```csharp
public void RegisterAssetPanelDisableOrder(AssetPanel assetPanel, Action disableOrder)
```

```csharp
public void SetActiveInfoPanel(InfoPanel infoPanel, float panelHeight = 0f)
```

```csharp
public void ActiveInfoPanelResized(float floatPanelHeight)
```

```csharp
public InfoPanel GetActiveInfoPanel()
```

```csharp
public void SetActiveAssetPanel(AssetPanel assetPanel, float panelHeight)
```

```csharp
public void ActiveAssetPanelResized(float floatPanelHeight)
```

```csharp
public AssetPanel GetActiveAssetPanel()
```

```csharp
public void HideAll()
```

```csharp
public void Show(GameObject canvasObject)
```

```csharp
public void Hide(string name)
```

```csharp
public bool IsVisible(string name)
```
