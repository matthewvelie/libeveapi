### Description ###
Represents a character or corporation journal entry from the eve api

### Library Method ###
```
/// <summary>
/// Returns a list of journal entries owned by a character or corporation.
/// </summary>
/// <param name="journalEntriesType"><see cref="JournalEntryType" /></param>
/// <param name="userId">userId of account for authentication</param>
/// <param name="characterId">CharacterId of character for authentication</param>
/// <param name="fullApiKey">Full access API key of account</param>
/// <returns></returns>
public static JournalEntries GetJournalEntryList(JournalEntryType journalEntriesType, int userId, int characterId, string fullApiKey)

/// <summary>
/// Returns a list of journal entries owned by a character or corporation.
/// </summary>
/// <param name="journalEntriesType"><see cref="JournalEntryType" /></param>
/// <param name="userId">userId of account for authentication</param>
/// <param name="characterId">CharacterId of character for authentication</param>
/// <param name="fullApiKey">Full access API key of account</param>
/// <param name="beforeRefId">Retrieve entries after this refId</param>
/// <returns></returns>
public static JournalEntries GetJournalEntryList(JournalEntryType journalEntriesType, int userId, int characterId, string fullApiKey, int beforeRefId)
```

### Result ###
**JornalEntries class (See ApiResponse for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| JournalEntryItems | JournalEntryItem[.md](.md) | List of journal entries |

**JornalEntries.JornalEntryItem class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| Date | DateTime | The date / time of the entry in CCP time |
| DateLocal | DateTime | The date / time of the entry in local time |
| RefId | int | A unique referenceId for each transaction |
| RefTypeId | int | The typeId of the item that is referenced in the entry |
| OwnerName1 | string | Name of the person/corp giving money |
| OwnerId1 | int | TypeId/CharId of the person/corp giving money |
| OwnerName2 | string | Name of the person/corp recieving money |
| OwnerId2 | int | TypeId/CharId of the person/corp recieving money |
| ArgName1 | string | This is either the system where the transaction took place For example when recieving bounties, or "EVE System" if used for other items like buying and selling|
| ArgId1 | int | This is an argument Id that goes with the argument Use the data from: http://wiki.eve-dev.net/APIv2_Eve_RefTypes_XML to determine what this is used for|
| Amount | double | The amount of the transaction |
| Balance | double | The balance left in the account after the transaction |
| Reason | string | This is the note attached to the transaction if any If exists for bounties this is the list of people killed and how many Ex: TypeId:Number;TypeId:Number|

**JournalEntryType enumeration**
| **Member** | **Value** | **Description** |
|:-----------|:----------|:----------------|
| Corporation | - | Corporation journal |
| Character | - | Character journal |

### Example ###
```
public static void JournalExample()
{
    bool done = false;
    int lastEntrySeen = 0;

    while (!done)
    {
        JournalEntries entries = EveApi.GetJournalEntryList(JournalEntryType.Character, 0, 0, "fullApiKey", lastEntrySeen);
        DisplayJournalEntries(entries);
        lastEntrySeen += entries.JournalEntryItems.Length;
        if (entries.JournalEntryItems.Length < 1000)
        {
            done = true;
        }
    }
}
```