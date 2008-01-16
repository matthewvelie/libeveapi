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
        /// <summary>
        /// 
        /// </summary>
        public MapSystemItem[] MapSystemJumps = new MapSystemItem[0];

        /// <summary>
        /// Create an MapJumps object by parsing an XmlDocument response from the eve api
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static MapJumps FromXmlDocument(XmlDocument xmlDoc)
        {
            MapJumps mapJumps = new MapJumps();
            mapJumps.ParseCommonElements(xmlDoc);

            List<MapSystemItem> systemList = new List<MapSystemItem>();
            foreach (XmlNode systemRow in xmlDoc.SelectNodes("//rowset[@name='solarSystems']/row"))
            {
                MapSystemItem systemData = new MapSystemItem();
                systemData.solarSystemID = Convert.ToInt32(systemRow.Attributes["solarSystemID"].InnerText);
                systemData.shipJumps = Convert.ToInt32(systemRow.Attributes["shipJumps"].InnerText);
                systemList.Add(systemData);
            }
            mapJumps.MapSystemJumps = systemList.ToArray();

            return mapJumps;
        }
    }

    /// <summary>
    /// The information for a system with one jump or more
    /// </summary>
    public class MapSystemItem
    {
        /// <summary>
        /// The ID of the solarsystem
        /// </summary>
        public int solarSystemID;

        /// <summary>
        /// The number of jumps
        /// </summary>
        public int shipJumps;
    }
}
