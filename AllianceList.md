### Description ###
Retrieves a list of all alliances in the game and each of their member corporations.

### Library Method ###
```
/// <summary>
/// Gets a list of all alliances and their member corporations
/// </summary>
/// <returns></returns>
public static AllianceList GetAllianceList()
```

### Result ###
**AllianceList class (See ApiResponse for inherited members)**
| **Member** | **Type** | **Description**|
|:-----------|:---------|:|
| AllianceListItems | AllianceList[.md](.md) | List of alliances |

**AllianceList.AllianceListItem class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| Name | string | full name of the alliance |
| ShortName | string | ticker name of the alliance |
| AllianceId | int | unique identifier for this alliance |
| ExecutorCorpId | int | unique identifier of executor corporation |
| MemberCount | int | Current number of pilots in the alliance |
| StartDate | DateTime | Date the alliance was created in CCP time |
| StartDateLocal | DateTime | Date the alliance was created in local time |
| CorporationListItems | CorporationListItem[.md](.md) | List of member corporations |

**AllianceList.CorporationListItem class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| CorporationId | int | unique identifier for the corporation |
| StartDate | DateTime | date the corporation joined the alliance in CCP time |
| StartDateLocal | DateTime | date the corporation joined the alliance in local time |

### Example ###
```
public static void PrintAllianceList()
{
    AllianceList allianceList = EveApi.GetAllianceList();
    foreach (AllianceList.AllianceListItem ali in allianceList.AllianceListItems)
    {
        Console.WriteLine("Alliance name: {0} members: {1}", ali.Name, ali.MemberCount);
        foreach (AllianceList.CorporationListItem cli in ali.CorporationListItems)
        {
            Console.WriteLine("Member Corporation Id: {0} Started: {1}", cli.CorporationId, cli.StartDate);
        }
    }
}
```