# TargetSelectionTool

*Decompiled from `PavonisInteractive/TerraInvicta/TargetSelectionTool.cs`.*


## Class `TargetSelectionTool`

```csharp
public class TargetSelectionTool : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Targets` | public IEnumerable<TIGameState> |
| `Filter` | public TIGameState |
| `IsInOrbitSelectionMode` | public bool |
| `IsinHabSiteSelectionMode` | public bool |
| `IsInNavigatorMode` | public bool |
| `FilteredTargets` | public IEnumerable<TIGameState> |
| `inIntelScreen` | public bool |
| `targetDetailPanelHeader` | public TMP_Text |
| `targetDetailCloseButton` | public Button |
| `targetListManager` | public ListManagerBase |
| `targetScrollView` | public ScrollRect |
| `targetScrollViewContentObject` | public GameObject |
| `highlightImage` | public Image |
| `newTargetOnFilterChange` | public bool |
| `targets` | private IEnumerable<TIGameState> |
| `filter` | private TIGameState |
| `GetHeaderString` | public Func<TargetSelectionTool, string> |
| `onTargetSelected` | public TargetSelectionTool.OnTargetSelected |
| `navigatorListObject` | public GameObject |
| `navigatorButtonListManager` | public ListManagerBase |
| `navigatorBodies` | private List<TINaturalSpaceObjectState> |
| `onFilterSelected` | public TargetSelectionTool.OnFilterSelected |
| `primaryNavigatorBodyTemplateNames` | public static readonly List<string> |

### Properties

- `public IOperation Operation`

### Methods

```csharp
private void Awake()
```

```csharp
public void UpdateListUI()
```

```csharp
public void Open(IEnumerable<TIGameState> targets, TIGameState filter, IOperation operation = null)
```

```csharp
public void Open()
```

```csharp
public void Close()
```

```csharp
public TIGameState GetArbitraryTarget()
```

```csharp
public void SetTargetsToAllOrbitsAndSpaceAssets()
```

```csharp
public void UpdateLabels()
```

```csharp
public void OnElementClicked(TIGameState gameState)
```

```csharp
public void InitializeNavigator()
```

```csharp
public void OnNavigatorListButtonClicked(TINaturalSpaceObjectState naturalSpaceObject)
```

```csharp
public delegate void OnTargetSelected(TIGameState gameState)
```

```csharp
public delegate void OnFilterSelected(TIGameState gameState)
```
