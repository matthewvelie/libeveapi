using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Log of 25 most recent kills for a character or 100 most recent for corporation
    /// </summary>
    public class KillLog : ApiResponse
    {
        /// <summary>
        /// Array containing all the kills returned from the api call 
        /// </summary>
        public Kill[] Kills = new Kill[0];

        /// <summary>
        /// Creates a KillLog object from the xml api response
        /// </summary>
        /// <param name="xmlDoc">XmlDocument Containing the api response</param>
        /// <returns></returns>
        public static KillLog FromXmlDocument(XmlDocument xmlDoc)
        {
            return null;
        }

        /// <summary>
        /// A Kill contains a victim, list of attackers, and items lost
        /// </summary>
        public class Kill
        {
            public int KillID;
            public int SolarSystemID;
            public DateTime KillTime;
            public int MoonID;
            public VictimPilot Victim;
            public Attacker[] Attackers = new Attacker[0];
            public Item[] Items = new Item[0];
        }

        /// <summary>
        /// A pilot base class
        /// </summary>
        public class Pilot
        {
            public int CharacterID;
            public string CharacterName;
            public int CorporationID;
            public string CorporationName;
            public int AllianceID;
            public string AllianceName;
            public int ShipTypeID;
        }
        /// <summary>
        /// The victim pilot
        /// </summary>
        public class VictimPilot : Pilot
        {
            public int DamageTaken;
        }

        /// <summary>
        /// An Attacking pilot
        /// </summary>
        public class Attacker : Pilot
        {
            public float SecurityStatus;
            public int DamageDone;
            public bool FinalBlow;
            public int WeaponTypeID;
        }

        /// <summary>
        /// An Item from the killmail
        /// </summary>
        public class Item
        {
            public int TypeID;
            public int Flag;
            public int QtyDropped;
            public int QtyDestroyed;
            public bool NotEmpty;
            public Item[] Contained = new Item[0];
        }
    }   
}
