using System;

namespace libeveapi
{
    /// <summary>
    /// Returns the titles of a corporation.
    /// http://wiki.eve-id.net/APIv2_Corp_CorporationTitles_XML
    /// </summary>
    public class Titles : ApiResponse
    {
        /// <summary>
        /// API Version Compatibility
        /// </summary>
		public const string API_VERSION = "0";
		private TitleItem[] titleItems = new TitleItem[0];

        public Titles(){throw new NotImplementedException("Object has not been tested against true data");}

        /// <summary>
        /// Array of Titles
        /// </summary>
        public TitleItem[] TitleItems
        {
            get { return titleItems; }
            set { titleItems = value; }
        }

        /// <summary>
        /// Contains Title/Role information
        /// </summary>
        public class TitleItem
        {
            /// <summary>
            /// XmlResponse Columns List for Titles
            /// This should match the list of field names contained in this object
            /// </summary>
			public static string ColumnsTitles ="titleID,titleName";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string KeyTitles = "titleID";
            /// <summary>
            /// XmlResponse Columns List for Roles
            /// This should match the list of field names contained in this object
            /// </summary>
			public static string ColumnsRoles ="roleID,roleName";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string KeyRoles = "roleID";
            /// <summary>
            /// Default Constructor
            /// </summary>
			public TitleItem(){}
            /// <summary>
            /// Partial Constructor
            /// </summary>
			public TitleItem(int id,string name)
			{
				this.id = id;
				this.name = name;
			}

			private int id;
			private string name;
            private TitleRole[] roles;
            private TitleRole[] grantableRoles;
            private TitleRole[] rolesAtHQ;
            private TitleRole[] grantableRolesAtHQ;
            private TitleRole[] rolesAtBase;
            private TitleRole[] grantableRolesAtBase;
            private TitleRole[] rolesAtOther;
            private TitleRole[] grantableRolesAtOther;

            /// <summary>
            /// ID
            /// </summary>
            public int ID
            {
                get { return id; }
                set { id = value; }
            }

            /// <summary>
            /// Name
            /// </summary>
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            
            /// <summary>
            /// Roles
            /// </summary>
            public TitleRole[] Roles
            {
                get { return roles; }
                set { roles = value; }
            }
            
            /// <summary>
            /// Roles
            /// </summary>
            public TitleRole[] GrantableRoles
            {
                get { return grantableRoles; }
                set { grantableRoles = value; }
            }
            
            /// <summary>
            /// Roles
            /// </summary>
            public TitleRole[] RolesAtHQ
            {
                get { return rolesAtHQ; }
                set { rolesAtHQ = value; }
            }
            
            /// <summary>
            /// Roles
            /// </summary>
            public TitleRole[] GrantableRolesAtHQ
            {
                get { return grantableRolesAtHQ; }
                set { grantableRolesAtHQ = value; }
            }
            
            /// <summary>
            /// Roles
            /// </summary>
            public TitleRole[] RolesAtBase
            {
                get { return rolesAtBase; }
                set { rolesAtBase = value; }
            }
            
            /// <summary>
            /// Roles
            /// </summary>
            public TitleRole[] GrantableRolesAtBase
            {
                get { return grantableRolesAtBase; }
                set { grantableRolesAtBase = value; }
            }

            /// <summary>
            /// Roles
            /// </summary>
            public TitleRole[] RolesAtOther
            {
                get { return rolesAtOther; }
                set { rolesAtOther = value; }
            }

            /// <summary>
            /// Roles
            /// </summary>
            public TitleRole[] GrantableRolesAtOther
            {
                get { return grantableRolesAtOther; }
                set { grantableRolesAtOther = value; }
            }
        }
        
        public class TitleRole
        {
            /// <summary>
            /// XmlResponse Columns List
            /// </summary>
			public static string Columns = "roleID,roleName";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string Key = "roleID";
			
            /// <summary>
            /// Default Constructor
            /// </summary>
            public TitleRole(){}
            /// <summary>
            /// Full Constructor
            /// </summary>
			public TitleRole(int id, string name)
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
