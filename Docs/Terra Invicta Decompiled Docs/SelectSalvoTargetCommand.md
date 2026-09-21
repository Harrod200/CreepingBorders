# SelectSalvoTargetCommand

*Decompiled from `SelectSalvoTargetCommand.cs`.*


## Class `SelectSalvoTargetCommand`

```csharp
public class SelectSalvoTargetCommand : TIShipCommandTemplate, IShipCommandWithTarget
```

### Methods

```csharp
public override int IconPosition()
```

```csharp
public override bool ActorCanPerformCommand(TISpaceShipState ship)
```

```csharp
public override bool RequiresTarget()
```

```csharp
public bool IncludeFriendlyTargets()
```

```csharp
public bool OnlyFriendlyTargets()
```

```csharp
public override void OnCommandExecute(TISpaceShipState ship, CombatTargetableState target)
```

```csharp
public Type GetTargetingMethod()
```

```csharp
public void InitiateTargeting(TISpaceShipState ship)
```

```csharp
public void EndTargeting(TIFactionState faction)
```
