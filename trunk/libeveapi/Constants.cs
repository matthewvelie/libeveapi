#define USE_LOCALHOST

using System;
using System.Collections.Generic;
using System.Text;

namespace libeveapi
{
    class Constants
    {
#if USE_LOCALHOST
        internal static readonly string ApiPrefix = "http://localhost/eveapi";
        internal static readonly string CharacterAccountBalance = "/char/AccountBalance.xml";
        internal static readonly string CorpAccountBalance = "/corp/AccountBalance.xml";
        internal static readonly string CharacterList = "/account/Characters.xml";
        internal static readonly string StarbaseDetails = "/corp/StarbaseDetail.xml";
        internal static readonly string StarbaseList = "/corp/StarbaseList.xml";
        internal static readonly string ErrorList = "/eve/ErrorList.xml";
#else
        internal static readonly string ApiPrefix = "http://api.eve-online.com";
        internal static readonly string CharacterAccountBalance = "/char/AccountBalance.xml.aspx";
        internal static readonly string CorpAccountBalance = "/corp/AccountBalance.xml.aspx";
        internal static readonly string CharacterList = "/account/Characters.xml.aspx";
        internal static readonly string StarbaseDetails = "/corp/StarbaseDetail.xml.aspx";
        internal static readonly string StarbaseList = "/corp/StarbaseList.xml.aspx";
        internal static readonly string ErrorList = "/eve/ErrorList.xml.aspx";
#endif
    }
}
