# HabSchematicDecision

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/HabSchematicDecision.cs`.*


## Class `HabSchematicDecision`

```csharp
public abstract class HabSchematicDecision
```

### Fields

| Name | Type |
|---|---|
| `Nothing` | protected static IEnumerable<TIHabModuleTemplate> |

### Methods

```csharp
public abstract IEnumerable<TIHabModuleTemplate> Decide(TIFactionState faction, TIGameState location, HabSchematicOrder order)
```

```csharp
protected static bool IsValidModule(TIFactionState faction, TIGameState location, TIHabModuleTemplate moduleTemplate, HabSchematicOrder order)
```

```csharp
protected static IEnumerable<TIHabModuleTemplate> InvalidModulesRemoved(TIFactionState faction, TIGameState location, IEnumerable<TIHabModuleTemplate> moduleTemplates, HabSchematicOrder order)
```
