# GUIStyle_DirectConverter

*Decompiled from `FullSerializer/Internal/DirectConverters/GUIStyle_DirectConverter.cs`.*


## Class `GUIStyle_DirectConverter`

```csharp
public class GUIStyle_DirectConverter : fsDirectConverter<GUIStyle>
```

### Methods

```csharp
protected override fsResult DoSerialize(GUIStyle model, Dictionary<string, fsData> serialized)
```

```csharp
protected override fsResult DoDeserialize(Dictionary<string, fsData> data, ref GUIStyle model)
```

```csharp
public override object CreateInstance(fsData data, Type storageType)
```
