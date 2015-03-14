### Description ###
Returns a list of all the characters on an account.

### Library Method ###
```
/// <summary>
/// Returns a list of all characters on an account
/// </summary>
/// <param name="userId">userID of the account for authentication</param>
/// <param name="apiKey">limited or full access api key of account</param>
/// <returns></returns>
public static CharacterList GetAccountCharacters(int userId, string apiKey)
```

### Result ###
**CharacterList class (See ApiResponse for inherited members)**
| Member | Type | Description |
|:-------|:-----|:------------|
| CharacterListItems | CharacterListItem[.md](.md) | The characters from this list |

**CharacterList.CharacterListItem class**
| Member | Type | Description |
|:-------|:-----|:------------|
| Name | string | Name of the character |
| CharacterId | int | ID of the character |
| CorporationName | string | Name of the character's corporation |
| CorporationId | int | ID of the character's corporation |

### Example ###
```
public static void PrintCharacterList()
{
    CharacterList characterList = EveApi.GetAccountCharacters(453245, "apiKey");
    foreach (CharacterList.CharacterListItem cli in characterList.CharacterListItems)
    {
        Console.WriteLine("Name: {0} Corporation: {1}", cli.Name, cli.CorporationName);
    }
}
```