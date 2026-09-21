# fsSerializationCallbackProcessor

*Decompiled from `FullSerializer/Internal/fsSerializationCallbackProcessor.cs`.*


## Class `fsSerializationCallbackProcessor`

```csharp
public class fsSerializationCallbackProcessor : fsObjectProcessor
```

### Methods

```csharp
public override bool CanProcess(Type type)
```

```csharp
public override void OnBeforeSerialize(Type storageType, object instance)
```

```csharp
public override void OnAfterSerialize(Type storageType, object instance, ref fsData data)
```

```csharp
public override void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
```

```csharp
public override void OnAfterDeserialize(Type storageType, object instance)
```
