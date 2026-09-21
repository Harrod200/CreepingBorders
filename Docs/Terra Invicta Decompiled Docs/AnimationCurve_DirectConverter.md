# AnimationCurve_DirectConverter

*Decompiled from `FullSerializer/Internal/DirectConverters/AnimationCurve_DirectConverter.cs`.*


## Class `AnimationCurve_DirectConverter`

```csharp
public class AnimationCurve_DirectConverter : fsDirectConverter<AnimationCurve>
```

### Methods

```csharp
protected override fsResult DoSerialize(AnimationCurve model, Dictionary<string, fsData> serialized)
```

```csharp
protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref AnimationCurve model)
```

```csharp
public override object CreateInstance(fsData data, Type storageType)
```
