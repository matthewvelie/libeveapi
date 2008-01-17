using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Represents a character or corporation AccountBalance response from the eve api
    /// http://wiki.eve-dev.net/APIv2_Corp_MarketOrders_XML
    /// </summary>
    public class MarketOrder : ApiResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public MarketOrderItem[] MarketOrderItems = new MarketOrderItem[0];

        /// <summary>
        /// Create an MarketOrderList by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static MarketOrder FromXmlDocument(XmlDocument xmlDoc)
        {
            MarketOrder MarketOrderList = new MarketOrder();
            MarketOrderList.ParseCommonElements(xmlDoc);

            List<MarketOrderItem> orders = new List<MarketOrderItem>();
            foreach (XmlNode node in xmlDoc.SelectNodes("//rowset[@name='orders']/row"))
            {
                orders.Add(ParseTransactionRow(node));
            }
            MarketOrderList.MarketOrderItems = orders.ToArray();

            return MarketOrderList;
        }

        /// <summary>
        /// Create an MarketOrderItem by parsing a single row
        /// </summary>
        /// <param name="marketOrderRow"></param>
        /// <returns></returns>
        protected static MarketOrderItem ParseTransactionRow(XmlNode marketOrderRow)
        {
            MarketOrderItem marketItem = new MarketOrderItem();

            marketItem.OrderId = Convert.ToInt32(marketOrderRow.Attributes["orderID"].InnerText);
            marketItem.CharId = Convert.ToInt64(marketOrderRow.Attributes["charID"].InnerText);
            marketItem.StationId = Convert.ToInt64(marketOrderRow.Attributes["stationID"].InnerText);
            marketItem.VolEntered = Convert.ToInt64(marketOrderRow.Attributes["volEntered"].InnerText);
            marketItem.VolRemaining = Convert.ToInt64(marketOrderRow.Attributes["volRemaining"].InnerText);
            marketItem.MinVolume = Convert.ToInt64(marketOrderRow.Attributes["minVolume"].InnerText);

            switch (Convert.ToInt32(marketOrderRow.Attributes["orderState"].InnerText))
            {
                case 0:
                    marketItem.OrderState = marketOrderState.OpenActive;
                    break;
                case 1:
                    marketItem.OrderState = marketOrderState.Closed;
                    break;
                case 2:
                    marketItem.OrderState = marketOrderState.ExpiredFulfilled;
                    break;
                case 3:
                    marketItem.OrderState = marketOrderState.Canceled;
                    break;
                case 4:
                    marketItem.OrderState = marketOrderState.Pending;
                    break;
                case 5:
                    marketItem.OrderState = marketOrderState.CharacterDeleted;
                    break;
                default:
                    break;
            }

            marketItem.TypeId = Convert.ToInt64(marketOrderRow.Attributes["typeID"].InnerText);
            marketItem.Range = Convert.ToInt32(marketOrderRow.Attributes["range"].InnerText);
            marketItem.AccountKey = Convert.ToInt32(marketOrderRow.Attributes["accountKey"].InnerText);
            marketItem.Duration = Convert.ToInt32(marketOrderRow.Attributes["duration"].InnerText);
            marketItem.Escrow = Convert.ToDouble(marketOrderRow.Attributes["escrow"].InnerText);
            marketItem.Price = Convert.ToDouble(marketOrderRow.Attributes["price"].InnerText);
            marketItem.Bid = Convert.ToBoolean(Convert.ToInt32(marketOrderRow.Attributes["bid"].InnerText));
            marketItem.Issued = Convert.ToDateTime(marketOrderRow.Attributes["issued"].InnerText);

            return marketItem;
        }
    }

    /// <summary>
    /// A single market order associated with a person or corporation
    /// </summary>
    public class MarketOrderItem
    {
        
        /// <summary>
        /// Order id, not forever unique but for this pull they will be unique
        /// </summary>
        public int OrderId;

        /// <summary>
        /// Character Id of the character who placed the market order
        /// </summary>
        public long CharId;

        /// <summary>
        /// The Id of the station that the order was placed in
        /// </summary>
        public long StationId;

        /// <summary>
        /// The quantity of the items required/offered when the order was placed
        /// </summary>
        public long VolEntered;

        /// <summary>
        /// The quantitiy of items that are still for sale/ still required
        /// </summary>
        public long VolRemaining;

        /// <summary>
        /// For bids (buy orders) the minimum quantity that must be sold in one
        /// sale so that the order is accepted.
        /// </summary>
        public long MinVolume;

        /// <summary>
        /// See <see cref="marketOrderState"/> for full descriptions of each order state
        /// </summary>
        public marketOrderState OrderState;

        /// <summary>
        /// This is the typeId of the item that is being bought/sold
        /// </summary>
        public long TypeId;

        /// <summary>
        /// This is the range of the order
        /// For sell orders it is always 32767
        /// For buy orders it is either -1 = station, 0 = solar system
        /// Any number above 1 is number of jumps in region
        /// And 32767 means region
        /// </summary>
        public int Range;

        /// <summary>
        /// This is which wallet the order is using, for a personal order
        /// this will always be 1000, for corporation orders it can be 1000-1006
        /// depending on which wallet is being used
        /// </summary>
        public int AccountKey;

        /// <summary>
        /// How many days this order is good for. Expiration is issued + duration in days
        /// </summary>
        public int Duration;

        /// <summary>
        /// How much ISK is in escrow. Valid for buy orders only (I believe).
        /// </summary>
        public double Escrow;

        /// <summary>
        /// The cost per unit for this order
        /// </summary>
        public double Price;

        /// <summary>
        /// If true this is a bid or buy order, else it is a sell order
        /// </summary>
        public bool Bid;

        /// <summary>
        /// This is when the order was issued
        /// </summary>
        public DateTime Issued;
    }

    /// <summary>
    /// This is the current state of the market order, letting you know if the
    /// item is still on the market or not.
    /// </summary>
    public enum marketOrderState
    {
        /// <summary>
        /// If the market order is still active and up on the market
        /// </summary>
        OpenActive = 0,

        /// <summary>
        /// The order has been closed
        /// </summary>
        Closed = 1,

        /// <summary>
        /// The order has expired, or has been fufilled so it is no longer active
        /// </summary>
        ExpiredFulfilled = 2,

        /// <summary>
        /// The order was canceled
        /// </summary>
        Canceled = 3,

        /// <summary>
        /// The order is currently pending, and not on the market
        /// </summary>
        Pending = 4,

        /// <summary>
        /// The character that this order was associated with has been deleted
        /// </summary>
        CharacterDeleted = 5
    }

    /// <summary>
    /// If this is a corporation or (peronal) character market order
    /// </summary>
    public enum MarketOrderType
    {
        /// <summary>
        /// A corporation market order
        /// </summary>
        Corporation,
        /// <summary>
        /// A personal market order
        /// </summary>
        Character
    }
}
