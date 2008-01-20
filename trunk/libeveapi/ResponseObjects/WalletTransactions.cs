using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Returns market transactions for a character.
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
            WalletTransactionItem walletTransactionItem = new WalletTransactionItem();

            walletTransactionItem.TransactionDateTime = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(walletTransactionRow.Attributes["transactionDateTime"].InnerText);
            walletTransactionItem.TransactionDateTimeLocal = TimeUtilities.ConvertCCPToLocalTime(walletTransactionItem.TransactionDateTime);
            walletTransactionItem.TransactionId = Convert.ToInt32(walletTransactionRow.Attributes["transactionID"].InnerText);
            walletTransactionItem.Quantity = Convert.ToInt32(walletTransactionRow.Attributes["quantity"].InnerText);
            walletTransactionItem.TypeName = walletTransactionRow.Attributes["typeName"].InnerText;
            walletTransactionItem.TypeId = Convert.ToInt32(walletTransactionRow.Attributes["typeID"].InnerText);
            walletTransactionItem.Price = (float)Convert.ToDouble(walletTransactionRow.Attributes["price"].InnerText);
            walletTransactionItem.ClientId = Convert.ToInt32(walletTransactionRow.Attributes["clientID"].InnerText);
            walletTransactionItem.ClientName = walletTransactionRow.Attributes["clientName"].InnerText;
            
            //These are only present in the corp version
            if (walletTransactionRow.Attributes.GetNamedItem("characterID") != null)
            {
                walletTransactionItem.CharacterId = Convert.ToInt32(walletTransactionRow.Attributes["characterID"].InnerText);
            }
            if (walletTransactionRow.Attributes.GetNamedItem("characterName") != null)
            {
                walletTransactionItem.CharacterName = walletTransactionRow.Attributes["characterName"].InnerText;
            }

            walletTransactionItem.StationId = Convert.ToInt32(walletTransactionRow.Attributes["stationID"].InnerText);
            walletTransactionItem.StationName = walletTransactionRow.Attributes["stationName"].InnerText;
            walletTransactionItem.TransactionType = walletTransactionRow.Attributes["transactionType"].InnerText;
            walletTransactionItem.TransactionFor = walletTransactionRow.Attributes["transactionFor"].InnerText;

            return walletTransactionItem;
        }
    }

    /// <summary>
    /// Contains information about one wallet transaction
    /// </summary>
    public class WalletTransactionItem
    {
        /// <summary>
        /// This is the date and time when the transaction took place in ccp time
        /// </summary>
        public DateTime TransactionDateTime;

        /// <summary>
        /// This is the date and time when the transaction took place in local time
        /// </summary>
        public DateTime TransactionDateTimeLocal;

        /// <summary>
        /// This is the transactionId that is assigned to the transaction
        /// </summary>
        public int TransactionId;

        /// <summary>
        /// This is the quantity of the item
        /// </summary>
        public int Quantity;

        /// <summary>
        /// This is the name of the item in the transaction
        /// </summary>
        public string TypeName;

        /// <summary>
        /// This is the typeId of the item referenced in the transaction
        /// </summary>
        public int TypeId;

        /// <summary>
        /// This is the price of the item in the transaction
        /// </summary>
        public double Price;

        /// <summary>
        /// The client's Id
        /// </summary>
        public int ClientId;

        /// <summary>
        /// The client's name
        /// </summary>
        public string ClientName;

        /// <summary>
        /// The character who initiated the transaction's id 
        /// This is only present when viewing corp transactions, otherwise
        /// it is assumed to be the character accessing the data
        /// </summary>
        public int CharacterId;

        /// <summary>
        /// The character who initiated the transaction's name 
        /// This is only present when viewing corp transactions, otherwise
        /// it is assumed to be the character accessing the data
        /// </summary>
        public string CharacterName;

        /// <summary>
        /// The Id of the station where the transaction took place
        /// </summary>
        public int StationId;

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
