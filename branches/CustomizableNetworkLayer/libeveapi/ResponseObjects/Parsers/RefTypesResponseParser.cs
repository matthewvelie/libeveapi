using System;
using System.Globalization;
using System.Xml;

namespace libeveapi.ResponseObjects.Parsers
{
    ///<summary>
    /// A parser which converts a given <see cref="XmlDocument"/> to a <see cref="RefTypes"/>.
    ///</summary>
    internal class RefTypesResponseParser : IApiResponseParser<RefTypes>
    {
        public RefTypes Parse(XmlDocument xmlDocument)
        {
            RefTypes refTypes = new RefTypes();
            refTypes.ParseCommonElements(xmlDocument);

            foreach (XmlNode refTypeNode in xmlDocument.SelectNodes("//rowset[@name='refTypes']/row"))
            {
                refTypes.ReferenceTypes.Add(Convert.ToInt32(refTypeNode.Attributes["refTypeID"].InnerText, CultureInfo.InvariantCulture), refTypeNode.Attributes["refTypeName"].InnerText);
            }

            return refTypes;
        }
    }
}
