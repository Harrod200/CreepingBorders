# JsonMod

*Decompiled from `PavonisInteractive/TerraInvicta/Modding/JsonMod.cs`.*


## Class `JsonMod`

```csharp
public class JsonMod : Mod
```

### Properties

- `public string ModFileName`
- `public string ModFilePath`
- `public string TargetFilePath`
- `public int LoadOrder`
- `public List<string> TemplatesToConcatArrays`
- `public List<string> TemplatesToReplaceArrays`
- `public List<string> TemplatesToReplace`
- `public List<JObject> FileContents`
- `public bool foundVanillaMatch`

### Methods

```csharp
public JObject GetJObject(string dataName)
```

```csharp
public HashSet<string> GetDataNames()
```

```csharp
public void SetFoundMatch()
```
