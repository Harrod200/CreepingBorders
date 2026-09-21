# GraphUI

*Decompiled from `PavonisInteractive/TerraInvicta/GraphUI.cs`.*


## Class `GraphUI`

```csharp
public class GraphUI : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `OrderedTargets` | private IEnumerable<TIGameState> |
| `OrderedAttributes` | private IEnumerable<string> |
| `Target` | public TIGameState |
| `Attribute` | public string |
| `TargetDropDown` | public TMP_Dropdown |
| `AttributeDropdown` | public TMP_Dropdown |
| `YLabel` | public TMP_Text |
| `XMark0` | public GameObject |
| `YMark0` | public GameObject |
| `XMarkResolution` | public int |
| `XStride` | public int |
| `YMarkResolution` | public int |
| `YStride` | public int |
| `Resolution` | public int |
| `LineThickness` | public float |
| `AnimationSpeed` | public float |
| `XMarks` | private List<GameObject> |
| `YMarks` | private List<GameObject> |
| `LinePrefab` | public GameObject |
| `Lines` | private List<GameObject> |

### Methods

```csharp
private void Start()
```

```csharp
private void FillTargetDropdown()
```

```csharp
private void FillAttributeDropdown()
```

```csharp
private void SetLabels()
```

```csharp
private void Update()
```

```csharp
public void OnTargetChanged()
```

```csharp
public void OnAttributeChanged()
```
