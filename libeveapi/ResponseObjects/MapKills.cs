using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Represents the number of kills per system from the eve api
    /// http://wiki.eve-dev.net/APIv2_Map_Kills_XML
    /// </summary>
    public class MapKills : ApiResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public MapKillsItem[] MapSystemKills = new MapKillsItem[0];

        /// <summary>
        /// Create an Mapkills object by parsing an XmlDocument response from the eve api
        /// </summary>
        /// <param name="xmlDoc">An XML Document containing kill information on the map</param>
        /// <returns><see cref="MapKills"/></returns>
        public static MapKills FromXmlDocument(XmlDocument xmlDoc)
        {
            MapKills mapKills = new MapKills();
            mapKills.ParseCommonElements(xmlDoc);

            List<MapKillsItem> systemList = new List<MapKillsItem>();
            foreach (XmlNode systemRow in xmlDoc.SelectNodes("//rowset[@name='solarSystems']/row"))
            {
                MapKillsItem systemData = new MapKillsItem();
                systemData.SolarSystemID = Convert.ToInt32(systemRow.Attributes["solarSystemID"].InnerText);
                systemData.ShipKills = Convert.ToInt32(systemRow.Attributes["shipKills"].InnerText);
                systemData.FactionKills = Convert.ToInt32(systemRow.Attributes["factionKills"].InnerText);
                systemData.PodKills = Convert.ToInt32(systemRow.Attributes["podKills"].InnerText);
                systemList.Add(systemData);
            }
            mapKills.MapSystemKills = systemList.ToArray();

            return mapKills;
        }
    }

    /// <summary>
    /// The information for a system with one jump or more
    /// </summary>
    public class MapKillsItem
    {
        /// <summary>
        /// The ID of the solarsystem
        /// </summary>
        public int SolarSystemID;

        /// <summary>
        /// The number of kills
        /// </summary>
        public int ShipKills;

        /// <summary>
        /// The number of kills
        /// </summary>
        public int FactionKills;

        /// <summary>
        /// The number of kills
        /// </summary>
        public int PodKills;
    }
}
