using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Returns a list of market orders that are either not expired or have expired in the past week (at most).
    /// http://wiki.eve-dev.net/APIv2_Corp_MarketOrders_XML
    /// </summary>
    public class MarketOrders : ApiResponse
    {
        private MarketOrderItem[] marketOrderItems = new MarketOrderItem[0];

        /// <summary>
        /// 
        /// </summary>
        public MarketOrderItem[] MarketOrderItems
        {
            get { return marketOrderItems; }
            set { marketOrderItems = value; }
        }

        /// <summary>
        /// Create an MarketOrderList by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static MarketOrders FromXmlDocument(XmlDocument xmlDoc)
        {
            MarketOrders MarketOrderList = new MarketOrders();
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

            marketItem.OrderId = Convert.ToInt32(marketOrderRow.Attributes["orderID"].InnerText, CultureInfo.InvariantCulture);
            marketItem.CharId = Convert.ToInt64(marketOrderRow.Attributes["charID"].InnerText, CultureInfo.InvariantCulture);
            marketItem.StationId = Convert.ToInt64(marketOrderRow.Attributes["stationID"].InnerText, CultureInfo.InvariantCulture);
            marketItem.VolEntered = Convert.ToInt64(marketOrderRow.Attributes["volEntered"].InnerText, CultureInfo.InvariantCulture);
            marketItem.VolRemaining = Convert.ToInt64(marketOrderRow.Attributes["volRemaining"].InnerText, CultureInfo.InvariantCulture);
            marketItem.MinVolume = Convert.ToInt64(marketOrderRow.Attributes["minVolume"].InnerText, CultureInfo.InvariantCulture);

            switch (Convert.ToInt32(marketOrderRow.Attributes["orderState"].InnerText, CultureInfo.InvariantCulture))
            {
                case 0:
                    marketItem.OrderState = MarketOrderState.OpenActive;
                    break;
                case 1:
                    marketItem.OrderState = MarketOrderState.Closed;
                    break;
                case 2:
                    marketItem.OrderState = MarketOrderState.ExpiredFulfilled;
                    break;
                case 3:
                    marketItem.OrderState = MarketOrderState.Canceled;
                    break;
                case 4:
                    marketItem.OrderState = MarketOrderState.Pending;
                    break;
                case 5:
                    marketItem.OrderState = MarketOrderState.CharacterDeleted;
                    break;
                default:
                    break;
            }

            marketItem.TypeId = Convert.ToInt64(marketOrderRow.Attributes["typeID"].InnerText, CultureInfo.InvariantCulture);
            marketItem.Range = Convert.ToInt32(marketOrderRow.Attributes["range"].InnerText, CultureInfo.InvariantCulture);
            marketItem.AccountKey = Convert.ToInt32(marketOrderRow.Attributes["accountKey"].InnerText, CultureInfo.InvariantCulture);
            marketItem.Duration = Convert.ToInt32(marketOrderRow.Attributes["duration"].InnerText, CultureInfo.InvariantCulture);
            marketItem.Escrow = Convert.ToDouble(marketOrderRow.Attributes["escrow"].InnerText, CultureInfo.InvariantCulture);
            marketItem.Price = Convert.ToDouble(marketOrderRow.Attributes["price"].InnerText, CultureInfo.InvariantCulture);
            marketItem.Bid = Convert.ToBoolean(Convert.ToInt32(marketOrderRow.Attributes["bid"].InnerText, CultureInfo.InvariantCulture), CultureInfo.InvariantCulture);
            marketItem.Issued = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(marketOrderRow.Attributes["issued"].InnerText);
            marketItem.IssuedLocal = TimeUtilities.ConvertCCPToLocalTime(marketItem.Issued);
            if (marketItem.Bid)
            {
                marketItem.OrderType = MarketOrderType.Buy;
            }
            else
            {
                marketItem.OrderType = MarketOrderType.Sell;
            }

            return marketItem;
        }

        /// <summary>
        /// A single market order associated with a person or corporation
        /// </summary>
        public class MarketOrderItem
        {
            public MarketOrderType orderType;
            public int orderId;
            public long charId;
            public long stationId;
            public long volEntered;
            public long volRemaining;
            public long minVolume;
            public MarketOrderState orderState;
            public long typeId;
            public int range;
            public int accountKey;
            public int duration;
            public double escrow;
            public double price;
            public bool bid;
            public DateTime issued;
            public DateTime issuedLocal;

            /// <summary>
            /// Order type (Buy or Sell)
            /// </summary>
            public MarketOrderType OrderType
            {
                get { return orderType; }
                set { orderType = value; }
            }

            /// <summary>
            /// Order id, not forever unique but for this pull they will be unique
            /// </summary>
            public int OrderId
            {
                get { return orderId; }
                set { orderId = value; }
            }

            /// <summary>
            /// Character Id of the character who placed the market order
            /// </summary>
            public long CharId
            {
                get { return charId; }
                set { charId = value; }
            }

            /// <summary>
            /// The Id of the station that the order was placed in
            /// </summary>
            public long StationId
            {
                get { return stationId; }
                set { stationId = value; }
            }

            /// <summary>
            /// The quantity of the items required/offered when the order was placed
            /// </summary>
            public long VolEntered
            {
                get { return volEntered; }
                set { volEntered = value; }
            }

            /// <summary>
            /// The quantitiy of items that are still for sale/ still required
            /// </summary>
            public long VolRemaining
            {
                get { return volRemaining; }
                set { volRemaining = value; }
            }

            /// <summary>
            /// For bids (buy orders) the minimum quantity that must be sold in one
            /// sale so that the order is accepted.
            /// </summary>
            public long MinVolume
            {
                get { return minVolume; }
                set { minVolume = value; }
            }

            /// <summary>
            /// See <see cref="MarketOrderState"/> for full descriptions of each order state
            /// </summary>
            public MarketOrderState OrderState
            {
                get { return orderState; }
                set { orderState = value; }
            }

            /// <summary>
            /// This is the typeId of the item that is being bought/sold
            /// </summary>
            public long TypeId
            {
                get { return typeId; }
                set { typeId = value; }
            }

            /// <summary>
            /// This is the range of the order
            /// For sell orders it is always 32767
            /// For buy orders it is either -1 = station, 0 = solar system
            /// Any number above 1 is number of jumps in region
            /// And 32767 means region
            /// </summary>
            public int Range
            {
                get { return range; }
                set { range = value; }
            }

            /// <summary>
            /// This is which wallet the order is using, for a personal order
            /// this will always be 1000, for corporation orders it can be 1000-1006
            /// depending on which wallet is being used
            /// </summary>
            public int AccountKey
            {
                get { return accountKey; }
                set { accountKey = value; }
            }

            /// <summary>
            /// How many days this order is good for. Expiration is issued + duration in days
            /// </summary>
            public int Duration
            {
                get { return duration; }
                set { duration = value; }
            }

            /// <summary>
            /// How much ISK is in escrow. Valid for buy orders only (I believe).
            /// </summary>
            public double Escrow
            {
                get { return escrow; }
                set { escrow = value; }
            }

            /// <summary>
            /// The cost per unit for this order
            /// </summary>
            public double Price
            {
                get { return price; }
                set { price = value; }
            }

            /// <summary>
            /// If true this is a bid or buy order, else it is a sell order
            /// </summary>
            public bool Bid
            {
                get { return bid; }
                set { bid = value; }
            }

            /// <summary>
            /// This is when the order was issued
            /// </summary>
            public DateTime Issued
            {
                get { return issued; }
                set { issued = value; }
            }

            /// <summary>
            /// This is when the order was issued in local time
            /// </summary>
            public DateTime IssuedLocal
            {
                get { return issuedLocal; }
                set { issuedLocal = value; }
            }
        }

        /// <summary>
        /// This is the current state of the market order, letting you know if the
        /// item is still on the market or not.
        /// </summary>
        public enum MarketOrderState
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
        /// What type of order was it on the market, buy or sell
        /// </summary>
        public enum MarketOrderType
        {
            /// <summary>
            /// Denotes a buy order
            /// </summary>
            Buy,

            /// <summary>
            /// Denotes a sell order
            /// </summary>
            Sell
        }
    }

    /// <summary>
    /// If this is a corporation or (peronal) character market order
    /// </summary>
    public enum MarketOrdersListType
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
