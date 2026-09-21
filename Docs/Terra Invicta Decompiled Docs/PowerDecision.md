# PowerDecision

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/PowerDecision.cs`.*


## Class `PowerDecision`

```csharp
internal class PowerDecision : ArchetypeDecision
```

### Fields

| Name | Type |
|---|---|
| `cachedBestPowerModules` | private static Dictionary<ValueTuple<TIFactionState, TISpaceBodyState, int, bool>, TIHabModuleTemplate> |
| `bestPowerModulesCachedFrame` | private static int |

### Methods

```csharp
public PowerDecision()
```

```csharp
public override IEnumerable<TIHabModuleTemplate> Decide(TIFactionState faction, TIGameState location, HabSchematicOrder order)
```

```csharp
private TIHabModuleTemplate GetBestPowerModuleTemplate_Internal(TIFactionState faction, TIGameState location, HabSchematicOrder order)
```

```csharp
public static TIHabModuleTemplate GetBestPowerModuleTemplate(TIFactionState faction, TIGameState location, IEnumerable<TIHabModuleTemplate> existingModules = null)
```
