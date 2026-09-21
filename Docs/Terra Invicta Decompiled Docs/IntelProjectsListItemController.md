# IntelProjectsListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/IntelProjectsListItemController.cs`.*


## Class `IntelProjectsListItemController`

```csharp
public class IntelProjectsListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `projectName` | public TMP_Text |
| `weightSprite` | public Image |
| `stealable` | public Image |

### Methods

```csharp
public void SetListItem(TIProjectTemplate project, bool inProgress, bool currentWork, int weight, float accumulatedResearch = 0f, float researchCost = 1f, List<TIProjectTemplate> stealableProjects = null, List<TIProjectTemplate> sabotageProjects = null)
```
