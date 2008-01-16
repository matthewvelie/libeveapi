using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Holds the full list of Conquerable stations and outposts
    /// </summary>
    public class ConquerableStationList : ApiResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public ConquerableStationItem[] conquerableStationList = new ConquerableStationItem[0];

        /// <summary>
        /// Create an Conquerable Station list by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static ConquerableStationList FromXmlDocument(XmlDocument xmlDoc)
        {
            ConquerableStationList stationList = new ConquerableStationList();
            stationList.ParseCommonElements(xmlDoc);

            List<ConquerableStationItem> stationItemList = new List<ConquerableStationItem>();
            foreach (XmlNode node in xmlDoc.SelectNodes("//rowset[@name='outposts']/row"))
            {
                stationItemList.Add(ParseStationRow(node));
            }
            stationList.conquerableStationList = stationItemList.ToArray();

            return stationList;
        }

        /// <summary>
        /// Create an ConquerableStationItem by parsing a single row
        /// Recursively parses all contained assets
        /// </summary>
        /// <param name="stationRow"></param>
        /// <returns></returns>
        protected static ConquerableStationItem ParseStationRow(XmlNode stationRow)
        {
            ConquerableStationItem conquerableStationItem = new ConquerableStationItem();
            conquerableStationItem.stationID = Convert.ToInt32(stationRow.Attributes["stationID"].InnerText);
            conquerableStationItem.stationName = stationRow.Attributes["stationName"].InnerText;
            conquerableStationItem.stationTypeID = Convert.ToInt32(stationRow.Attributes["stationTypeID"].InnerText);
            conquerableStationItem.solarSystemID = Convert.ToInt32(stationRow.Attributes["solarSystemID"].InnerText);
            conquerableStationItem.corporationID = Convert.ToInt32(stationRow.Attributes["corporationID"].InnerText);
            conquerableStationItem.corporationName = stationRow.Attributes["corporationName"].InnerText;

            return conquerableStationItem;
        }
    }

    /// <summary>
    /// Represents one conquerable station / outpost
    /// </summary>
    public class ConquerableStationItem
    {
        /// <summary>
        /// The unique station ID
        /// </summary>
        public int stationID;

        /// <summary>
        /// The name of the station (corp gets to name it)
        /// </summary>
        public string stationName;

        /// <summary>
        /// The typeID of the station / outpost
        /// </summary>
        public int stationTypeID;

        /// <summary>
        /// The solarSystemID that the station / outpost is located in
        /// </summary>
        public int solarSystemID;

        /// <summary>
        /// The id of the corporation that owns teh station / outpost
        /// </summary>
        public int corporationID;

        /// <summary>
        /// The name of the corporation that owns the station / outpost
        /// </summary>
        public string corporationName;
    }

}
