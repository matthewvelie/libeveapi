using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi.ResponseObjects.Parsers
{
    internal class CharFacWarStatsResponseParser : IApiResponseParser<FacWarStats.CharFacWarStatsItem>
    {
        public FacWarStats.CharFacWarStatsItem Parse(XmlDocument xmlDocument)
        {
            this.CheckVersion(xmlDocument);
            FacWarStats stats = new FacWarStats();
            stats.ParseCommonElements(xmlDocument);

            stats.CharacterFactionWarStats.FactionID = Convert.ToInt32(xmlDocument.SelectSingleNode("//factionID").InnerText);
            stats.CharacterFactionWarStats.FactionName = xmlDocument.SelectSingleNode("//factionName").InnerText;
            stats.CharacterFactionWarStats.Enlisted = Convert.ToDateTime(xmlDocument.SelectSingleNode("//enlisted").InnerText);
            stats.CharacterFactionWarStats.CurrentRank = Convert.ToInt32(xmlDocument.SelectSingleNode("//currentRank").InnerText);
            stats.CharacterFactionWarStats.HighestRank = Convert.ToInt32(xmlDocument.SelectSingleNode("//highestRank").InnerText);
            stats.CharacterFactionWarStats.KillsYesterday = Convert.ToInt32(xmlDocument.SelectSingleNode("//killsYesterday").InnerText);
            stats.CharacterFactionWarStats.KillsLastWeek = Convert.ToInt32(xmlDocument.SelectSingleNode("//killsLastWeek").InnerText);
            stats.CharacterFactionWarStats.KillsTotal = Convert.ToInt32(xmlDocument.SelectSingleNode("//killsTotal").InnerText);
            stats.CharacterFactionWarStats.VictoryPointsYesterday = Convert.ToInt32(xmlDocument.SelectSingleNode("//victoryPointsYesterday").InnerText);
            stats.CharacterFactionWarStats.VictoryPointsLastWeek = Convert.ToInt32(xmlDocument.SelectSingleNode("//victoryPointsLastWeek").InnerText);
            stats.CharacterFactionWarStats.VictoryPointsTotal = Convert.ToInt32(xmlDocument.SelectSingleNode("//victoryPointsTotal").InnerText);

            return stats.CharacterFactionWarStats;
        }

        public void CheckVersion(XmlDocument xmlDocument)
        {
            if (FacWarStats.VersionCheck)
            {
                string version = xmlDocument.SelectSingleNode("//eveapi").Attributes["version"].InnerText;
                if (version.CompareTo(FacWarStats.API_VERSION) != 0)
                {
                    throw new ApiVersionException(version, FacWarStats.API_VERSION);
                }
            }
        }
    }
}
