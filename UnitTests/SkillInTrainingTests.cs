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
            Assert.AreEqual("6/21/2007 9:27:50 PM", skillintraining.TrainingEndTime.ToString());
            Assert.AreEqual("6/21/2007 11:00:38 AM", skillintraining.TrainingStartTime.ToString());
            Assert.AreEqual(3347, skillintraining.TrainingTypeID);
            Assert.AreEqual(4000, skillintraining.TrainingStartSP);
            Assert.AreEqual(22628, skillintraining.TrainingDestinationSP);
            Assert.AreEqual(2, skillintraining.TrainingToLevel);
            Assert.AreEqual(true, skillintraining.SkillCurrentlyInTraining);
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
            Assert.AreEqual(cached.TrainingEndTime, skillintraining.TrainingEndTime);
            Assert.AreEqual(cached.TrainingStartTime, skillintraining.TrainingStartTime);
            Assert.AreEqual(cached.TrainingTypeID, skillintraining.TrainingTypeID);
            Assert.AreEqual(cached.TrainingStartSP, skillintraining.TrainingStartSP);
            Assert.AreEqual(cached.TrainingDestinationSP, skillintraining.TrainingDestinationSP);
            Assert.AreEqual(cached.TrainingToLevel, skillintraining.TrainingToLevel);
            Assert.AreEqual(cached.SkillCurrentlyInTraining, skillintraining.SkillCurrentlyInTraining);
        }
    }
}
