using System;

namespace libeveapi
{
    /// <summary>
    /// Returns info about corporation role changes for members and who did it. 
    /// http://wiki.eve-id.net/APIv2_Corp_MemberSecurityLog_XML
    /// </summary>
    public class MemberSecurityLog : ApiResponse
    {
		// ***************** FIXME *****************
		/// <summary>
        /// Array of Security Titles
        /// </summary>
		public const string API_VERSION = "0";
        private ChangeLogEntry[] changeLog = new ChangeLogEntry[0];

        public MemberSecurityLog(){throw new NotImplementedException("Object has not been tested against true data");}

        /// <summary>
        /// Array of Change Log Entries
        /// </summary>
        public ChangeLogEntry[] ChangeLog
        {
            get { return changeLog; }
            set { changeLog = value; }
        }

        /// <summary>
        /// A single Change Log Entry
        /// </summary>
		public class ChangeLogEntry
		{
            /// <summary>
            /// XmlResponse Columns List
            /// </summary>
			public static string Columns = "changeTime,characterID,characterName,issuerID,issuerName,roleLocationType";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string Key = "changeTime";
            /// <summary>
            /// Default Constructor
            /// </summary>
			public ChangeLogEntry(){}
            /// <summary>
            /// Full Constructor
            /// </summary>
			public ChangeLogEntry(DateTime changeTime, int characterID, string characterName, int issuerID, string issuerName, string roleLocationType, MemberSecurity.MemberSecurityItem[] oldRoles, MemberSecurity.MemberSecurityItem[] newRoles)
			{
				this.changeTime = changeTime;
				this.characterID = characterID;
				this.characterName = characterName;
				this.issuerID = issuerID;
				this.issuerName = issuerName;
				this.roleLocationType = roleLocationType;
				this.oldRoles = oldRoles;
				this.newRoles = newRoles;
			}

            private DateTime changeTime;
            private int characterID;
            private string characterName;
            private int issuerID;
            private string issuerName;
            private string roleLocationType;
            private MemberSecurity.MemberSecurityItem[] oldRoles;
            private MemberSecurity.MemberSecurityItem[] newRoles;

            /// <summary>
            /// DateTime the entry was made
            /// </summary>
            public DateTime ChangeTime {get;set;}
            /// <summary>
            /// ID of the character the entry is about
            /// </summary>
			public int CharacterID {get;set;}
            /// <summary>
            /// Name of the character the entry is about
            /// </summary>
			public string CharacterName {get;set;}
            /// <summary>
            /// ID of the character that created the entry
            /// </summary>
			public int IssuerID {get;set;}
            /// <summary>
            /// Name of the character that created the entry
            /// </summary>
			public string IssuerName {get;set;}
            /// <summary>
            /// Unknown FIXME
            /// </summary>
			public string RoleLocationType {get;set;}
            /// <summary>
            /// Array of roles previously assined to the Character
            /// </summary>
			public MemberSecurity.MemberSecurityItem[] OldRoles {get;set;}
            /// <summary>
            /// Array of roles assined to the Character
            /// </summary>
			public MemberSecurity.MemberSecurityItem[] NewRoles {get;set;}
		}
/*
		/// <summary>
        /// Contains a single log entry
        /// </summary>
        public class MemberSecurityLogItem
        {
			public static string Columns = "roleID,roleName";
			public static string Key = "roleID";
			
			public MemberSecurityLogItem(int id, string name)
			{
				this.id = id;
				this.name = name;
			}
			
            private int id;
            private string name;
			
			#region Properties
            /// <summary>
            /// ID
            /// </summary>
            public int ID
            {
                get { return id; }
                set { id = value; }
            }

            /// <summary>
            /// Name/Description
            /// </summary>
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

			#endregion Properties
        }
        */
    }
}
