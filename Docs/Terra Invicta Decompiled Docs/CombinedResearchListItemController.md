# CombinedResearchListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/CombinedResearchListItemController.cs`.*


## Class `CombinedResearchListItemController`

```csharp
public class CombinedResearchListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private ResearchScreenController |
| `selectTechButton` | public Button |
| `selectTechButtonText` | public TMP_Text |
| `techIcon` | public Image |
| `heldDataName` | public string |
| `backgroundImage` | public Image |
| `defaultBackground` | public Sprite |
| `selectedBackground` | public Sprite |

### Methods

```csharp
public void Init(ResearchScreenController controller)
```

```csharp
public void UpdateTechListItem(TITechTemplate template)
```

```csharp
public void UpdateProjectListItem(TIProjectTemplate template)
```

```csharp
public void OnLineClicked()
```

```csharp
public void SetSelected(bool selected)
```
