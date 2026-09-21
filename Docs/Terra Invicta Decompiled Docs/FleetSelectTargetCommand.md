# FleetSelectTargetCommand

*Decompiled from `FleetSelectTargetCommand.cs`.*


## Class `FleetSelectTargetCommand`

```csharp
public class FleetSelectTargetCommand : TIFleetCommandTemplate, IFleetCommandWithTarget
```

### Fields

| Name | Type |
|---|---|
| `ships` | public List<TISpaceShipState> |

### Methods

```csharp
public override int IconPosition()
```

```csharp
public override TIShipCommandTemplate GetShipCommandTemplate()
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
public Type GetTargetingMethod()
```

```csharp
public void InitiateTargeting(List<TISpaceShipState> ships)
```

```csharp
public void EndTargeting(TIFactionState faction)
```
