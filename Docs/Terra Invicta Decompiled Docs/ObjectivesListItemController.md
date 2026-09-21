# ObjectivesListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/ObjectivesListItemController.cs`.*


## Class `ObjectivesListItemController`

```csharp
public class ObjectivesListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private ObjectivesScreenController |
| `selectObjectiveButton` | public Button |
| `selectObjectiveButtonText` | public TMP_Text |
| `headerBackground` | public Image |
| `completedCheckmark` | public Image |
| `dividerLine` | public Image |
| `completedColor` | public Color32 |
| `heldObjective` | private TIObjectiveTemplate |
| `heldDataName` | private string |
| `heldFaction` | private TIFactionState |

### Methods

```csharp
public void Init(ObjectivesScreenController controller)
```

```csharp
public void UpdateObjectivesListItem(TIObjectiveTemplate objective, TIFactionState faction, bool completed = false, bool showDividerLine = true)
```

```csharp
public void UpdateHeaderListItem(ObjectiveType objectiveType, bool completed = false)
```

```csharp
public void OnLineClicked()
```
