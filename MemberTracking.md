### Description ###
Retrieves current detailed information about a corporation's members including the ship they are currently piloting and their location.

### Library Method ###
```
/// <summary>
/// Returns information on every member in the corporation. Information retrieved
/// varies on your roles without within the corporation. Not valid for NPC corps.
/// </summary>
/// <param name="userId">user Id of account for authentication</param>
/// <param name="characterId">Character Id of a char with director/CEO access in the corp that owns the starbase</param>
/// <param name="fullApiKey">Full access api key of account</param>
/// <returns></returns>
public static MemberTracking GetMemberTracking(int userId, int characterId, string fullApiKey)
```

### Result ###
**MemberTracking class (See ApiResult for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| Members| Member[.md](.md) | Information about a corporation member |

**Member class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| CharacterId | int | Unique identifier of the member |
| Name | string | member's character name |
| StartDateTime | DateTime | Member's start date with the corporation in CCP time |
| StartDateTimeLocal | DateTime | Member's start date with the corporation in local time |
| BaseId | int | The unique identifier of the member's base station |
| Base | string | Name of the member's base station |
| Title | string | Member's assigned title in the corporation |
| LogonDateTime | DateTime | Date of the member's last log on in CCP time |
| LogonDateTimeLocal | DateTime | Date of the member's last log on in local time |
| LogoffDateTime | DateTime | Date of the member's last log off in CCP time |
| LogoffDateTimeLocal | DateTime | Date of the member's last log off in local time |
| LocationId | int | Unique id of the system where the member is currently located |
| !Location | string | Name of the system where the member is currently located |
| ShipTypeId | int | Unique identifier of the ship type the member is currently piloting |
| ShipType | string | Name of the ship type the member is currently piloting |
| RolesMask | string | A bit mask describing the member's roles in the corporation. See CorpRoles. |
| GrantableRoles | string | Depricated |
| [Roles](Roles.md) | Roles | An object that contains information about the member's roles in the corporation. See [Roles](Roles.md).|

### Example ###
```
public static void MemberTrackingExample()
{
    MemberTracking memberTracking = EveApi.GetMemberTracking(123, 456, "fullApiKey");
    
    // Output the name and location of all corporation directors
    foreach (MemberTracking.Member member in memberTracking.Members)
    {
        if (member.Roles.HasRole(RoleTypes.Director))
        {
            Console.WriteLine("Director Name: {0} Location: {1}", member.Name, member.Location);
        }
    }
}
```