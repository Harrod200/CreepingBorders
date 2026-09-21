# NotificationQueueItem

*Decompiled from `NotificationQueueItem.cs`.*


## Class `NotificationQueueItem`

```csharp
public class NotificationQueueItem
```

### Fields

| Name | Type |
|---|---|
| `template` | public TINotificationTemplate |
| `itemHammer` | public string |
| `alertFactions` | public List<TIFactionState> |
| `timerFactions` | public List<TIFactionState> |
| `newsFeedFactions` | public List<TIFactionState> |
| `summaryLogFactions` | public List<TIFactionState> |
| `putInTimerQueue` | public bool |
| `putInNewsFeed` | public bool |
| `putInSummaryLog` | public bool |
| `templateName` | public string |
| `primaryFactions` | public List<TIFactionState> |
| `relevantFactions` | public List<TIFactionState> |
| `itemHeadline` | public string |
| `itemSummary` | public string |
| `itemDetail` | public string |
| `dateTimeString` | public string |
| `icon` | public string |
| `iconBackgroundResource` | public string |
| `factionSpecificDetail` | public Dictionary<TIFactionState, string> |
| `popupResource1` | public string |
| `popup1BackgroundResource` | public string |
| `popupResource2` | public string |
| `illustrationResource` | public string |
| `videoResource` | public string |
| `movieResource` | public string |
| `animationSpriteSheetPath` | public string |
| `backgroundColor` | public Color |
| `outcome` | public TIMissionOutcome |
| `alertBlockFaction` | public TIFactionState |
| `promptingGameState` | public TIGameState |
| `alertRelatedState` | public TIGameState |
| `relatedTemplate` | public TIDataTemplate |
| `utilityValue` | public int |
| `alertBlockEventName` | public string |
| `controlPointsRelevant` | public bool |
| `oldControlPoints` | public IList<TIGameState> |
| `newControlPoints` | public IList<TIGameState> |
| `allNarrativeEventTargetsAndSeconds` | public Dictionary<TIGameState, TIGameState> |
| `soundToPlay` | public string |
| `fanfareToPlay` | public string |
| `musicIntensityDelta` | public float |
| `OnOpenNotification` | public Action |
| `OnCloseNotification` | public Action |
| `mission` | public TIMissionState |
| `operation` | public ActorOperationData |
| `gotoGameState` | public TIGameState |
| `narrativeEventAlert` | public bool |
| `triggerEndGame` | public bool |
| `showSideArt` | public bool |
| `customButtonTemplateName` | public string |
| `dateTime` | public TIDateTime |
| `notificationDelegates` | public List<SpecialNotificationDelegate> |

### Methods

```csharp
private List<TIFactionState> DefaultAudienceFactions(NotificationAudience audience)
```
