using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace libeveapi
{
    [XmlInclude(typeof(CharacterList))]
    public class ApiResponse
    {
        [XmlElement]
        public string Url;

        [XmlElement]
        public DateTime CurrentTime;

        [XmlElement]
        public DateTime CachedUntil;

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
