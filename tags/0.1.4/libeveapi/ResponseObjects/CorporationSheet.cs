using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Detailed information about a corporation
    /// </summary>
    public class CorporationSheet : ApiResponse
    {
        public int CorporationId;
        public string CorporationName;
        public string Ticker;
        public int CeoId;
        public string CeoName;
        public int StationId;
        public string StationName;
        public string Description;
        public string Url;
        public int AllianceId;
        public string AllianceName;
        public double TaxRate;
        public int MemberCount;
        public int MemberLimit;
        public long Shares;

        public Division[] Divisions = new Division[0];
        public WalletDivision[] WalletDivisions = new WalletDivision[0];
        public CorpLogo Logo = new CorpLogo();

        internal static CorporationSheet FromXmlDocument(XmlDocument xmlDoc)
        {
            CorporationSheet corporationSheet = new CorporationSheet();
            corporationSheet.ParseCommonElements(xmlDoc);

            corporationSheet.CorporationId = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/corporationID").InnerText);
            corporationSheet.CorporationName = xmlDoc.SelectSingleNode("//result/corporationName").InnerText;
            corporationSheet.Ticker = xmlDoc.SelectSingleNode("//result/ticker").InnerText;
            corporationSheet.CeoId = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/ceoID").InnerText);
            corporationSheet.CeoName = xmlDoc.SelectSingleNode("//result/ceoName").InnerText;
            corporationSheet.StationId = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/stationID").InnerText);
            corporationSheet.StationName = xmlDoc.SelectSingleNode("//result/stationName").InnerText;
            corporationSheet.Description = xmlDoc.SelectSingleNode("//result/description").InnerText;
            corporationSheet.Url = xmlDoc.SelectSingleNode("//result/url").InnerText;
            corporationSheet.AllianceId = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/allianceID").InnerText);
            corporationSheet.AllianceName = xmlDoc.SelectSingleNode("//result/allianceName").InnerText;
            corporationSheet.TaxRate = Convert.ToDouble(xmlDoc.SelectSingleNode("//result/taxRate").InnerText);
            corporationSheet.MemberCount = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/memberCount").InnerText);
            corporationSheet.MemberLimit = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/memberLimit").InnerText);
            corporationSheet.Shares = Convert.ToInt64(xmlDoc.SelectSingleNode("//result/shares").InnerText);

            List<Division> parsedDivisions = new List<Division>();
            foreach (XmlNode row in xmlDoc.SelectNodes("//rowset[@name='divisions']/row"))
            {
                Division division = new Division();
                division.AccountKey = Convert.ToInt64(row.Attributes["accountKey"].InnerText);
                division.Description = row.Attributes["description"].InnerText;
                parsedDivisions.Add(division);
            }
            corporationSheet.Divisions = parsedDivisions.ToArray();

            List<WalletDivision> parsedWalletDivisions = new List<WalletDivision>();
            foreach (XmlNode row in xmlDoc.SelectNodes("//rowset[@name='walletDivisions']/row"))
            {
                WalletDivision walletDivision = new WalletDivision();
                walletDivision.AccountKey = Convert.ToInt64(row.Attributes["accountKey"].InnerText);
                walletDivision.Description = row.Attributes["description"].InnerText;
                parsedWalletDivisions.Add(walletDivision);
            }
            corporationSheet.WalletDivisions = parsedWalletDivisions.ToArray();

            corporationSheet.Logo.GraphicId = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/logo/graphicID").InnerText);
            corporationSheet.Logo.Shape1 = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/logo/shape1").InnerText);
            corporationSheet.Logo.Shape2 = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/logo/shape2").InnerText);
            corporationSheet.Logo.Shape3 = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/logo/shape3").InnerText);
            corporationSheet.Logo.Color1 = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/logo/color1").InnerText);
            corporationSheet.Logo.Color2 = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/logo/color2").InnerText);
            corporationSheet.Logo.Color3 = Convert.ToInt32(xmlDoc.SelectSingleNode("//result/logo/color3").InnerText);

            return corporationSheet;
        }

        public class Division
        {
            public long AccountKey;
            public string Description;
        }

        public class WalletDivision
        {
            public long AccountKey;
            public string Description;
        }

        public class CorpLogo
        {
            public int GraphicId;
            public int Shape1;
            public int Shape2;
            public int Shape3;
            public int Color1;
            public int Color2;
            public int Color3;
        }
    }
}
