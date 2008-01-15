using System;
using System.Collections.Generic;
using System.Text;

namespace libeveapi
{
    public class Constants
    {
        public static string ApiPrefix = "http://api.eve-online.com";
        public static string CharacterAccountBalance = "/char/AccountBalance.xml.aspx";
        public static string CorpAccountBalance = "/corp/AccountBalance.xml.aspx";
        public static string CharacterList = "/account/Characters.xml.aspx";
        public static string StarbaseDetails = "/corp/StarbaseDetail.xml.aspx";
        public static string StarbaseList = "/corp/StarbaseList.xml.aspx";
        public static string ErrorList = "/eve/ErrorList.xml.aspx";
        public static string CharAssetList = "/char/AssetList.xml.aspx";
        public static string CorpAssetList = "/corp/AssetList.xml.aspx";
        public static string CharIndustryJobs = "/char/IndustryJobs.xml.aspx";
        public static string CorpIndustryJobs = "/corp/IndustryJobs.xml.aspx";
        public static string CharJournalEntries = "/char/WalletJournal.xml.aspx";
        public static string CorpJournalEntries = "/corp/WalletJournal.xml.aspx";
        public static string CharMarketTransactions = "/char/WalletTransactions.xml.aspx";
        public static string CorpMarketTransactions = "/corp/WalletTransactions.xml.aspx";
        public static string RefTypesList = "/eve/RefTypes.xml.aspx";
        public static string MemberTracking = "/corp/MemberTracking.xml.aspx";

        // Not part of the eve-api - used for unit tests
        public static string ExampleError = "/Error.xml.aspx";
    }
}
