# FactionToggleListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/FactionToggleListItemController.cs`.*


## Class `FactionToggleListItemController`

```csharp
public class FactionToggleListItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `factionNameText` | public TMP_Text |
| `factionToggle` | public Toggle |
| `faction` | public TIFactionTemplate |
| `controller` | private StartMenuController |

### Methods

```csharp
public void Init(TIFactionTemplate template, TIFactionTemplate selectedPlayerFaction, StartMenuController controller)
```

```csharp
public void UpdateItem(TIFactionTemplate currentSelectedFaction)
```

```csharp
public void UpdateForDefaultFactions(List<TIFactionTemplate> factionsInScenario)
```

```csharp
public void OnUpdateToggle()
```
