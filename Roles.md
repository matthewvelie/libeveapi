## Description ##
A class for dealing with corporation roles.
See CorpRoles for a detailed description of roles masks and corporation roles.

## Member Functions ##
| **Method** | **Description** |
|:-----------|:----------------|
| Role(string rolesMask) | Create a Roles object using this roles mask |
| Role(ulong rolesMask) | Create a Roles object using this roles mask |
| bool HasRole(RoleTypes roleType) | Returns true if the mask contains this role |
| string GetRoleName(RoleTypes roleType) | Returns the short name of the role |
| string GetRoleDescription(RoleTypes roleType) | Returns a detailed description of the role |

## Example ##
```

// Create a new roles object using a roles mask
Roles roles = new Roles("1281");

// Test if we have this role
if (roles.HasRole(RoleTypes.Director))
{
    // We do, so output the name and description of the role
    Console.WriteLine("{0}: {1}", Roles.GetRoleName(RoleTypes.Director),
        Roles.GetRoleDescription(RoleTypes.Director));
}
```