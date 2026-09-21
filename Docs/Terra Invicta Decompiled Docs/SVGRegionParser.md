# SVGRegionParser

*Decompiled from `SVGRegionParser.cs`.*


## Class `SVGRegionParser`

```csharp
public class SVGRegionParser
```

### Fields

| Name | Type |
|---|---|
| `commands` | private string[] |
| `width` | private float |
| `height` | private float |

### Methods

```csharp
public void ParseSVG(string filepath, RegionOutlineCollection regionCollection)
```

```csharp
private CurvedPolyPoint[] ParsePath(string svgLine)
```

```csharp
private List<object> CleanSVGLine(string svgLine)
```

```csharp
private string GetCommand(string token)
```
