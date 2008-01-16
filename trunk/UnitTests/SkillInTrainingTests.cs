using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class SkillInTrainingTests
    {
        [SetUp]
        public void Setup()
        {
            Utility.UseLocalUrls();
        }

        [Test]
        public void GetSkillInTraining()
        {
            ResponseCache.Clear();
            SkillInTraining skillintraining = EveApi.GetSkillInTraining("asdf","asdf","asdf");

            //Attributes of the currently training skill
            Assert.AreEqual("6/21/2007 9:27:50 PM", skillintraining.trainingEndTime.ToString());
            Assert.AreEqual("6/21/2007 11:00:38 AM", skillintraining.trainingStartTime.ToString());
            Assert.AreEqual(3347, skillintraining.trainingTypeID);
            Assert.AreEqual(4000, skillintraining.trainingStartSP);
            Assert.AreEqual(22628, skillintraining.trainingDestinationSP);
            Assert.AreEqual(2, skillintraining.trainingToLevel);
            Assert.AreEqual(true, skillintraining.skillInTraining);
        }

        [Test]
        public void PersistSkillInTraining()
        {
            ResponseCache.Clear();
            SkillInTraining skillintraining = EveApi.GetSkillInTraining("asdf", "asdf", "asdf");
            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            SkillInTraining cached = EveApi.GetSkillInTraining("asdf", "asdf", "asdf");

            //Test the Cache Time
            Assert.AreEqual(skillintraining.CachedUntilLocal, cached.CachedUntilLocal);

            //Attributes of the currently training skill
            Assert.AreEqual(cached.trainingEndTime, skillintraining.trainingEndTime);
            Assert.AreEqual(cached.trainingStartTime, skillintraining.trainingStartTime);
            Assert.AreEqual(cached.trainingTypeID, skillintraining.trainingTypeID);
            Assert.AreEqual(cached.trainingStartSP, skillintraining.trainingStartSP);
            Assert.AreEqual(cached.trainingDestinationSP, skillintraining.trainingDestinationSP);
            Assert.AreEqual(cached.trainingToLevel, skillintraining.trainingToLevel);
            Assert.AreEqual(cached.skillInTraining, skillintraining.skillInTraining);
        }
    }
}
