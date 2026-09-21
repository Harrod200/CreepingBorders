# OperationData

*Decompiled from `OperationData.cs`.*


## Class `OperationData`

```csharp
public class OperationData
```

### Fields

| Name | Type |
|---|---|
| `operation` | public IOperation |
| `_operation` | private IOperation |

### Properties

- `public string operationDataName`
- `public TIGameState target`
- `public TIDateTime startDate`
- `public TIDateTime completionDate`

### Methods

```csharp
public OperationData(IOperation operation, TIGameState target, TIDateTime startDate, TIDateTime completionDate)
```

```csharp
public void OnOperationCancel(TIGameState actorState)
```

```csharp
public void Reschedule(TIDateTime newTime)
```

```csharp
public void ChangeTarget(TIGameState newTarget)
```

```csharp
public void RepairOperation(string operationDataName)
```
