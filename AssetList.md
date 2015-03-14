### Description ###
A list of assets owned by a character or corporation.

### Library Method ###
```
/// <summary>
/// Returns a list of assets owned by a character or corporation.
/// </summary>
/// <param name="assetListType"><see cref="AssetListType" /></param>
/// <param name="userId">userID of account for authentication</param>
/// <param name="characterId">CharacterID of character for authentication</param>
/// <param name="fullApiKey">Full access API key of account</param>
/// <returns></returns>
public static AssetList GetAssetList(AssetListType assetListType, int userId, int characterId, string fullApiKey)
```

### Result ###
**AssetList class (See ApiResponse for inherited members)**
| Member | Type | Description |
|:-------|:-----|:------------|
| AssetListItems | AssetListItem[.md](.md) | An array of top level assets |

**AssetList.AssetListItem class**
| Member | Type | Description |
|:-------|:-----|:------------|
| ItemId | int | A unique identifier for this item |
| LocationId | int | References a solar system or station. May not be present. |
| TypeId | int | The type of this item. References the invTypes table. |
| Quantity | long | How many items are in this stack. |
| Flag | InventoryFlagType | Indicates something about this item's storage location. See InventoryFlags |
| Singleton | bool | If true, indicates that this item is a singleton. This means that the item is not packaged. |
| Contents | AssetListItem[.md](.md) | The items contained in this item if any |

**AssetListType Enumeration**
| Member | Value | Description |
|:-------|:------|:------------|
| Corporation | - | Retrieve the asset list for the characterID's corporation |
| Character | - | Retrieve the asset list for the characterID |

### Example ###
```
public static void PrintAllAssets()
{
    AssetList assetList = EveApi.GetAssetList(AssetListType.Corporation, 1237, 453, "fullApiKey");
    foreach (AssetList.AssetListItem ali in assetList.AssetListItems)
    {
        PrintAsset(ali);
    }
}

public static void PrintAsset(AssetList.AssetListItem ali)
{
    Console.WriteLine("itemID: {0} quantity: {1}", ali.ItemId, ali.Quantity);
    foreach (AssetList.AssetListItem childAsset in ali.Contents)
    {
        PrintAsset(childAsset);
    }
}
```