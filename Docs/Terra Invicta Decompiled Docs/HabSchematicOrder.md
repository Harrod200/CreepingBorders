# HabSchematicOrder

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/HabSchematicOrder.cs`.*


## Class `HabSchematicOrder`

```csharp
public class HabSchematicOrder : List<TIHabModuleTemplate>
```

### Properties

- `public HabPreferences Preferences`

### Methods

```csharp
public HabSchematicOrder(HabPreferences preferences = null, IEnumerable<TIHabModuleTemplate> habModuleTemplates = null)
```

```csharp
public float Score(TIFactionState faction, TIGameState location, Func<FactionResource, float> GetMonthlyIncome = null, bool onlyScoreNewModules = false, bool applyMetaAdjustment = true)
```

```csharp
public static float GetMetaScore(TIFactionState faction, float score, float productivity, int missionControlIncome, float spaceCombatStrength, float troopStrength)
```

```csharp
public float GetMetaScore(TIFactionState faction, float score)
```
