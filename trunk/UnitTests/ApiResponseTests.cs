using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class ApiResponseTests
    {
        [Test]
        public void CommonElementParsing()
        {
            XmlDocument xmlDoc = Network.GetXml("http://localhost/eveapi/Characters.xml");
            ApiResponse apiResponse = new ApiResponse();
            apiResponse.ParseCommonElements(xmlDoc);

            DateTime currentTime = new DateTime(2007, 12, 12, 11, 48, 50);
            DateTime cachedUntil = new DateTime(2008, 12, 12, 12, 48, 50);

            Assert.AreEqual(currentTime, apiResponse.CurrentTime);
            Assert.AreEqual(cachedUntil, apiResponse.CachedUntil);
        }

        [Test]
        [ExpectedException(typeof(ApiResponseErrorException))]
        public void ApiResponseError()
        {
            XmlDocument xmlDoc = Network.GetXml("http://localhost/eveapi/Error.xml");
            ApiResponse apiResponse = new ApiResponse();
            apiResponse.ParseCommonElements(xmlDoc);
        }
    }
}
