# TICouncilorState

*Decompiled from `PavonisInteractive/TerraInvicta/TICouncilorState.cs`.*


## Class `TICouncilorState`

```csharp
public class TICouncilorState : TIGameState
```

### Fields

| Name | Type |
|---|---|
| `isCouncilorState` | public override bool |
| `searchable` | public override Searchable |
| `ref_councilor` | public override TICouncilorState |
| `ref_faction` | public override TIFactionState |
| `ref_region` | public override TIRegionState |
| `ref_nation` | public override TINationState |
| `ref_fleet` | public override TISpaceFleetState |
| `ref_factions` | public override List<TIFactionState> |
| `ref_hab` | public override TIHabState |
| `ref_habSite` | public override TIHabSiteState |
| `ref_spaceBody` | public override TISpaceBodyState |
| `ref_orbit` | public override TIOrbitState |
| `ref_ship` | public override TISpaceShipState |
| `ref_spaceObject` | public override TISpaceObjectState |
| `ref_naturalSpaceObject` | public override TINaturalSpaceObjectState |
| `ref_spaceAsset` | public override TISpaceAssetState |
| `hasMapObject` | public override bool |
| `hasEarthMapObject` | public override bool |
| `inSpace` | public override bool |
| `template` | public TICouncilorTemplate |
| `homeNation` | public TINationState |
| `currentNation` | public TINationState |
| `turned` | public bool |
| `detained` | public bool |
| `active` | public bool |
| `OnEarth` | public bool |
| `OnOrAroundEarth` | public bool |
| `OnAShip` | public bool |
| `InAHab` | public bool |
| `AtABase` | public bool |
| `OnAStation` | public bool |
| `HasMission` | public bool |
| `maxCouncilorAttribute` | private int |
| `elasticApparentLoyalty` | public bool |
| `transparentLoyalty` | public bool |
| `typeTemplate` | public TICouncilorTypeTemplate |
| `isAlien` | public bool |
| `isHuman` | public bool |
| `age` | public int |
| `appearanceTemplate` | public TICouncilorAppearanceTemplate |
| `useOldPortrait` | public bool |
| `videoResource` | public string |
| `portraitResource` | public string |
| `iconResource` | public string |
| `iconBackground` | public string |
| `voiceTemplate` | public TICouncilorVoiceTemplate |
| `DetectCouncilorScore` | public float |
| `HideScore` | public float |
| `ReleaseDetailedCouncilorEventName` | public string |
| `controlPointCapacity` | public int |
| `activeOrgs` | public List<TIOrgState> |
| `orgsWeight` | public int |
| `prospectiveOrgsWeight` | public int |
| `availableAdministration` | public int |
| `AllOrgsSaleValue` | public TIResourcesCost |
| `enemyFactionsTargetingMe` | public List<TIFactionState> |
| `LongHaulHomeEventName` | public string |
| `XPModifier` | public float |
| `jobDisplayName` | public string |
| `genericIconPath` | public string |
| `projectContributionString` | public string |
| `personalName` | public string |
| `familyName` | public string |
| `typeTemplateName` | public string |
| `homeRegion` | public TIRegionState |
| `possibleFaction` | public TIFactionState |
| `detainingFaction` | public TIFactionState |
| `orgs` | public List<TIOrgState> |
| `prospectiveOrgs` | public List<TIOrgState> |
| `priorLocation` | public TIGameState |
| `preMissionPhaseLocation` | public TIGameState |
| `locationIllustration` | private CouncilorIllustrationData |
| `dateBorn` | public TIDateTime |
| `gender` | public CouncilorGender |
| `ancestry` | public CouncilorAncestry |
| `status` | public CouncilorStatus |
| `everBeenAvailable` | public bool |
| `appearanceTemplateName` | public string |
| `voiceTemplateName` | public string |
| `XP` | public int |
| `imBeingTargeted` | public bool |
| `targetedLastTurn` | public bool |
| `assassinations` | public Dictionary<TIFactionState, int> |
| `gameStateSubjectCreated` | private bool |
| `_typeTemplate` | private TICouncilorTypeTemplate |
| `_voiceTemplate` | private TICouncilorVoiceTemplate |
| `icon` | private Sprite |
| `usingOldPortrait` | private bool |
| `_appearanceTemplate` | private TICouncilorAppearanceTemplate |
| `cachedFinalAttributeValues` | private Dictionary<CouncilorAttribute, int> |
| `resourceModifyingAttributes` | public static readonly CouncilorAttribute[] |

