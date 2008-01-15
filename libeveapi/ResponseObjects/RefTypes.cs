using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    public class RefTypes : ApiResponse
    {
        public SerializableDictionary<int, string> ReferenceTypes = new SerializableDictionary<int, string>();

        /// <summary>
        /// Create an ErrorList by parsing an XmlDocument response from the eveapi
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static RefTypes FromXmlDocument(XmlDocument xmlDoc)
        {
            RefTypes refTypes = new RefTypes();
            refTypes.ParseCommonElements(xmlDoc);

            foreach (XmlNode refTypeNode in xmlDoc.SelectNodes("//rowset[@name='refTypes']/row"))
            {
                refTypes.ReferenceTypes.Add(Convert.ToInt32(refTypeNode.Attributes["refTypeID"].InnerText), refTypeNode.Attributes["refTypeName"].InnerText);
            }

            return refTypes;
        }

        /// <summary>
        /// Returns the description for the specified error code
        /// </summary>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public string GetReferenceTypeNameForID(int referenceTypeID)
        {
            try
            {
                return ReferenceTypes[referenceTypeID];
            }
            catch (KeyNotFoundException)
            {
                return "Unknown Reference Type ID";
            }
        }
    }
}
