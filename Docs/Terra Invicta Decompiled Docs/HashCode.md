# HashCode

*Decompiled from `System/HashCode.cs`.*


## Struct `HashCode`

```csharp
public struct HashCode
```

### Fields

| Name | Type |
|---|---|
| `s_seed` | private static readonly uint |
| `Prime1` | private const uint |
| `Prime2` | private const uint |
| `Prime3` | private const uint |
| `Prime4` | private const uint |
| `Prime5` | private const uint |
| `_v1` | private uint |
| `_v2` | private uint |
| `_v3` | private uint |
| `_v4` | private uint |
| `_queue1` | private uint |
| `_queue2` | private uint |
| `_queue3` | private uint |
| `_length` | private uint |

### Methods

```csharp
private static uint GenerateGlobalSeed()
```

```csharp
public static int Combine<T1>(T1 value1)
```

```csharp
public static int Combine<T1, T2>(T1 value1, T2 value2)
```

```csharp
public static int Combine<T1, T2, T3>(T1 value1, T2 value2, T3 value3)
```

```csharp
public static int Combine<T1, T2, T3, T4>(T1 value1, T2 value2, T3 value3, T4 value4)
```

```csharp
public static int Combine<T1, T2, T3, T4, T5>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5)
```

```csharp
public static int Combine<T1, T2, T3, T4, T5, T6>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6)
```

```csharp
public static int Combine<T1, T2, T3, T4, T5, T6, T7>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7)
```

```csharp
public static int Combine<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value1, T2 value2, T3 value3, T4 value4, T5 value5, T6 value6, T7 value7, T8 value8)
```

```csharp
private static uint Rol(uint value, int count)
```

```csharp
private static void Initialize(out uint v1, out uint v2, out uint v3, out uint v4)
```

```csharp
private static uint Round(uint hash, uint input)
```

```csharp
private static uint QueueRound(uint hash, uint queuedValue)
```

```csharp
private static uint MixState(uint v1, uint v2, uint v3, uint v4)
```

```csharp
private static uint MixEmptyState()
```

```csharp
private static uint MixFinal(uint hash)
```

```csharp
public void Add<T>(T value)
```

```csharp
public void Add<T>(T value, IEqualityComparer<T> comparer)
```

```csharp
private void Add(int value)
```

```csharp
public int ToHashCode()
```

```csharp
public override int GetHashCode()
```

```csharp
public override bool Equals(object obj)
```
