using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    public class AllianceList : ApiResponse
    {
        public AllianceListItem[] AllianceListItems = new AllianceListItem[0];

        internal static AllianceList FromXmlDocument(XmlDocument xmlDoc)
        {
            AllianceList allianceList = new AllianceList();
            allianceList.ParseCommonElements(xmlDoc);

            List<AllianceListItem> parsedAllianceListItems = new List<AllianceListItem>();
            foreach (XmlNode allianceRow in xmlDoc.SelectNodes("//rowset[@name='alliances']/row"))
            {
                AllianceListItem ali = new AllianceListItem();
                ali.Name = allianceRow.Attributes["name"].InnerText;
                ali.ShortName = allianceRow.Attributes["shortName"].InnerText;
                ali.AllianceId = Convert.ToInt32(allianceRow.Attributes["allianceID"].InnerText);
                ali.ExecutorCorpId = Convert.ToInt32(allianceRow.Attributes["executorCorpID"].InnerText);
                ali.MemberCount = Convert.ToInt32(allianceRow.Attributes["memberCount"].InnerText);
                ali.StartDate = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(allianceRow.Attributes["startDate"].InnerText);
                ali.StartDateLocal = TimeUtilities.ConvertCCPToLocalTime(ali.StartDate);

                List<CorporationListItem> parsedCorporationListItems = new List<CorporationListItem>();
                foreach (XmlNode corpRow in allianceRow.SelectNodes("rowset[@name='memberCorporations']/row"))
                {
                    CorporationListItem cli = new CorporationListItem();
                    cli.CorporationId = Convert.ToInt32(corpRow.Attributes["corporationID"].InnerText);
                    cli.StartDate = TimeUtilities.ConvertCCPTimeStringToDateTimeUTC(corpRow.Attributes["startDate"].InnerText);
                    cli.StartDateLocal = TimeUtilities.ConvertCCPToLocalTime(cli.StartDate);

                    parsedCorporationListItems.Add(cli);
                }
                ali.CorporationListItems = parsedCorporationListItems.ToArray();

                parsedAllianceListItems.Add(ali);
            }

            allianceList.AllianceListItems = parsedAllianceListItems.ToArray();
            return allianceList;
        }

        public class AllianceListItem
        {
            public string Name;
            public string ShortName;
            public int AllianceId;
            public int ExecutorCorpId;
            public int MemberCount;
            public DateTime StartDate;
            public DateTime StartDateLocal;
            public CorporationListItem[] CorporationListItems;
        }

        public class CorporationListItem
        {
            public int CorporationId;
            public DateTime StartDate;
            public DateTime StartDateLocal;
        }
    }
}
