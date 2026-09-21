# TIPolicyOptionWithConfirm

*Decompiled from `TIPolicyOptionWithConfirm.cs`.*


## Class `TIPolicyOptionWithConfirm`

```csharp
public abstract class TIPolicyOptionWithConfirm : TIPolicyOption
```

### Properties

- `public abstract string PromptName`

### Methods

```csharp
public override bool RequiresTargetConfirm()
```

```csharp
public abstract float AIAgreeChance(TINationState proposingNation, TIGameState respondingState)
```

```csharp
public virtual float AIAgreeChance_Prospective(TINationState proposingNation, TIGameState respondingState)
```

```csharp
public override void OnConfirm(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public virtual void PromptPolicyResponse(TINationState enactingNation, TIGameState policyTarget)
```

```csharp
public override bool Allowed(TINationState nationState)
```
