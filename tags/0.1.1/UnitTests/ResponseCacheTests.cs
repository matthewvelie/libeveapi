using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class ResponseCacheTests
    {
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
            apiResponse.Url = "PersistResponseCache";

            ResponseCache.Set("PersistResponseCache", apiResponse);
            ResponseCache.SaveToFile("responseCache.xml");
            ResponseCache.Clear();
            ResponseCache.LoadFromFile("responseCache.xml");

            ApiResponse cachedResponse = ResponseCache.Get("PersistResponseCache");
            Assert.AreEqual(cachedUntil, cachedResponse.CachedUntilLocal);
        }
    }
}