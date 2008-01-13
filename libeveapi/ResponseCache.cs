using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace libeveapi
{
    public class ResponseCache
    {
        private static Hashtable hashTable = new Hashtable();

        /// <summary>
        /// Store an ApiResponse in the cache
        /// </summary>
        /// <param name="url"></param>
        /// <param name="apiResponse"></param>
        public static void Set(string url, ApiResponse apiResponse)
        {
            if (hashTable.Contains(url))
            {
                hashTable.Remove(url);
            }
            hashTable.Add(url, apiResponse);
        }

        /// <summary>
        /// Get an ApiResponse from the cache
        /// </summary>
        /// <param name="url"></param>
        /// <returns>ApiResponse if cached ApiResponse is valid, null if it is expired</returns>
        public static ApiResponse Get(string url)
        {
            if (hashTable.Contains(url))
            {
                ApiResponse cachedResponse = hashTable[url] as ApiResponse;
                if (cachedResponse == null)
                {
                    return null;
                }

                if (DateTime.Now >= cachedResponse.CachedUntilLocal)
                {
                    return null;
                }

                return cachedResponse;
            }

            return null;
        }
    }
}
