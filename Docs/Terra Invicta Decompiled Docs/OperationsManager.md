# OperationsManager

*Decompiled from `OperationsManager.cs`.*


## Class `OperationsManager`

```csharp
public static class OperationsManager
```

### Fields

| Name | Type |
|---|---|
| `armyOperations` | public static List<IOperation> |
| `fleetOperations` | public static List<IOperation> |
| `spaceOperations` | public static List<IOperation> |
| `nationOperations` | public static List<IOperation> |
| `operationsLookup` | public static Dictionary<Type, IOperation> |
| `AIArmyOperations` | public static List<IOperation> |
| `LegalArmyOperationsWhileMoving` | public static List<IOperation> |
| `CancelArmyOperation` | public static List<IOperation> |

### Methods

```csharp
public static void Initalize()
```
