# fsDictionaryConverter

*Decompiled from `FullSerializer/Internal/fsDictionaryConverter.cs`.*


## Class `fsDictionaryConverter`

```csharp
public class fsDictionaryConverter : fsConverter
```

### Methods

```csharp
public override bool CanProcess(Type type)
```

```csharp
public override object CreateInstance(fsData data, Type storageType)
```

```csharp
public override fsResult TryDeserialize(fsData data, ref object instance_, Type storageType)
```

```csharp
public override fsResult TrySerialize(object instance_, out fsData serialized, Type storageType)
```

```csharp
private fsResult AddItemToDictionary(IDictionary dictionary, object key, object value)
```

```csharp
private static void GetKeyValueTypes(Type dictionaryType, out Type keyStorageType, out Type valueStorageType)
```
