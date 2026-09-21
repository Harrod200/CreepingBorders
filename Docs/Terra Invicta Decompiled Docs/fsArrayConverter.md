# fsArrayConverter

*Decompiled from `FullSerializer/Internal/fsArrayConverter.cs`.*


## Class `fsArrayConverter`

```csharp
public class fsArrayConverter : fsConverter
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
public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
```

```csharp
public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
```

```csharp
public override object CreateInstance(fsData data, Type storageType)
```
