# LayerMask_DirectConverter

*Decompiled from `FullSerializer/Internal/DirectConverters/LayerMask_DirectConverter.cs`.*


## Class `LayerMask_DirectConverter`

```csharp
public class LayerMask_DirectConverter : fsDirectConverter<LayerMask>
```

### Methods

```csharp
protected override fsResult DoSerialize(LayerMask model, Dictionary<string, fsData> serialized)
```

```csharp
protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref LayerMask model)
```

```csharp
public override object CreateInstance(fsData data, Type storageType)
```
