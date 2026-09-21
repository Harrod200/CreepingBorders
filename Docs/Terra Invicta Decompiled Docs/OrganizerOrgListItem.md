# OrganizerOrgListItem

*Decompiled from `PavonisInteractive/TerraInvicta/OrganizerOrgListItem.cs`.*


## Class `OrganizerOrgListItem`

```csharp
public class OrganizerOrgListItem : DragItem
```

### Fields

| Name | Type |
|---|---|
| `orgIcon` | public Image |
| `orgName` | public TMP_Text |
| `orgDescription` | public TMP_Text |
| `orgTier` | public TMP_Text |
| `orgTooltip` | public TooltipTrigger |
| `orgStatus` | public OrganizerOrgListItem.OrgStatus |
| `org` | public TIOrgState |
| `newRibbon` | public Image |
| `parentDragContainer` | public OrganizerCouncilorListItem |
| `gridController` | public CouncilGridController |
| `OrgStatus` | public enum |

### Methods

```csharp
public void SetListItem(TIOrgState orgState, OrganizerOrgListItem.OrgStatus status, CouncilGridController controller, OrganizerCouncilorListItem parentContainer)
```

```csharp
public override void OnBeginDrag(PointerEventData eventData)
```

```csharp
public override void OnEndDrag(PointerEventData eventData)
```
