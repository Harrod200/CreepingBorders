# ArchetypeDecision

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/ArchetypeDecision.cs`.*


## Class `ArchetypeDecision`

```csharp
public class ArchetypeDecision : HabSchematicDecision
```

### Fields

| Name | Type |
|---|---|
| `Archetypes` | public static IEnumerable<ArchetypeDecision.HabModuleArchetype> |
| `HumanOutpostCore` | public static TIHabModuleTemplate |
| `HumanOutpostMine` | public static TIHabModuleTemplate |
| `templatesByArchetype` | private static Dictionary<ArchetypeDecision.HabModuleArchetype, List<TIHabModuleTemplate>> |
| `HabModuleArchetype` | public enum |

### Properties

- `public ArchetypeDecision.HabModuleArchetype Archetype`
- `public bool ReturnAllMatches`

### Methods

```csharp
public ArchetypeDecision(ArchetypeDecision.HabModuleArchetype archetype, bool returnAllMatches = false)
```

```csharp
public ArchetypeDecision()
```

```csharp
public override IEnumerable<TIHabModuleTemplate> Decide(TIFactionState faction, TIGameState location, HabSchematicOrder order)
```

```csharp
public static IEnumerable<TIHabModuleTemplate> GetTemplatesWithinArchetype(ArchetypeDecision.HabModuleArchetype archetype)
```

```csharp
public static void ClearTemplates()
```
