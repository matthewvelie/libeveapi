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
        private static string characterSheetUrl = "/CharacterSheet.xml";
        private static string skillInTrainingUrl = "/SkillInTraining.xml";
        private static string charAccountBalanceUrl = "/char/AccountBalance.xml";
        private static string corpAccountBalanceUrl = "/corp/AccountBalance.xml";

        private Cache cache = Cache.GetInstance();

        public enum AccountBalanceType
        {
            Char,
            Corp
        }

        public XmlDocument GetAccountBalance(string userId, string fullApiKey, string characterId, AccountBalanceType accountBalanceType)
        {
            string url = APIBASE;
            if (accountBalanceType == AccountBalanceType.Char)
            {
                url += charAccountBalanceUrl;
            }
            else
            {
                url += corpAccountBalanceUrl;
            }

            string postData = "userid=" + userId + "&apiKey=" + fullApiKey;

            XmlDocument cachedResult = cache.Get(url + postData);
            if (cachedResult != null)
            {
                return cachedResult;
            }

            XmlResponse xmlResponse = GetXmlResponse(url, postData);
            cache.Set(url + postData, xmlResponse);
            return xmlResponse.XmlDoc;
        }
        
        public XmlDocument GetCharacterListXml(string userId, string apiKey, string characterId)
        {
            string url = APIBASE + apiCharListUrl;
            string postData = "userid=" + userId + "&apiKey=" + apiKey;

            XmlDocument cachedResult = cache.Get(url + postData);
            if (cachedResult != null)
            {
                return cachedResult;
            }

            XmlResponse xmlResponse = GetXmlResponse(url, postData);
            cache.Set(url + postData, xmlResponse);
            return xmlResponse.XmlDoc;
        }

        public XmlDocument GetCharacterSheet(string userId, string apiKey, string characterId)
        {
            string url = APIBASE + characterSheetUrl;
            string postData = "userID=" + userId + "&apiKey=" + apiKey + "&characterID=" + characterId;

            XmlDocument cachedResult = cache.Get(url + postData);
            if (cachedResult != null)
            {
                return cachedResult;
            }

            XmlResponse xmlResponse = GetXmlResponse(url, postData);
            cache.Set(url + postData, xmlResponse);
            return xmlResponse.XmlDoc;
        }
        
        public XmlDocument GetSkillInTrainingXml(string userId, string apiKey, string characterId)
        {
            string url = APIBASE + skillInTrainingUrl;
            string postData = "userID=" + userId + "&apiKey=" + apiKey + "&characterID=" + characterId;

            XmlDocument cachedResult = cache.Get(url + postData);
            if (cachedResult != null)
            {
                return cachedResult;
            }

            XmlResponse xmlResponse = GetXmlResponse(url, postData);
            cache.Set(url + postData, xmlResponse);
            return xmlResponse.XmlDoc;
        }

        private XmlResponse GetXmlResponse(string url, string postData)
        {
            WebRequestState wrs = new WebRequestState();
            wrs.SetPost(postData);
            XmlDocument xmlDoc = EVEMonWebRequest.LoadXml(url, wrs);
            DateTime cachedUntilUTC = GetCacheExpiryUTC(xmlDoc);
            return new XmlResponse(DateTime.Now.ToUniversalTime(), cachedUntilUTC, xmlDoc);
        }

        /// <summary>
        /// Converts a CCP API date/time string to a UTC DateTime
        /// </summary>
        /// <param name="timeUTC"></param>
        /// <returns></returns>
        public static DateTime ConvertCCPTimeStringToDateTime(string timeUTC)
        {
            // timeUTC  = yyyy-mm-dd hh:mm:ss
            if (timeUTC == null || timeUTC == "")
                return DateTime.MinValue;
            DateTime dt = new DateTime(
                            Int32.Parse(timeUTC.Substring(0, 4)),
                            Int32.Parse(timeUTC.Substring(5, 2)),
                            Int32.Parse(timeUTC.Substring(8, 2)),
                            Int32.Parse(timeUTC.Substring(11, 2)),
                            Int32.Parse(timeUTC.Substring(14, 2)),
                            Int32.Parse(timeUTC.Substring(17, 2)),
                            0,
                            DateTimeKind.Utc);
            return dt;
        }

        /// <summary>
        /// Compute the "cached until" time for the user's machine from the currentTime and cachedUntil nodes 
        /// in a CCP API message.
        /// </summary>
        /// <param name="xdoc">The xml message after validating that there is actual content!</param>
        /// <returns>a DateTime object in UTC time for when the message can be retrieved again - adjusted to compensate for the user's clock</returns>
        public static DateTime GetCacheExpiryUTC(XmlDocument xdoc)
        {
            // Firstly, extract the currentTime form the message - in case things go wrong, assume currentTine is "now"
            DateTime CCPCurrent = DateTime.Now.ToUniversalTime();
            try
            {
                XmlNode currentTimeNode = xdoc.SelectSingleNode("/eveapi/currentTime");
                CCPCurrent = ConvertCCPTimeStringToDateTime(currentTimeNode.InnerText);
            }
            catch (Exception)
            {
                // do  nothing - default to "now";
            }

            // Now suck out the cachedUntil time - assume 6 hours from now in case the parse fails
            DateTime cacheExpires = DateTime.Now.ToUniversalTime() + new TimeSpan(6, 0, 0);
            try
            {
                XmlNode cachedTimeNode = xdoc.SelectSingleNode("/eveapi/cachedUntil");
                cacheExpires = ConvertCCPTimeStringToDateTime(cachedTimeNode.InnerText);
            }
            catch (Exception)
            {
                // do  nothing - default to "now";
            }


            // Work out teh cache period from the message and calculate the expiry time according to user's pc clock...
            return DateTime.Now.ToUniversalTime() + (cacheExpires - CCPCurrent);
        }
    }
}
