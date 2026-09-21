# UnityEvent_Converter

*Decompiled from `FullSerializer/Internal/Converters/UnityEvent_Converter.cs`.*


## Class `UnityEvent_Converter`

```csharp
public class UnityEvent_Converter : fsConverter
```

### Methods

```csharp
public override bool CanProcess(Type type)
```

```csharp
public override bool RequestCycleSupport(Type storageType)
```

```csharp
public override fsResult TryDeserialize(fsData data, ref object instance, Type storageType)
```

```csharp
public override fsResult TrySerialize(object instance, out fsData serialized, Type storageType)
```
