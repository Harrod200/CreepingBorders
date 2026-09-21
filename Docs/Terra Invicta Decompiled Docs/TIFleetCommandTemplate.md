# TIFleetCommandTemplate

*Decompiled from `TIFleetCommandTemplate.cs`.*


## Class `TIFleetCommandTemplate`

```csharp
public abstract class TIFleetCommandTemplate : TIDataTemplate, IFleetCommand
```

### Methods

```csharp
public virtual string GetDisplayName(bool isGroupCommand = false)
```

```csharp
public virtual string GetDescription(bool isGroupCommand = false)
```

```csharp
public virtual string GetTooltipText(bool isGroupCommand = false)
```

```csharp
public abstract int IconPosition()
```

```csharp
public virtual string CommandIconImagePath()
```

```csharp
public virtual string GetCommandIconImagePath_On()
```

```csharp
public virtual string GetCommandIconImagePath_Off()
```

```csharp
public virtual bool RequiresTarget()
```

```csharp
public TIFleetCommandTemplate GetTemplate()
```

```csharp
public abstract TIShipCommandTemplate GetShipCommandTemplate()
```

```csharp
public virtual bool CommandVisibleToPlayer(List<TISpaceShipState> playerShips)
```

```csharp
public virtual bool PlayerCanIssueCommand(List<TISpaceShipState> playerShips)
```

```csharp
public virtual List<TISpaceShipState> GetEligibleShips(List<TISpaceShipState> playerShips)
```

```csharp
public TIFleetCommandTemplate()
```

```csharp
public virtual void OnExecuteFleetCommand(List<TISpaceShipState> playerShips, CombatTargetableState target = null)
```
