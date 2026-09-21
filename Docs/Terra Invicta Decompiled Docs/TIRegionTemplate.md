# TIRegionTemplate

*Decompiled from `TIRegionTemplate.cs`.*


## Class `TIRegionTemplate`

```csharp
public class TIRegionTemplate : TIDataTemplate
```

### Fields

| Name | Type |
|---|---|
| `displayName` | public override string |
| `displayNameSentIn` | public string |
| `displayNameSentOf` | public string |
| `fighterSquadronName` | public string |
| `baseBoostPerYear_dekatons` | public float |
| `illustrationPaths` | public List<string> |
| `mapRegionName` | public string |
| `population_Millions` | public float |
| `mining` | public bool |
| `oilResource` | public bool |
| `coreEco` | public bool |
| `oilCapable` | public bool |
| `mineCapable` | public bool |
| `environment` | public EnvironmentType |
| `annualPopGrowthModifier` | public float |
| `boostPerYear_tons` | public float? |
| `missionControl` | public int? |
| `worldOcean` | public WorldOceanType |
| `afr` | public float? |
| `asi` | public float? |
| `eas` | public float? |
| `eur` | public float? |
| `his` | public float? |
| `oce` | public float? |
| `afrPersonal` | public string[] |
| `afrFamily` | public string[] |
| `afrWeight` | public float[] |
| `asiPersonal` | public string[] |
| `asiFamily` | public string[] |
| `asiWeight` | public float[] |
| `easPersonal` | public string[] |
| `easFamily` | public string[] |
| `easWeight` | public float[] |
| `eurPersonal` | public string[] |
| `eurFamily` | public string[] |
| `eurWeight` | public float[] |
| `hisPersonal` | public string[] |
| `hisFamily` | public string[] |
| `hisWeight` | public float[] |
| `ocePersonal` | public string[] |
| `oceFamily` | public string[] |
| `oceWeight` | public float[] |
| `language` | public string |
| `acc_afr` | public string |
| `acc_asi` | public string |
| `acc_eas` | public string |
| `acc_eur` | public string |
| `acc_his` | public string |
| `acc_oce` | public string |
| `illustrationPathStrs` | public List<string> |
| `occupyingNation` | public string |
| `occupationValue` | public float |
| `nuclearDetonations` | public int? |
| `asi_RegionalHeadwear` | public RegionalHeadwear |
| `_displayNameSentIn` | private string |
| `_displayNameSentOf` | private string |
| `_fighterSquadronName` | private string |

### Methods

```csharp
public override bool IsValid(out string error)
```

```csharp
public string accent(CouncilorAncestry ancestry)
```

```csharp
public override TIGameState CreateGameState()
```
