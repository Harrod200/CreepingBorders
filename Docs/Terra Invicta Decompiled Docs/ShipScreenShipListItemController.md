# ShipScreenShipListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/ShipScreenShipListItemController.cs`.*


## Class `ShipScreenShipListItemController`

```csharp
public class ShipScreenShipListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `shipName` | public TMP_Text |
| `className` | public TMP_Text |
| `fleetName` | public TMP_Text |
| `locationImage` | public Image |
| `factionImage` | public Image |
| `controller` | private FleetsScreenController |
| `button` | public Button |
| `defaultButtonSprite` | private Sprite |

### Properties

- `public TISpaceShipState ship`

### Methods

```csharp
public void SetListItem(TISpaceShipState ship, FleetsScreenController controller)
```

```csharp
public void UpdateNames(TISpaceShipState ship, FleetsScreenController controller)
```

```csharp
public void OnShipScreenListItemClicked()
```

```csharp
public void OnNewShipSelected(TISpaceShipState selectedShip)
```
