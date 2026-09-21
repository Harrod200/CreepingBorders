# IntelCouncilorListItem

*Decompiled from `PavonisInteractive/TerraInvicta/IntelCouncilorListItem.cs`.*


## Class `IntelCouncilorListItem`

```csharp
public class IntelCouncilorListItem : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `councilorName` | public TMP_Text |
| `councilorJob` | public TMP_Text |
| `missionIcon` | public Image |
| `location` | public TMP_Text |
| `tooltip` | public TooltipTrigger |
| `councilor` | private TICouncilorState |
| `parentController` | private IntelScreenController |

### Methods

```csharp
public void Initialize(TICouncilorState councilor, IntelScreenController parentController)
```

```csharp
public void UpdateListItem()
```

```csharp
public void OnIntelCouncilorListItemClicked()
```
