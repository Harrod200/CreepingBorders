# TIBilateralTemplate

*Decompiled from `TIBilateralTemplate.cs`.*


## Class `TIBilateralTemplate`

```csharp
public class TIBilateralTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `projectUnlock` | public TIProjectTemplate |
| `nationState1` | public TINationState |
| `nationState2` | public TINationState |
| `regionState1` | public TIRegionState |
| `regionState2` | public TIRegionState |
| `BilateralCanBeActive` | public bool |
| `relationType` | public BilateralRelationType |
| `federation` | public string |
| `nation1` | public string |
| `nation2` | public string |
| `region1` | public string |
| `region2` | public string |
| `projectUnlockName` | public string |
| `capitalClaim` | public bool |
| `initialOwner` | public bool |
| `initialColony` | public bool |
| `friendlyOnly` | public bool |
| `hostileClaim` | public bool |
| `_currentScenarioSet` | private bool |
| `_inCurrentScenario` | private bool |
| `_nationState1` | private TINationState |
| `_nationState2` | private TINationState |
| `_regionState1` | private TIRegionState |
| `_regionState2` | private TIRegionState |

### Methods

```csharp
public TIGameState CheckToCreateGameState()
```

```csharp
public bool BilateralIsInScenario()
```

```csharp
public bool BilateralIsInScenario_FromTemplates(List<TINationTemplate> nationsInScenario, List<string> completedProjects, bool includingGatedByTech)
```

```csharp
public bool BilateralIsActive()
```
