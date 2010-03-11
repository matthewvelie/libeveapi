using System;

namespace libeveapi
{
    /// <summary>
    /// Returns Mailing Lists for character.
    /// http://wiki.eve-id.net/APIv2_Char_mailinglists_XML
    /// </summary>
    public class MailList : ApiResponse
    {
        /// <summary>
        /// API Version Compatibility
        /// </summary>
		public const string API_VERSION = "0";
        private MailListItem[] mailListItems = new MailListItem[0];

        /// <summary>
        /// Array of Mailing Lists
        /// </summary>
        public MailListItem[] MailListItems
        {
            get { return mailListItems; }
            set { mailListItems = value; }
        }

        /// <summary>
        /// Mailing List Entry
        /// </summary>
        public class MailListItem
        {
            /// <summary>
            /// XmlResponse Columns List
            /// </summary>
			public static string Columns = "listID,displayName";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string Key = "listID";
			
            /// <summary>
            /// Full constructor
            /// </summary>
			public MailListItem(int listID, string displayName)
			{
				this.listID = listID;
				this.displayName = displayName;
			}
            private int listID;
            private string displayName;

            /// <summary>
            /// ID of the Mailing List
            /// </summary>
            public int ListID
            {
                get { return listID; }
                set { listID = value; }
            }

            /// <summary>
            /// Name of the Mailing List
            /// </summary>
            public string DisplayName
            {
                get { return displayName; }
                set { displayName = value; }
            }
        }
    }
}
