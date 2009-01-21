using System.Xml;

namespace libeveapi.ResponseObjects.Parsers
{
    ///<summary>
    /// A parser which converts a given <see cref="XmlDocument"/> to a <see cref="ErrorList"/>.
    ///</summary>
    internal class ErrorListResponseParser : IApiResponseParser<ErrorList>
    {
        public ErrorList Parse(XmlDocument xmlDocument)
        {
            ErrorList errorList = new ErrorList();
            errorList.ParseCommonElements(xmlDocument);

            foreach (XmlNode errorNode in xmlDocument.SelectNodes("//rowset[@name='errors']/row"))
            {
                errorList.ErrorTable.Add(errorNode.Attributes["errorCode"].InnerText, errorNode.Attributes["errorText"].InnerText);
            }

            return errorList;
        }
    }
}
