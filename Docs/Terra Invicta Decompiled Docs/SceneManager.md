# SceneManager

*Decompiled from `PavonisInteractive/TerraInvicta/Systems/Bootstrap/SceneManager.cs`.*


## Class `SceneManager`

```csharp
public class SceneManager
```

### Fields

| Name | Type |
|---|---|
| `activeSceneName` | public string |
| `onStartScreen` | public bool |
| `onSolarSystem` | public bool |
| `self` | public static SceneManager |
| `sceneLoader` | private ZenjectSceneLoader |

### Methods

```csharp
public SceneManager()
```

```csharp
public async void LoadScene(string name)
```

```csharp
public async void LoadScene(string name, Action<DiContainer> inject)
```

```csharp
private async Task HandleLoadingScreen(AsyncOperation sceneLoad)
```
