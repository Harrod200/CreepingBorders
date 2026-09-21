# IntelWarsListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/IntelWarsListItemController.cs`.*


## Class `IntelWarsListItemController`

```csharp
public class IntelWarsListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `warName` | public TMP_Text |
| `warActiveText` | public TMP_Text |
| `warDurationText` | public TMP_Text |
| `attackerLeaderNation` | public TMP_Text |
| `defenderLeaderNation` | public TMP_Text |
| `attackerFactionObject` | public GameObject |
| `attackerFactionIcon` | public Image |
| `attackerNuclearObject` | public GameObject |
| `attackerNavalObject` | public GameObject |
| `attackerArmiesObject` | public GameObject |
| `attackerArmiesText` | public TMP_Text |
| `defenderFactionObject` | public GameObject |
| `defenderFactionIcon` | public Image |
| `defenderNuclearObject` | public GameObject |
| `defenderNavalObject` | public GameObject |
| `defenderArmiesObject` | public GameObject |
| `defenderArmiesText` | public TMP_Text |
| `attackerFlagsList` | public ListManagerBase |
| `defenderFlagsList` | public ListManagerBase |
| `attackerFlagsLayout` | public HorizontalLayoutGroup |
| `defenderFlagsLayout` | public HorizontalLayoutGroup |

### Methods

```csharp
public void SetListItem(TIWarState warData)
```

```csharp
public int GetFlagSpacing(int allianceSize)
```
