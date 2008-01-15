using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class ResponseCacheTests
    {
        [SetUp]
        public void Setup()
        {
            Utility.UseLocalUrls();
        }

        [Test]
        public void NonExpiredApiResponse()
        {
            ResponseCache.Clear();
            ApiResponse apiResponse = new ApiResponse();
            apiResponse.CachedUntilLocal = DateTime.Now.Add(TimeSpan.FromDays(1));

            ResponseCache.Set("NonExpiredApiResponse", apiResponse);
            ApiResponse cachedResponse = ResponseCache.Get("NonExpiredApiResponse");

            Assert.AreEqual(apiResponse, cachedResponse);
        }

        [Test]
        public void ExpiredApiResponse()
        {
            ResponseCache.Clear();
            ApiResponse apiResponse = new ApiResponse();
            apiResponse.CachedUntilLocal = DateTime.Now.Subtract(TimeSpan.FromDays(1));

            ResponseCache.Set("ExpiredApiResponse", apiResponse);
            ApiResponse cachedResponse = ResponseCache.Get("ExpiredApiResponse");

            Assert.AreEqual(null, cachedResponse);
        }

        [Test]
        public void PersistResponseCache()
        {
            ResponseCache.Clear();
            ApiResponse apiResponse = new ApiResponse();
            DateTime cachedUntil = DateTime.Now.Add(TimeSpan.FromDays(1));
            apiResponse.CachedUntilLocal = cachedUntil;
            apiResponse.HashedUrl = "PersistResponseCache";

            ResponseCache.Set("PersistResponseCache", apiResponse);
            ResponseCache.Save("responseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("responseCache.xml");

            ApiResponse cachedResponse = ResponseCache.Get("PersistResponseCache");
            Assert.AreEqual(cachedUntil, cachedResponse.CachedUntilLocal);
        }

        [Test]
        public void UsingStreams()
        {
            ResponseCache.Clear();
            ApiResponse apiResponse = new ApiResponse();
            DateTime cachedUntil = DateTime.Now.Add(TimeSpan.FromDays(1));
            apiResponse.CachedUntilLocal = cachedUntil;
            apiResponse.HashedUrl = "PersistResponseCache";

            ResponseCache.Set("PersistResponseCache", apiResponse);
            
            using (Stream s = new FileStream("ResponseCache.xml", FileMode.Create))
            {
                ResponseCache.Save(s);
            }
            
            ResponseCache.Clear();
            
            using (Stream s = new FileStream("ResponseCache.xml", FileMode.Open))
            {
                ResponseCache.Load(s);
            }

            ApiResponse cachedResponse = ResponseCache.Get("PersistResponseCache");
            
            Assert.AreEqual(cachedUntil, cachedResponse.CachedUntilLocal);
        }
    }
}
