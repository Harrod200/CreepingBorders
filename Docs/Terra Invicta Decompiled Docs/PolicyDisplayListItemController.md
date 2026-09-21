# PolicyDisplayListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/PolicyDisplayListItemController.cs`.*


## Class `PolicyDisplayListItemController`

```csharp
public class PolicyDisplayListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `policyName` | public TMP_Text |
| `policyCandidates` | public TMP_Text |
| `policyNameContainer` | public GameObject |
| `policyCandidatesContainer` | public GameObject |
| `mainVerticalLayout` | public VerticalLayoutGroup |
| `candidatesVerticalLayout` | public VerticalLayoutGroup |
| `policyTip` | public TooltipTrigger |

### Methods

```csharp
public void SetListItem(TIPolicyOption policyOption, TINationState nationState)
```

```csharp
public void SetListItemAsCooldowns(TINationState nationState)
```

```csharp
public static string policyTipStr(TIPolicyOption policyOption, TINationState nationState)
```
