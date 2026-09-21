# Utilities

*Decompiled from `Utilities.cs`.*


## Class `Utilities`

```csharp
public static class Utilities
```

### Fields

| Name | Type |
|---|---|
| `SmoothLerpSamples` | private static List<float> |
| `templateFolder` | public const string |
| `namelistFolder` | public const string |
| `locFolder` | public const string |
| `modFolder` | public const string |
| `modFolderDisabled` | public const string |
| `modFolderWithSlash` | public const string |
| `modFolderDisabledWithSlash` | public const string |
| `dlcFolder` | public const string |
| `dlcFolderWithSlash` | public const string |
| `smoothLerpSamples` | private static List<float> |
| `RoundType` | public enum |

### Methods

```csharp
public static string GetStackTrace()
```

```csharp
public static float SinEase(float input)
```

```csharp
public static int CountBits(uint bits)
```

```csharp
public static int CountBits(ulong bits)
```

```csharp
public static string Capitalize(string str)
```

```csharp
public static string PlayerCountryCode()
```

```csharp
public static int IndexOf<T>(this IEnumerable<T> enumerable, T element)
```

```csharp
public static T MinBy_IComparable<T, U>(this IEnumerable<T> enumerable, Func<T, U> Evaluate) where U : IComparable
```

```csharp
public static T MaxBy_IComparable<T, U>(this IEnumerable<T> enumerable, Func<T, U> Evaluate) where U : IComparable
```

```csharp
public static IEnumerable<Transform> GetChildren(this Transform transform)
```

```csharp
public static double VariableTruncate(double value, int decimalPlaces)
```

```csharp
public static float VariableTruncate(float value, int decimalPlaces)
```

```csharp
public static int Round(this float value)
```

```csharp
public static int RoundUp(this float value)
```

```csharp
public static int RoundDown(this float value)
```

```csharp
public static bool Between(double value, double lower, double upper, bool inclusiveLower, bool inclusiveUpper)
```

```csharp
public static Vector3 XZY(this Vector3 vector)
```

```csharp
public static IEnumerable<int> Range(this int integer)
```

```csharp
public static string ToCommaSeparatedString<T>(this IEnumerable<T> elements, Func<T, string> ToString = null)
```

```csharp
public static string ToSeparatedString<T>(this IEnumerable<T> elements, Func<T, string> ToString = null)
```

```csharp
public static IEnumerable<T> LinkedList<T>(T element, Func<T, T> GetNextElement)
```

```csharp
public static IEnumerable<U> SelectSansNulls<T, U>(this IEnumerable<T> collection, Func<T, U> Selector)
```

```csharp
public static double GetElapsedFractionalMilliseconds(this Stopwatch stopwatch)
```

```csharp
public static double GetElapsedSeconds(this Stopwatch stopwatch)
```

```csharp
public static bool CanParseAsInt(this string string_)
```

```csharp
public static bool CanParseAsFloat(this string string_)
```

```csharp
public static bool CanParseAsDouble(this string string_)
```

```csharp
public static IEnumerable<string> SplitLines(this string string_)
```

```csharp
private static IEnumerator EnableOrDisableAsynchronously(MonoBehaviour[] monoBehaviours, bool enable, float secondsPerFrame)
```

```csharp
public static void EnableAsynchronously(this MonoBehaviour[] monoBehaviours, float secondsPerFrame = 0.001f)
```

```csharp
public static void EnableAsynchronously(this IEnumerable<MonoBehaviour> monoBehaviours, float secondsPerFrame = 0.001f)
```

```csharp
public static void DisableAsynchronously(this MonoBehaviour[] monoBehaviours, float secondsPerFrame = 0.001f)
```

```csharp
public static void DisableAsynchronously(this IEnumerable<MonoBehaviour> monoBehaviours, float secondsPerFrame = 0.001f)
```

```csharp
public static float GetSmoothLerpFactor(float factor)
```

```csharp
public static float Median(IEnumerable<float> values, bool medoid = false)
```

```csharp
public static float RoundToStep(float value, float stepAmount, Utilities.RoundType type = Utilities.RoundType.Nearest)
```

```csharp
public static bool CompareColor32(Color32 color1, Color32 color2)
```

```csharp
public static void CopyDirectory(string sourceDir, string destinationDir, bool recursive)
```

```csharp
public static bool IsFileInUse(FileInfo file)
```

```csharp
public static bool CanDeleteDirectory(DirectoryInfo directory)
```

```csharp
public static void DebugDrawPlane(Vector3 position, Vector3 normal, Color color, float scalar = 1f)
```

```csharp
public static void DebugDrawPoint(Vector3 position, float lineLength, Color color, float duration = 0f)
```

```csharp
public static void DebugDrawCone(Transform transform, Vector3 direction, int numberOfLines, float angle, float lineLength, Color color, float duration = 0f)
```

```csharp
public static void DebugDrawCircle(Vector3 position, Quaternion rotation, float radius, Color color, int segments = 8, float duration = 0f)
```

```csharp
public static void DebugDrawSphere(Vector3 position, Quaternion orientation, float radius, Color color, int segments = 4, float duration = 0f)
```

```csharp
public static void DebugDrawBox(Bounds bounds, Color color, float duration = 0f)
```
