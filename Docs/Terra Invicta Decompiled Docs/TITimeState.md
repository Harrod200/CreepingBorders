# TITimeState

*Decompiled from `PavonisInteractive/TerraInvicta/TITimeState.cs`.*


## Class `TITimeState`

```csharp
public class TITimeState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `template` | public TIStartTimeTemplate |
| `masterMetaTemplate` | public TIMetaTemplate |
| `scenarioMetaTemplate` | public TIMetaTemplate |
| `currentDateTime` | private TIDateTime |

### Properties

- `public int daysInCampaign`
- `public int currentQuarterSinceStart`
- `public string masterMetaTemplateName`
- `public string scenarioMetaTemplateName`

### Methods

```csharp
public override void InitWithTemplate(TIDataTemplate template)
```

```csharp
public void SetMasterMetaTemplate(string templateName, string scenarioTemplateName)
```

```csharp
public void UpdateCurrentDateTime(double seconds)
```

```csharp
public void SetCurrentDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond)
```

```csharp
public TIDateTime Time_Now()
```

```csharp
public static TIDateTime Now()
```

```csharp
public DateTime Time_SystemNow()
```

```csharp
public static DateTime SystemNow()
```

```csharp
public void AddDayToCampaign()
```

```csharp
public void AddQuarterToCampaign()
```

```csharp
public static int CampaignDuration_days()
```

```csharp
public static int CurrentQuarter()
```

```csharp
public static int CampaignDuration_CompleteMonths()
```

```csharp
public static float CampaignDuration_months_Exact()
```

```csharp
public static int CampaignDuration_CompleteYears()
```

```csharp
public static float CampaignDuration_years_Exact()
```
