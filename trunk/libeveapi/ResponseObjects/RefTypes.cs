using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// This represents the different refence types used in the journal entries
    /// </summary>
    public class RefTypes : ApiResponse
    {
        /// <summary>
        /// A reference type is made up of an int, which is the referenceId, and then a string
        /// which is the name of the reference.  They are stored in a serializable dictionary
        /// for easy searching and saving.
        /// </summary>
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
        /// Returns the description for the specified reference type id
        /// </summary>
        /// <param name="referenceTypeId"></param>
        /// <returns></returns>
        public string GetReferenceTypeNameForId(int referenceTypeId)
        {
            try
            {
                return ReferenceTypes[referenceTypeId];
            }
            catch (KeyNotFoundException)
            {
                return "Unknown Reference Type Id";
            }
        }
    }
}
