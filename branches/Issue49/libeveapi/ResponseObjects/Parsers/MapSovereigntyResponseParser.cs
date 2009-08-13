using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace libeveapi.ResponseObjects.Parsers
{
    ///<summary>
    /// A parser which converts a given <see cref="XmlDocument"/> to a <see cref="MapSovereignty"/>.
    ///</summary>
    internal class MapSovereigntyResponseParser : IApiResponseParser<MapSovereignty>
    {
        public MapSovereignty Parse(XmlDocument xmlDocument)
        {
            MapSovereignty mapSovereignty = new MapSovereignty();
            mapSovereignty.ParseCommonElements(xmlDocument);

            List<MapSovereignty.MapSovereigntyItem> sovereigntyList = new List<MapSovereignty.MapSovereigntyItem>();
            foreach (XmlNode systemRow in xmlDocument.SelectNodes("//rowset[@name='solarSystems']/row"))
            {
                MapSovereignty.MapSovereigntyItem sovereigntyData = new MapSovereignty.MapSovereigntyItem();
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
    }
}
