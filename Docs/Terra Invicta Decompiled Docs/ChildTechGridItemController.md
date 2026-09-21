# ChildTechGridItemController

*Decompiled from `PavonisInteractive/TerraInvicta/ChildTechGridItemController.cs`.*


## Class `ChildTechGridItemController`

```csharp
public class ChildTechGridItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private ResearchScreenController |
| `techNameString` | public string |
| `tech` | public TIGenericTechTemplate |
| `techName` | public TMP_Text |
| `techStatus` | public TMP_Text |
| `techUnlockOrProgressText` | public TMP_Text |
| `gradientImage` | public Image |
| `techIcon` | public Image |
| `lockIcon` | public Image |
| `projectIcon` | public Image |
| `checkIcon` | public Image |
| `xIcon` | public Image |
| `borderHighlightObject` | public GameObject |
| `targetHighlightObject` | public GameObject |
| `lineObjectPrefab` | public GameObject |
| `projectIconObject` | public GameObject |
| `techTooltip` | public TooltipTrigger |
| `toolTipString` | public string |
| `node` | public int |
| `visited` | public bool |
| `connectionLines` | public List<GameObject> |
| `enablesList` | public List<GameObject> |
| `prereqList` | public List<GameObject> |
| `altPrereq0` | public GameObject |
| `altPrereq1` | public GameObject |
| `connectionsTarget` | public List<Vector2> |
| `connectionList` | public List<string> |
| `connectionInit` | public bool |
| `connectionTarget` | public Vector2 |
| `prereqY` | public float |
| `hidden` | public bool |
| `showLines` | public bool |
| `imageLoaded` | public bool |
| `selected` | public bool |
| `cachedColors` | public List<Color> |

### Methods

```csharp
public void Init(ResearchScreenController controller, TIGenericTechTemplate tech)
```

```csharp
public void UpdateGridItem()
```

```csharp
public void UpdateTooltip()
```

```csharp
public void OnGridItemClicked()
```

```csharp
public void OnClickFullTechItem(bool baseTechOverride)
```

```csharp
public void SelectFullTechItem(bool baseTechOverride = false)
```

```csharp
public void OnMouseEnter()
```

```csharp
public void OnMouseExit()
```

```csharp
public void OnRightClickTechItem()
```

```csharp
private void OpenSelectiveTechTreeFromRightClick()
```

```csharp
public IEnumerator OpenSelectiveTechTree()
```

```csharp
public void ToggleActiveLineColor(GameObject connection, bool downstream = true, bool upstream = true, bool baseTechOverride = false)
```

```csharp
public IEnumerator SetOrangeLineColor(GameObject connection, bool downstream = true, bool upstream = true, bool baseTechOverride = false)
```

```csharp
public void ResetLineColors()
```

```csharp
public void ClearConnections()
```

```csharp
public void SetConnection(Vector2 targetPoint, GameObject targetObject)
```

```csharp
public IEnumerator DrawLine(Vector2 targetPoint, GameObject targetObject, bool categoryColor = false)
```
