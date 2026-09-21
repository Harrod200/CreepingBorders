# ChangeCouncilorBio

*Decompiled from `PavonisInteractive/TerraInvicta/Actions/ChangeCouncilorBio.cs`.*


## Class `ChangeCouncilorBio`

```csharp
public class ChangeCouncilorBio : PlayerAction
```

### Fields

| Name | Type |
|---|---|
| `councilorID` | private GameStateID |
| `givenName` | private string |
| `familyName` | private string |
| `appearanceTemplateDataName` | private string |
| `voiceTemplateDataName` | private string |

### Methods

```csharp
public ChangeCouncilorBio(TICouncilorState councilor, string givenName, string familyName, TICouncilorAppearanceTemplate appearanceTemplate, TICouncilorVoiceTemplate voiceTemplate)
```

```csharp
public override void Execute()
```
