# EnemyShipListItemController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/UI/EnemyShipListItemController.cs`.*


## Class `EnemyShipListItemController`

```csharp
public class EnemyShipListItemController : CombatantListItemController
```

### Fields

| Name | Type |
|---|---|
| `primaryTargetImage` | public Image |
| `distanceToTargetTxt` | public TMP_Text |
| `targetingCombatant` | private CombatantController |
| `ySize` | public const float |
| `_addedCombatSecondListener` | private bool |

### Methods

```csharp
public override void Init(SpaceCombatCanvasController masterController, CombatantController combatantController, int position)
```

```csharp
public void OnListItemClicked()
```

```csharp
public override void OnDoubleClick()
```

```csharp
public void OnPrimaryTargetSelected()
```

```csharp
public void OnPlayerShipSelected()
```

```csharp
public void OnShipSelectionCleared()
```

```csharp
private void UpdateTargetDistance(CombatSecond e)
```

```csharp
private void ShowTargetDistance()
```

```csharp
public void ClearPrimaryTarget()
```

```csharp
public override void OnDisable()
```

```csharp
public override void OnDestroy()
```
