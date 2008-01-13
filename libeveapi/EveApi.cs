using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    public class EveApi
    {
        /// <summary>
        /// Returns a list of all characters on an account
        /// </summary>
        /// <param name="userId">userID of the account for authentication</param>
        /// <param name="apiKey">limited or full access api key of account</param>
        /// <returns></returns>
        public static CharacterList GetAccountCharacters(string userId, string apiKey)
        {
            string url = String.Format("http://localhost/eveapi/Characters.xml?userId={0}&apiKey={1}", userId, apiKey);

            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as CharacterList;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            CharacterList characterList = CharacterList.FromXmlDocument(xmlDoc);
            characterList.Url = url;
            ResponseCache.Set(url, characterList);

            return characterList;
        }

        /// <summary>
        /// Returns the ISK balance of a corporation or character
        /// </summary>
        /// <param name="accountBalanceType">retrieve balance for character or corporation</param>
        /// <param name="userId">user ID of account for authentication</param>
        /// <param name="characterId">
        /// For character balance: The character you are requesting data for
        /// For corporation balance: Character ID of a char with director/CEO access in the corp you want the balance for
        /// </param>
        /// <param name="apiKey">Full access api key of account</param>
        /// <returns></returns>
        public static AccountBalance GetAccountBalance(AccountBalanceType accountBalanceType, string userId, string characterId, string apiKey)
        {
            string url = string.Empty;
            if (accountBalanceType == AccountBalanceType.Character)
            {
                url = "http://localhost/eveapi/CharAccountBalance.xml";
            }
            else if (accountBalanceType == AccountBalanceType.Corporation)
            {
                url = "http://localhost/eveapi/CorpAccountBalance.xml";
            }

            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as AccountBalance;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            AccountBalance accountBalance = AccountBalance.FromXmlDocument(xmlDoc);
            accountBalance.Url = url;
            ResponseCache.Set(url, accountBalance);

            return accountBalance;
        }

        /// <summary>
        /// Returns a list of starbases owned by a corporation
        /// </summary>
        /// <param name="userId">user ID of account for authentication</param>
        /// <param name="characterId">Character ID of a char with director/CEO access in the corp you want the starbases for</param>
        /// <param name="apiKey">Full access api key of account</param>
        /// <returns></returns>
        public static StarbaseList GetStarbaseList(string userId, string characterId, string apiKey)
        {
            string url = "http://localhost/eveapi/StarbaseList.xml";

            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as StarbaseList;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            StarbaseList starbaseList = StarbaseList.FromXmlDocument(xmlDoc);
            starbaseList.Url = url;
            ResponseCache.Set(url, starbaseList);

            return starbaseList;
        }

        /// <summary>
        /// Convert a CCP DateTime to local time
        /// </summary>
        /// <param name="ccpCurrentTime">CCP server current datetime</param>
        /// <param name="ccpDateTime">the datetime to convert to local</param>
        /// <returns></returns>
        public static DateTime CCPDateTimeToLocal(DateTime ccpCurrentTime, DateTime ccpDateTime)
        {
            TimeSpan offset = DateTime.Now.Subtract(ccpCurrentTime);
            return ccpDateTime.Add(offset);
        }
    }

    /// <summary>
    /// Raised when an error reponse is received from an eve api request
    /// </summary>
    public class ApiResponseErrorException : Exception
    {
        public string Code;

        public ApiResponseErrorException(string code, string message)
            : base(message)
        {
            this.Code = code;
        }
    }
}
