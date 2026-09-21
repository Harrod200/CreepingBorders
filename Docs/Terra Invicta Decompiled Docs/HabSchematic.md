# HabSchematic

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/HabSchematic.cs`.*


## Class `HabSchematic`

```csharp
public class HabSchematic
```

### Fields

| Name | Type |
|---|---|
| `Decisions` | public List<HabSchematicDecision> |
| `Preferences` | public HabPreferences |

### Properties

- `public TIHabSchematicTemplate Template`

### Methods

```csharp
public HabSchematic(TIHabSchematicTemplate template, HabPreferences preferences, params HabSchematicDecision[] decisions)
```

```csharp
public HabSchematic(params HabSchematicDecision[] decisions)
```

```csharp
public HabSchematic(IEnumerable<HabSchematicDecision> decisions, TIHabSchematicTemplate template = null, HabPreferences preferences = null)
```

```csharp
public HabSchematic(IEnumerable<HabSchematicDecision> decisions, TIHabSchematicTemplate template = null)
```

```csharp
public HabSchematic()
```

```csharp
public HabSchematicOrder GetOrder(TIFactionState faction, TIGameState location, bool useImagination = false, bool useExistingModules = true, IEnumerable<TIHabModuleTemplate> forcedModules = null)
```

```csharp
public static HabSchematic SelectHabSchematic(TIFactionState faction, TIGameState location, out HabSchematicOrder order, Func<FactionResource, float> GetMonthlyIncome = null)
```

```csharp
public static HabSchematic SelectHabSchematic(TIFactionState faction, TIGameState location, Func<FactionResource, float> GetMonthlyIncome = null)
```

```csharp
public static HabSchematicOrder GetOrderWithoutHabSchematic(TIFactionState faction, TIGameState location, Func<FactionResource, float> GetMonthlyIncome = null)
```
