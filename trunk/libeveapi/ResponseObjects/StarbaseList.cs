using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Represents a list of all the starbases owned by the specified corporation
    /// </summary>
    public class StarbaseList : ApiResponse
    {
        private StarbaseListItem[] starbaseListItems = new StarbaseListItem[0];

        /// <summary>
        /// List of all the starbases owned by this corporation
        /// </summary>
        public StarbaseListItem[] StarbaseListItems
        {
            get { return starbaseListItems; }
            set { starbaseListItems = value; }
        }

        /// <summary>
        /// Create a StarbaseList by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static StarbaseList FromXmlDocument(XmlDocument xmlDoc)
        {
            StarbaseList starbaseList = new StarbaseList();
            starbaseList.ParseCommonElements(xmlDoc);

            List<StarbaseListItem> starbaseListItems = new List<StarbaseListItem>();
            foreach (XmlNode starbaseNode in xmlDoc.SelectNodes("//rowset[@name='starbases']/row"))
            {
                StarbaseListItem starbase = new StarbaseListItem();
                starbase.ItemId = Convert.ToInt32(starbaseNode.Attributes["itemID"].InnerText);
                starbase.TypeId = Convert.ToInt32(starbaseNode.Attributes["typeID"].InnerText);
                starbase.LocationId = Convert.ToInt32(starbaseNode.Attributes["locationID"].InnerText);
                starbase.MoonId = Convert.ToInt32(starbaseNode.Attributes["moonID"].InnerText);
                starbase.StateTimestamp = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(starbaseNode.Attributes["stateTimestamp"].InnerText);
                starbase.OnlineTimestamp = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(starbaseNode.Attributes["onlineTimestamp"].InnerText);

                starbase.StateTimestampLocal = TimeUtilities.ConvertCCPToLocalTime(starbase.StateTimestamp);
                starbase.OnlineTimestampLocal = TimeUtilities.ConvertCCPToLocalTime(starbase.OnlineTimestamp);
                
                switch (Convert.ToInt32(starbaseNode.Attributes["state"].InnerText))
                {
                    case 1:
                        starbase.State = StarbaseState.AnchoredOrOffline;
                        break;
                    case 2:
                        starbase.State = StarbaseState.Onlining;
                        break;
                    case 3:
                        starbase.State = StarbaseState.Reinforced;
                        break;
                    case 4:
                        starbase.State = StarbaseState.Online;
                        break;
                    default:
                        break;
                }

                starbaseListItems.Add(starbase);
            }

            starbaseList.StarbaseListItems = starbaseListItems.ToArray();
            return starbaseList;
        }

        /// <summary>
        /// Represents a single starbase in the starbase list
        /// </summary>
        public class StarbaseListItem
        {
            private int itemId;
            private int typeId;
            private int locationId;
            private int moonId;
            private StarbaseState state;
            private DateTime stateTimestamp;
            private DateTime onlineTimestamp;
            private DateTime stateTimestampLocal;
            private DateTime onlineTimestampLocal;

            /// <summary>
            /// Unique identifier for this starbase
            /// </summary>
            public int ItemId
            {
                get { return itemId; }
                set { itemId = value; }
            }

            /// <summary>
            /// Control tower type id
            /// </summary>
            public int TypeId
            {
                get { return typeId; }
                set { typeId = value; }
            }

            /// <summary>
            /// The id of the system where the starbase is located
            /// </summary>
            public int LocationId
            {
                get { return locationId; }
                set { locationId = value; }
            }

            /// <summary>
            /// The id of the moon where the starbase is located
            /// </summary>
            public int MoonId
            {
                get { return moonId; }
                set { moonId = value; }
            }

            /// <summary>
            /// See <see cref="StarbaseState"/> for full descriptions of each starbase state
            /// </summary>
            public StarbaseState State
            {
                get { return state; }
                set { state = value; }
            }

            /// <summary>
            /// See <see cref="StarbaseState"/> for the potential meanings of StateTimestamp
            /// </summary>
            public DateTime StateTimestamp
            {
                get { return stateTimestamp; }
                set { stateTimestamp = value; }
            }

            /// <summary>
            /// See <see cref="StarbaseState"/> for the potential meanings of OnlineTimestamp
            /// </summary>
            public DateTime OnlineTimestamp
            {
                get { return onlineTimestamp; }
                set { onlineTimestamp = value; }
            }

            /// <summary>
            /// StateTimestamp in local time
            /// </summary>
            public DateTime StateTimestampLocal
            {
                get { return stateTimestampLocal; }
                set { stateTimestampLocal = value; }
            }

            /// <summary>
            /// OnlineTimestamp in local time
            /// </summary>
            public DateTime OnlineTimestampLocal
            {
                get { return onlineTimestampLocal; }
                set { onlineTimestampLocal = value; }
            }
        }

        /// <summary>
        /// This represents the current state of the starbase, of which there are
        /// four different valid states.
        /// </summary>
        public enum StarbaseState
        {
            /// <summary>
            /// Starbase is anchored or offline
            /// if offline then it went offline at StateTimestamp
            /// </summary>
            AnchoredOrOffline = 1,

            /// <summary>
            /// Starbase is in the process of coming online
            /// Will be online at time OnlineTimestamp
            /// </summary>
            Onlining = 2,

            /// <summary>
            /// Starbase in in reinforced mode
            /// Until time StateTimestamp
            /// </summary>
            Reinforced = 3,

            /// <summary>
            /// Starbase is online
            /// Continuously since time OnlineTimestamp
            /// </summary>
            Online = 4
        }
    }
}
