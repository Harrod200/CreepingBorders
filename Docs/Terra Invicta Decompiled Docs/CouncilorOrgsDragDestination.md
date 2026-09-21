# CouncilorOrgsDragDestination

*Decompiled from `PavonisInteractive/TerraInvicta/UI/CouncilorOrgsDragDestination.cs`.*


## Class `CouncilorOrgsDragDestination`

```csharp
public class CouncilorOrgsDragDestination : DragDestination
```

### Fields

| Name | Type |
|---|---|
| `_councilorController` | private CouncilGridController |
| `councilor` | private TICouncilorState |
| `organizer` | public bool |

### Methods

```csharp
public override void SetControllerBase(CanvasControllerBase canvasControllerBase)
```

```csharp
public void SetCouncilor(TICouncilorState councilor, CouncilGridController gridController)
```

```csharp
public override void OnDrop(PointerEventData eventData)
```

```csharp
protected override bool CanDropItemHere()
```
