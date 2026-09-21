# fsAotCompilationManager

*Decompiled from `FullSerializer/fsAotCompilationManager.cs`.*


## Class `fsAotCompilationManager`

```csharp
public class fsAotCompilationManager
```

### Fields

| Name | Type |
|---|---|
| `AotCandidateTypes` | public static HashSet<Type> |

### Methods

```csharp
private static bool HasMember(fsAotVersionInfo versionInfo, fsAotVersionInfo.Member member)
```

```csharp
public static bool IsAotModelUpToDate(fsMetaType currentModel, fsIAotConverter aotModel)
```

```csharp
public static string RunAotCompilationForType(fsConfig config, Type type)
```

```csharp
private static string EmitVersionInfo(string prefix, Type type, fsMetaProperty[] members, bool isConstructorPublic)
```

```csharp
private static string GetConverterString(fsMetaProperty member)
```

```csharp
public static string GetQualifiedConverterNameForType(Type type)
```

```csharp
private static string GenerateDirectConverterForTypeInCSharp(Type type, fsMetaProperty[] members, bool isConstructorPublic)
```
