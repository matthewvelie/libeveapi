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
    public class MapSovereignty : ApiResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public MapSovereigntyItem[] MapSystemSovereignty = new MapSovereigntyItem[0];

        /// <summary>
        /// Create an Mapkills object by parsing an XmlDocument response from the eve api
        /// </summary>
        /// <param name="xmlDoc">XML Document containing map sovereignty information</param>
        /// <returns><see cref="MapSovereignty"/>A map sovereignty object</returns>
        public static MapSovereignty FromXmlDocument(XmlDocument xmlDoc)
        {
            MapSovereignty mapSovereignty = new MapSovereignty();
            mapSovereignty.ParseCommonElements(xmlDoc);

            List<MapSovereigntyItem> sovereigntyList = new List<MapSovereigntyItem>();
            foreach (XmlNode systemRow in xmlDoc.SelectNodes("//rowset[@name='solarSystems']/row"))
            {
                MapSovereigntyItem sovereigntyData = new MapSovereigntyItem();
                sovereigntyData.SolarSystemId = Convert.ToInt32(systemRow.Attributes["solarSystemID"].InnerText);
                sovereigntyData.AllianceId = Convert.ToInt32(systemRow.Attributes["allianceID"].InnerText);
                sovereigntyData.ConstellationSovereignty = Convert.ToInt32(systemRow.Attributes["constellationSovereignty"].InnerText);
                sovereigntyData.SovereigntyLevel = Convert.ToInt32(systemRow.Attributes["sovereigntyLevel"].InnerText);
                sovereigntyData.FactionId = Convert.ToInt32(systemRow.Attributes["factionID"].InnerText);
                sovereigntyData.SolarSystemName = systemRow.Attributes["solarSystemName"].InnerText;
                sovereigntyList.Add(sovereigntyData);
            }
            mapSovereignty.MapSystemSovereignty = sovereigntyList.ToArray();

            return mapSovereignty;
        }
    }

    /// <summary>
    /// The information for a system with one jump or more
    /// </summary>
    public class MapSovereigntyItem
    {
        /// <summary>
        /// The unique identification number of a solar system
        /// </summary>
        public int SolarSystemId;

        /// <summary>
        /// The Id of the alliance that has sovereignty of this solar system, or 0 if nobody has sovereignty.
        /// </summary>
        public int AllianceId;

        /// <summary>
        /// The Id of the alliance that has sovereignty of this constellation, or 0 if nobody has constellation sovereignty.
        /// http://myeve.eve-online.com/devblog.asp?a=blog&bid=477
        /// </summary>
        public int ConstellationSovereignty;

        /// <summary>
        /// The level of sovernty
        /// </summary>
        public int SovereigntyLevel;

        /// <summary>
        /// The NPC faction that controls this system
        /// </summary>
        public int FactionId;

        /// <summary>
        /// Name of the solar system
        /// </summary>
        public string SolarSystemName;
    }
}
