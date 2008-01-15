using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace libeveapi
{
    [XmlInclude(typeof(CharacterList))]
    [XmlInclude(typeof(AccountBalance))]
    [XmlInclude(typeof(StarbaseList))]
    [XmlInclude(typeof(StarbaseDetail))]
    [XmlInclude(typeof(ErrorList))]
    [XmlInclude(typeof(AssetList))]
    [XmlInclude(typeof(IndustryJobList))]
    [XmlInclude(typeof(JournalEntries))]
    [XmlInclude(typeof(WalletTransactions))]
    [XmlInclude(typeof(MarketOrder))]
    [XmlInclude(typeof(RefTypes))]
    [XmlInclude(typeof(MemberTracking))]
    public class ApiResponse
    {
        [XmlElement]
        public string HashedUrl;

        [XmlElement]
        public DateTime CurrentTime;

        [XmlElement]
        public DateTime CachedUntil;

        [XmlElement]
        public DateTime CurrentTimeLocal;

        [XmlElement]
        public DateTime CachedUntilLocal;

        [XmlElement]
        public XmlDocument ResponseXml;

        public void ParseCommonElements(XmlDocument xmlDoc)
        {
            DateTime.TryParse(xmlDoc.GetElementsByTagName("currentTime")[0].InnerText, out this.CurrentTime);
            DateTime.TryParse(xmlDoc.GetElementsByTagName("cachedUntil")[0].InnerText, out this.CachedUntil);
            this.ResponseXml = xmlDoc;

            TimeSpan cachedTimeSpan = CachedUntil.Subtract(CurrentTime);
            this.CachedUntilLocal = DateTime.Now.Add(cachedTimeSpan);

            this.CurrentTimeLocal = EveApi.CCPDateTimeToLocal(this.CurrentTime, this.CurrentTime);

            XmlNodeList errors = xmlDoc.GetElementsByTagName("error");
            if (errors.Count > 0)
            {
                string code = errors[0].Attributes["code"].InnerText;
                string message = errors[0].InnerText;
                throw new ApiResponseErrorException(code, message);
            }
        }
    }
}
