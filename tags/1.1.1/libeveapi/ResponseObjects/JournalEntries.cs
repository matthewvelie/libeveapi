using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Represents a character or corporation journal entry from the eve api
    /// http://wiki.eve-dev.net/APIv2_Char_JournalEntries_XML
    /// </summary>
    public class JournalEntries : ApiResponse
    {
        private JournalEntryItem[] journalEntryItems = new JournalEntryItem[0];

        /// <summary>
        /// 
        /// </summary>
        public JournalEntryItem[] JournalEntryItems
        {
            get { return journalEntryItems; }
            set { journalEntryItems = value; }
        }

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

            journalEntryItem.Date = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(journalTransactionRow.Attributes["date"].InnerText);
            journalEntryItem.DateLocal = TimeUtilities.ConvertCCPToLocalTime(journalEntryItem.Date);
            journalEntryItem.RefId = Convert.ToInt32(journalTransactionRow.Attributes["refID"].InnerText, CultureInfo.InvariantCulture);
            journalEntryItem.RefTypeId = Convert.ToInt32(journalTransactionRow.Attributes["refTypeID"].InnerText, CultureInfo.InvariantCulture);
            journalEntryItem.OwnerName1 = journalTransactionRow.Attributes["ownerName1"].InnerText;
            journalEntryItem.OwnerId1 = Convert.ToInt32(journalTransactionRow.Attributes["ownerID1"].InnerText, CultureInfo.InvariantCulture);
            journalEntryItem.OwnerName2 = journalTransactionRow.Attributes["ownerName2"].InnerText;
            journalEntryItem.OwnerId2 = Convert.ToInt32(journalTransactionRow.Attributes["ownerID2"].InnerText, CultureInfo.InvariantCulture);
            journalEntryItem.ArgName1 = journalTransactionRow.Attributes["argName1"].InnerText;
            journalEntryItem.ArgId1 = Convert.ToInt32(journalTransactionRow.Attributes["argID1"].InnerText, CultureInfo.InvariantCulture);
            journalEntryItem.Amount = Convert.ToDouble(journalTransactionRow.Attributes["amount"].InnerText, CultureInfo.InvariantCulture);
            journalEntryItem.Balance = Convert.ToDouble(journalTransactionRow.Attributes["balance"].InnerText, CultureInfo.InvariantCulture);
            journalEntryItem.Reason = journalTransactionRow.Attributes["reason"].InnerText;

            return journalEntryItem;
        }

        /// <summary>
        /// Contains the data for one journal entry item
        /// </summary>
        public class JournalEntryItem
        {
            private DateTime date;
            private DateTime dateLocal;
            private int refId;
            private int refTypeId;
            private string ownerName1;
            private int ownerId1;
            private string ownerName2;
            private int ownerId2;
            private string argName1;
            private int argId1;
            private double amount;
            private double balance;
            private string reason;

            /// <summary>
            /// The date / time of the entry
            /// </summary>
            public DateTime Date
            {
                get { return date; }
                set { date = value; }
            }

            /// <summary>
            /// The date / time of the entry in local time
            /// </summary>
            public DateTime DateLocal
            {
                get { return dateLocal; }
                set { dateLocal = value; }
            }

            /// <summary>
            /// A unique referenceId for each transaction
            /// </summary>
            public int RefId
            {
                get { return refId; }
                set { refId = value; }
            }

            /// <summary>
            /// The typeId of the item that is referenced in the entry
            /// </summary>
            public int RefTypeId
            {
                get { return refTypeId; }
                set { refTypeId = value; }
            }

            /// <summary>
            /// Name of the person/corp giving money
            /// </summary>
            public string OwnerName1
            {
                get { return ownerName1; }
                set { ownerName1 = value; }
            }

            /// <summary>
            /// TypeId/CharId of the person/corp giving money
            /// </summary>
            public int OwnerId1
            {
                get { return ownerId1; }
                set { ownerId1 = value; }
            }

            /// <summary>
            /// Name of the person/corp recieving money
            /// </summary>
            public string OwnerName2
            {
                get { return ownerName2; }
                set { ownerName2 = value; }
            }

            /// <summary>
            /// TypeId/CharId of the person/corp recieving money
            /// </summary>
            public int OwnerId2
            {
                get { return ownerId2; }
                set { ownerId2 = value; }
            }

            /// <summary>
            /// This is either the system where the transaction took place
            /// For example when recieving bounties, or "EVE System" if used
            /// for other items like buying and selling
            /// </summary>
            public string ArgName1
            {
                get { return argName1; }
                set { argName1 = value; }
            }

            /// <summary>
            /// This is an argument Id that goes with the argument
            /// Use the data from: http://wiki.eve-dev.net/APIv2_Eve_RefTypes_XML
            /// to determine what this is used for
            /// </summary>
            public int ArgId1
            {
                get { return argId1; }
                set { argId1 = value; }
            }

            /// <summary>
            /// The amount of the transaction
            /// </summary>
            public double Amount
            {
                get { return amount; }
                set { amount = value; }
            }

            /// <summary>
            /// The balance left in the account after the transaction
            /// </summary>
            public double Balance
            {
                get { return balance; }
                set { balance = value; }
            }

            /// <summary>
            /// This is the note attached to the transaction if any
            /// If exists for bounties this is the list of people killed and how many
            /// Ex: TypeId:Number;TypeId:Number
            /// </summary>
            public string Reason
            {
                get { return reason; }
                set { reason = value; }
            }
        }
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