### Properties

- `public TIFactionState faction`
- `public TIFactionState agentForFaction`
- `public float autofailMissionsValue`
- `public TIGameState protectingTarget`
- `public TIGameState location`
- `public TIDateTime recruitDate`
- `public TIDateTime detainedReleaseDate`
- `public List<string> traitTemplateNames`
- `public List<string> learnedMissionsTemplateNames`
- `public Dictionary<CouncilorAttribute, int> attributes`
- `public List<TIFactionState> knowsIveBeenSeenBy`
- `public TIMissionState activeMission`
- `public TIMissionState completedMission`
- `public string priorMissionTemplateName`
- `public TIGameState priorMissionTarget`
- `public bool repeatOrder`
- `public bool permanentAssignment`
- `public bool permanentDefenseMode`
- `public List<string> missionsExcludedFromDefenseMode`
- `public bool inTransit`
- `public List<TITraitTemplate> traits`
- `public List<TIMissionTemplate> learnedMissions`

### Methods

```csharp
public override void InitWithTemplate(TIDataTemplate template)
```

```csharp
public override void PostGlobalGameStateCreateInit_2()
```

```csharp
public override void PostVisualizerCreationInit_6()
```

```csharp
public void RemoveFromGoals()
```

```csharp
public void Retire()
```

```csharp
public void SetDisplayName()
```

```csharp
public override string GetDisplayName(TIFactionState faction)
```

```csharp
public TIResourcesCost HireRecruitCost(TIFactionState faction)
```

```csharp
public static Tuple<string, string> GenerateNameFromRegionAncestry(TIRegionState homeRegion, CouncilorAncestry ancestry, CouncilorGender gender)
```

```csharp
public static CouncilorAncestry RandomizeAncestryFromRegion(TIRegionState homeRegion)
```

```csharp
private void RandomizeBirthday()
```

```csharp
public static CouncilorGender RandomizeGender(TIRegionState homeRegion)
```

```csharp
public static TIRegionState RandomizeRegionWeightedByPopulation(bool considerSocialDemographics, TIFactionState forFaction = null)
```

```csharp
private void RandomizeJob(TIFactionState faction, bool considerAvailable)
```

```csharp
private void RandomizeStats(TIFactionState forFaction, bool forceBestStats)
```

```csharp
public float GetIndividualTraitChance(TITraitTemplate traitTemplate, TIFactionState forFaction)
```

```csharp
public void AddTrait(string templateName)
```

```csharp
public void AddTrait(TITraitTemplate template, bool notify = false)
```

```csharp
public bool RemoveTrait(TITraitTemplate template)
```

```csharp
public void SetTraits()
```

```csharp
private void RandomizeTraits(TIFactionState faction)
```

```csharp
private void AssignStatsFromTemplate()
```

```csharp
private string SelectAppearance()
```

```csharp
public void NewCharacterGeneration(TICouncilorTypeTemplate forcedJob = null, TIRegionState forcedRegion = null, TIFactionState forFaction = null, bool forceMaxStats = false, bool startup = false)
```

```csharp
public void UpdateBiographicalInformation(string givenName, string familyName, TICouncilorAppearanceTemplate appearanceTemplate, TICouncilorVoiceTemplate voiceTemplate)
```

```csharp
public void SelectVoice()
```

```csharp
public void PlayMissionVoice(TIMissionTemplate missionTemplate, TICouncilorVoiceTemplate.VoiceMissionSituation voiceMissionSituation, bool onEarth)
```

```csharp
public void PlayMissionVoice(TIMissionTemplate missionTemplate, TIMissionOutcome voiceMissionOutcome, bool onEarth)
```

```csharp
public void PlaySelectionVoice()
```

```csharp
public void SetAttributesDirty()
```

```csharp
public int GetClampedMaxStatValue(CouncilorAttribute attribute)
```

```csharp
public int GetAttribute(CouncilorAttribute type, bool includeOrgs = true, bool includeAllUnconditionalTraits = true, bool capped = true, bool adminForOrgControl = false, bool useProspectiveOrgs = false, bool fullyUnclamped = false)
```

```csharp
public bool ModifyAttribute(CouncilorAttribute attribute, int value)
```

```csharp
public int SumMissionRelevantAttributes()
```

