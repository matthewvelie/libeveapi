using System;
using System.Collections.Generic;
using System.Text;

namespace libeveapi
{
    /// <summary>
    /// Contains a list of research projects transactions for a character.
    /// http://wiki.eve-id.net/APIv2_Char_JournalEntries_XML
    /// </summary>
    public class WalletJournal :  JournalEntries
    {

        /// <summary>
        /// API Version Compatibility
        /// </summary>
        public new const string API_VERSION = "2";
        private WalletJournalItem[] walletJournalItems = new WalletJournalItem[0];

        /// <summary>
        /// Array of Wallet Journal Transactions
        /// </summary>
        public WalletJournalItem[] WalletJournalItems { get { return walletJournalItems; } set { walletJournalItems = value; } }
        /// <summary>
        /// Deprecated Entry List.  Exists for legacy compatibility.
        /// Use WalletJournalItems
        /// </summary>
        public new JournalEntryItem[] JournalEntryItems { get { return base.JournalEntryItems; } set { base.JournalEntryItems = value; } }

        /// <summary>
        /// Contains one Wallet Journal Entry
        /// </summary>
        public class WalletJournalItem : JournalEntryItem
        {
            /// <summary>
            /// XmlResponse Columns List
            /// </summary>
            public static string ColumnsChar = "date,refID,refTypeID,ownerName1,ownerID1,ownerName2,ownerID2,argName1,argID1,amount,balance,reason, taxRecieverID, taxAmount";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
            public static string KeyChar = "refID";
            /// <summary>
            /// XmlResponse Columns List
            /// </summary>
            public static string ColumnsCorp = "date,refID,refTypeID,ownerName1,ownerID1,ownerName2,ownerID2,argName1,argID1,amount,balance,reason";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
            public static string KeyCorp = "refID";
            private int taxReceiverID;
            private decimal taxAmount;

            /// <summary>
            /// If Corporation taxes are involved. The ID of the Corporation the Tax is paid to
            /// </summary>
            public int TaxRecieverID { get { return taxReceiverID; } set { taxReceiverID = value; } }
            /// <summary>
            /// Amount of the Tax paid to the corporation determined by TaxRecieverID
            /// </summary>
            public decimal TaxAmount { get { return taxAmount; } set { taxAmount = value; } }
        }
    }

    /// <summary>
    /// Represents the type of Wallet Journal entry, corporation or character
    /// </summary>
    public enum WalletJournalType
    {
        /// <summary>
        /// Corporation Wallet Journal entry
        /// </summary>
        Corporation,
        /// <summary>
        /// Character Wallet Journal entry
        /// </summary>
        Character
    }
}
