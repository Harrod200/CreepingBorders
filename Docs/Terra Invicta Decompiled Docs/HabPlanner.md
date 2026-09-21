# HabPlanner

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/HabPlanner.cs`.*


## Class `HabPlanner`

```csharp
public abstract class HabPlanner
```

### Fields

| Name | Type |
|---|---|
| `HumanHabPlanner` | public static HabPlanner |
| `AlienHabPlanner` | public static HabPlanner |

### Methods

```csharp
public static HabPlanner GetPlanner(TIFactionState faction)
```

```csharp
public static void ClearStaticData()
```

```csharp
public abstract void ManageHabGoals(TIFactionState faction)
```

```csharp
public abstract void FoundHabs(TIFactionState faction)
```

```csharp
public abstract void ManageHabs(TIFactionState faction)
```
