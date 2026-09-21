# AssetBundleManager

*Decompiled from `AssetBundles/AssetBundleManager.cs`.*


## Class `AssetBundleManager`

```csharp
public class AssetBundleManager
```

### Fields

| Name | Type |
|---|---|
| `SimulateAssetBundleInEditor` | public static bool |
| `bundlePath` | private static string |
| `manifest` | private static AssetBundleManifest |
| `loadedBundles` | private static Dictionary<string, AssetBundle> |
| `simulateAssetBundleInEditor` | private static int |
| `simulateAssetBundles` | private const string |
| `DLCAShipBundle` | private const string |
| `keySimulateDLCDarkSkiesInEditor` | public const string |

### Methods

```csharp
public static void Initialize()
```

```csharp
public static T LoadAsset<T>(string assetPath) where T : global::UnityEngine.Object
```

```csharp
public static void UnloadAssetBundle(string assetBundleName)
```

```csharp
public static bool AreDLCBundlesLoaded(int index)
```
