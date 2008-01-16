using System;
using System.Collections.Generic;
using System.Text;
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
        /// <summary>
        /// 
        /// </summary>
        public MemberTrackingItem[] MemberTrackingItems = new MemberTrackingItem[0];

        /// <summary>
        /// Create a MemberTracking object by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static MemberTracking FromXmlDocument(XmlDocument xmlDoc)
        {
            MemberTracking memberTracking = new MemberTracking();
            memberTracking.ParseCommonElements(xmlDoc);

            List<MemberTrackingItem> parsedMemeberTrackingItems = new List<MemberTrackingItem>();
            foreach (XmlNode row in xmlDoc.SelectNodes("//rowset[@name='members']/row"))
            {
                MemberTrackingItem mti = new MemberTrackingItem();
                mti.CharacterId = Convert.ToInt32(row.Attributes["characterID"].InnerText);
                mti.Name = row.Attributes["name"].InnerText;
                mti.BaseId = Convert.ToInt32(row.Attributes["baseID"].InnerText);
                mti.Base = row.Attributes["base"].InnerText;
                mti.Title = row.Attributes["title"].InnerText;
                mti.LocationId = Convert.ToInt32(row.Attributes["locationID"].InnerText);
                mti.Location = row.Attributes["location"].InnerText;
                mti.ShipTypeId = Convert.ToInt32(row.Attributes["shipTypeID"].InnerText);
                mti.ShipType = row.Attributes["shipType"].InnerText;
                mti.RolesMask = row.Attributes["roles"].InnerText;
                mti.GrantableRoles = row.Attributes["grantableRoles"].InnerText;

                DateTime.TryParse(row.Attributes["startDateTime"].InnerText, out mti.StartDateTime);
                DateTime.TryParse(row.Attributes["logonDateTime"].InnerText, out mti.LogonDateTime);
                DateTime.TryParse(row.Attributes["logoffDateTime"].InnerText, out mti.LogoffDateTime);
                mti.StartDateTimeLocal = EveApi.CCPDateTimeToLocal(memberTracking.CurrentTime, mti.StartDateTimeLocal);
                mti.LogonDateTimeLocal = EveApi.CCPDateTimeToLocal(memberTracking.CurrentTime, mti.LogonDateTimeLocal);
                mti.LogoffDateTimeLocal = EveApi.CCPDateTimeToLocal(memberTracking.CurrentTime, mti.LogoffDateTimeLocal);

                parsedMemeberTrackingItems.Add(mti);
            }

            memberTracking.MemberTrackingItems = parsedMemeberTrackingItems.ToArray();
            return memberTracking;
        }
    }

    /// <summary>
    /// Information about an individual member of the corporation.
    /// </summary>
    public class MemberTrackingItem
    {
        /// <summary>
        /// Unique identifier of the pilot.
        /// </summary>
        public int CharacterId;

        /// <summary>
        /// Name of the pilot
        /// </summary>
        public string Name;

        /// <summary>
        /// Pilot's start date with the corporation
        /// </summary>
        public DateTime StartDateTime;

        /// <summary>
        /// Pilot's start date with the corporation in local time
        /// </summary>
        public DateTime StartDateTimeLocal;

        /// <summary>
        /// The unique identifier of the station the pilot's 
        /// base station.
        /// </summary>
        public int BaseId;

        /// <summary>
        /// The human readable description of the pilot's base 
        /// station.
        /// </summary>
        public string Base;

        /// <summary>
        /// Pilot's assigned title in the corporation
        /// </summary>
        public string Title;

        /// <summary>
        /// Timestamp of pilot's last logon
        /// </summary>
        public DateTime LogonDateTime;

        /// <summary>
        /// Timestamp of pilot's last logon in local time
        /// </summary>
        public DateTime LogonDateTimeLocal;

        /// <summary>
        /// Timestamp of pilot's last logoff
        /// </summary>
        public DateTime LogoffDateTime;

        /// <summary>
        /// Timestamp of pilot's last logoff in local time
        /// </summary>
        public DateTime LogoffDateTimeLocal;

        /// <summary>
        /// The unique id of the system where the pilot is currently located
        /// </summary>
        public int LocationId;

        /// <summary>
        /// A human readable description of the current location of the pilot
        /// </summary>
        public string Location;

        /// <summary>
        /// The unique identifier of the ship type the pilot is 
        /// currently flying
        /// </summary>
        public int ShipTypeId;

        /// <summary>
        /// The human readable description of the type of ship the 
        /// pilot is currently flying
        /// </summary>
        public string ShipType;

        /// <summary>
        /// A mask describing the pilot's current roles in the corporation
        /// </summary>
        public string RolesMask;

        /// <summary>
        /// Depricated
        /// </summary>
        public string GrantableRoles;

        /// <summary>
        /// This pilot's roles in the corporation
        /// </summary>
        protected Roles roles;
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
