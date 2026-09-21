# fsObjectProcessor

*Decompiled from `FullSerializer/fsObjectProcessor.cs`.*


## Class `fsObjectProcessor`

```csharp
public abstract class fsObjectProcessor
```

### Methods

```csharp
public virtual bool CanProcess(Type type)
```

```csharp
public virtual void OnBeforeSerialize(Type storageType, object instance)
```

```csharp
public virtual void OnAfterSerialize(Type storageType, object instance, ref fsData data)
```

```csharp
public virtual void OnBeforeDeserialize(Type storageType, ref fsData data)
```

```csharp
public virtual void OnBeforeDeserializeAfterInstanceCreation(Type storageType, object instance, ref fsData data)
```

```csharp
public virtual void OnAfterDeserialize(Type storageType, object instance)
```
