using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using System.Security.Cryptography;

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
            url = SHA1HashString(url);

            if (hashTable.Contains(url))
            {
                hashTable.Remove(url);
            }
            hashTable.Add(url, apiResponse);
            apiResponse.HashedUrl = url;
        }

        /// <summary>
        /// Get an ApiResponse from the cache
        /// </summary>
        /// <param name="url"></param>
        /// <returns>ApiResponse if cached ApiResponse is valid, null if it is expired</returns>
        public static ApiResponse Get(string url)
        {
            url = SHA1HashString(url);

            if (hashTable.Contains(url))
            {
                ApiResponse cachedResponse = hashTable[url] as ApiResponse;

                if (DateTime.Now >= cachedResponse.CachedUntilLocal)
                {
                    return null;
                }

                return cachedResponse;
            }

            return null;
        }

        /// <summary>
        /// Remove all saved items from the cache
        /// </summary>
        public static void Clear()
        {
            hashTable.Clear();
        }

        /// <summary>
        /// Save all currently cached items to the specified file
        /// </summary>
        /// <param name="filePath"></param>
        public static void SaveToFile(string filePath)
        {
            List<ApiResponse> apiResponses = new List<ApiResponse>();
            foreach (ApiResponse apiResponse in hashTable.Values)
            {
                apiResponses.Add(apiResponse);
            }

            using (Stream s = new FileStream(filePath, FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<ApiResponse>), new Type[] { typeof(ApiResponse) });
                xs.Serialize(s, apiResponses);
            }
        }

        /// <summary>
        /// Load cached items from the specified file
        /// </summary>
        /// <param name="filePath"></param>
        public static void LoadFromFile(string filePath)
        {
            using (Stream s = new FileStream(filePath, FileMode.Open))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<ApiResponse>), new Type[] { typeof(ApiResponse) });
                List<ApiResponse> apiResponses = xs.Deserialize(s) as List<ApiResponse>;
                hashTable.Clear();
                foreach (ApiResponse apiResponse in apiResponses)
                {
                    hashTable.Add(apiResponse.HashedUrl, apiResponse);
                }
            }
        }

        private static string SHA1HashString(string input)
        {
            Byte[] clearBytes;
            Byte[] hashedBytes;
            string output = String.Empty;

            clearBytes = Encoding.UTF8.GetBytes(input);
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            sha1.ComputeHash(clearBytes);
            hashedBytes = sha1.Hash;
            sha1.Clear();
            output = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

            return output;
        }
    }
}
