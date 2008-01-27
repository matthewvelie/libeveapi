using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Represents the number of jumps per system from the eve api
    /// http://wiki.eve-dev.net/APIv2_Map_Jumps_XML
    /// </summary>
    public class MapJumps : ApiResponse
    {
        private MapSystemItem[] mapSystemJumps = new MapSystemItem[0];

        /// <summary>
        /// 
        /// </summary>
        public MapSystemItem[] MapSystemJumps
        {
            get { return mapSystemJumps; }
            set { mapSystemJumps = value; }
        }

        /// <summary>
        /// Create an MapJumps object by parsing an XmlDocument response from the eve api
        /// </summary>
        /// <param name="xmlDoc">An XML document containing jump information</param>
        /// <returns></returns>
        public static MapJumps FromXmlDocument(XmlDocument xmlDoc)
        {
            MapJumps mapJumps = new MapJumps();
            mapJumps.ParseCommonElements(xmlDoc);

            List<MapSystemItem> systemList = new List<MapSystemItem>();
            foreach (XmlNode systemRow in xmlDoc.SelectNodes("//rowset[@name='solarSystems']/row"))
            {
                MapSystemItem systemData = new MapSystemItem();
                systemData.SolarSystemId = Convert.ToInt32(systemRow.Attributes["solarSystemID"].InnerText);
                systemData.ShipJumps = Convert.ToInt32(systemRow.Attributes["shipJumps"].InnerText);
                systemList.Add(systemData);
            }
            mapJumps.MapSystemJumps = systemList.ToArray();

            return mapJumps;
        }

        /// <summary>
        /// The information for a system with one jump or more
        /// </summary>
        public class MapSystemItem
        {
            private int solarSystemId;
            private int shipJumps;

            /// <summary>
            /// The Id of the solarsystem
            /// </summary>
            public int SolarSystemId
            {
                get { return solarSystemId; }
                set { solarSystemId = value; }
            }

            /// <summary>
            /// The number of jumps
            /// </summary>
            public int ShipJumps
            {
                get { return shipJumps; }
                set { shipJumps = value; }
            }
        }
    }
}
