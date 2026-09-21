# FactionView

*Decompiled from `PavonisInteractive/TerraInvicta/FactionView.cs`.*


## Struct `FactionView`

```csharp
public struct FactionView
```

### Fields

| Name | Type |
|---|---|
| `showLeader` | public bool |
| `leader` | public string |
| `fullLeader` | public string |
| `goal` | public string |
| `knownUnassignedOrgsPool` | public List<TIOrgState> |
| `victory` | public string |
| `currentProjectProgress` | public List<ProjectProgress> |
| `completedProjectsDistinct` | public List<TIProjectTemplate> |
| `availableProjects` | public List<TIProjectTemplate> |
| `playerFaction` | private readonly TIFactionState |
| `faction` | private readonly TIFactionState |

### Methods

```csharp
public FactionView(TIFactionState faction, TIFactionState playerFaction)
```

```csharp
public List<TIObjectiveTemplate> GetObjectives(ObjectiveType objectiveType, ObjectiveStatus status)
```

```csharp
public string GetResourceString(FactionResource resource)
```
