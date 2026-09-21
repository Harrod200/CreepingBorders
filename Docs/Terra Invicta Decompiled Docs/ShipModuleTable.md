# ShipModuleTable

*Decompiled from `PavonisInteractive/TerraInvicta/UI/Canvas_Prefabs/FleetsScreen/ShipModuleTable.cs`.*


## Class `ShipModuleTable`

```csharp
public class ShipModuleTable : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `rows` | public IEnumerable<ShipModuleListItem> |
| `rowsAndLabels` | public IEnumerable<ShipModuleListItem> |
| `labels` | public ShipModuleListItem |
| `rowsContainer` | public Transform |
| `canvas` | public Canvas |
| `cachedContainerWidth` | private float |

### Methods

```csharp
private void Update()
```

```csharp
public void ForceUpdateRefreshColumnWidths()
```

```csharp
public void ResizeColumns()
```
