# GameStateID

*Decompiled from `PavonisInteractive/TerraInvicta/GameStateID.cs`.*


## Struct `GameStateID`

```csharp
public struct GameStateID : IEquatable<GameStateID>, IEquatable<GameStateID?>, IEquatable<int>, IComparable<GameStateID>
```

### Fields

| Name | Type |
|---|---|
| `operator` | public static bool |
| `operator` | public static bool |
| `operator` | public static bool |
| `value` | private int |

### Methods

```csharp
public GameStateID(int value)
```

```csharp
public override int GetHashCode()
```

```csharp
public TIGameState GetState()
```

```csharp
public T GetState<T>(bool allowChild = false) where T : TIGameState
```

```csharp
public bool TryGetState<T>(out T state, bool allowChild = false) where T : TIGameState
```

```csharp
public bool Equals(GameStateID other)
```

```csharp
public bool Equals(GameStateID? other)
```

```csharp
public bool Equals(int otherValue)
```

```csharp
public override bool Equals(object obj)
```

```csharp
public int CompareTo(GameStateID other)
```

```csharp
public override string ToString()
```

```csharp
public static bool operator <(GameStateID lhs, GameStateID rhs)
```

```csharp
public static bool operator >(GameStateID lhs, GameStateID rhs)
```

```csharp
public static explicit operator int(GameStateID id)
```

```csharp
public static implicit operator GameStateID(int newValue)
```