```csharp
public void SetFaction(TIFactionState faction)
```

```csharp
public void SetRecruitDate()
```

```csharp
public float MonthsSinceRecruitDate()
```

```csharp
public void ProtectTarget(TIGameState target)
```

```csharp
public void EndProtectionOfTarget()
```

```csharp
public List<TICouncilorState> GetProtectors()
```

```csharp
public float GetProtectionBonus(CouncilorAttribute attribute)
```

```csharp
public string DetainCouncilor(TIFactionState newDetainingFaction, float baseDuration_Turns, float extendDuration_Turns, bool passiveCapture)
```

```csharp
public void ScheduledCouncilorRelease(TimeEventStart e)
```

```csharp
public void ReleaseCouncilor(bool onTime)
```

```csharp
public void TurnCouncilor(TIFactionState turningFaction)
```

```csharp
public bool AutofailTurnedCouncilor(TIMissionTemplate mission, TIGameState target)
```

```csharp
public void PassIntel()
```

```csharp
public void UnTurnCouncilor(bool dismissedByTurningFaction, bool betraysToFaction)
```

```csharp
public void KillCouncilorOnMission(TIMissionState mission)
```

```csharp
public void KillCouncilor(bool violent, TIFactionState killer = null)
```

```csharp
public void SetAutofailMissionsValue(float value)
```

```csharp
public float GetResourceMultiplierFromAttributes(FactionResource resourceType)
```

```csharp
private float GetMonthlyIncomeFromTraits(FactionResource resource)
```

```csharp
private float GetMonthlyIncomeFromOrgs(FactionResource resource)
```

```csharp
private float GetMonthlyIncomeFromTraits_PositiveOnly(FactionResource resource)
```

```csharp
private float GetMonthlyIncomeFromTraits_NegativeOnly(FactionResource resource)
```

```csharp
private float GetMonthlyIncomeFromOrgs_PositiveOnly(FactionResource resource)
```

```csharp
private float GetMonthlyIncomeFromOrgs_NegativeOnly(FactionResource resource)
```

```csharp
public float GetMonthlyIncome(FactionResource resourceType)
```

```csharp
public float GetMonthlyIncome_PositiveOnly(FactionResource resourceType)
```

```csharp
public float GetMonthlyIncome_NegativeOnly(FactionResource resourceType, bool returnPositiveNumber)
```

```csharp
public float GetYearlyIncome(FactionResource resourceType)
```

```csharp
public float TotalTechBonus(TechCategory category, bool activeOrgsOnly)
```

```csharp
public float ProjectUnlockBonus()
```

```csharp
public bool HasOrg(TIOrgTemplate orgTemplate)
```

```csharp
public bool SufficientCapacityForOrg(TIOrgState org)
```

```csharp
public bool AreProspectiveOrgsValid(out string reason)
```

```csharp
public int SpareCapacityForOrgs()
```

```csharp
public bool CanAddExternalOrgValidatedForFaction(TIOrgState org)
```

```csharp
public void AddOrg(TIOrgState org)
```

```csharp
public bool OrgProvidingActiveMission(TIOrgState org)
```

```csharp
public List<TIOrgState> RemoveableOrgs()
```

```csharp
public bool CanRemoveOrg(TIOrgState org)
```

```csharp
public bool CanRemoveOrg_Admin(TIOrgState org)
```

```csharp
public void RemoveOrg(TIOrgState org)
```

```csharp
public List<TIOrgState> GetStealableOrgs(TICouncilorState targetingCouncilor)
```

```csharp
public List<TIOrgState> GetLoseableOrgs()
```

```csharp
public bool StealOrg(TIOrgState org, out List<TIOrgState> discardedOrgs)
```

```csharp
public void ActivateAllOrgs()
```

```csharp
public void DeactivateAllOrgs()
```

```csharp
public float TechCategoryBonusFromOrgs(TechCategory techCategory, bool activeOrgsOnly)
```

```csharp
public List<TIMissionTemplate> GetPossibleMissionList(bool filterForCouncilorConditions = false, bool sort = false, bool checkDetained = true, TIOrgState skipOrg = null, bool useProspectiveOrgs = false)
```

```csharp
public List<TIMissionTemplate> RestrictedMissions()
```

```csharp
public List<MissionOption> MissionOptionsForTarget(TIGameState target)
```

