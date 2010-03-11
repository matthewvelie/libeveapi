using System;

namespace libeveapi
{
    /// <summary>
    /// Returns the medals owned by the Character.
    /// http://wiki.eve-id.net/APIv2_Char_Medals_XML
    /// </summary>
    public class CorporationMedals : ApiResponse
    {
        /// <summary>
        /// API Version Compatibility
        /// </summary>
		public const string API_VERSION = "2";
		private MedalItem[] Medals = new MedalItem[0];

        public CorporationMedals(){throw new NotImplementedException("Object has not been tested against true data");}
        
        /// <summary>
        /// Array of Medals
        /// </summary>
        public MedalItem[] MedalItems
        {
            get { return MedalItems; }
            set { MedalItems = value; }
        }

        /// <summary>
        /// Contains Medal Information
        /// </summary>
        public class MedalItem
        {
            /// <summary>
            /// XmlResponse Columns List
            /// </summary>
			public static string Columns="medalID,title,description,creatorID,created";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string Key = "medalID";
			
            /// <summary>
            /// Full Constructor
            /// </summary>
			public MedalItem(int medalID,string title,string description,int createrID,DateTime created)
			{
				this.medalID = medalID;
				this.title = title;
				this.description = description;
				this.createrID = createrID;
				this.created = created;
			}

			private int medalID;
			private string title;
			private string description;
			private int createrID;
			private DateTime created;

            /// <summary>
            /// Unique Medal ID
            /// </summary>
            public int MedalID
            {
                get { return medalID; }
                set { medalID = value; }
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
            /// Description as entered by the Creater
            /// </summary>
            public string Description
            {
                get { return description; }
                set { description = value; }
            }
            /// <summary>
            /// Creaters Character ID
            /// </summary>
            public int CreaterID
            {
                get { return createrID; }
                set { createrID = value; }
            }
            /// <summary>
            /// Date Created
            /// </summary>
            public DateTime Created
            {
                get { return created; }
                set { created = value; }
            }
        }
    }
}
