# ModMapper

*Decompiled from `PavonisInteractive/TerraInvicta/Modding/ModMapper.cs`.*


## Class `ModMapper`

```csharp
public class ModMapper
```

### Fields

| Name | Type |
|---|---|
| `modMapList` | private List<ModMap> |
| `cachedModMapList` | private List<ModMap> |

### Properties

- `private List<string> requiredDirectories = new List<string>`
- `private List<string> requiredFiles = new List<string>`

### Methods

```csharp
public ModMapper()
```

```csharp
private void SetupDirectories()
```

```csharp
private void SetupFiles()
```

```csharp
public List<ModMap> GetModMap()
```

```csharp
public List<ModMap> ScanMods()
```

```csharp
public bool IsModListCurrent()
```

```csharp
public void UpdateModMap(List<ModMap> newModMap)
```

```csharp
public void UpdateModMap()
```

```csharp
public void SaveModMap()
```

```csharp
public void MarkModAsValid(string modFilePath, bool valid = true)
```

```csharp
public void AddErrors(string modFilePath, List<string> errorMessages)
```
