# AssetLoader

*Decompiled from `AssetLoader.cs`.*


## Class `AssetLoader`

```csharp
public class AssetLoader
```

### Fields

| Name | Type |
|---|---|
| `_cachedAssets` | private Dictionary<string, Sprite> |

### Methods

```csharp
public void Initialize()
```

```csharp
public T LoadAsset<T>(string asset) where T : global::UnityEngine.Object
```

```csharp
public T[] LoadAll<T>(string[] assetArray) where T : global::UnityEngine.Object
```

```csharp
public GameObject InstantiatePrefab(string asset)
```

```csharp
public GameObject InstantiatePrefab(string asset, Transform parent)
```

```csharp
public void LoadAssetForImageAssignment(string asset, Image imageToAssign)
```

```csharp
public Texture2D LoadAssetForTexture2DAssignment(string asset)
```

```csharp
public Sprite LoadAssetForSpriteAssignment(string asset)
```
