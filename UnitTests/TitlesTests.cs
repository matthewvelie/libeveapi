using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class TitlesTests
    {
        [SetUp]
        public void Setup()
        {
            Utility.UseLocalUrls();
        }

        [Test]
        public void GetCharTitlesTest()
        {
            Titles titles = EveApi.GetTitles(453254, 453453, "apiKey");
            Titles.TitleItem titleItem = titles.TitleItems[0];
            Assert.AreEqual(1, titleItem.ID);
            Assert.AreEqual("Member", titleItem.Name);
            
            Assert.AreEqual(8192, titleItem.RolesAtHQ[0].ID);
            Assert.AreEqual("roleHanderCanTake1", titleItem.RolesAtHQ[0].Name);
//            Assert.AreEqual("Can take items from this divisions hangar", titleItem.RolesAtHQ[0].);
        }

        [Test]
        public void AccountPersist()
        {
            ResponseCache.Clear();

            Titles titles = EveApi.GetTitles(432435, 346, "apiKey");
            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            Titles cachedTitles = EveApi.GetTitles(432435, 346, "apiKey");

            Assert.AreEqual(titles.CachedUntilLocal, cachedTitles.CachedUntilLocal);

            for (int i = 0; i < titles.TitleItems.Length; i++)
            {
                for (int j = 0; j < titles.TitleItems[i].Roles.Length; j++)
                {
                    Assert.AreEqual(titles.TitleItems[i].Roles[j], cachedTitles.TitleItems[i].Roles[j]);
                }
                for (int j = 0; j < titles.TitleItems[i].GrantableRoles.Length; j++)
                {
                    Assert.AreEqual(titles.TitleItems[i].GrantableRoles[j], cachedTitles.TitleItems[i].GrantableRoles[j]);
                }
                for (int j = 0; j < titles.TitleItems[i].RolesAtHQ.Length; j++)
                {
                    Assert.AreEqual(titles.TitleItems[i].RolesAtHQ[j], cachedTitles.TitleItems[i].RolesAtHQ[j]);
                }
                for (int j = 0; j < titles.TitleItems[i].GrantableRolesAtHQ.Length; j++)
                {
                    Assert.AreEqual(titles.TitleItems[i].GrantableRolesAtHQ[j], cachedTitles.TitleItems[i].GrantableRolesAtHQ[j]);
                }
                for (int j = 0; j < titles.TitleItems[i].RolesAtBase.Length; j++)
                {
                    Assert.AreEqual(titles.TitleItems[i].RolesAtBase[j], cachedTitles.TitleItems[i].RolesAtBase[j]);
                }
                for (int j = 0; j < titles.TitleItems[i].RolesAtOther.Length; j++)
                {
                    Assert.AreEqual(titles.TitleItems[i].RolesAtOther[j], cachedTitles.TitleItems[i].RolesAtOther[j]);
                }
                for (int j = 0; j < titles.TitleItems[i].GrantableRolesAtOther.Length; j++)
                {
                    Assert.AreEqual(titles.TitleItems[i].GrantableRolesAtOther[j], cachedTitles.TitleItems[i].GrantableRolesAtOther[j]);
                }
            }
        }
    }
}
