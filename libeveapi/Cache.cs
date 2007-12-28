using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    internal class Cache
    {
        private static Cache instance = null;
        private static Object mutexLock = new Object();

        private Hashtable responseCache = new Hashtable();

        public static Cache GetInstance()
        {
            lock (mutexLock)
            {
                if (instance == null)
                    instance = new Cache();
                return instance;
            }
        }

        internal void Set(string key, XmlResponse xmlResponse)
        {
            lock (mutexLock)
            {
                if (responseCache.ContainsKey(key))
                {
                    responseCache.Remove(key);
                }

                responseCache.Add(key, xmlResponse);
            }
        }

        internal XmlDocument Get(string key)
        {
            if (responseCache.ContainsKey(key))
            {
                XmlResponse cachedXmlReponse = responseCache[key] as XmlResponse;
                if (DateTime.Now.ToUniversalTime() < cachedXmlReponse.CachedUntilUTC)
                {
                    return cachedXmlReponse.XmlDoc;
                }
            }

            return null;
        }
    }

    internal class XmlResponse
    {
        private DateTime retrievedAtUTC;
        private DateTime cachedUntilUTC;
        private XmlDocument xmlDoc;

        public XmlResponse(DateTime retrievedAtUTC, DateTime cachedUntilUTC, XmlDocument xmlDoc)
        {
            this.retrievedAtUTC = retrievedAtUTC;
            this.cachedUntilUTC = cachedUntilUTC;
            this.xmlDoc = xmlDoc;
        }

        public DateTime RetrievedAtUTC
        {
            get { return this.retrievedAtUTC; }
        }

        public DateTime CachedUntilUTC
        {
            get { return this.cachedUntilUTC; }
        }

        public XmlDocument XmlDoc
        {
            get { return this.xmlDoc; }
        }
    }
}
