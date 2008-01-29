using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Returns a list of solarsystems and what faction or alliance controls them.
    /// http://wiki.eve-dev.net/APIv2_Map_Kills_XML
    /// </summary>
    public class MapSovereignty : ApiResponse
    {
        private MapSovereigntyItem[] mapSystemSovereigntyItems = new MapSovereigntyItem[0];

        /// <summary>
        /// 
        /// </summary>
        public MapSovereigntyItem[] MapSystemSovereigntyItems
            {
                get { return mapSystemSovereigntyItems; }
                set { mapSystemSovereigntyItems = value; }
            }

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
                sovereigntyData.SolarSystemId = Convert.ToInt32(systemRow.Attributes["solarSystemID"].InnerText, CultureInfo.InvariantCulture);
                sovereigntyData.AllianceId = Convert.ToInt32(systemRow.Attributes["allianceID"].InnerText, CultureInfo.InvariantCulture);
                sovereigntyData.ConstellationSovereignty = Convert.ToInt32(systemRow.Attributes["constellationSovereignty"].InnerText, CultureInfo.InvariantCulture);
                sovereigntyData.SovereigntyLevel = Convert.ToInt32(systemRow.Attributes["sovereigntyLevel"].InnerText, CultureInfo.InvariantCulture);
                sovereigntyData.FactionId = Convert.ToInt32(systemRow.Attributes["factionID"].InnerText, CultureInfo.InvariantCulture);
                sovereigntyData.SolarSystemName = systemRow.Attributes["solarSystemName"].InnerText;
                sovereigntyList.Add(sovereigntyData);
            }
            mapSovereignty.MapSystemSovereigntyItems = sovereigntyList.ToArray();

            return mapSovereignty;
        }

        /// <summary>
        /// The information for a system with one jump or more
        /// </summary>
        public class MapSovereigntyItem
        {
            private int solarSystemId;
            private int allianceId;
            private int constellationSovereignty;
            private int sovereigntyLevel;
            private int factionId;
            private string solarSystemName;

            /// <summary>
            /// The unique identification number of a solar system
            /// </summary>
            public int SolarSystemId
            {
                get { return solarSystemId; }
                set { solarSystemId = value; }
            }

            /// <summary>
            /// The Id of the alliance that has sovereignty of this solar system, or 0 if nobody has sovereignty.
            /// </summary>
            public int AllianceId
            {
                get { return allianceId; }
                set { allianceId = value; }
            }

            /// <summary>
            /// The Id of the alliance that has sovereignty of this constellation, or 0 if nobody has constellation sovereignty.
            /// </summary>
            public int ConstellationSovereignty
            {
                get { return constellationSovereignty; }
                set { constellationSovereignty = value; }
            }

            /// <summary>
            /// The level of sovernty
            /// </summary>
            public int SovereigntyLevel
            {
                get { return sovereigntyLevel; }
                set { sovereigntyLevel = value; }
            }

            /// <summary>
            /// The NPC faction that controls this system
            /// </summary>
            public int FactionId
            {
                get { return factionId; }
                set { factionId = value; }
            }

            /// <summary>
            /// Name of the solar system
            /// </summary>
            public string SolarSystemName
            {
                get { return solarSystemName; }
                set { solarSystemName = value; }
            }
        }
    }
}
