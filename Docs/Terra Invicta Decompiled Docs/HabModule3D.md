# HabModule3D

*Decompiled from `PavonisInteractive/TerraInvicta/Components/HabModule3D.cs`.*


## Class `HabModule3D`

```csharp
public class HabModule3D
```

### Fields

| Name | Type |
|---|---|
| `meshFilter` | public MeshFilter |
| `renderer` | public MeshRenderer |
| `N1` | public MeshRenderer |
| `N2` | public MeshRenderer |
| `W1` | public MeshRenderer |
| `W2` | public MeshRenderer |
| `S1` | public MeshRenderer |
| `S2` | public MeshRenderer |
| `E1` | public MeshRenderer |
| `E2` | public MeshRenderer |
| `moduleConnector` | public MeshRenderer |
| `animator` | public Animator |
| `explosionSequencePrefab` | public GameObject |
| `explosionSequenceInstance` | public GameObject |
| `sector` | public int |
| `moduleSlot` | public int |

### Methods

```csharp
public void Empty(TIHabModuleState module)
```

```csharp
public void SetMesh(TIHabModuleState module, bool alienStation)
```

```csharp
public void HideModule()
```

```csharp
public void SetAlienConnections()
```

```csharp
public void UpdateConnections(TIHabModuleState habModule, bool hide)
```
