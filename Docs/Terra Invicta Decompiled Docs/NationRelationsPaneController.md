# NationRelationsPaneController

*Decompiled from `PavonisInteractive/TerraInvicta/NationRelationsPaneController.cs`.*


## Class `NationRelationsPaneController`

```csharp
public class NationRelationsPaneController : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `nationsList` | public ListManagerBase |
| `nation` | private TINationState |
| `unaligned` | private bool |
| `initialized` | private bool |
| `controller` | public NationInfoController |

### Properties

- `public TIFactionState faction`

### Methods

```csharp
public void SetFactionAndNation(TIFactionState faction, TINationState nation, NationInfoController mainController)
```

```csharp
public void OnEnable()
```

```csharp
public void SetNationsList()
```

```csharp
public void UpdateNationRelationsList()
```

```csharp
public bool Allof(RelationChange change)
```
