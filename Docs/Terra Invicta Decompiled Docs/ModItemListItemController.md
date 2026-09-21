# ModItemListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/ModItemListItemController.cs`.*


## Class `ModItemListItemController`

```csharp
public class ModItemListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `controller` | private ModMenuController |
| `modName` | public TMP_Text |
| `modDesc` | public TMP_Text |
| `modStatusText` | public TMP_Text |
| `modEnableText` | public TMP_Text |
| `modDisableText` | public TMP_Text |
| `modDeleteText` | public TMP_Text |
| `modWorkshopText` | public TMP_Text |
| `modEnableButton` | public Button |
| `modDisableButton` | public Button |
| `modDeleteButton` | public Button |
| `enabledImage` | public Image |
| `modStatus` | public ModItemListItemController.ModStatus |
| `ModStatus` | public enum |

### Methods

```csharp
public void Init(ModMenuController controller)
```

```csharp
public void ItemSelected()
```

```csharp
public void OnClickDisable()
```

```csharp
public void OnClickEnable()
```

```csharp
public void OnClickDelete()
```

```csharp
public void UpdateListItem(ModItemListItemController.ModStatus modStatus, bool steamWorkshop = false)
```
