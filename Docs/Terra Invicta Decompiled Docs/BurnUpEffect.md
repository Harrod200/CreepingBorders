# BurnUpEffect

*Decompiled from `BurnUpEffect.cs`.*


## Class `BurnUpEffect`

```csharp
public class BurnUpEffect : AbstractEffectController
```

### Fields

| Name | Type |
|---|---|
| `u_mask` | private static int |
| `u_maskST` | private static int |
| `u_burnColor` | private static int |
| `u_progress` | private static int |
| `m_burnUpMaterial` | public Material |
| `m_duration` | public float |
| `m_destroyTargetsOnComplete` | public bool |
| `m_applyToDescendants` | private bool |
| `m_targetObjects` | private GameObject[] |
| `m_targets` | private List<Renderer> |
| `m_burnUpMaterials` | private List<Material> |
| `m_time` | private float |

### Methods

```csharp
private void Awake()
```

```csharp
private void InitTargets()
```

```csharp
private void DisableTargetRenderers()
```

```csharp
private void DestroyTargets()
```

```csharp
private void ApplyMaterialToTargets()
```

```csharp
public override void CleanUp()
```

```csharp
protected override void OnPlay()
```

```csharp
protected override void OnUpdate(float deltaTime)
```

```csharp
protected override void OnStop()
```

```csharp
protected override void OnPause()
```

```csharp
protected override void OnUnPause()
```

```csharp
public void SetTargetObjects(GameObject[] targets, bool applyToDescendants = false)
```
