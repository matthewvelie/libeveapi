using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    class JournalEntries : ApiResponse
    {

    }

    public class JournalEntryItem
    {
        /// <summary>
        /// The date / time of the entry
        /// </summary>
        public DateTime date;

        /// <summary>
        /// 
        /// </summary>
        public long refID;

        /// <summary>
        /// The typeID of the item that is referenced in the entry
        /// </summary>
        public long refTypeID;

        /// <summary>
        /// 
        /// </summary>
        public string ownerName1;

        /// <summary>
        /// 
        /// </summary>
        public long ownerID1 ;

        /// <summary>
        /// 
        /// </summary>
        public string ownerName2;

        /// <summary>
        /// 
        /// </summary>
        public long ownerID2;

        /// <summary>
        /// 
        /// </summary>
        public string argName1;

        /// <summary>
        /// 
        /// </summary>
        public long argID1;

        /// <summary>
        /// The ammount of the transaction
        /// </summary>
        public double ammount;

        /// <summary>
        /// The balance lfet in the account after the transaction
        /// </summary>
        public double balance;

        /// <summary>
        /// 
        /// </summary>
        public string reason;
    }

    public enum WalletTransactionListType
    {
        Corporation,
        Character
    }
}
