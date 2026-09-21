# fsPrimitiveConverter

*Decompiled from `FullSerializer/Internal/fsPrimitiveConverter.cs`.*


## Class `fsPrimitiveConverter`

```csharp
public class fsPrimitiveConverter : fsConverter
```

### Methods

```csharp
public override bool CanProcess(Type type)
```

```csharp
public override bool RequestCycleSupport(Type storageType)
```

```csharp
public override bool RequestInheritanceSupport(Type storageType)
```

```csharp
private static bool UseBool(Type type)
```

```csharp
private static bool UseInt64(Type type)
```

```csharp
private static bool UseDouble(Type type)
```

```csharp
private static bool UseString(Type type)
```

```csharp
public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
```

```csharp
public override fsResult TryDeserialize(fsData storage, ref object instance, Type storageType)
```
