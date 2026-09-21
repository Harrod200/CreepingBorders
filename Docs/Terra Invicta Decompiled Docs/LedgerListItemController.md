# LedgerListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/LedgerListItemController.cs`.*


## Class `LedgerListItemController`

```csharp
public class LedgerListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `indent` | public GameObject |
| `icon` | public Image |
| `entryName` | public TMP_Text |
| `entryNameRect` | public RectTransform |
| `collapsable` | public bool |
| `associatedState` | public TIGameState |
| `associatedTemplate` | public TIDataTemplate |
| `parentGameState` | public TIGameState |
| `ledgerEntry` | public TMP_Text[] |
| `values` | public Dictionary<LedgerEntryCategory, float> |
| `collapseButton` | public Button |
| `parentController` | public CouncilGridController |

### Methods

```csharp
private void SetEntryLine(LedgerEntryCategory category, float value, bool inactive = false, bool cost = false, bool percent = false)
```

```csharp
private void SetEmptyLine(LedgerEntryCategory category)
```

```csharp
private void SetListItem_Common(TIGameState state, TIDataTemplate template, TIGameState masterState, bool collapsable)
```

```csharp
public void SetListItem(LedgerListItem_Data data, TIHabState hab)
```

```csharp
public void SetListItem(LedgerListItem_Data data, TIHabModuleState habModule)
```

```csharp
public void SetListItem(LedgerListItem_Data data, TIFactionState faction, int which)
```

```csharp
public void SetListItem(LedgerListItem_Data data, TISpaceFleetState fleet)
```

```csharp
public void SetListItem(LedgerListItem_Data data, TISpaceShipState ship)
```

```csharp
public void SetListItem(LedgerListItem_Data data, TINationState nation, TIFactionState faction)
```

```csharp
public void SetListItem(LedgerListItem_Data data, TICouncilorState councilor)
```

```csharp
public void SetListItem(LedgerListItem_Data data, TIOrgState org)
```

```csharp
public void SetListItem(LedgerListItem_Data data, TITraitTemplate trait, TICouncilorState councilor)
```

```csharp
public void OnClickTextButton()
```

```csharp
public void OnClickIconButton()
```