```csharp
public TIOrgState OrgGrantingMission(TIMissionTemplate mission, bool exclusiveToOrg)
```

```csharp
public void SetActiveMission(TIMissionState mission)
```

```csharp
public void SetRepeatOrder(bool repeatOrder)
```

```csharp
public void SetPermanentAssignment(bool setting)
```

```csharp
public void ClearActiveMission()
```

```csharp
public void SetPriorMission(TIMissionTemplate mission, TIGameState target)
```

```csharp
public void SetCompletedMission(TIMissionState missionState)
```

```csharp
public void ClearCompletedMission()
```

```csharp
public bool CanRepeatMission(TIMissionState mission)
```

```csharp
public void SetPermanentDefenseMode(bool setting)
```

```csharp
public void ToggleDefenseModeMission(TIMissionTemplate mission, bool shouldBeActive)
```

```csharp
public bool SelectPermanentDefenseModeMission()
```

```csharp
public int MaxSliderSteps()
```

```csharp
public int CurrentMaxSliderSteps(TIMissionTemplate mission, float AIAvailableFraction = 1f)
```

```csharp
public bool ValidDestination(TIGameState candidateDestination, out string reason)
```

```csharp
public void AddToParanoia(TIFactionState otherFaction)
```

```csharp
public void SetLearnedMissions()
```

```csharp
public bool LearnMission(TIMissionTemplate template)
```

```csharp
public void RecordLocation()
```

```csharp
public void EnterTransit()
```

```csharp
public void ExitTransit()
```

```csharp
public bool InTransit()
```

```csharp
public bool CheckAndChaseMissionTarget()
```

```csharp
public void RemoveFromCurrentLocation()
```

```csharp
public void ChangeLocation(TIGameState destination)
```

```csharp
public void SetLocation(TIGameState location)
```

```csharp
public void LongHaulHome(TISpaceGameState origin)
```

```csharp
public void OnLongHaulHomeComplete(TimeEventStart e)
```

```csharp
public float AdvisingBonus(CouncilorAttribute attribute)
```

```csharp
public void ChangeXP(int value)
```

```csharp
public bool CanAffordAnyCandidateAugmentations(bool XPAugmentsOnly)
```

```csharp
public List<CouncilorAugmentationOption> GetCandidateAugmentations()
```

```csharp
public void ApplyAugmentation(CouncilorAugmentationOption augmentation)
```

```csharp
public TITraitTemplate GetTraitGrouping(int grouping)
```

```csharp
public static List<TITraitTemplate> GetAllTraitsOfGrouping(int grouping)
```

```csharp
public TITraitTemplate GetTraitWithSpecialTraitRule(SpecialTraitRule rule)
```

```csharp
public bool HasTraitWithTag(string tag)
```

```csharp
public bool GrantsMarkedToAssassin()
```

```csharp
public List<TITraitTemplate> GetAllCouncilorTraitsWithTag(string tag)
```

```csharp
public static List<TITraitTemplate> GetAllTraitsWithTag(string tag)
```

```csharp
public float TechCategoryBonusFromTraits(TechCategory techCategory)
```

```csharp
public float MissionQuality(TIMissionTemplate mission)
```

```csharp
public Sprite GetAirplaneTexture()
```

```csharp
public string GetRecruitCostString(TIFactionState faction, bool includeCostString = true)
```

```csharp
public string GetCurrentMissionString(bool includeTarget = true, bool includeResolveTime = false, bool twoLineTarget = false)
```

```csharp
public Sprite GetIcon(bool forceUpdate = false)
```

```csharp
public string GetCurrentMissionIcon(bool on)
```

```csharp
public string subjectivePronoun(bool cap)
```

```csharp
public string objectivePronoun(bool cap)
```

```csharp
public string possessivePronoun(bool cap)
```

```csharp
public string GetHomeLocationString()
```

```csharp
public string GetVerboseHomeLocationString()
```

```csharp
public string GetVerboseAgeString()
```

```csharp
public string GetDOBString()
```

```csharp
public string VisibleSummary(TIFactionState viewingFaction)
```

```csharp
public CouncilorIllustrationData GetIllustrationData()
```

```csharp
public static CouncilorIllustrationData GetUnknownIllustrationData(TICouncilorState councilor)
```

```csharp
public CouncilorIllustrationData SetIllustrationData(TIGameState location, bool randomizeOffset, bool sameLocation = false)
```
