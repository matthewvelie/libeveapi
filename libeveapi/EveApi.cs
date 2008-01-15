using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// 
    /// </summary>
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
            ResponseCache.Set(url, starbaseList);

            return starbaseList;
        }

        /// <summary>
        /// Returns the character id and character name, given the one or the other
        /// </summary>
        /// <param name="charactername">character name string, use to look up character id</param>
        /// <returns></returns>
        public static CharacterID GetCharacterIDName(string charactername)
        {
            string url = String.Format("{0}{1}?names={2}", Constants.ApiPrefix, Constants.CharacterIDName, charactername);

            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as CharacterID;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            CharacterID charID = CharacterID.FromXmlDocument(xmlDoc);
            ResponseCache.Set(url, charID);

            return charID;
        }

        /// <summary>
        /// Returns the character id and character name, given the one or the other
        /// </summary>
        /// <param name="characterID">characterID used to look up character name</param>
        /// <returns></returns>
        public static CharacterID GetCharacterIDName(int characterID)
        {
            string url = String.Format("{0}{1}?ids={2}", Constants.ApiPrefix, Constants.CharacterIDName, characterID);

            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as CharacterID;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            CharacterID charID = CharacterID.FromXmlDocument(xmlDoc);
            ResponseCache.Set(url, charID);

            return charID;
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
            ResponseCache.Set(url, assetList);

            return assetList;
        }

        /// <summary>
        /// Returns a list of industrial jobs owned by a character or corporation.
        /// </summary>
        /// <param name="industryJobListType"><see cref="IndustryJobListType" /></param>
        /// <param name="userId">userID of account for authentication</param>
        /// <param name="characterId">CharacterID of character for authentication</param>
        /// <param name="fullApiKey">Full access API key of account</param>
        /// <returns></returns>
        public static IndustryJobList GetIndustryJobList(IndustryJobListType industryJobListType, string userId, string characterId, string fullApiKey)
        {
            string apiPath = string.Empty;
            switch (industryJobListType)
            {
                case IndustryJobListType.Character:
                    apiPath = Constants.CharIndustryJobs;
                    break;
                case IndustryJobListType.Corporation:
                    apiPath = Constants.CorpIndustryJobs;
                    break;
            }

            string url = String.Format("{0}{1}?userID={2}&characterID={3}&apiKey={4}&version=2", Constants.ApiPrefix, apiPath, userId, characterId, fullApiKey);

            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as IndustryJobList;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            IndustryJobList industryJobList = IndustryJobList.FromXmlDocument(xmlDoc);
            ResponseCache.Set(url, industryJobList);

            return industryJobList;
        }

        /// <summary>
        /// Returns a list of journal entries owned by a character or corporation.
        /// </summary>
        /// <param name="journalEntriesType"><see cref="JournalEntryType" /></param>
        /// <param name="userId">userID of account for authentication</param>
        /// <param name="characterId">CharacterID of character for authentication</param>
        /// <param name="fullApiKey">Full access API key of account</param>
        /// <returns></returns>
        public static JournalEntries GetJournalEntryList(JournalEntryType journalEntriesType, string userId, string characterId, string fullApiKey)
        {
            string apiPath = string.Empty;
            switch (journalEntriesType)
            {
                case JournalEntryType.Character:
                    apiPath = Constants.CharJournalEntries;
                    break;
                case JournalEntryType.Corporation:
                    apiPath = Constants.CorpJournalEntries;
                    break;
            }

            string url = String.Format("{0}{1}?userID={2}&characterID={3}&apiKey={4}", Constants.ApiPrefix, apiPath, userId, characterId, fullApiKey);
            Console.WriteLine(url);
            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as JournalEntries;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            JournalEntries journalEntriesList = JournalEntries.FromXmlDocument(xmlDoc);
            ResponseCache.Set(url, journalEntriesList);

            return journalEntriesList;
        }

        /// <summary>
        /// Returns a list of market orders owned by a character or corporation.
        /// </summary>
        /// <param name="marketOrdersType"><see cref="MarketOrderType" /></param>
        /// <param name="userId">userID of account for authentication</param>
        /// <param name="characterId">CharacterID of character for authentication</param>
        /// <param name="fullApiKey">Full access API key of account</param>
        /// <returns></returns>
        public static MarketOrder GetMarketOrderList(MarketOrderType marketOrdersType, string userId, string characterId, string fullApiKey)
        {
            string apiPath = string.Empty;
            switch (marketOrdersType)
            {
                case MarketOrderType.Character:
                    apiPath = Constants.CharMarketOrders;
                    break;
                case MarketOrderType.Corporation:
                    apiPath = Constants.CorpMarketOrders;
                    break;
            }

            string url = String.Format("{0}{1}?userID={2}&characterID={3}&apiKey={4}&version=2", Constants.ApiPrefix, apiPath, userId, characterId, fullApiKey);

            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as MarketOrder;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            MarketOrder marketOrderList = MarketOrder.FromXmlDocument(xmlDoc);
            ResponseCache.Set(url, marketOrderList);

            return marketOrderList;
        }

        /// <summary>
        /// Returns a list of market transactions (wallet transactions) owned by a character or corporation.
        /// </summary>
        /// <param name="walletTransactionType"><see cref="WalletTransactionListType" /></param>
        /// <param name="userId">userID of account for authentication</param>
        /// <param name="characterId">CharacterID of character for authentication</param>
        /// <param name="fullApiKey">Full access API key of account</param>
        /// <returns></returns>
        public static WalletTransactions GetWalletTransactionsList(WalletTransactionListType walletTransactionType, string userId, string characterId, string fullApiKey)
        {
            string apiPath = string.Empty;
            switch (walletTransactionType)
            {
                case WalletTransactionListType.Character:
                    apiPath = Constants.CharWalletTransactions;
                    break;
                case WalletTransactionListType.Corporation:
                    apiPath = Constants.CorpWalletTransactions;
                    break;
            }

            string url = String.Format("{0}{1}?userID={2}&characterID={3}&apiKey={4}&version=2", Constants.ApiPrefix, apiPath, userId, characterId, fullApiKey);

            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as WalletTransactions;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            WalletTransactions walletTransactionList = WalletTransactions.FromXmlDocument(xmlDoc);
            ResponseCache.Set(url, walletTransactionList);

            return walletTransactionList;
        }

        /// <summary>
        /// Returns a list of RefTypes that are used by certain API Calls
        /// </summary>
        /// <returns></returns>
        public static RefTypes GetRefTypesList()
        {
            string url = String.Format("{0}{1}?version=2", Constants.ApiPrefix, Constants.RefTypesList);

            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as RefTypes;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            RefTypes refTypeList = RefTypes.FromXmlDocument(xmlDoc);
            ResponseCache.Set(url, refTypeList);

            return refTypeList;
        }


        /// <summary>
        /// Returns information on every member in the corporation. Information retrieved
        /// varies on your roles without within the corporation. Not valid for NPC corps.
        /// </summary>
        /// <param name="userId">user ID of account for authentication</param>
        /// <param name="characterId">Character ID of a char with director/CEO access in the corp that owns the starbase</param>
        /// <param name="fullApiKey">Full access api key of account</param>
        /// <returns></returns>
        public static MemberTracking GetMemberTracking(string userId, string characterId, string fullApiKey)
        {
            string url = String.Format("{0}{1}?userID={2}&characterID={3}&apiKey={4}&version=1", Constants.ApiPrefix, Constants.MemberTracking, userId, characterId, fullApiKey);

            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as MemberTracking;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            MemberTracking memberTracking = MemberTracking.FromXmlDocument(xmlDoc);
            ResponseCache.Set(url, memberTracking);

            return memberTracking;
        }

        /// <summary>
        /// Returns a detailed description of a character
        /// </summary>
        /// <param name="userId">userID of account for authentication</param>
        /// <param name="characterId">CharacterID of character for authentication</param>
        /// <param name="apiKey">Limited access API key of account</param>
        /// <returns></returns>
        public static CharacterSheet GetCharacterSheet(string userId, string characterId, string apiKey)
        {
            string url = String.Format("{0}{1}?userID={2}&characterID={3}&apiKey={4}", Constants.ApiPrefix, Constants.CharacterSheet, userId, characterId, apiKey);
            
            ApiResponse cachedResponse = ResponseCache.Get(url);
            if (cachedResponse != null)
            {
                return cachedResponse as CharacterSheet;
            }

            XmlDocument xmlDoc = Network.GetXml(url);
            CharacterSheet characterSheet = CharacterSheet.FromXmlDocument(xmlDoc);
            ResponseCache.Set(url, characterSheet);

            return characterSheet;
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
        /// <summary>
        /// The error code
        /// </summary>
        public string Code;

        /// <summary>
        /// Sets the current error code to the code recieved
        /// </summary>
        /// <param name="code"></param>
        /// <param name="message"></param>
        public ApiResponseErrorException(string code, string message)
            : base(message)
        {
            this.Code = code;
        }
    }
}
