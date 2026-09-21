# TIHabSchematicTemplate

*Decompiled from `TIHabSchematicTemplate.cs`.*


## Class `TIHabSchematicTemplate`

```csharp
public class TIHabSchematicTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `DecisionArchetypes` | public IEnumerable<ArchetypeDecision.HabModuleArchetype> |
| `HabSchematic` | public HabSchematic |
| `decisions` | public List<string> |
| `preferences` | public HabPreferences |
| `factionDataName` | public string |
| `relativeValue` | public float |

### Methods

```csharp
public bool AvailableToFaction(TIFactionState faction)
```
