### Description ###
Returns market/wallet transactions for a character or corporation.
("Market" and "Wallet" are used interchangeably)

### Library Method ###
```
/// <summary>
/// Returns a list of market transactions (wallet transactions) owned by a character or corporation.
/// </summary>
/// <param name="walletTransactionType"><see cref="WalletTransactionListType" /></param>
/// <param name="userId">userId of account for authentication</param>
/// <param name="characterId">CharacterId of character for authentication</param>
/// <param name="fullApiKey">Full access API key of account</param>
/// <returns></returns>
public static WalletTransactions GetWalletTransactionsList(WalletTransactionListType walletTransactionType, int userId, int characterId, string fullApiKey)

/// <summary>
/// Returns a list of market transactions (wallet transactions) owned by a character or corporation.
/// </summary>
/// <param name="walletTransactionType"><see cref="WalletTransactionListType" /></param>
/// <param name="userId">userId of account for authentication</param>
/// <param name="characterId">CharacterId of character for authentication</param>
/// <param name="fullApiKey">Full access API key of account</param>
/// <param name="beforeTransId">retrieve up to 1000 entries after this transactionId</param>
/// <returns></returns>
public static WalletTransactions GetWalletTransactionsList(WalletTransactionListType walletTransactionType, int userId, int characterId, string fullApiKey, int beforeTransId)
```

## Results ##
**WalletTransactions class (See ApiResponse for inherited members)**
| **Member** | **Type** | **Description**|
|:-----------|:---------|:|
| WalletTransactionItems | WalletTransactionItem[.md](.md) | List of alliances |

**WalletTransactions.WalletTransactionItem class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| TransactionDateTime | DateTime | This is the date and time when the transaction took place in ccp time |
| TransactionDateTimeLocal | DateTime | This is the date and time when the transaction took place in local time |
| TransactionId | int | This is the transactionId that is assigned to the transaction |
| Quantity | int | This is the quantity of the item |
| TypeName | string | This is the name of the item in the transaction |
| TypeId | int | This is the typeId of the item referenced in the transaction |
| Price | double | This is the price of the item in the transaction |
| ClientId | int | The client's Id |
| ClientName | string | The client's name |
| CharacterId | int | The character who initiated the transaction's id  This is only present when viewing corp transactions, otherwise it is assumed to be the character accessing the data|
| CharacterName | string | The character who initiated the transaction's name  This is only present when viewing corp transactions, otherwise it is assumed to be the character accessing the data|
| StationId | int | The Id of the station where the transaction took place |
| StationName | string | The name of the station where the transaction took place |
| TransactionType | string | This is the type of transaction type, sell or buy |
| TransactionFor | string | This is who the transaction was for (personal or corporation) |

**WalletTransactionListType enumeration**
| **Member** | **Value** | **Description** |
|:-----------|:----------|:----------------|
| Corporation | - | Transaction list for a corporation |
| Character | - | Transaction list for a character |

### Example ###
```
public static void WalletTransactionsExample()
{
    bool done = false;
    int lastEntrySeen = 0;

    while (!done)
    {
        WalletTransactions transactions = EveApi.GetWalletTransactionsList(WalletTransactionListType.Character, 0, 0, "fullApiKey", lastEntrySeen);
        DisplayWalletTransactions(transactions);
        lastEntrySeen += transactions.WalletTransactionItems.Length;
        if (transactions.WalletTransactionItems.Length < 1000)
        {
            done = true;
        }
    }
}

public static void DisplayWalletTransactions(WalletTransactions transactions)
{
    foreach (WalletTransactions.WalletTransactionItem transaction in transactions.WalletTransactionItems)
    {
        Console.WriteLine("Date: {0} Quantity: {1} Price: {2}", transaction.TransactionDateTimeLocal, transaction.Quantity, transaction.Price);
    }
}
```