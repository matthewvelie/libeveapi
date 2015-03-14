### Description ###
Represents a industry jobs that have been performed and are currently in progress response from the eve api.

### Library Method ###
```
/// <summary>
/// Returns a list of industrial jobs owned by a character or corporation.
/// </summary>
/// <param name="industryJobListType"><see cref="IndustryJobListType" /></param>
/// <param name="userId">userId of account for authentication</param>
/// <param name="characterId">CharacterId of character for authentication</param>
/// <param name="fullApiKey">Full access API key of account</param>
/// <returns></returns>
public static IndustryJobList GetIndustryJobList(IndustryJobListType industryJobListType, int userId, int characterId, string fullApiKey)
```

### Result ###
**IndustryJobList class (See ApiResponse for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| IndustryJobItems | IndustryJobItem[.md](.md) | List of industry jobs |

**IndustryJobList.IndustryJobItem class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| JobId | int | This is the unique job id that is assigned to the job by the eve system|
| AssemblyLineId | int | This is the assembly line that it is installed into if in a station |
| ContainerId | int |  |
| InstalledItemId | int | This is the itemId of the item that was installed for whatever factory job was happening, this isnt really useful as it can change, but it will link back to something in your asset list (hopefully)|
| InstalledItemLocationId | int | This is the locationId of where the item was installed |
| InstalledItemQuantity | int | This is how many of the item were installed, (usually 1) |
| InstalledItemProductivityLevel | int | This is the blueprints Productivity Level (TE) |
| InstalledItemMaterialLevel | int | This is the blueprints Material Level (ME) |
| InstalledItemLicensedProductionRunsRemaining | int | This is how many production runs are left on the  blueprint that was installed.  A -1 represents a BPO with unlimited copies left. |
| OutputLocationId | int | This is where the output of the job will be placed |
| InstallerId | int | The characterId of the person who installed the job |
| Runs | int | This is how many runs of the object are being made. |
| LicensedProductionRuns | int |  |
| InstalledInSolarSystemId | int | This is the solarsystemId of where the job was installed |
| ContainerLocationId | int | Where the container is located at, usually a moon or station. |
| MaterialMultiplier | double | This is the ME multiplier from the installation place. |
| CharMaterialMultiplier | double | This is the ME multiplier that id done by the character's skills |
| TimeMultiplier | double | This is the TE multiplier of the station |
| CharTimeMultiplier | double | The TE multiplier that id done by the character's skills |
| InstalledItemTypeId | int | This is the typeId of the item that was installed (a blueprint) |
| OutputTypeId | int | This is the typeId of what will be outputted when the item is finished doing whatever it is doing.  For research this will be the blueprint itself, for manufacturing this will be the item |
| ContainerTypeId | int | This is the lab the items are currently in Can be looked up like any typeId, usually a mobile lab or something similar |
| InstalledItemCopy | bool | This value is a bool value, if the blueprint installed was a copy or not. |
| Completed | bool | This is a boolean value if the item has completed or not |
| CompletedSuccessfully | bool | Boolean value if the job completed successfully or not |
| InstalledItemFlag | int | See InventoryFlags |
| OutputFlag | int | See InventoryFlags |
| ActivityId | int | This is what kind of activity was going on with the item 3 = Time Efficiency, 4 = Material Research |
| CompletedStatus | int | 1 = delivered, 2 = aborted, 3 = GM aborted, 4 = inflight unanchored, 5 = destroyed, 0 = failed |
| InstallTime | DateTime | When this item was installed |
| BeginProductionTime | DateTime | When production time started (different than install time if a queue) |
| EndProductionTime | DateTime | When the job will be finished |
| PauseProductionTime | DateTime |  |
| InstallTimeLocal | DateTime | When this item was installed in local time |
| BeginProductionTimeLocal | DateTime | When production time started in local time (different than install time if a queue) |
| EndProductionTimeLocal | DateTime | When the job will be finished in local time |
| PauseProductionTimeLocal | DateTime |  |

**IndustryJobListType enumeration**
| **Member** | **Value** | **Description** |
|:-----------|:----------|:----------------|
| Corporation | - | Retrieve jobs for a corporation |
| Character | - | Retrieve jobs for a character |

### Example ###
```
public static void IndustryJobListExample()
{
    IndustryJobList ijl = EveApi.GetIndustryJobList(IndustryJobListType.Corporation, 1234, 5678, "fullApiKey");
    foreach (IndustryJobList.IndustryJobListItem item in ijl.IndustryJobListItems)
    {
        if (item.Completed)
        {
            Console.WriteLine("Completed JobId: {0} Installed at location: {1}", item.JobId, item.InstalledItemLocationId);
        }
    }
}
```