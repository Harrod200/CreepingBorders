# PolicyOptionWithTarget

*Decompiled from `PavonisInteractive/TerraInvicta/PolicyOptionWithTarget.cs`.*


## Class `PolicyOptionWithTarget`

```csharp
public class PolicyOptionWithTarget
```

### Fields

| Name | Type |
|---|---|
| `policy` | public TIPolicyOption |
| `CausesGuaranteedOneWayNationExpansion` | public bool |
| `GoallessImportance` | public int |
| `actingNation` | public TINationState |
| `policyType` | public PolicyType |
| `target` | public TIGameState |

### Methods

```csharp
public PolicyOptionWithTarget(TINationState actingNation, TIPolicyOption policy, TIGameState target)
```

```csharp
public PolicyOptionWithTarget(TINationState actingNation, PolicyType policyType, TIGameState target)
```

```csharp
public bool AllowAIToUseWithoutGoal()
```

```csharp
public bool SuperNationRelease()
```
