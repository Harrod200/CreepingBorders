# DamageLayer

*Decompiled from `PavonisInteractive/TerraInvicta/DamageLayer.cs`.*


## Class `DamageLayer`

```csharp
public class DamageLayer : MonoBehaviour
```

### Fields

| Name | Type |
|---|---|
| `s_uDamagePointArray` | private static readonly int |
| `s_uDamagePointArrayLength` | private static readonly int |
| `_shipDamageMaterial` | private Material |
| `_shipRenderers` | private Renderer[] |
| `_clearDamageOnUpdate` | private bool |
| `_originalMaterials` | private Dictionary<Renderer, Material[]> |
| `_damageMaterials` | private List<Material> |
| `_damagePoints` | private List<Vector4> |
| `refShipState` | private TISpaceShipState |

### Methods

```csharp
private void Start()
```

```csharp
private void OnEnable()
```

```csharp
private void OnDisable()
```

```csharp
private void LateUpdate()
```

```csharp
public void AddDamagePoint(Vector3 hitPosition, float radius, DamageType damageType)
```

```csharp
public static Vector4 AddDamagePointInternal(Vector3 hitPosition, float radius, DamageType damageType)
```

```csharp
public List<Vector4> GetDamagePoints()
```

```csharp
public void LoadDamagePoints(List<Vector4> damagePoints)
```

```csharp
public void SyncDamageVisualizations()
```

```csharp
public void ClearDamagePoints()
```

```csharp
private static float GetPackedFloat(float a, float b)
```

```csharp
private static ValueTuple<float, float> GetUnpackedFloat(float f)
```
