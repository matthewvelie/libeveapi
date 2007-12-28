using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using EVEMon.Common;

namespace libeveapi
{
    public class EveApi
    {
        private static string APIBASE = "http://exa-nation.com/api";
        private static string apiCharListUrl = "/Characters.xml";

        private Cache cache = Cache.GetInstance();

        public XmlDocument GetCharacterListXml(string userId, string apiKey, string characterId)
        {
            WebRequestState wrs = new WebRequestState();
            string url = APIBASE + apiCharListUrl;
            string postData = "userid=" + userId + "&apiKey=" + apiKey;

            XmlDocument cachedResult = cache.Get(url + postData);
            if (cachedResult != null)
            {
                return cachedResult;
            }

            wrs.SetPost(postData);
            return EVEMonWebRequest.LoadXml(url, wrs);
        }
    }
}
