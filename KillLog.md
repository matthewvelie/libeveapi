### Description ###
Log of 25 most recent kills for a character or 100 most recent for corporation

### Library Methods ###
```
/// <summary>
/// Retrieves the Kill Log for a character or corporation
/// </summary>
/// <param name="killLogType">KillLogType -- Character/Corporation which kill log do you want to retrieve</param>
/// <param name="userId">User ID for authentication</param>
/// <param name="characterId">The character your requesting data for</param>
/// <param name="fullApiKey">Full Api Key for the account</param>
/// <returns>Kill Log object containing the array of kills</returns>
public static KillLog GetKillLog(KillLogType killLogType, int userId, int characterId, string fullApiKey)

/// <summary>
/// Retrieves the Kill Log for a character or corporation
/// </summary>
/// <param name="killLogType">KillLogType -- Character/Corporation which kill log do you want to retrieve</param>
/// <param name="userId">User ID for authentication</param>
/// <param name="characterId">The character your requesting data for</param>
/// <param name="fullApiKey">Full Api Key for the account</param>
/// <param name="beforeKillID">Returns the most recent kills before the specified Kill ID - used for scrolling back through the log</param>
/// <returns>Kill Log object containing the array of kills</returns>
public static KillLog GetKillLog(KillLogType killLogType, int userId, int characterId, string fullApiKey, int beforeKillID)
```

### Results ###
**KillLog class (See ApiResponse for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| Kills | Kill[.md](.md) | List of kills |

**KillLog.Kill class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| KillId | int | Unique kill ID for this kill. This is to be used as the input for beforeKillID if you need to scroll back. This is globally unique and can be used for uniquely identifying a kill to other killboards.|
| SolarSystemId | int | The ID of the solar system this kill occurred in. |
| KillTime | DateTime | What time the event occurred. |
| KillTimeLocal | DateTime | What time the event occurred in local time |
| MoonId | int | In some situations, this is present to define what moon a kill occurred at. Note that this is generally only present in situations where the loss is a POS structure. It is not guaranteed to be populated. |
| Victim | VictimPilot | object containing data about the victim |
| Attackers | Attacker | list of objects containing data about the attackers |
| Items | Item[.md](.md) | List of items lost in the kill |

**Pilot base class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| CharacterId | int | Character's ID. Fairly self-explanatory. Can be 0 in which case this kill was not done by a character and instead was done by a corporation. In the victim case, this implies it is a structure loss.|
| CharacterName | string | If present, the name of the above characterID.|
| CorporationId | int | The ID of the corporation. This will always be present, as there is always a corporation behind the victim, whether it is the corporation itself or simply someone in that corporation. |
| CorporationName | string | The name of the above corporation. |
| AllianceId | int | If not 0, this is the ID of the alliance the corporation belongs to. |
| AllianceName | string | The name of the alliance associated with the kill.|
| ShipTypeId | int | The item lost. This could be a ship as suggested by the name but can potentially be anything that generates a kill event.|

**KillLog.VictimPilot class (See Pilot base class for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| DamageTaken | int |  How much damage the victim took before succumbing to fiery defeat and humiliation. Please note that this damage is calculated after resists. It does give you a decent idea of how much they were tanking, however. |

**KillLog.Attacker class (See Pilot base class for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| SecurityStatus | double |The security status of the aggressor at the time of this kill. |
| DamageDone | int | The amount of damage done to the victim. This is post-resists damage done.|
| FinalBlow | bool | Whether or not this aggressor is attributed with the so-called "final blow." |
| WeaponTypeId | int | What weapon we decided to show this person as using. Often a weapon, sometimes a ship or missile, rarely a fish |

**KillLog.Item class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| TypeId | int |The typeID of this item, references the invTypes table |
| Flag | InventoryFlag | See InventoryFlags for details |
| QtyDropped | int | How many of this item were dropped. If the user had multiple stacks, we compress the total number of dropped items to just one stack for space purposes. |
| QtyDestroyed | int |How many of this item fell victim to atomic dispersal and other sad little ends that such things can meet. |
| Container | bool | True if the destroyed item contained other items. |
| ContainedItems | Item[.md](.md) | List of contained items. |

**KillLogType enumeration**
| **Member** | **Value** | **Description** |
|:-----------|:----------|:----------------|
| Corporation | - | Retrieve kill log for a corporation. |
| Character | - | Retrieve kill log for a character. |

### Example ###
```
public static void KillLog()
{
    KillLog killLog = EveApi.GetKillLog(KillLogType.Character, 0, 0, "fullApiKey");
    KillLog.Kill kill = killLog.Kills[0];

    Console.WriteLine("{0} was killed at {1} in system {2}", kill.Victim.CharacterName, kill.KillTimeLocal, kill.SolarSystemId);
    Console.WriteLine("The attackers were:");
    foreach (KillLog.Attacker attacker in kill.Attackers)
    {
        Console.WriteLine("{0} from corporation {1}", attacker.CharacterName, attacker.CorporationName);
    }
}
```