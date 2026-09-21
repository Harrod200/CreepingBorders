# TechsButtonListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/TechsButtonListItemController.cs`.*


## Class `TechsButtonListItemController`

```csharp
public class TechsButtonListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private ResearchScreenController |
| `SelectTechButton` | public Button |
| `SelectTechButtonText` | public TMP_Text |
| `SelectTechButtonImage` | public Image |
| `techTemplate` | public TITechTemplate |
| `categorySortWeight` | public float |
| `heldDataName` | public string |
| `backgroundImage` | public Image |
| `defaultBackground` | public Sprite |
| `selectedBackground` | public Sprite |

### Methods

```csharp
public void Init(ResearchScreenController controller)
```

```csharp
public void UpdateListItem(TITechTemplate template)
```

```csharp
public void OnLineClicked()
```

```csharp
public void SetSelected(bool selected)
```
