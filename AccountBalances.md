### Description ###
Returns the ISK balance of a character or corporation.

### Library Method ###
```
/// <summary>
/// Returns the ISK balance of a corporation or character
/// </summary>
/// <param name="accountBalanceType">retrieve balance for character or corporation</param>
/// <param name="userId">user ID of account for authentication</param>
/// <param name="characterId">
/// For character balance: The character you are requesting data for
/// For corporation balance: Character ID of a char with director/CEO access in the corp you want the balance for
/// </param>
/// <param name="fullApiKey">Full access api key of account</param>
/// <returns></returns>
public static AccountBalance GetAccountBalance(AccountBalanceType accountBalanceType, int userId, int characterId, string fullApiKey)
```

### Result ###
**AccountBalance class (See ApiResponse for inherited members)**
| Member | Type | Description |
|:-------|:-----|:------------|
| AccountBalanceItems | AccountBalanceItem[.md](.md) | The accounts associated with this character or corporation |

**AccountBalance.AccountBalanceItem class**
| Member | Type | Description |
|:-------|:-----|:------------|
| AccountId | int | ID number of the account |
| AccountKey | int | Account Identifier. For Characters: always 1000. For Corp: the wallet division |
| Balance | double | The amount of ISK in the account |

**AccountBalanceType Enumeration**
| Member | Value | Description |
|:-------|:------|:------------|
| Character | - | Retrieve the account balances for the specified characterID |
| Corporation | - | Retrieve the account balances for the characterID's corporation |

### Example ###
```
public static void PrintAccounts()
{
    AccountBalance accountBalance = EveApi.GetAccountBalance(AccountBalanceType.Corporation, 1234, 2567, "fullApiKey");
    foreach (AccountBalance.AccountBalanceItem abi in accountBalance.AccountBalanceItems)
    {
        Console.WriteLine("id: {0} key: {1} balance: {2}", abi.AccountId, abi.AccountKey, abi.Balance);
    }
}
```