# NotADecision

*Decompiled from `PavonisInteractive/TerraInvicta/Tasks/NotADecision.cs`.*


## Class `NotADecision`

```csharp
public class NotADecision : HabSchematicDecision
```

### Properties

- `public TIHabModuleTemplate HabModuleTemplate`
- `public bool CheckForValidity`

### Methods

```csharp
public NotADecision(TIHabModuleTemplate habModuleTemplate, bool checkForValidity)
```

```csharp
public override IEnumerable<TIHabModuleTemplate> Decide(TIFactionState faction, TIGameState location, HabSchematicOrder order)
```
