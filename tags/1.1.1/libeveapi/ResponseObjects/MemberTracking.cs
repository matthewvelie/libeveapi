using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Xml;
using System.Xml.Serialization;

namespace libeveapi
{
    /// <summary>
    /// Contains information on every member in the corporation. Information retrieved
    /// varies on your roles without within the corporation. Not valid for NPC corps.
    /// </summary>
    public class MemberTracking : ApiResponse
    {
        private Member[] members = new Member[0];

        /// <summary>
        /// 
        /// </summary>
        public Member[] Members
        {
            get { return members; }
            set { members = value; }
        }

        /// <summary>
        /// Create a MemberTracking object by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc">An XML File containing member tracking data</param>
        /// <returns></returns>
        public static MemberTracking FromXmlDocument(XmlDocument xmlDoc)
        {
            MemberTracking memberTracking = new MemberTracking();
            memberTracking.ParseCommonElements(xmlDoc);

            List<Member> parsedMemeberTrackingItems = new List<Member>();
            foreach (XmlNode row in xmlDoc.SelectNodes("//rowset[@name='members']/row"))
            {
                Member mti = new Member();
                mti.CharacterId = Convert.ToInt32(row.Attributes["characterID"].InnerText, CultureInfo.InvariantCulture);
                mti.Name = row.Attributes["name"].InnerText;
                mti.BaseId = Convert.ToInt32(row.Attributes["baseID"].InnerText, CultureInfo.InvariantCulture);
                mti.Base = row.Attributes["base"].InnerText;
                mti.Title = row.Attributes["title"].InnerText;
                mti.LocationId = Convert.ToInt32(row.Attributes["locationID"].InnerText, CultureInfo.InvariantCulture);
                mti.Location = row.Attributes["location"].InnerText;
                mti.ShipTypeId = Convert.ToInt32(row.Attributes["shipTypeID"].InnerText, CultureInfo.InvariantCulture);
                mti.ShipType = row.Attributes["shipType"].InnerText;
                mti.RolesMask = row.Attributes["roles"].InnerText;
                mti.GrantableRoles = row.Attributes["grantableRoles"].InnerText;

                mti.StartDateTime = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(row.Attributes["startDateTime"].InnerText);
                mti.LogonDateTime = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(row.Attributes["logonDateTime"].InnerText);
                mti.LogoffDateTime = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(row.Attributes["logoffDateTime"].InnerText);
                mti.StartDateTimeLocal = TimeUtilities.ConvertCCPToLocalTime(mti.StartDateTime);
                mti.LogonDateTimeLocal = TimeUtilities.ConvertCCPToLocalTime(mti.LogonDateTime);
                mti.LogoffDateTimeLocal = TimeUtilities.ConvertCCPToLocalTime(mti.LogoffDateTime);

                parsedMemeberTrackingItems.Add(mti);
            }

            memberTracking.Members = parsedMemeberTrackingItems.ToArray();
            return memberTracking;
        }

        /// <summary>
        /// Information about an individual member of the corporation.
        /// </summary>
        public class Member
        {
            private int characterId;
            private string name;
            private DateTime startDateTime;
            private DateTime startDateTimeLocal;
            private int baseId;
            private string _base;
            private string title;
            private DateTime logonDateTime;
            private DateTime logonDateTimeLocal;
            private DateTime logoffDateTime;
            private DateTime logoffDateTimeLocal;
            private int locationId;
            private string location;
            private int shipTypeId;
            private string shipType;
            private string rolesMask;
            private string grantableRoles;
            private Roles roles;

            /// <summary>
            /// Unique identifier of the pilot.
            /// </summary>
            public int CharacterId
            {
                get { return characterId; }
                set { characterId = value; }
            }

            /// <summary>
            /// Name of the pilot
            /// </summary>
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            /// <summary>
            /// Pilot's start date with the corporation
            /// </summary>
            public DateTime StartDateTime
            {
                get { return startDateTime; }
                set { startDateTime = value; }
            }

            /// <summary>
            /// Pilot's start date with the corporation in local time
            /// </summary>
            public DateTime StartDateTimeLocal
            {
                get { return startDateTimeLocal; }
                set { startDateTimeLocal = value; }
            }

            /// <summary>
            /// The unique identifier of the station the pilot's 
            /// base station.
            /// </summary>
            public int BaseId
            {
                get { return baseId; }
                set { baseId = value; }
            }

            /// <summary>
            /// The human readable description of the pilot's base 
            /// station.
            /// </summary>
            public string Base
            {
                get { return _base; }
                set { _base = value; }
            }

            /// <summary>
            /// Pilot's assigned title in the corporation
            /// </summary>
            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            /// <summary>
            /// Timestamp of pilot's last logon
            /// </summary>
            public DateTime LogonDateTime
            {
                get { return logonDateTime; }
                set { logonDateTime = value; }
            }

            /// <summary>
            /// Timestamp of pilot's last logon in local time
            /// </summary>
            public DateTime LogonDateTimeLocal
            {
                get { return logonDateTimeLocal; }
                set { logonDateTimeLocal = value; }
            }

            /// <summary>
            /// Timestamp of pilot's last logoff
            /// </summary>
            public DateTime LogoffDateTime
            {
                get { return logoffDateTime; }
                set { logoffDateTime = value; }
            }

            /// <summary>
            /// Timestamp of pilot's last logoff in local time
            /// </summary>
            public DateTime LogoffDateTimeLocal
            {
                get { return logoffDateTimeLocal; }
                set { logoffDateTimeLocal = value; }
            }

            /// <summary>
            /// The unique id of the system where the pilot is currently located
            /// </summary>
            public int LocationId
            {
                get { return locationId; }
                set { locationId = value; }
            }

            /// <summary>
            /// A human readable description of the current location of the pilot
            /// </summary>
            public string Location
            {
                get { return location; }
                set { location = value; }
            }

            /// <summary>
            /// The unique identifier of the ship type the pilot is 
            /// currently flying
            /// </summary>
            public int ShipTypeId
            {
                get { return shipTypeId; }
                set { shipTypeId = value; }
            }

            /// <summary>
            /// The human readable description of the type of ship the 
            /// pilot is currently flying
            /// </summary>
            public string ShipType
            {
                get { return shipType; }
                set { shipType = value; }
            }

            /// <summary>
            /// A mask describing the pilot's current roles in the corporation
            /// </summary>
            public string RolesMask
            {
                get { return rolesMask; }
                set { rolesMask = value; }
            }

            /// <summary>
            /// Depricated
            /// </summary>
            public string GrantableRoles
            {
                get { return grantableRoles; }
                set { grantableRoles = value; }
            }

            /// <summary>
            /// This pilot's roles in the corporation
            /// </summary>
            public Roles Roles
            {
                get
                {
                    if (this.roles == null)
                    {
                        this.roles = new Roles(this.RolesMask);
                    }

                    return this.roles;
                }
            }
        }
    }

   
}
