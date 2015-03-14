### Description ###
Represents a list of all the starbases owned by the specified corporation

### Library Method ###
```
/// <summary>
/// Returns a list of starbases owned by a corporation
/// </summary>
/// <param name="userId">user ID of account for authentication</param>
/// <param name="characterId">Character ID of a char with director/CEO access in the corp you want the starbases for</param>
/// <param name="fullApiKey">Full access api key of account</param>
/// <returns></returns>
public static StarbaseList GetStarbaseList(int userId, int characterId, string fullApiKey)
```

### Result ###
**StarbaseList class (See ApiResponse for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| StarbaseListItems | StarbaseListItem[.md](.md) | The starbases contained in the list |

**StarbaseList.StarbaseListItem class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| ItemId | string | Unique identifier for the starbase |
| TypeId | string | Control tower type id |
| LocationId | string | ID of the system containing the starbase |
| MoonId | string | ID of the moon where the starbase is located |
| State | StarbaseState | See StarbaseState documentation |
| StateTimestamp | DateTime | See StarbaseState documentation (CCP Time) |
| OnlineTimestamp | DateTime | See StarbaseState documentation (CCP Time) |
| StateTimestampLocal | DateTime | The StateTimestamp in local time |
| OnlineTimeStampLocal | DateTime | The OnlineTimestamp in local time |

**StarbaseList.StarbaseState Enumeration**
| **Member** | **Value** | **Description** |
|:-----------|:----------|:----------------|
| AnchoredOrOffline | 1 | Starbase is anchored or offline if offline then it went offline at StateTimestamp |
| Onlining | 2 | Starbase is in the process of coming online and will be online at time OnlineTimestamp |
| Reinforced | 3 | Starbase in in reinforced mode until time StateTimestamp |
| Online | 4 | Starbase is online and has been continuously since time OnlineTimestamp |

### Example ###
```
public static void PrintStarbaseList()
{
    StarbaseList starbaseList = EveApi.GetStarbaseList(5385, 5431487, "fullApiKey");
    foreach (StarbaseList.StarbaseListItem sli in starbaseList.StarbaseListItems)
    {
        Console.WriteLine("ItemID: {0} LocationID: {1} State: {2}", sli.ItemId, sli.LocationId, sli.State);
    }
}

```