using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Represents a character or corporation journal entry from the eve api
    /// http://wiki.eve-dev.net/APIv2_Char_JournalEntries_XML
    /// </summary>
    public class JournalEntries : ApiResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public JournalEntryItem[] JournalEntryItems = new JournalEntryItem[0];

        /// <summary>
        /// Create an JournalEntryItemList by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc">An XML Document containing the JournalEntries List</param>
        /// <returns><see cref="JournalEntries"/></returns>
        public static JournalEntries FromXmlDocument(XmlDocument xmlDoc)
        {
            JournalEntries JournalEntryList = new JournalEntries();
            JournalEntryList.ParseCommonElements(xmlDoc);

            List<JournalEntryItem> journalEntry = new List<JournalEntryItem>();
            foreach (XmlNode node in xmlDoc.SelectNodes("//rowset[@name='entries']/row"))
            {
                journalEntry.Add(ParseTransactionRow(node));
            }
            JournalEntryList.JournalEntryItems = journalEntry.ToArray();

            return JournalEntryList;
        }

        /// <summary>
        /// Create an JournalEntryItem by parsing a single row
        /// </summary>
        /// <param name="journalTransactionRow"></param>
        /// <returns></returns>
        protected static JournalEntryItem ParseTransactionRow(XmlNode journalTransactionRow)
        {
            JournalEntryItem journalEntryItem = new JournalEntryItem();

            journalEntryItem.Date = Convert.ToDateTime(journalTransactionRow.Attributes["date"].InnerText);
            journalEntryItem.RefID = Convert.ToInt64(journalTransactionRow.Attributes["refID"].InnerText);
            journalEntryItem.RefTypeID = Convert.ToInt64(journalTransactionRow.Attributes["refTypeID"].InnerText);
            journalEntryItem.OwnerName1 = journalTransactionRow.Attributes["ownerName1"].InnerText;
            journalEntryItem.OwnerID1 = Convert.ToInt64(journalTransactionRow.Attributes["ownerID1"].InnerText);
            journalEntryItem.OwnerName2 = journalTransactionRow.Attributes["ownerName2"].InnerText;
            journalEntryItem.OwnerID2 = Convert.ToInt64(journalTransactionRow.Attributes["ownerID2"].InnerText);
            journalEntryItem.ArgName1 = journalTransactionRow.Attributes["argName1"].InnerText;
            journalEntryItem.ArgID1 = Convert.ToInt64(journalTransactionRow.Attributes["argID1"].InnerText);
            journalEntryItem.Amount = Convert.ToDouble(journalTransactionRow.Attributes["amount"].InnerText);
            journalEntryItem.Balance = Convert.ToDouble(journalTransactionRow.Attributes["balance"].InnerText);
            journalEntryItem.Reason = journalTransactionRow.Attributes["reason"].InnerText;

            return journalEntryItem;
        }
    }

    /// <summary>
    /// Contains the data for one journal entry item
    /// </summary>
    public class JournalEntryItem
    {
        /// <summary>
        /// The date / time of the entry
        /// </summary>
        public DateTime Date;

        /// <summary>
        /// A unique referenceID for each transaction
        /// </summary>
        public long RefID;

        /// <summary>
        /// The typeID of the item that is referenced in the entry
        /// </summary>
        public long RefTypeID;

        /// <summary>
        /// Name of the person/corp giving money
        /// </summary>
        public string OwnerName1;

        /// <summary>
        /// TypeID/CharID of the person/corp giving money
        /// </summary>
        public long OwnerID1 ;

        /// <summary>
        /// Name of the person/corp recieving money
        /// </summary>
        public string OwnerName2;

        /// <summary>
        /// TypeID/CharID of the person/corp recieving money
        /// </summary>
        public long OwnerID2;

        /// <summary>
        /// This is either the system where the transaction took place
        /// For example when recieving bounties, or "EVE System" if used
        /// for other items like buying and selling
        /// </summary>
        public string ArgName1;

        /// <summary>
        /// This is an argument ID that goes with the argument
        /// Use the data from: http://wiki.eve-dev.net/APIv2_Eve_RefTypes_XML
        /// to determine what this is used for
        /// </summary>
        public long ArgID1;

        /// <summary>
        /// The amount of the transaction
        /// </summary>
        public double Amount;

        /// <summary>
        /// The balance left in the account after the transaction
        /// </summary>
        public double Balance;

        /// <summary>
        /// This is the note attached to the transaction if any
        /// If exists for bounties this is the list of people killed and how many
        /// Ex: TypeID:Number;TypeID:Number
        /// </summary>
        public string Reason;
    }

    /// <summary>
    /// Represents what type of journal entry, corporation or character
    /// </summary>
    public enum JournalEntryType
    {
        /// <summary>
        /// Corporation journal entry
        /// </summary>
        Corporation,
        /// <summary>
        /// Character journal entry
        /// </summary>
        Character
    }
}