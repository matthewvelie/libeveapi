using System;
using System.Collections.Generic;
using System.Text;

using libeveapi;

namespace UnitTests
{
    public class Utility
    {
        public static void UseLocalUrls()
        {
            Constants.ApiPrefix = "http://localhost/eveapi";
            Constants.CharacterAccountBalance = "/char/AccountBalance.xml";
            Constants.CorpAccountBalance = "/corp/AccountBalance.xml";
            Constants.CharacterList = "/account/Characters.xml";
            Constants.StarbaseDetails = "/corp/StarbaseDetail.xml";
            Constants.StarbaseList = "/corp/StarbaseList.xml";
            Constants.ErrorList = "/eve/ErrorList.xml";
            Constants.CharAssetList = "/char/AssetList.xml";
            Constants.CorpAssetList = "/corp/AssetList.xml";
        }
    }
}
