# VisualizerLoader

*Decompiled from `VisualizerLoader.cs`.*


## Class `VisualizerLoader`

```csharp
public class VisualizerLoader : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `control` | private GameControl |
| `loadingSave` | private bool |
| `scenario` | private IScenario |
| `smallWait` | private readonly WaitForSeconds |
| `frameWait` | private readonly WaitForEndOfFrame |

### Methods

```csharp
public void Initialize(bool loadingSave, IScenario scenario)
```

```csharp
private void Update()
```

```csharp
private IEnumerator CatchUp()
```

```csharp
private void InitVisualizersCampaign_Editor()
```

```csharp
private IEnumerator InitVisualizersCampaign()
```

```csharp
private void InitVisualizersSkirmish()
```

```csharp
private void CompleteInitVisualizer()
```
