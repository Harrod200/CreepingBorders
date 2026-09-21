# SpaceCombatDamageGridItemController

*Decompiled from `PavonisInteractive/TerraInvicta/SpaceCombat/UI/SpaceCombatDamageGridItemController.cs`.*


## Class `SpaceCombatDamageGridItemController`

```csharp
public class SpaceCombatDamageGridItemController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `damageIcon` | public Image |
| `damConIcon` | public Image |
| `damConDisabledIcon` | public Image |
| `damageDetailText` | public TooltipTrigger |
| `overlayText` | public TMP_Text |
| `recentDamageAnimatior` | public Animator |
| `ship` | private TISpaceShipState |
| `which` | private int |
| `coordinates` | public Vector2Int |

### Properties

- `public ShipSystem attachedSystem`
- `public ModuleDataEntry attachedModule`

### Methods

```csharp
private string damageIconStr(float damagePct)
```

```csharp
private string SetTooltip()
```

```csharp
public void PreInitialize(Vector2Int coordinates)
```

```csharp
public void Initialize()
```

```csharp
public void Clear()
```

```csharp
public void Initialize(TISpaceShipState ship, ShipSystem attachedSystem)
```

```csharp
public void Initialize(TISpaceShipState ship, ModuleDataEntry attachedModule)
```

```csharp
public void UpdateListItem()
```

```csharp
public void SetRepairStatus(bool value, bool isDamConSuspended)
```

```csharp
public void TookDamage(bool repaired)
```

```csharp
private void OnGameTimeSpeedChanged(GameTimeSpeedChanged e)
```

```csharp
private void OnDestroy()
```
