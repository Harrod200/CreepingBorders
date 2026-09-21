# HumanHabPlanner

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/HumanHabPlanner.cs`.*


## Class `HumanHabPlanner`

```csharp
public class HumanHabPlanner : HabPlanner
```

### Fields

| Name | Type |
|---|---|
| `nextTargetOrderCount` | public static Dictionary<TIFactionState, int> |
| `ExpansionType` | private enum |

### Methods

```csharp
private IEnumerable<TISpaceBodyState> GetHighStrategicValueSpaceBodies(TIFactionState faction)
```

```csharp
private void ManageProspectGoals(TIFactionState faction)
```

```csharp
private bool ShouldExpand(TIFactionState faction, HumanHabPlanner.ExpansionType expansionType)
```

```csharp
private bool ShouldPerformHabUpgrades(TIFactionState faction)
```

```csharp
private void ManageFoundGoals(TIFactionState faction)
```

```csharp
public override void ManageHabGoals(TIFactionState faction)
```

```csharp
public override void FoundHabs(TIFactionState faction)
```

```csharp
public static void ManageMineNetwork(TIFactionState faction)
```

```csharp
public override void ManageHabs(TIFactionState faction)
```

```csharp
public void BuildHabModules(TIFactionState faction)
```
