using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class MemberTrackingTests
    {
        [SetUp]
        public void Setup()
        {
            Utility.UseLocalUrls();
        }

        [Test]
        public void GetMemberTracking()
        {
            ResponseCache.Clear();
            MemberTracking memberTracking = EveApi.GetMemberTracking("userId", "characterId", "fullApiKey");

            Assert.AreEqual(memberTracking.Members.Length, 2);

            MemberTracking.Member mti = memberTracking.Members[0];
            Assert.AreEqual(150336922, mti.CharacterId);
            Assert.AreEqual("corpexport", mti.Name);
            Assert.AreEqual(0, mti.BaseId);
            Assert.AreEqual("base", mti.Base);
            Assert.AreEqual("asdf", mti.Title);
            Assert.AreEqual(60011566, mti.LocationId);
            Assert.AreEqual("Bourynes VII - Moon 2 - University of Caille School", mti.Location);
            Assert.AreEqual(606, mti.ShipTypeId);
            Assert.AreEqual("Velator", mti.ShipType);
            Assert.AreEqual("1281", mti.RolesMask);
            Assert.AreEqual("0", mti.GrantableRoles);

            Assert.AreEqual(new DateTime(2007, 6, 13, 14, 39, 00), mti.StartDateTime);
            Assert.AreEqual(new DateTime(2007, 6, 16, 21, 12, 00), mti.LogonDateTime);
            Assert.AreEqual(new DateTime(2007, 6, 16, 21, 36, 00), mti.LogoffDateTime);

            Assert.IsFalse(mti.Roles.HasRole(RoleTypes.PersonnelManager));
            Assert.IsFalse(mti.Roles.HasRole(RoleTypes.SecurityManager));
            Assert.IsTrue(mti.Roles.HasRole(RoleTypes.Director));
            Assert.IsTrue(mti.Roles.HasRole(RoleTypes.Accountant));
            Assert.IsTrue(mti.Roles.HasRole(RoleTypes.FactoryManager));
        }

        [Test]
        public void MemberTrackingPersist()
        {
            ResponseCache.Clear();
            MemberTracking memberTracking = EveApi.GetMemberTracking("userId", "characterId", "fullApiKey");

            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            MemberTracking cachedMemberTracking = EveApi.GetMemberTracking("userId", "characterId", "fullApiKey");

            Assert.AreEqual(memberTracking.CachedUntilLocal, cachedMemberTracking.CachedUntilLocal);
            Assert.AreEqual(memberTracking.Members.Length, cachedMemberTracking.Members.Length);

            for (int i = 0; i < memberTracking.Members.Length; i++)
            {
                MemberTracking.Member mti = memberTracking.Members[i];
                MemberTracking.Member cmti = cachedMemberTracking.Members[i];

                Assert.AreEqual(mti.CharacterId, cmti.CharacterId);
                Assert.AreEqual(mti.Name, cmti.Name);
                Assert.AreEqual(mti.BaseId, cmti.BaseId);
                Assert.AreEqual(mti.Base, cmti.Base);
                Assert.AreEqual(mti.Title, cmti.Title);
                Assert.AreEqual(mti.LocationId, cmti.LocationId);
                Assert.AreEqual(mti.Location, cmti.Location);
                Assert.AreEqual(mti.ShipTypeId, cmti.ShipTypeId);
                Assert.AreEqual(mti.ShipType, cmti.ShipType);
                Assert.AreEqual(mti.RolesMask, cmti.RolesMask);
                Assert.AreEqual(mti.GrantableRoles, cmti.GrantableRoles);
                Assert.AreEqual(mti.StartDateTime, cmti.StartDateTime);
                Assert.AreEqual(mti.LogonDateTime, cmti.LogonDateTime);
                Assert.AreEqual(mti.LogoffDateTime, cmti.LogoffDateTime);
                Assert.AreEqual(mti.StartDateTimeLocal, cmti.StartDateTimeLocal);
                Assert.AreEqual(mti.LogonDateTimeLocal, cmti.LogonDateTimeLocal);
                Assert.AreEqual(mti.LogoffDateTimeLocal, cmti.LogoffDateTimeLocal);
            }
        }
    }
}
