# HabBuilding

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/Habs/HabBuilding.cs`.*


## Class `HabBuilding`

```csharp
public class HabBuilding : StrategyLayerComponentSystem, IHabBuilder
```

### Fields

| Name | Type |
|---|---|
| `habs` | private HabBuilding.HabGroup |
| `habBuilds` | private HabBuilding.HabBuildGroup |
| `oldNow` | private DateTime |
| `HabGroup` | public struct |
| `Length` | public readonly int |
| `GameObject` | public GameObjectArray |
| `Hab` | public ComponentArray<HabComponent> |
| `HabBuildGroup` | public struct |
| `Length` | public readonly int |
| `GameObject` | public GameObjectArray |
| `Hab` | public ComponentArray<HabComponent> |
| `HabBuild` | public ComponentArray<HabBuildComponent> |

### Methods

```csharp
public override void Initialize()
```

```csharp
protected override void OnUpdate()
```

```csharp
public void BuildHab(TIHabState habState)
```
