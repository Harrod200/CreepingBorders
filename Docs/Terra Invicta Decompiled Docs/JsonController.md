# JsonController

*Decompiled from `PavonisInteractive/TerraInvicta/Modding/JsonController.cs`.*


## Class `JsonController`

```csharp
public class JsonController
```

### Methods

```csharp
public JsonMod LoadJson(string jsonPath)
```

```csharp
public JsonMod LoadJsonString(string jString)
```

```csharp
public void GetModSettings(string modPath, JsonMod mod)
```

```csharp
public static bool IsReplaceableModFile(string modPath, string modFile)
```

```csharp
public static int GetModLoadOrder(string modPath)
```

```csharp
public bool WriteJson(dynamic jsonContents, string jsonPath)
```

```csharp
public string jObjectListToString(List<JObject> jObjectList)
```

```csharp
public List<JObject> CombineJson(List<JObject> originalJson, List<JObject> replaceJson, bool dlcFile, MergeArrayHandling mergeArrayMode = MergeArrayHandling.Merge)
```
