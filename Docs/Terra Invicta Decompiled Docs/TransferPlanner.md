# TransferPlanner

*Decompiled from `PavonisInteractive/TerraInvicta/TransferPlanner.cs`.*


## Class `TransferPlanner`

```csharp
public class TransferPlanner : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Origin` | public ITransferTarget |
| `Destination` | public ITransferTarget |
| `CanParseAcceleration` | public bool |
| `Acceleration` | public float |
| `CanParseDV` | public bool |
| `DV` | public float |
| `CanParseDeparture` | public bool |
| `minDaysToDeparture` | public float |
| `tabbedPaneController` | public TabbedPaneController |
| `targetSelectionTool` | public TargetSelectionTool |
| `thrustProfileTool` | public ThrustProfileTool |
| `originButton` | public TransferPlannerLocationButton |
| `destinationButton` | public TransferPlannerLocationButton |
| `accelerationInputField` | public TMP_InputField |
| `dvInputField` | public TMP_InputField |
| `departureInputField` | public TMP_InputField |
| `headerLabel` | public TMP_Text |
| `originLabel` | public TMP_Text |
| `destinationLabel` | public TMP_Text |
| `accelerationLabel` | public TMP_Text |
| `accelerationUnits` | public TMP_Text |
| `dvLabel` | public TMP_Text |
| `dvUnits` | public TMP_Text |
| `departureLabel` | public TMP_Text |
| `departureUnits` | public TMP_Text |
| `thrustProfileHeaderLabel` | public TMP_Text |
| `transferWaypointPanels` | public GameObject[] |
| `transferWaypointArrows` | public GameObject[] |
| `OnNextClose` | public Action |
| `maxInputLength` | private const int |

### Methods

```csharp
private void Awake()
```

```csharp
private void Update()
```

```csharp
public void UpdateThrustProfile()
```

```csharp
public void OnHideTab()
```

```csharp
private void InitializeLocalization()
```
