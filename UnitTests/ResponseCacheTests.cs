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
        public void ExpiredApiResponse()
        {
            ResponseCache.Clear();
            string errorListLocation = Constants.ErrorList;
            Constants.ErrorList = "/ErrorListExpired.xml.aspx";
            ErrorList errorList = EveApi.GetErrorList();
            System.Threading.Thread.Sleep(10);
            ErrorList errorList2 = EveApi.GetErrorList();

            Assert.AreNotEqual(errorList.CachedUntilLocal, errorList2.CachedUntilLocal);

            Constants.ErrorList = errorListLocation;
        }

        [Test]
        public void UsingStreams()
        {
            ResponseCache.Clear();
            ErrorList errorList = EveApi.GetErrorList();

            using (Stream s = new FileStream("ResponseCache.xml", FileMode.Create))
            {
                ResponseCache.Save(s);
            }
            
            ResponseCache.Clear();
            
            using (Stream s = new FileStream("ResponseCache.xml", FileMode.Open))
            {
                ResponseCache.Load(s);
            }

            ErrorList cached = EveApi.GetErrorList();

            Assert.AreEqual(errorList.CachedUntilLocal, cached.CachedUntilLocal);
        }
    }
}
