# Prompt

*Decompiled from `PavonisInteractive/TerraInvicta/Prompt.cs`.*


## Struct `Prompt`

```csharp
public struct Prompt : IEquatable<Prompt>
```

### Fields

| Name | Type |
|---|---|
| `operator` | public static bool |

### Properties

- `public TIGameState actingState`
- `public TIGameState promptingGameState`
- `public TIGameState relatedGameState`
- `public string name`
- `public int value`

### Methods

```csharp
public Prompt(TIGameState actingState, TIGameState promptingGameState, TIGameState relatedGameState, string name, int value)
```

```csharp
public override string ToString()
```

```csharp
public bool Equals(Prompt other)
```

```csharp
public override bool Equals(object obj)
```

```csharp
public override int GetHashCode()
```
