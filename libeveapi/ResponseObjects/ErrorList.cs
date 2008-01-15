using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// 
    /// </summary>
    public class ErrorList : ApiResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public SerializableDictionary<string, string> ErrorTable = new SerializableDictionary<string, string>();

        /// <summary>
        /// Create an ErrorList by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static ErrorList FromXmlDocument(XmlDocument xmlDoc)
        {
            ErrorList errorList = new ErrorList();
            errorList.ParseCommonElements(xmlDoc);

            foreach (XmlNode errorNode in xmlDoc.SelectNodes("//rowset[@name='errors']/row"))
            {
                errorList.ErrorTable.Add(errorNode.Attributes["errorCode"].InnerText, errorNode.Attributes["errorText"].InnerText);
            }

            return errorList;
        }

        /// <summary>
        /// Returns the description for the specified error code
        /// </summary>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public string GetMessageForErrorCode(string errorCode)
        {
            try
            {
                return ErrorTable[errorCode];
            }
            catch (KeyNotFoundException)
            {
                return "Unknown Error Code";
            }
        }
    }
}
