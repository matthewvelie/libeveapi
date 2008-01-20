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
            Assert.AreEqual(new DateTime(2008, 01, 24, 23, 11, 16), skillintraining.TrainingEndTime);
            Assert.AreEqual(new DateTime(2008, 01, 16, 05, 21, 58), skillintraining.TrainingStartTime);
            Assert.AreEqual(24241, skillintraining.TrainingTypeId);
            Assert.AreEqual(90510, skillintraining.TrainingStartSP);
            Assert.AreEqual(512000, skillintraining.TrainingDestinationSP);
            Assert.AreEqual(5, skillintraining.TrainingToLevel);
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
            Assert.AreEqual(cached.TrainingTypeId, skillintraining.TrainingTypeId);
            Assert.AreEqual(cached.TrainingStartSP, skillintraining.TrainingStartSP);
            Assert.AreEqual(cached.TrainingDestinationSP, skillintraining.TrainingDestinationSP);
            Assert.AreEqual(cached.TrainingToLevel, skillintraining.TrainingToLevel);
            Assert.AreEqual(cached.SkillCurrentlyInTraining, skillintraining.SkillCurrentlyInTraining);
        }
    }
}
