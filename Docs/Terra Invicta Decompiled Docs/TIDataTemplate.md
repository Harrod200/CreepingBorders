# TIDataTemplate

*Decompiled from `TIDataTemplate.cs`.*


## Class `TIDataTemplate`

```csharp
public class TIDataTemplate : TIDataClass
```

### Fields

| Name | Type |
|---|---|
| `referenceName` | public string |
| `localizationName` | public string |
| `displayName` | public virtual string |
| `_displayName` | protected string |

### Properties

- `public string dataName`
- `public string friendlyName`
- `public string referenceAlias`
- `public string localizationAlias`
- `public bool disable`
- `public string[] scenarioTags`

### Methods

```csharp
public string displayNameCurrentForStartScreen()
```

```csharp
public TIDataTemplate()
```

```csharp
public TIDataTemplate(string templateName)
```

```csharp
public virtual TIGameState CreateGameState()
```

```csharp
public virtual bool IsValid(out string error)
```

```csharp
public void RenameDataName(string dataName_)
```

```csharp
public override string ToString()
```
