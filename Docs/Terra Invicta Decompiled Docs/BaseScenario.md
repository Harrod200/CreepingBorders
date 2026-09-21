# BaseScenario

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/Bootstrap/BaseScenario.cs`.*


## Class `BaseScenario`

```csharp
public abstract class BaseScenario : IScenario
```

### Fields

| Name | Type |
|---|---|
| `scenarioTemplateName` | public virtual string |

### Properties

- `public virtual TIMetaTemplate scenarioTemplate`
- `public TIFactionTemplate activePlayerFaction`

### Methods

```csharp
public bool OnStartScene()
```

```csharp
public virtual bool Initialize()
```

```csharp
public void SetActivePlayerFaction(TIFactionTemplate faction)
```
