# OrgItemView

*Decompiled from `PavonisInteractive/TerraInvicta/OrgItemView.cs`.*


## Class `OrgItemView`

```csharp
public class OrgItemView : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Button` | private Button |
| `orgName` | public TMP_Text |
| `orgIcon` | public Image |
| `status` | public OrgItemView.OrgStatus |
| `tooltip` | public TooltipTrigger |
| `flagIcon` | public Image |
| `tierData` | public TMP_Text |
| `background` | public Image |
| `selectedSprite` | public Sprite |
| `button` | private Button |
| `newRibbon` | public Image |
| `councilorController` | public CouncilGridController |
| `org` | private TIOrgState |
| `canvasGroup` | private CanvasGroup |
| `dragDestination` | private DragDestination |
| `OrgStatus` | public enum |

### Methods

```csharp
public void UpdateOrgItem(TIOrgState org, TICouncilorState councilor)
```

```csharp
private bool IsAssignable(TICouncilorState councilor)
```

```csharp
private void SetAssignable(TICouncilorState councilor)
```

```csharp
private void SetStatus()
```

```csharp
public TIOrgState GetOrg()
```

```csharp
public void OnLeftClickItem()
```

```csharp
public void OnRightClickItem()
```

```csharp
public void SetButtonHighlight(bool highlight)
```
