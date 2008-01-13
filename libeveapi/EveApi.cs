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
        public CharacterList GetAccountCharacters(string userId, string apiKey)
        {
            string url = String.Format("http://localhost/eveapi/Characters.xml?userId={0}&apiKey={1}", userId, apiKey);
            XmlDocument xmlDoc = Network.GetXml(url);
            CharacterList characterList = CharacterList.FromXmlDocument(xmlDoc);
            characterList.Url = url;

            return characterList;
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
