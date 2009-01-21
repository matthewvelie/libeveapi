using System.Collections.Generic;

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
