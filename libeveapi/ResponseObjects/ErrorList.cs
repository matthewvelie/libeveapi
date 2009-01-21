using System.Collections.Generic;

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
