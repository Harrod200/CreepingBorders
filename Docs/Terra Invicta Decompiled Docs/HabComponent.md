# HabComponent

*Decompiled from `PavonisInteractive/TerraInvicta/Components/HabComponent.cs`.*


## Class `HabComponent`

```csharp
public class HabComponent : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `Value` | public Hab |
| `modules` | public Dictionary<string, HabModule3D> |
| `torusRenderers` | public MeshRenderer[] |
| `notBuilding` | public bool |
| `initialized` | private bool |
| `habModelController` | public HabModelController |
| `delay` | private readonly WaitForSeconds |

### Properties

- `public TIHabState hab`

### Methods

```csharp
public void InitStation()
```

```csharp
public void Initialize(TIHabState hab)
```

```csharp
private void UpdateModel(HabModuleConstructionStatusChange e)
```

```csharp
private void ModuleDestroyed(HabModuleDestroyed e)
```

```csharp
private IEnumerator UpdateModuleDelayed(HabModule3D module, TIHabModuleState state)
```

```csharp
private void UpdateModule(HabModule3D module, TIHabModuleState state)
```

```csharp
private void CacheHabModules()
```

```csharp
public void Update3DModel()
```

```csharp
private void UpdateDestructionVFX(TIHabModuleState habModule)
```

```csharp
private void EmptySector(int s)
```
