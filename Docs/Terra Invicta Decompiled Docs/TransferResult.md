# TransferResult

*Decompiled from `PavonisInteractive/TerraInvicta/TransferResult.cs`.*


## Class `TransferResult`

```csharp
public class TransferResult
```

### Fields

| Name | Type |
|---|---|
| `Result` | public TransferResult.Outcome |
| `Value` | public double |
| `Value2` | public double |
| `Outcome` | public enum |

### Methods

```csharp
public TransferResult(TransferResult.Outcome result, double value = 0.0, double value2 = 0.0)
```

```csharp
public static TransferResult Best(TransferResult a, TransferResult b)
```

```csharp
public bool WasBug()
```

```csharp
public bool TryGetMinimumDVneeded_mps(out double minimumDV_mps)
```

```csharp
public bool TryGetMinimumDVneeded_kps(out double minimumDV_kps)
```

```csharp
public bool TryGetMinimumAccelerationNeeded(out double minimumAcceleration_mps2, double fleetAcceleration_mps2)
```

```csharp
public override string ToString()
```
