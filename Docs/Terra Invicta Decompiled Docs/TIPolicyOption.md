# TIPolicyOption

*Decompiled from `TIPolicyOption.cs`.*


## Class `TIPolicyOption`

```csharp
public abstract class TIPolicyOption : TIDataTemplate, IPolicyOption
```

### Fields

| Name | Type |
|---|---|
| `EnactAgainstRelatedState` | public virtual bool |
| `TargetsMyFederation` | public virtual bool |
| `relationChange` | public virtual RelationChange |

### Methods

```csharp
public abstract PolicyType GetPolicyType()
```

```csharp
public string GetDisplayName()
```

```csharp
public virtual string GetDescription()
```

```csharp
public string GetTargetSelectionHeaderText()
```

```csharp
public string templateName()
```

```csharp
public virtual string GetResponsePrompt(TINationState policyNation, TINationState respondingNation, TIGameState policyTarget)
```

```csharp
public virtual string GetConfirmPrompt(TINationState enactingNation, TIGameState target)
```

```csharp
public abstract IList<TIGameState> GetPossibleTargets(TINationState policyNation)
```

```csharp
public abstract void OnPassage(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public virtual bool Allowed(TINationState nationState)
```

```csharp
public virtual bool RequiresTargets()
```

```csharp
public virtual bool RequiresTargetConfirm()
```

```csharp
public virtual bool DegradesRelations()
```

```csharp
public virtual bool ImprovesRelations()
```

```csharp
public virtual bool WeakensNation()
```

```csharp
public virtual bool HasTooltip()
```

```csharp
public virtual string GetTooltipString()
```

```csharp
public virtual bool HandledAtFactionLevel()
```

```csharp
public TIPolicyOption()
```

```csharp
public virtual void OnConfirm(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public virtual void EnactPolicy(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public virtual void DeclinePolicy(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public virtual int Importance(TINationState policyNation, TIGameState target)
```
