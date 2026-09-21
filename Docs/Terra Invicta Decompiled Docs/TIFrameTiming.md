# TIFrameTiming

*Decompiled from `PavonisInteractive/TerraInvicta/TIFrameTiming.cs`.*


## Class `TIFrameTiming`

```csharp
public class TIFrameTiming : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `singleton` | private static TIFrameTiming |
| `lastFrametime` | public static float |
| `secondsSinceStartOfUpdate` | public static double |
| `stopwatch` | private Stopwatch |
| `previousStartOfUpdateSeconds` | private double |
| `startOfUpdateSeconds` | private double |
| `frametimeHistory` | private Queue<float> |
| `frametimeHistoryLength` | private int |
| `singleton_` | private static TIFrameTiming |

### Methods

```csharp
private void Start()
```

```csharp
private void Update()
```

```csharp
public static float GetAverageFrametime(int targetFrameCount)
```
