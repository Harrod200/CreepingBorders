# TIShipCommandTemplate

*Decompiled from `TIShipCommandTemplate.cs`.*


## Class `TIShipCommandTemplate`

```csharp
public abstract class TIShipCommandTemplate : TIDataTemplate, IShipCommand
```

### Fields

| Name | Type |
|---|---|
| `commandIconImagePath` | public string |
| `TriggersManeuver` | public virtual bool |

### Methods

```csharp
public string GetDisplayName()
```

```csharp
public virtual string GetDescription(TISpaceShipState ship = null)
```

```csharp
public virtual string GetTooltipText(TISpaceShipState ship = null)
```

```csharp
public abstract int IconPosition()
```

```csharp
public virtual string GetCommandIconImagePath_On()
```

```csharp
public string GetCommandIconImagePath_Off()
```

```csharp
public virtual bool RequiresTarget()
```

```csharp
public TIShipCommandTemplate GetTemplate()
```

```csharp
public virtual bool CommandVisibleToActor(TISpaceShipState ship)
```

```csharp
public virtual bool ActorCanPerformCommand(TISpaceShipState ship)
```

```csharp
public abstract void OnCommandExecute(TISpaceShipState ship, CombatTargetableState target = null)
```

```csharp
public virtual TIResourcesCost GetResourcesCost(TISpaceShipState ship)
```

```csharp
public TIShipCommandTemplate()
```

```csharp
public void OnExecuteCommand(TISpaceShipState ship)
```
