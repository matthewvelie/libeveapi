### Description ###
Contains the settings and fuel status of a starbase

### Library Method ###
```
/// <summary>
/// Returns the settings and fuel status of a starbase
/// </summary>
/// <param name="userId">user ID of account for authentication</param>
/// <param name="characterId">Character ID of a char with director/CEO access in the corp that owns the starbase</param>
/// <param name="fullApiKey">Full access api key of account</param>
/// <param name="itemId">Item ID of the starbase as given in the starbase list</param>
/// <returns></returns>
public static StarbaseDetail GetStarbaseDetail(int userId, int characterId, string fullApiKey, int itemId)
```

### Result ###
**StarbaseDetail class (See ApiResponse for inherited members)**
| Member | Type | Description |
|:-------|:-----|:------------|
| UsageFlags | string |  |
| DeployFlags | string |  |
| AllowCorporationMembers | bool | Allow corporation members access inside the forcefield bubble |
| AllowAllianceMembers | bool | Allow alliance members access inside the forcefield bubble |
| ClaimSovereignty | bool | Is this starbase claiming sovernty (only in 0.0) |
| OnStandingDropEnabled | bool | Attack if target standing is dropping |
| OnStandingDropStanding| string| Attack if target standing is below this |
| OnStatusDropEnabled| bool | Attack if target is status is dropping |
| OnStatusDropStanding| string| Attack if target status is below this |
| OnAgressionEnabled| bool | Attack if target has aggressed |
| OnCorporationWarEnabled| bool | Attack if target is a wartarget |
| FuelList | FuelListItem[.md](.md) | List of fuels present in the starbase |

**StarbaseDetail.FuelListItem Object**
| Member | Type | Description |
|:-------|:-----|:------------|
| TypeId | string | typeID of the fuel |
| Quantity | long | Number of units of the fuel remaining |

### Example ###
```
public static void PrintStarbaseDetail()
{
    StarbaseDetail starbaseDetail = EveApi.GetStarbaseDetail(45353, 45317, "fullApiKey", 43534);
    Console.WriteLine("usageFlags: {0} deployFlags: {1}", starbaseDetail.UsageFlags, starbaseDetail.DeployFlags);

    foreach (StarbaseDetail.FuelListItem fli in starbaseDetail.FuelList)
    {
        Console.WriteLine("TypeID: {0} Quantity: {1}", fli.TypeId, fli.Quantity);
    }
}
```