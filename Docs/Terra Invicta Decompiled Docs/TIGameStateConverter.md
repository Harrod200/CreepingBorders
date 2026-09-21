# TIGameStateConverter

*Decompiled from `PavonisInteractive/TerraInvicta/TIGameStateConverter.cs`.*


## Class `TIGameStateConverter`

```csharp
public class TIGameStateConverter : fsReflectedConverter
```

### Fields

| Name | Type |
|---|---|
| `gamestates` | private static Dictionary<GameStateID, TIGameState> |
| `gameStateDepth` | private static int |

### Methods

```csharp
public static void Reset()
```

```csharp
public override object CreateInstance(fsData data, Type storageType)
```

```csharp
public override bool RequestCycleSupport(Type storageType)
```

```csharp
public override bool CanProcess(Type type)
```

```csharp
public fsResult DeserializeGameStateFromID(fsData data, ref object instance)
```

```csharp
public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
```

```csharp
public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
```
