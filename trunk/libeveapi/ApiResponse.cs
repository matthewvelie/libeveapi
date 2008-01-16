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
    [XmlInclude(typeof(CharacterSheet))]
    [XmlInclude(typeof(CorporationSheet))]
    public class ApiResponse
    {
        /// <summary>
        /// This is a hashed version of the url that is sent to CCP to request the file
        /// </summary>
        [XmlElement]
        public string HashedUrl;

        /// <summary>
        /// This is the current time that CCP sends to us on the file.
        /// </summary>
        [XmlElement]
        public DateTime CurrentTime;

        /// <summary>
        /// This is the time that the file says it is cacheable till in CCP time.  We use
        /// the currentTime that is sent along with the file to calculate how long this
        /// is till.
        /// </summary>
        [XmlElement]
        public DateTime CachedUntil;

        /// <summary>
        /// This is the current time on the local machine.
        /// </summary>
        [XmlElement]
        public DateTime CurrentTimeLocal;

        /// <summary>
        /// This is what time the file should be cached to according to the local
        /// clock.  A timespan is created from the eve time, and added to CurrentTimeLocal
        /// </summary>
        [XmlElement]
        public DateTime CachedUntilLocal;

        /// <summary>
        /// 
        /// </summary>
        [XmlElement]
        public XmlDocument ResponseXml;

        /// <summary>
        /// This parses out all of the elements that are common to each one of the xml files,
        /// which mainly includes dates, or errors if they exist.
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
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
