using System;

namespace libeveapi
{
    /// <summary>
    /// Returns the medals owned by the Character.
    /// http://wiki.eve-id.net/APIv2_Char_Medals_XML
    /// </summary>
    public class Shareholders : ApiResponse
    {
        /// <summary>
        /// API Version Compatibility
        /// </summary>
		public const string API_VERSION = "2";
		private CharacterShareholder[] characterShares = new CharacterShareholder[0];
		private CorporationShareholder[] corporationShares = new CorporationShareholder[0];

        public Shareholders(){throw new NotImplementedException("Object has not been tested against true data");}

        /// <summary>
        /// Array of Character Shareholders
        /// </summary>
        public CharacterShareholder[] CharacterShares
        {
            get { return characterShares; }
            set { characterShares = value; }
        }
        /// <summary>
        /// Array of Corporation Shareholders
        /// </summary>
        public CorporationShareholder[] CorporationShares
        {
            get { return corporationShares; }
            set { corporationShares = value; }
        }

        /// <summary>
        /// Contains Character Shareholder information
        /// </summary>
		public class CharacterShareholder : ShareholderItem
		{
            /// <summary>
            /// XmlResponse Columns List
            /// </summary>
			public static string Columns="shareholderID,shareholderName,shareholderCorporationID,shareholderCorporationName,shares";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string Key = "shareholderID";
			
            /// <summary>
            /// Default Constructor
            /// </summary>
            public CharacterShareholder(){}
            /// <summary>
            /// Full Constructor
            /// </summary>
			public CharacterShareholder(int shareholderID,string shareholderName,int shareholderCorporationID,string shareholderCorporationName,int shares)
			{
				this.shareholderID = shareholderID;
				this.shareholderName = shareholderName;
				this.shareholderCorporationID = shareholderCorporationID;
				this.shareholderCorporationName = shareholderCorporationName;
				this.shares = shares;
			}
			
			private int shareholderCorporationID;
			private string shareholderCorporationName;

		    /// <summary>
            /// Corporation ID of share holder
            /// </summary>
            public int ShareholderCorporationID
            {
                get { return shareholderCorporationID; }
                set { shareholderCorporationID = value; }
            }
            /// <summary>
            /// Corporation name of share holder
            /// </summary>
            public string ShareholderCorporationName
            {
                get { return shareholderCorporationName; }
                set { shareholderCorporationName = value; }
            }

		}
        /// <summary>
        /// Holds Shareholder information for a Corporation
        /// </summary>
        public class CorporationShareholder : ShareholderItem
        {
            /// <summary>
            /// XmlResponse Columns List
            /// </summary>
			public static string Columns="shareholderID,shareholderName,shares";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string Key = "shareholderID";
			
            /// <summary>
            /// Default Constructor
            /// </summary>
            public CorporationShareholder(){}
            /// <summary>
            /// Full constructor
            /// </summary>
            public CorporationShareholder(int shareholderID,string shareholderName,int shares)
			{
				this.shareholderID = shareholderID;
				this.shareholderName = shareholderName;
				this.shares = shares;
			}

		}
        
        /// <summary>
        /// Base class holds Shareholder information
        /// </summary>
        abstract public class ShareholderItem
        {
            /// <summary>
            /// Default Constructor
            /// </summary>
            public ShareholderItem(){}
            /// <summary>
            /// Full Constructor
            /// </summary>
            public ShareholderItem(int shareholderID,string shareholderName,int shares)
			{
				this.shareholderID = shareholderID;
				this.shareholderName = shareholderName;
				this.shares = shares;
			}

            /// <summary>
            /// ID
            /// </summary>
			protected int shareholderID;
            /// <summary>
            /// Name
            /// </summary>
			protected string shareholderName;
            /// <summary>
            /// Number of shares
            /// </summary>
			protected int shares;

            /// <summary>
            /// Character ID of share holder
            /// </summary>
            public int ShareholderID
            {
                get { return shareholderID; }
                set { shareholderID = value; }
            }

            /// <summary>
            /// Character name of share holder
            /// </summary>
            public string ShareholderName
            {
                get { return shareholderName; }
                set { shareholderName = value; }
            }
            /// <summary>
            /// Number of Shares
            /// </summary>
            public int Shares
            {
                get { return shares; }
                set { shares = value; }
            }
		}
    }
    /// <summary>
    /// If the transaction is a corporation or character transaction
    /// </summary>
    public enum ShareholderType
    {
        /// <summary>
        /// Shareholder Entry Type
        /// </summary>
        Corporation,
        /// <summary>
        /// A character transaction
        /// </summary>
        Character
    }
}
