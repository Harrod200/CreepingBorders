# GlobalInstaller

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/Bootstrap/GlobalInstaller.cs`.*


## Class `GlobalInstaller`

```csharp
public class GlobalInstaller : MonoInstaller<GlobalInstaller>
```

### Fields

| Name | Type |
|---|---|
| `container` | public static DiContainer |
| `playerPrefab` | private GameObject |
| `gameControl` | private GameObject |

### Methods

```csharp
public static void InjectGameControlBinding<T>(T component, string propertyName) where T : class
```

```csharp
public override void InstallBindings()
```

```csharp
private void HandleException(string message, string stackTrace, LogType type)
```
