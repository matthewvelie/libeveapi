### Description ###
Returns a list of market orders that are either not expired or have expired in the past week (at most).

### Library Method ###
```
/// <summary>
/// Returns a list of market orders owned by a character or corporation.
/// </summary>
/// <param name="marketOrdersType"><see cref="MarketOrderType" /></param>
/// <param name="userId">userId of account for authentication</param>
/// <param name="characterId">CharacterId of character for authentication</param>
/// <param name="fullApiKey">Full access API key of account</param>
/// <returns></returns>
public static MarketOrder GetMarketOrderList(MarketOrdersListType marketOrdersListType, int userId, int characterId, string fullApiKey)
```

### Results ###
**MarketOrders class (See ApiResult for inherited members)**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| MarketOrderItems | MarketOrderItem | List of market orders |

**MarketOrders.MarketOrderItem class**
| **Member** | **Type** | **Description** |
|:-----------|:---------|:----------------|
| OrderType | MarketOrderType | Order Type (Buy or Sell) |
| OrderId | int | Order id, not forever unique but for this pull they will be unique |
| CharId | int | Character Id of the character who placed the market order |
| StationId | int | The Id of the station that the order was placed in |
| VolEntered | long | The quantity of the items required/offered when the order was placed |
| VolRemaining | long | The quantitiy of items that are still for sale/ still required |
| MinVolume | long | For bids (buy orders) the minimum quantity that must be sold in one sale so that the order is accepted. |
| OrderState | MarketOrderState | See MarketOrderState for full descriptions of each order state |
| TypeId | int | This is the typeId of the item that is being bought/sold |
| Range | int | This is the range of the order For sell orders it is always 32767 For buy orders it is either -1 = station, 0 = solar system Any number above 1 is number of jumps in region And 32767 means region |
| AccountKey | int | This is which wallet the order is using, for a personal order this will always be 1000, for corporation orders it can be 1000-1006 depending on which wallet is being used|
| Duration | int | How many days this order is good for. Expiration is issued + duration in days |
| Escrow | double | How much ISK is in escrow. Valid for buy orders only (I believe). |
| Price | double | The cost per unit for this order |
| Bid | bool | If true this is a bid or buy order, else it is a sell order  |
| Issued | DateTime | This is when the order was issued |
| IssuedLocal | DateTime | This is when the order was issued in local time |

**MarketOrders.MarketOrderState enumeration**
| **Member** | **Value** | **Description** |
|:-----------|:----------|:----------------|
| OpenActive | 0 | If the market order is still active and up on the market |
| Closed | 1 | The order has been closed |
| ExpiredFulfilled | 2 | The order has expired, or has been fufilled so it is no longer active |
| Canceled | 3 | The order was canceled |
| Pending | 4 |  The order is currently pending, and not on the market|
| CharacterDeleted | 5 | The character that this order was associated with has been deleted |

**MarketOrders.MarketOrderState enumeration**
| **Member** | **Value** | **Description** |
|:-----------|:----------|:----------------|
| Buy | - | Denotes a buy order |
| Sell | - | Denotes a sell order |

**MarketOrdersListType enumeration**
| **Member** | **Value** | **Description** |
|:-----------|:----------|:----------------|
| Corporation | - | Retrieve the market order list for a corporation |
| Character | - | Retrieve the market order list for a character |

### Example ###
```
public static void MarketOrdersExample()
{
    MarketOrders orders = EveApi.GetMarketOrderList(MarketOrdersListType.Character, 0, 0, "fullApiKey");
    foreach (MarketOrders.MarketOrderItem item in orders.MarketOrderItems)
    {
        if (item.OrderType == MarketOrders.MarketOrderType.Sell && item.TypeId == 123)
        {
            Console.WriteLine("Item 123 is for sale at: {0}", item.StationId);
        }
    }
}
```