# PolicyTargetGridItemController

*Decompiled from `PavonisInteractive/TerraInvicta/PolicyTargetGridItemController.cs`.*


## Class `PolicyTargetGridItemController`

```csharp
public class PolicyTargetGridItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private NotificationScreenController |
| `targetName` | public TMP_Text |
| `targetNationFlag` | public Image |
| `heldTarget` | private TIGameState |
| `executiveFactionIcon` | public Image |
| `secondaryIcon` | public Image |

### Methods

```csharp
public void Init(NotificationScreenController controller)
```

```csharp
public void UpdateListItem(TIGameState target, TIPolicyOption policyOption, TIFactionState policyFaction, TINationState proposingNation)
```

```csharp
public void OnClicked()
```
