using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class RefTypeTests
    {
        [SetUp]
        public void Setup()
        {
            Utility.UseLocalUrls();
        }

        [Test]
        public void GetRefTypeList()
        {
            RefTypes referenceType = EveApi.GetRefTypesList();

            Assert.AreEqual("Undefined", referenceType.GetReferenceTypeNameForID(0) );
            Assert.AreEqual("Player Trading", referenceType.GetReferenceTypeNameForID(1));
        }

        [Test]
        public void RefTypePersist()
        {
            ResponseCache.Clear();

            RefTypes referenceType = EveApi.GetRefTypesList();
            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            RefTypes cachedReferenceType = EveApi.GetRefTypesList();

            Assert.AreEqual(referenceType.CachedUntilLocal, cachedReferenceType.CachedUntilLocal);
        }
    }
}

