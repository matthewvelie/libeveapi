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
            string url = String.Format("{0}{1}?userID={2}&apiKey={3}", Constants.ApiPrefix, Constants.CharacterList, userId, apiKey);

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
        /// <param name="fullApiKey">Full access api key of account</param>
        /// <returns></returns>
        public static AccountBalance GetAccountBalance(AccountBalanceType accountBalanceType, string userId, string characterId, string fullApiKey)
        {
            string apiPath = string.Empty;
            switch (accountBalanceType)
            {
                case AccountBalanceType.Character:
                    apiPath = Constants.CharacterAccountBalance;
                    break;
                case AccountBalanceType.Corporation:
                    apiPath = Constants.CorpAccountBalance;
                    break;
            }

            string url = String.Format("{0}{1}?userID={2}&characterID={3}&apiKey={4}", Constants.ApiPrefix, apiPath, userId, characterId, fullApiKey);

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
        /// <param name="fullApiKey">Full access api key of account</param>
        /// <returns></returns>
        public static StarbaseList GetStarbaseList(string userId, string characterId, string fullApiKey)
        {
            string url = String.Format("{0}{1}?userID={2}&characterID={3}&apiKey={4}&version=2", Constants.ApiPrefix, Constants.StarbaseList, userId, characterId, fullApiKey);

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
        /// Returns the settings and fuel status of a starbase
        /// </summary>
        /// <param name="userId">user ID of account for authentication</param>
        /// <param name="characterId">Character ID of a char with director/CEO access in the corp that owns the starbase</param>
        /// <param name="fullApiKey">Full access api key of account</param>
        /// <param name="itemId">Item ID of the starbase as given in the starbase list</param>
        /// <returns></returns>
        public static StarbaseDetail GetStarbaseDetail(string userId, string characterId, string fullApiKey, string itemId)
        {
            string url = String.Format("{0}{1}?userID={2}&characterID={3}&apiKey={4}&itemID={5}&version=2", Constants.ApiPrefix, Constants.StarbaseDetails, userId, characterId, fullApiKey, itemId);

            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as StarbaseDetail;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            StarbaseDetail starbaseDetail = StarbaseDetail.FromXmlDocument(xmlDoc);
            starbaseDetail.Url = url;
            ResponseCache.Set(url, starbaseDetail);

            return starbaseDetail;
        }

        /// <summary>
        /// Returns a list of error codes that can be returned by the EVE API servers
        /// </summary>
        /// <returns></returns>
        public static ErrorList GetErrorList()
        {
            string url = String.Format("{0}{1}?version=2", Constants.ApiPrefix, Constants.ErrorList);

            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as ErrorList;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            ErrorList errorList = ErrorList.FromXmlDocument(xmlDoc);
            errorList.Url = url;
            ResponseCache.Set(url, errorList);

            return errorList;
        }

        /// <summary>
        /// Returns a list of assets owned by a character or corporation.
        /// </summary>
        /// <param name="assetListType"><see cref="AssetListType" /></param>
        /// <param name="userId">userID of account for authentication</param>
        /// <param name="characterId">CharacterID of character for authentication</param>
        /// <param name="fullApiKey">Full access API key of account</param>
        /// <returns></returns>
        public static AssetList GetAssetList(AssetListType assetListType, string userId, string characterId, string fullApiKey)
        {
            string apiPath = string.Empty;
            switch (assetListType)
            {
                case AssetListType.Character:
                    apiPath = Constants.CharAssetList;
                    break;
                case AssetListType.Corporation:
                    apiPath = Constants.CorpAssetList;
                    break;
            }

            string url = String.Format("{0}{1}?userID={2}&characterID={3}&apiKey={4}&version=2", Constants.ApiPrefix, apiPath, userId, characterId, fullApiKey);

            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as AssetList;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            AssetList assetList = AssetList.FromXmlDocument(xmlDoc);
            assetList.Url = url;
            ResponseCache.Set(url, assetList);

            return assetList;
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
