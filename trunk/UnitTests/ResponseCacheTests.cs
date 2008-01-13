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
            ApiResponse apiResponse = new ApiResponse();
            apiResponse.CachedUntilLocal = DateTime.Now.Add(TimeSpan.FromDays(1));

            ResponseCache.Set("NonExpiredApiResponse", apiResponse);
            ApiResponse cachedResponse = ResponseCache.Get("NonExpiredApiResponse");

            Assert.AreEqual(apiResponse, cachedResponse);
        }

        [Test]
        public void ExpiredApiResponse()
        {
            ApiResponse apiResponse = new ApiResponse();
            apiResponse.CachedUntilLocal = DateTime.Now.Subtract(TimeSpan.FromDays(1));

            ResponseCache.Set("ExpiredApiResponse", apiResponse);
            ApiResponse cachedResponse = ResponseCache.Get("ExpiredApiResponse");

            Assert.AreEqual(null, cachedResponse);
        }
    }
}
