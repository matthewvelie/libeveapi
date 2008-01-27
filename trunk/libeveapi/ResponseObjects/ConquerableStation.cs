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
        private ConquerableStation[] conquerableStations = new ConquerableStation[0];

        /// <summary>
        /// 
        /// </summary>
        public ConquerableStation[] ConquerableStations
        {
            get { return conquerableStations; }
            set { conquerableStations = value; }
        }

        /// <summary>
        /// Create an Conquerable Station list by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static ConquerableStationList FromXmlDocument(XmlDocument xmlDoc)
        {
            ConquerableStationList stationList = new ConquerableStationList();
            stationList.ParseCommonElements(xmlDoc);

            List<ConquerableStation> stationItemList = new List<ConquerableStation>();
            foreach (XmlNode node in xmlDoc.SelectNodes("//rowset[@name='outposts']/row"))
            {
                stationItemList.Add(ParseStationRow(node));
            }
            stationList.ConquerableStations = stationItemList.ToArray();

            return stationList;
        }

        /// <summary>
        /// Create an ConquerableStationItem by parsing a single row
        /// </summary>
        /// <param name="stationRow"></param>
        /// <returns></returns>
        protected static ConquerableStation ParseStationRow(XmlNode stationRow)
        {
            ConquerableStation conquerableStationItem = new ConquerableStation();
            conquerableStationItem.StationId = Convert.ToInt32(stationRow.Attributes["stationID"].InnerText);
            conquerableStationItem.StationName = stationRow.Attributes["stationName"].InnerText;
            conquerableStationItem.StationTypeId = Convert.ToInt32(stationRow.Attributes["stationTypeID"].InnerText);
            conquerableStationItem.SolarSystemId = Convert.ToInt32(stationRow.Attributes["solarSystemID"].InnerText);
            conquerableStationItem.CorporationId = Convert.ToInt32(stationRow.Attributes["corporationID"].InnerText);
            conquerableStationItem.CorporationName = stationRow.Attributes["corporationName"].InnerText;

            return conquerableStationItem;
        }

        /// <summary>
        /// Represents one conquerable station / outpost
        /// </summary>
        public class ConquerableStation
        {
            private int stationId;
            private string stationName;
            private int stationTypeId;
            private int solarSystemId;
            private int corporationId;
            private string corporationName;

            /// <summary>
            /// The unique station Id
            /// </summary>
            public int StationId
            {
                get { return stationId; }
                set { stationId = value; }
            }

            /// <summary>
            /// The name of the station (corp gets to name it)
            /// </summary>
            public string StationName
            {
                get { return stationName; }
                set { stationName = value; }
            }

            /// <summary>
            /// The typeId of the station / outpost
            /// </summary>
            public int StationTypeId
            {
                get { return stationTypeId; }
                set { stationTypeId = value; }
            }

            /// <summary>
            /// The solarSystemId that the station / outpost is located in
            /// </summary>
            public int SolarSystemId
            {
                get { return solarSystemId; }
                set { solarSystemId = value; }
            }

            /// <summary>
            /// The id of the corporation that owns teh station / outpost
            /// </summary>
            public int CorporationId
            {
                get { return corporationId; }
                set { corporationId = value; }
            }

            /// <summary>
            /// The name of the corporation that owns the station / outpost
            /// </summary>
            public string CorporationName
            {
                get { return corporationName; }
                set { corporationName = value; }
            }
        }
    }
}
