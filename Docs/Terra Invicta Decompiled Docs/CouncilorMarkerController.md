# CouncilorMarkerController

*Decompiled from `PavonisInteractive/TerraInvicta/CouncilorMarkerController.cs`.*


## Class `CouncilorMarkerController`

```csharp
public class CouncilorMarkerController : SingleMarkerController
```

### Fields

| Name | Type |
|---|---|
| `friendlyCouncilorStack` | private List<TICouncilorState> |
| `enemyCouncilorStack` | private List<TICouncilorState> |
| `alienCouncilorStack` | private List<TICouncilorState> |
| `friendlyMarker` | public MarkerController |
| `friendlyCouncilors` | public List<TICouncilorState> |
| `topFriendlyCouncilor` | public TICouncilorState |
| `topFriendlyCouncilorIndex` | public int |
| `opposedMarker` | public MarkerController |
| `opposedCouncilors` | public List<TICouncilorState> |
| `topOpposedCouncilor` | public TICouncilorState |
| `topOpposedCouncilorIndex` | public int |
| `alienMarker` | public MarkerController |
| `alienCouncilors` | public List<TICouncilorState> |
| `topAlienCouncilor` | public TICouncilorState |
| `topAlienCouncilorIndex` | public int |
| `unwindStacks` | private bool |
| `targetingMode` | private bool |
| `orgTargetingMode` | private bool |
| `missionTemplate` | private TIMissionTemplate |
| `targetingCouncilor` | private TICouncilorState |
| `currentTargetList` | private List<TIGameState> |
| `individualMarkers` | public List<MarkerController> |
| `localCouncilors` | public List<TICouncilorState> |
| `orgMarkers` | public List<MarkerController> |
| `localOrgs` | public List<TIOrgState> |
| `targetedOrgMarker` | private MarkerController |
| `spaceObjectSelection` | private SpaceObjectSelection |
| `councilorDataDirty` | private bool |
| `updateRateInDays` | private int |
| `lastUpdateDate` | private TIDateTime |
| `newlyDiscoveredCouncilor` | private TICouncilorState |

### Methods

```csharp
public override void InitializeWithRegion(RegionController regionController, MarkerContainerController container)
```

```csharp
public void Update()
```

```csharp
public void TryUpdateMarker()
```

```csharp
public void UpdateMarker(MissionPhaseStart e)
```

```csharp
public void UpdateMarker(MapActivationChangedEvent e)
```

```csharp
public void UpdateMarker(CouncilorPositionUpdated e)
```

```csharp
public void UpdateMarker(CouncilorDepartsRegion e)
```

```csharp
public void OnEnable()
```

```csharp
public void UpdateMarker(CouncilorSelectedOffMap e)
```

```csharp
public void UpdateMarker(CouncilorVisibilityChanged e)
```

```csharp
public void UpdateMarker(CouncilorMissionUpdated e)
```

```csharp
public override void UpdateMarker()
```

```csharp
public void ShutDownAllTargetingAnimations()
```

```csharp
public void ActivateCouncilorTargets(TargetCouncilors e)
```

```csharp
public void DeactivateCouncilorTargets(DeTargetCouncilors e)
```

```csharp
public void DeactivateCouncilorTargets()
```

```csharp
public void OnCouncilorClickedDuringTargeting(CouncilorMapItemSelected e)
```

```csharp
public void DisableGroupMarkers()
```

```csharp
public void DisableIndividualMarkers()
```

```csharp
public void ShowIndividualCouncilors()
```

```csharp
public void OnIndividualCouncilorMarkerClicked(MarkerController controller)
```

```csharp
public void UpdateMarkerStacks()
```

```csharp
private void FrontNewFriendlyCouncilor()
```

```csharp
private void FrontNewOpposingCouncilor()
```

```csharp
private void FrontNewAlienCouncilor()
```

```csharp
private string SetStackTooltip(string tooltip)
```

```csharp
private string SetStackTooltip(IEnumerable<TICouncilorState> councilors)
```

```csharp
private void UpdateSuccessValue(MarkerController marker, TICouncilorState topCouncilorState)
```

```csharp
private void UpdateCouncilorStackMarker(MarkerController marker, TICouncilorState topCouncilorState, List<TICouncilorState> councilorsInStack, int councilorCount)
```

```csharp
private void UpdateFriendlyCouncilorMarkerStackData()
```

```csharp
private void UpdateOpposedCouncilorMarkerStackData()
```

```csharp
private void UpdateAlienCouncilorMarkerStackData()
```

```csharp
private void OnCouncilorStackButtonClick(MarkerController controller)
```

```csharp
private void OnCouncilorAssetDeselected(CurrentAssetDeSelected e)
```

```csharp
private void OnCouncilorOtherStateDeselected(CurrentOtherStateDeselected e)
```

```csharp
private void ActivateOrgTargets(TargetOrgs e)
```

```csharp
private void DeactivateOrgTargets(DeTargetOrgs e)
```

```csharp
public void OnOrgMarkerClicked(MarkerController controller)
```

```csharp
public void OnOrgTargetSelected(OrgSelectedEvent e)
```
