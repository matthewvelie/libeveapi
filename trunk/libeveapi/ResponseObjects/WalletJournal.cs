using System;
using System.Collections.Generic;
using System.Text;

namespace libeveapi
{
    class WalletJournal :  JournalEntries
    {

        private WalletJournalItem[] walletJournalItems = new WalletJournalItem[0];

        public WalletJournalItem[] WalletJournalItems { get { return walletJournalItems; } set { walletJournalItems = value; } }

        public class WalletJournalItem : JournalEntryItem
        {
            private int taxReceiverID;
            private decimal taxAmount;

            public int TaxRecieverID { get { return taxReceiverID; } set { taxReceiverID = value; } }
            public decimal TaxAmount { get { return taxAmount; } set { taxAmount = value; } }
        }
    }
}
