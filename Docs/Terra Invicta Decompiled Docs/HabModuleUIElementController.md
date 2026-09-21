# HabModuleUIElementController

*Decompiled from `PavonisInteractive/TerraInvicta/HabModuleUIElementController.cs`.*


## Class `HabModuleUIElementController`

```csharp
public class HabModuleUIElementController : SpaceCombatAssetUIController
```

### Fields

| Name | Type |
|---|---|
| `hab` | private TIHabState |
| `canvas` | public Canvas |
| `moduleDisplayName` | public TMP_Text |
| `module` | private TIHabModuleState |
| `mainCamera` | private Camera |
| `moduleController` | private HabModuleController |
| `spaceObjectSelection` | private SpaceObjectSelection |
| `collider` | public BoxCollider |

### Methods

```csharp
public void SetController(HabModuleController moduleController)
```

```csharp
public void Initialize(TIHabModuleState module)
```

```csharp
public override void InitializeForCombat(CombatantController combatantController, CombatantListItemController combatantListItemController)
```

```csharp
private void OnEnable()
```

```csharp
private void OnDisable()
```

```csharp
private void OnMouseEnter()
```

```csharp
private void OnMouseOver()
```

```csharp
private void OnMouseExit()
```

```csharp
private void OnMouseUp()
```

```csharp
private void Update()
```
