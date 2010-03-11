using System;

namespace libeveapi
{
    /// <summary>
    /// Returns the security roles of members in a corporation. 
    /// http://wiki.eve-id.net/APIv2_Corp_ContainerLog_XML
    /// </summary>
    public class MemberSecurity : ApiResponse
    {
		// ***************** FIXME *****************
		/// <summary>
        /// Array of Security Titles
        /// </summary>
		public const string API_VERSION = "0";
        private MemberSecurityRole[] memberSecurityRoles = new MemberSecurityRole[0];

        public MemberSecurity(){throw new NotImplementedException("Object has not been tested against true data");}

        public MemberSecurityRole[] MemberSecurityRoles { get { return memberSecurityRoles; } set { memberSecurityRoles = value; } }

        
        public class MemberSecurityRole
        {
            private int characterID;
            private string name;
            private MemberSecurityItem[] titles = new MemberSecurityItem[0];
            private MemberSecurityItem[] roles = new MemberSecurityItem[0];
            private MemberSecurityItem[] grantableRoles = new MemberSecurityItem[0];
            private MemberSecurityItem[] rolesAtHQ = new MemberSecurityItem[0];
            private MemberSecurityItem[] grantableRolesAtHQ = new MemberSecurityItem[0];
            private MemberSecurityItem[] rolesAtBase = new MemberSecurityItem[0];
            private MemberSecurityItem[] grantableRolesAtBase = new MemberSecurityItem[0];
            private MemberSecurityItem[] rolesAtOther = new MemberSecurityItem[0];
            private MemberSecurityItem[] grantableRolesAtOther = new MemberSecurityItem[0];

            /// <summary>
            /// Array of Security Titles
            /// </summary>
            public int CharacterID
            {
                get { return characterID; }
                set { characterID = value; }
            }

            /// <summary>
            /// Array of Security Titles
            /// </summary>
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            /// <summary>
            /// Array of Security Titles
            /// </summary>
            public MemberSecurityItem[] Titles
            {
                get { return titles; }
                set { titles = value; }
            }

            /// <summary>
            /// Array of Security Roles
            /// </summary>
            public MemberSecurityItem[] Roles
            {
                get { return roles; }
                set { roles = value; }
            }
            
            /// <summary>
            /// Array of Security Roles
            /// </summary>
            public MemberSecurityItem[] GrantableRoles
            {
                get { return grantableRoles; }
                set { grantableRoles = value; }
            }
            
            /// <summary>
            /// Array of Security Roles
            /// </summary>
            public MemberSecurityItem[] RolesAtHQ
            {
                get { return rolesAtHQ; }
                set { rolesAtHQ = value; }
            }
            
            /// <summary>
            /// Array of Security Roles
            /// </summary>
            public MemberSecurityItem[] GrantableRolesAtHQ
            {
                get { return grantableRolesAtHQ; }
                set { grantableRolesAtHQ = value; }
            }
            
            /// <summary>
            /// Array of Security Roles
            /// </summary>
            public MemberSecurityItem[] RolesAtBase
            {
                get { return rolesAtBase; }
                set { rolesAtBase = value; }
            }
            
            /// <summary>
            /// Array of Security Roles
            /// </summary>
            public MemberSecurityItem[] GrantableRolesAtBase
            {
                get { return grantableRolesAtBase; }
                set { grantableRolesAtBase = value; }
            }
            
            /// <summary>
            /// Array of Security Roles
            /// </summary>
            public MemberSecurityItem[] RolesAtOther
            {
                get { return rolesAtOther; }
                set { rolesAtOther = value; }
            }

            /// <summary>
            /// Array of Security Roles
            /// </summary>
            public MemberSecurityItem[] GrantableRolesAtOther
            {
                get { return grantableRolesAtOther; }
                set { grantableRolesAtOther = value; }
            }            
        }
        
		/// <summary>
        /// Contains a single log entry
        /// </summary>
        public class MemberSecurityItem
        {
            /// <summary>
            /// XmlResponse Columns List
            /// </summary>
			public static string ColumnsRoles = "roleID,roleName";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string KeyRoles = "roleID";
            /// <summary>
            /// XmlResponse Columns List
            /// </summary>
			public static string ColumnsTitles = "titleID,titleName";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string KeyTitles = "titleID";
			
            /// <summary>
            /// Default Constructor
            /// </summary>
            public MemberSecurityItem(){}
            /// <summary>
            /// Full Constructor
            /// </summary>
			public MemberSecurityItem(int id, string name)
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
    }
}
