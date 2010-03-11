using System;

namespace libeveapi
{
    /// <summary>
    /// Returns the medals owned by the Character.
    /// http://wiki.eve-id.net/APIv2_Char_Medals_XML
    /// </summary>
    public class CharacterMedals : ApiResponse
    {
        /// <summary>
        /// API Version Compatibility
        /// </summary>
		public const string API_VERSION = "2";
		private MedalItem[] medals = new MedalItem[0];

        public CharacterMedals(){throw new NotImplementedException("Object has not been tested against true data");}
        
        /// <summary>
        /// Array of Medals
        /// </summary>
        public MedalItem[] Medals
        {
            get { return medals; }
            set { medals = value; }
        }

        /// <summary>
        /// Contains Medal Information
        /// </summary>
        public class MedalItem
        {
            /// <summary>
            /// XmlResponse Columns List
            /// This should match the list of field names contained in this object
            /// </summary>
			public static string Columns="medalID,reason,status,issuerID,issued,corporationID,title,description";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
            public static string Key = "medalID";
			
            /// <summary>
            /// Default Constructor
            /// </summary>
			public MedalItem(){}
            /// <summary>
            /// Full Constructor
            /// </summary>
			public MedalItem(int medalID,string reason,string status,int issuerID,DateTime issued,int corporationID,string title,string description)
			{
				this.medalID = medalID;
				this.reason = reason;
				this.status = status;
				this.issuerID = issuerID;
				this.corporationID = corporationID;
				this.issued = issued;
				this.title = title;
				this.description = description;
			}

			private int medalID;
			private string reason;
			private string status;
			private int issuerID;
			private int corporationID;
			private DateTime issued;
			private string title;
			private string description;

            /// <summary>
            /// Unique Medal ID
            /// </summary>
            public int MedalID
            {
                get { return medalID; }
                set { medalID = value; }
            }

            /// <summary>
            /// Reason the Medal was Awarded
			/// Entered by the Issuer
            /// </summary>
            public string Reason
            {
                get { return reason; }
                set { reason = value; }
            }

            /// <summary>
            /// Status of the Medal (Private/Public)
            /// </summary>
            public string Status
            {
                get { return status; }
                set { status = value; }
            }
            /// <summary>
            /// Title of the Medal
            /// </summary>
            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            /// <summary>
            /// Issuer ID
            /// </summary>
            public int IssuerID
            {
                get { return issuerID; }
                set { issuerID = value; }
            }
            /// <summary>
            /// Date Issued
            /// </summary>
            public DateTime Issued
            {
                get { return issued; }
                set { issued = value; }
            }
            /// <summary>
            /// Corporation ID of the issuing corporation
            /// </summary>
            public int CorporationID
            {
                get { return corporationID; }
                set { corporationID = value; }
            }
            /// <summary>
            /// Description
            /// </summary>
            public string Description
            {
                get { return description; }
                set { description = value; }
            }
        }
    }
	/// <summary>
    /// Medal Viewable Status
	/// Private/Public
    /// </summary>
    public enum MedalStatus
    {
        /// <summary>
        /// Not Publicly Viewable
        /// </summary>
        Private = 1,
        /// <summary>
        /// Publicly Viewable
        /// </summary>
        Public = 2
    }
}
