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
    class WalletTransactions : ApiResponse
    {
        public WalletTransactionItem[] WalletTransactionItems = new WalletTransactionItem[0];

        /// <summary>
        /// Create an IndustryJobList by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc"></param>
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
        /// <param name="assetRow"></param>
        /// <returns></returns>
        protected static WalletTransactionItem ParseTransactionRow(XmlNode walletTransactionRow)
        {
            WalletTransactionItem WalletTransactionItem = new WalletTransactionItem();

            WalletTransactionItem.transactionDateTime = Convert.ToDateTime(walletTransactionRow.Attributes["transactionDateTime"].InnerText);
            WalletTransactionItem.transactionID = Convert.ToInt32(walletTransactionRow.Attributes["transactionID"].InnerText);
            WalletTransactionItem.quantity = Convert.ToInt32(walletTransactionRow.Attributes["quantity"].InnerText);
            WalletTransactionItem.typeName = walletTransactionRow.Attributes["typeName"].InnerText;
            WalletTransactionItem.typeID = Convert.ToInt64(walletTransactionRow.Attributes["typeID"].InnerText);
            WalletTransactionItem.price = (float)Convert.ToDouble(walletTransactionRow.Attributes["price"].InnerText);
            WalletTransactionItem.clientID = Convert.ToInt64(walletTransactionRow.Attributes["clientID"].InnerText);
            WalletTransactionItem.clientName = walletTransactionRow.Attributes["clientName"].InnerText;
            
            //These are only present in the corp version
            if (walletTransactionRow.Attributes.GetNamedItem("characterID") != null)
            {
                WalletTransactionItem.characterID = Convert.ToInt64(walletTransactionRow.Attributes["characterID"].InnerText);
            }
            if (walletTransactionRow.Attributes.GetNamedItem("characterName") != null)
            {
                WalletTransactionItem.characterName = walletTransactionRow.Attributes["characterName"].InnerText;
            }

            WalletTransactionItem.stationID = Convert.ToInt64(walletTransactionRow.Attributes["stationID"].InnerText);
            WalletTransactionItem.stationName = walletTransactionRow.Attributes["stationName"].InnerText;
            WalletTransactionItem.transactionType = walletTransactionRow.Attributes["transactionType"].InnerText;
            WalletTransactionItem.transactionFor = walletTransactionRow.Attributes["transactionFor"].InnerText;

            return WalletTransactionItem;
        }
    }

    public class WalletTransactionItem
    {
        /// <summary>
        /// This is the date and time when the transaction took place
        /// </summary>
        public DateTime transactionDateTime;

        /// <summary>
        /// This is the transactionID that is assigned to the transaction
        /// </summary>
        public int transactionID;

        /// <summary>
        /// This is the quantity of the item
        /// </summary>
        public int quantity;

        /// <summary>
        /// This is the name of the item in the transaction
        /// </summary>
        public string typeName;

        /// <summary>
        /// This is the typeID of the item referenced in the transaction
        /// </summary>
        public long typeID;

        /// <summary>
        /// This is the price of the item in the transaction
        /// </summary>
        public double price;

        /// <summary>
        /// The client's ID
        /// </summary>
        public long clientID;

        /// <summary>
        /// The client's name
        /// </summary>
        public string clientName;

        /// <summary>
        /// The character who initiated the transaction's id 
        /// This is only present when viewing corp transactions, otherwise
        /// it is assumed to be the character accessing the data
        /// </summary>
        public long characterID;

        /// <summary>
        /// The character who initiated the transaction's name 
        /// This is only present when viewing corp transactions, otherwise
        /// it is assumed to be the character accessing the data
        /// </summary>
        public string characterName;

        /// <summary>
        /// The ID of the station where the transaction took place
        /// </summary>
        public long stationID;

        /// <summary>
        /// The name of the station where the transaction took place
        /// </summary>
        public string stationName;

        /// <summary>
        /// This is the type of transaction type, sell or buy
        /// </summary>
        public string transactionType;

        /// <summary>
        /// This is who the transaction was for (personal or corporation)
        /// </summary>
        public string transactionFor;
    }

    public enum WalletTransactionListType
    {
        Corporation,
        Character
    }
}
