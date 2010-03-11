using System;

namespace libeveapi
{
    /// <summary>
    /// Returns a log of Corporate Container Actions
    /// http://wiki.eve-id.net/APIv2_Corp_ContainerLog_XML
    /// </summary>
    public class ContainerLog : ApiResponse
    {
		/// <summary>
        /// Array of Security Titles
        /// </summary>
		public const string API_VERSION = "2";

        public ContainerLog(){throw new NotImplementedException("Object has not been tested against true data");}
        
        private ContainerLogItem[] containerLogItems = new ContainerLogItem[0];

        /// <summary>
        /// Array of Container Log Entries
        /// </summary>
        public ContainerLogItem[] ContainerLogItems
        {
            get { return containerLogItems; }
            set { containerLogItems = value; }
        }

        /// <summary>
        /// Contains a single log entry
        /// </summary>
        public class ContainerLogItem
        {
            /// <summary>
            /// XmlResponse Columns List
            /// </summary>
			public static string Columns = "logTime,itemID,itemTypeID,actorID,actorName,flag,locationID,action,passwordType,typeID,quantity,oldConfiguration,newConfiguration";
            /// <summary>
            /// Column Key or Unique Identifier for the object
            /// </summary>
			public static string Key = "logTime";
			
            /// <summary>
            /// Full Constructor
            /// </summary>
			public ContainerLogItem(DateTime logTime, int itemID, int itemTypeID, int actorID, string actorName, int flag, int locationID, string action, string passwordType, int typeID, int quantity, int oldConfiguration, int newConfiguration)
			{
				this.logTime = logTime;
				this.itemID = itemID;
				this.itemTypeID = itemTypeID;
				this.actorID = actorID;
				this.actorName = actorName;
				this.flag = flag;
				this.locationID = locationID;
				this.action = action;
				this.passwordType = passwordType;
				this.typeID = typeID;
				this.quantity = quantity;
				this.oldConfiguration = oldConfiguration;
				this.newConfiguration = newConfiguration;
			}
			
            private DateTime logTime;
            private int itemID;
            private int itemTypeID;
            private int actorID;
            private string actorName;
			private int flag;
			private int locationID;
			private string action;
			private string passwordType;
			private int typeID;
			private int quantity;
			private int oldConfiguration;
			private int newConfiguration;
			
			#region Properties
            /// <summary>
            /// Timestamp of Entry
            /// </summary>
            public DateTime LogTime
            {
                get { return logTime; }
                set { logTime = value; }
            }
            /// <summary>
            /// ID of the container
            /// </summary>
            public int ItemID
            {
                get { return itemID; }
                set { itemID = value; }
            }

            /// <summary>
            /// ID of ItemType
            /// </summary>
            public int ItemTypeID
            {
                get { return itemTypeID; }
                set { itemTypeID = value; }
            }

            /// <summary>
            /// ID of character that made the change
            /// </summary>
            public int ActorID
            {
                get { return actorID; }
                set { actorID = value; }
            }

            /// <summary>
            /// Character name that made the change
            /// </summary>
            public string ActorName
            {
                get { return actorName; }
                set { actorName = value; }
            }
            /// <summary>
            /// Flag
            /// </summary>
            public int Flag
            {
                get { return flag; }
                set { flag = value; }
            }
	        /// <summary>
            /// ID of the containers location
            /// </summary>
            public int LocationID
            {
                get { return locationID; }
                set { locationID = value; }
            }
            /// <summary>
            /// What was done to the container.
            /// </summary>
            public string Action
            {
                get { return action; }
                set { action = value; }
            }
            /// <summary>
            /// Password type changed. Config/Container
            /// </summary>
            public string PasswordType
            {
                get { return passwordType; }
                set { passwordType = value; }
            }
			/// <summary>
            /// ID of the item affected
            /// </summary>
            public int TypeID
            {
                get { return typeID; }
                set { typeID = value; }
            }
	        /// <summary>
            /// Quantity of items added/removed/locked
            /// </summary>
            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }
	        /// <summary>
            /// Unknown 
            /// </summary>
            public int OldConfiguration
            {
                get { return oldConfiguration; }
                set { oldConfiguration = value; }
            }
	        /// <summary>
            /// Unknown. 
            /// </summary>
            public int NewConfiguration
            {
                get { return newConfiguration; }
                set { newConfiguration = value; }
            }

			#endregion Properties
        }
    }
}
