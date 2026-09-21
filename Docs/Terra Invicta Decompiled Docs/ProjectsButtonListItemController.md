# ProjectsButtonListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/ProjectsButtonListItemController.cs`.*


## Class `ProjectsButtonListItemController`

```csharp
public class ProjectsButtonListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private ResearchScreenController |
| `SelectProjectButton` | public Button |
| `SelectProjectButtonImage` | public Image |
| `SelectProjectButtonText` | public TMP_Text |
| `projectTemplate` | public TIProjectTemplate |
| `categorySortWeight` | public float |
| `obsoleteToggle` | public Toggle |
| `favoriteToggle` | public Toggle |
| `obsoleteIcon` | public Image |
| `favoriteIcon` | public Image |
| `obsoleteTooltip` | public TooltipTrigger |
| `favoriteTooltip` | public TooltipTrigger |
| `favorite_on` | public Sprite |
| `favorite_off` | public Sprite |
| `obsolete_on` | public Sprite |
| `obsolete_off` | public Sprite |
| `backgroundImage` | public Image |
| `defaultBackground` | public Sprite |
| `selectedBackground` | public Sprite |
| `heldDataName` | public string |

### Methods

```csharp
public void Init(ResearchScreenController controller)
```

```csharp
public void UpdateListItem(TIProjectTemplate template, TIFactionState faction)
```

```csharp
public void UpdateToggles(TIProjectTemplate template, TIFactionState faction)
```

```csharp
public void OnLineClicked()
```

```csharp
public void OnObsoleteToggle()
```

```csharp
public void OnFavoriteToggle()
```

```csharp
public void SetSelected(bool selected)
```
