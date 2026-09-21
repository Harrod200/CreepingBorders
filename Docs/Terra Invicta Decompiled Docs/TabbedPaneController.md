# TabbedPaneController

*Decompiled from `PavonisInteractive/TerraInvicta/TabbedPaneController.cs`.*


## Class `TabbedPaneController`

```csharp
public class TabbedPaneController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `IsSelected` | public bool |
| `TabButton` | public Button |
| `tab` | private GameObject |
| `updateWhenShowingPane` | public UnityEvent |
| `updateWhenHidingPane` | public UnityEvent |
| `skipResize` | public bool |
| `paneCanvasGroup` | private CanvasGroup |
| `paneCanvas` | public Canvas |
| `paneRaycaster` | public GraphicRaycaster |
| `tabButton` | private Button |
| `tabButtonRT` | private RectTransform |
| `tabImage` | private Image |
| `originalSprite` | private Sprite |
| `activeTabHeightOffset` | public float |
| `menuDepth` | private float |
| `headerDepth` | private float |
| `itemDepth` | private float |
| `originalButtonHeight` | private float |
| `numItems` | private int |
| `activeTabSpriteAssetPath` | public string |

### Properties

- `public TabbedPaneManager paneManager`

### Methods

```csharp
public void Awake()
```

```csharp
public void Start()
```

```csharp
public void Show(bool update = true)
```

```csharp
public void SetSize(float menuDepth, float headerDepth, float itemDepth, int numItems)
```

```csharp
public void UpdateSize()
```

```csharp
public void Hide()
```
