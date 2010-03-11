using System;
using System.Collections.Generic;

namespace libeveapi
{
    /// <summary>
    /// Returns Mail Message List for character.
    /// http://wiki.eve-id.net/APIv2_Char_MailMessages_XML
    /// </summary>
    public class MailMessages : ApiResponse
    {
		const int API_VERSION = 2;
		private MailMessageItem[] mailMessageItems = new MailMessageItem[0];

        /// <summary>
        /// Array of Mail Messages
        /// </summary>
        public MailMessageItem[] MailMessageItems
        {
            get { return mailMessageItems; }
            set { mailMessageItems = value; }
        }

        /// <summary>
        /// Mailing Message Item
        /// </summary>
        public class MailMessageItem
        {
            /// <summary>
            /// XmlResponse Columns List
            /// This should match the list of field names contained in this object
            /// </summary>
			public static string Columns="messageID;int senderID;int sentDate;int title;int toCorpOrAllianceID;int toCharacterIDs;int toListIDs;int read";
            /// <summary>
            /// Column Key or Unique Identifier
            /// </summary>
			public static string Key = "messageID";
			
            /// <summary>
            /// Full constructor
            /// </summary>
			public MailMessageItem(int messageID,int senderID,DateTime sentDate,string title,string toCorpOrAllianceID,string toCharacterIDs,string toListIDs,bool read)
			{
				this.messageID = messageID;
				this.senderID = senderID;
				this.sentDate = sentDate;
				this.title = title;
				this.toCorpOrAllianceID = toCorpOrAllianceID;
				this.toCharacterIDs = toCharacterIDs;
				this.toListIDs = toListIDs;
				this.read = read;
				
				this.characterIDs = ParseIdString(toCharacterIDs);
				this.listIDs = ParseIdString(toListIDs);
			}
			// Parse a comma-seperated list of integers into an int Array
            /// <summary>
            /// Parse a list of comma-seperated list of integers into an int array
            /// </summary>
			public int[] ParseIdString(string list)
			{
				string[] tmp = list.Split(new char[]{','});
				List<int> idList = new List<int>(tmp.Length);
			
				foreach(string id in tmp)
				{
					try
					{
						idList.Add(Convert.ToInt32(id.Trim()));
					}
					catch(Exception error)
					{
						throw error;
					}
				}
				return idList.ToArray();
			}
			private int messageID;
			private int senderID;
			private DateTime sentDate;
			private string title;
			private string toCorpOrAllianceID;
			private int[] characterIDs = new int[0];
			private string toCharacterIDs;
			private int[] listIDs = new int[0];
			private string toListIDs;
			private bool read;

            /// <summary>
            /// Unique Message ID Number
            /// </summary>
            public int MessageID
            {
                get { return messageID; }
                set { messageID = value; }
            }

            /// <summary>
            /// CharacterID of the Message Originator
            /// </summary>
            public int SenderID
            {
                get { return senderID; }
                set { senderID = value; }
            }

            /// <summary>
            /// Date the message was sent
            /// </summary>
            public DateTime SentDate
            {
                get { return sentDate; }
                set { sentDate = value; }
            }
            /// <summary>
            /// Title of the Message
            /// </summary>
            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            /// <summary>
            /// Corporation/Alliance the mail was sent to
            /// </summary>
            public string ToCorpOrAllianceID
            {
                get { return toCorpOrAllianceID; }
                set { toCorpOrAllianceID = value; }
            }
            /// <summary>
            /// String CSV list of CharacterIDs of characters the mail was sent to
            /// </summary>
            public string ToCharacterIDs
            {
                get { return toCharacterIDs; }
                set { toCharacterIDs = value; }
            }
            /// <summary>
            /// Array of CharacterIDs of characters the mail was sent to
            /// </summary>
            public int[] CharacterIDs
            {
                get { return characterIDs; }
                set { characterIDs = value; }
            }
            /// <summary>
            /// Array of ListIDs list of mailing lists that the mail was sent to.
            /// </summary>
            public int[] ListIDs
            {
                get { return listIDs; }
                set { listIDs = value; }
            }
            /// <summary>
            /// String CSV list of mailing lists that the mail was sent to.
            /// </summary>
            public string ToListIDs
            {
                get { return toListIDs; }
                set { toListIDs = value; }
            }
            /// <summary>
            /// Mail has been Read
            /// </summary>
            public bool Read
            {
                get { return read; }
                set { read = value; }
            }
        }
    }
}
