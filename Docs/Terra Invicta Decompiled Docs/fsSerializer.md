# fsSerializer

*Decompiled from `FullSerializer/fsSerializer.cs`.*


## Class `fsSerializer`

```csharp
public class fsSerializer
```

### Fields

| Name | Type |
|---|---|
| `_reservedKeywords` | private static HashSet<string> |
| `_cachedConverterTypeInstances` | private Dictionary<Type, fsBaseConverter> |
| `_cachedConverters` | private Dictionary<Type, fsBaseConverter> |
| `_cachedProcessors` | private Dictionary<Type, List<fsObjectProcessor>> |
| `_availableConverters` | private readonly List<fsConverter> |
| `_availableDirectConverters` | private readonly Dictionary<Type, fsDirectConverter> |
| `_processors` | private readonly List<fsObjectProcessor> |
| `_references` | private readonly fsCyclicReferenceManager |
| `_lazyReferenceWriter` | private readonly fsSerializer.fsLazyCycleDefinitionWriter |
| `_abstractTypeRemap` | private readonly Dictionary<Type, Type> |
| `Context` | public fsContext |
| `Config` | public fsConfig |
| `fsLazyCycleDefinitionWriter` | internal class |
| `_pendingDefinitions` | private Dictionary<int, fsData> |
| `_references` | private HashSet<int> |

### Properties

- `private static readonly string Key_ObjectReference = string.Format("`
- `private static readonly string Key_ObjectDefinition = string.Format("`
- `private static readonly string Key_InstanceType = string.Format("`
- `private static readonly string Key_Version = string.Format("`
- `private static readonly string Key_Content = string.Format("`

### Methods

```csharp
public static bool IsReservedKeyword(string key)
```

```csharp
private static bool IsObjectReference(fsData data)
```

```csharp
private static bool IsObjectDefinition(fsData data)
```

```csharp
private static bool IsVersioned(fsData data)
```

```csharp
private static bool IsTypeSpecified(fsData data)
```

```csharp
private static bool IsWrappedData(fsData data)
```

```csharp
public static void StripDeserializationMetadata(ref fsData data)
```

```csharp
private static void ConvertLegacyData(ref fsData data)
```

```csharp
private static void Invoke_OnBeforeSerialize(List<fsObjectProcessor> processors, Type storageType, object instance)
```

```csharp
private static void Invoke_OnAfterSerialize(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
```

```csharp
private static void Invoke_OnBeforeDeserialize(List<fsObjectProcessor> processors, Type storageType, ref fsData data)
```

```csharp
private static void Invoke_OnBeforeDeserializeAfterInstanceCreation(List<fsObjectProcessor> processors, Type storageType, object instance, ref fsData data)
```

```csharp
private static void Invoke_OnAfterDeserialize(List<fsObjectProcessor> processors, Type storageType, object instance)
```

```csharp
private static void EnsureDictionary(fsData data)
```

```csharp
private void RemapAbstractStorageTypeToDefaultType(ref Type storageType)
```

```csharp
public fsSerializer()
```

```csharp
public void AddProcessor(fsObjectProcessor processor)
```

```csharp
public void RemoveProcessor<TProcessor>()
```

```csharp
public void SetDefaultStorageType(Type abstractType, Type defaultStorageType)
```

```csharp
private List<fsObjectProcessor> GetProcessors(Type type)
```

```csharp
public void AddConverter(fsBaseConverter converter)
```

```csharp
private fsBaseConverter GetConverter(Type type, Type overrideConverterType)
```

```csharp
public fsResult TrySerialize<T>(T instance, out fsData data)
```

```csharp
public fsResult TryDeserialize<T>(fsData data, ref T instance)
```

```csharp
public fsResult TrySerialize(Type storageType, object instance, out fsData data)
```

```csharp
public fsResult TrySerialize(Type storageType, Type overrideConverterType, object instance, out fsData data)
```

```csharp
private fsResult InternalSerialize_1_ProcessCycles(Type storageType, Type overrideConverterType, object instance, out fsData data)
```

```csharp
private fsResult InternalSerialize_2_Inheritance(Type storageType, Type overrideConverterType, object instance, out fsData data)
```

```csharp
private fsResult InternalSerialize_3_ProcessVersioning(Type overrideConverterType, object instance, out fsData data)
```

```csharp
private fsResult InternalSerialize_4_Converter(Type overrideConverterType, object instance, out fsData data)
```

```csharp
public fsResult TryDeserialize(fsData data, Type storageType, ref object result)
```

```csharp
public fsResult TryDeserialize(fsData data, Type storageType, Type overrideConverterType, ref object result)
```

```csharp
private fsResult InternalDeserialize_1_CycleReference(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
```

```csharp
private fsResult InternalDeserialize_2_Version(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
```

```csharp
private fsResult InternalDeserialize_3_Inheritance(Type overrideConverterType, fsData data, Type storageType, ref object result, out List<fsObjectProcessor> processors)
```

```csharp
private fsResult InternalDeserialize_4_Cycles(Type overrideConverterType, fsData data, Type resultType, ref object result)
```

```csharp
private fsResult InternalDeserialize_5_Converter(Type overrideConverterType, fsData data, Type resultType, ref object result)
```

```csharp
public void WriteDefinition(int id, fsData data)
```

```csharp
public void WriteReference(int id, Dictionary<string, fsData> dict)
```

```csharp
public void Clear()
```
