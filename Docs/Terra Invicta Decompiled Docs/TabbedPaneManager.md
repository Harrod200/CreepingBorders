# TabbedPaneManager

*Decompiled from `PavonisInteractive/TerraInvicta/TabbedPaneManager.cs`.*


## Class `TabbedPaneManager`

```csharp
public class TabbedPaneManager : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `tabs` | public IEnumerable<TabbedPaneController> |
| `initialActiveTab` | public GameObject |
| `tabVerticalSpacing` | public float |
| `reclickToHide` | public bool |
| `originalDepth` | private float |
| `rt` | private RectTransform |

### Properties

- `public TabbedPaneController activeTab`

### Methods

```csharp
private void Awake()
```

```csharp
private void Start()
```

```csharp
public void Toggle(TabbedPaneController tabbedPane)
```

```csharp
public void ClearActiveTab()
```

```csharp
public void Resize(float menuDepth, float headerDepth, float itemDepth, int items)
```

```csharp
public void Resize()
```
