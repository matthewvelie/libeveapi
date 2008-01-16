using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Represents a character or corporation AccountBalance response from the eve api
    /// http://wiki.eve-dev.net/APIv2_Char_MarketTransactions_XML
    /// </summary>
    public class WalletTransactions : ApiResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public WalletTransactionItem[] WalletTransactionItems = new WalletTransactionItem[0];

        /// <summary>
        /// Create an WalletTransaction by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc">An XML Document Containing Wallet Transaction Data</param>
        /// <returns></returns>
        public static WalletTransactions FromXmlDocument(XmlDocument xmlDoc)
        {
            WalletTransactions WalletTransactionList = new WalletTransactions();
            WalletTransactionList.ParseCommonElements(xmlDoc);

            List<WalletTransactionItem> transactions = new List<WalletTransactionItem>();
            foreach (XmlNode node in xmlDoc.SelectNodes("//rowset[@name='transactions']/row"))
            {
                transactions.Add(ParseTransactionRow(node));
            }
            WalletTransactionList.WalletTransactionItems = transactions.ToArray();

            return WalletTransactionList;
        }

        /// <summary>
        /// Create an WalletTransactionItem by parsing a single row
        /// </summary>
        /// <param name="walletTransactionRow"></param>
        /// <returns></returns>
        protected static WalletTransactionItem ParseTransactionRow(XmlNode walletTransactionRow)
        {
            WalletTransactionItem WalletTransactionItem = new WalletTransactionItem();

            WalletTransactionItem.TransactionDateTime = Convert.ToDateTime(walletTransactionRow.Attributes["transactionDateTime"].InnerText);
            WalletTransactionItem.TransactionID = Convert.ToInt32(walletTransactionRow.Attributes["transactionID"].InnerText);
            WalletTransactionItem.Quantity = Convert.ToInt32(walletTransactionRow.Attributes["quantity"].InnerText);
            WalletTransactionItem.TypeName = walletTransactionRow.Attributes["typeName"].InnerText;
            WalletTransactionItem.TypeID = Convert.ToInt64(walletTransactionRow.Attributes["typeID"].InnerText);
            WalletTransactionItem.Price = (float)Convert.ToDouble(walletTransactionRow.Attributes["price"].InnerText);
            WalletTransactionItem.ClientID = Convert.ToInt64(walletTransactionRow.Attributes["clientID"].InnerText);
            WalletTransactionItem.ClientName = walletTransactionRow.Attributes["clientName"].InnerText;
            
            //These are only present in the corp version
            if (walletTransactionRow.Attributes.GetNamedItem("characterID") != null)
            {
                WalletTransactionItem.CharacterID = Convert.ToInt64(walletTransactionRow.Attributes["characterID"].InnerText);
            }
            if (walletTransactionRow.Attributes.GetNamedItem("characterName") != null)
            {
                WalletTransactionItem.CharacterName = walletTransactionRow.Attributes["characterName"].InnerText;
            }

            WalletTransactionItem.StationID = Convert.ToInt64(walletTransactionRow.Attributes["stationID"].InnerText);
            WalletTransactionItem.StationName = walletTransactionRow.Attributes["stationName"].InnerText;
            WalletTransactionItem.TransactionType = walletTransactionRow.Attributes["transactionType"].InnerText;
            WalletTransactionItem.TransactionFor = walletTransactionRow.Attributes["transactionFor"].InnerText;

            return WalletTransactionItem;
        }
    }

    /// <summary>
    /// Contains information about one wallet transaction
    /// </summary>
    public class WalletTransactionItem
    {
        /// <summary>
        /// This is the date and time when the transaction took place
        /// </summary>
        public DateTime TransactionDateTime;

        /// <summary>
        /// This is the transactionID that is assigned to the transaction
        /// </summary>
        public int TransactionID;

        /// <summary>
        /// This is the quantity of the item
        /// </summary>
        public int Quantity;

        /// <summary>
        /// This is the name of the item in the transaction
        /// </summary>
        public string TypeName;

        /// <summary>
        /// This is the typeID of the item referenced in the transaction
        /// </summary>
        public long TypeID;

        /// <summary>
        /// This is the price of the item in the transaction
        /// </summary>
        public double Price;

        /// <summary>
        /// The client's ID
        /// </summary>
        public long ClientID;

        /// <summary>
        /// The client's name
        /// </summary>
        public string ClientName;

        /// <summary>
        /// The character who initiated the transaction's id 
        /// This is only present when viewing corp transactions, otherwise
        /// it is assumed to be the character accessing the data
        /// </summary>
        public long CharacterID;

        /// <summary>
        /// The character who initiated the transaction's name 
        /// This is only present when viewing corp transactions, otherwise
        /// it is assumed to be the character accessing the data
        /// </summary>
        public string CharacterName;

        /// <summary>
        /// The ID of the station where the transaction took place
        /// </summary>
        public long StationID;

        /// <summary>
        /// The name of the station where the transaction took place
        /// </summary>
        public string StationName;

        /// <summary>
        /// This is the type of transaction type, sell or buy
        /// </summary>
        public string TransactionType;

        /// <summary>
        /// This is who the transaction was for (personal or corporation)
        /// </summary>
        public string TransactionFor;
    }

    /// <summary>
    /// If the transaction is a corporation or character transaction
    /// </summary>
    public enum WalletTransactionListType
    {
        /// <summary>
        /// A corporation transaction
        /// </summary>
        Corporation,
        /// <summary>
        /// A character transaction
        /// </summary>
        Character
    }
}
