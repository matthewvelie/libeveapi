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
        /// A unique referenceID for each transaction
        /// </summary>
        public long refID;

        /// <summary>
        /// The typeID of the item that is referenced in the entry
        /// </summary>
        public long refTypeID;

        /// <summary>
        /// Name of the person/corp giving money
        /// </summary>
        public string ownerName1;

        /// <summary>
        /// TypeID/CharID of the person/corp giving money
        /// </summary>
        public long ownerID1 ;

        /// <summary>
        /// Name of the person/corp recieving money
        /// </summary>
        public string ownerName2;

        /// <summary>
        /// TypeID/CharID of the person/corp recieving money
        /// </summary>
        public long ownerID2;

        /// <summary>
        /// This is either the system where the transaction took place
        /// For example when recieving bounties, or "EVE System" if used
        /// for other items like buying and selling
        /// </summary>
        public string argName1;

        /// <summary>
        /// This is an argument ID that goes with the argument
        /// 38 = Dividend, 1/10 = Player Transfer, 72/74 = Insurance, 85 = Bounties
        /// 42 = ,54 = , 2 = , 15 = , 35 =, 46 = , 17 = Single Bounty, 33 = , 37 =
        /// </summary>
        public long argID1;

        /// <summary>
        /// The ammount of the transaction
        /// </summary>
        public double ammount;

        /// <summary>
        /// The balance left in the account after the transaction
        /// </summary>
        public double balance;

        /// <summary>
        /// This is the note attached to the transaction if any
        /// If exists for bounties this is the list of people killed and how many
        /// Ex: TypeID:Number;TypeID:Number
        /// </summary>
        public string reason;
    }

    public enum WalletTransactionListType
    {
        Corporation,
        Character
    }
}
