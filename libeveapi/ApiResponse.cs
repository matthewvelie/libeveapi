using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    public class ApiResponse
    {
        public string Url;
        public DateTime CurrentTime;
        public DateTime CachedUntil;
        public DateTime CachedUntilLocal;
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
