using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class KillLogTests
    {
        [SetUp]
        public void Setup()
        {
            Utility.UseLocalUrls();
        }

        [Test]
        public void GetKillLog()
        {
            KillLog killLog = EveApi.GetKillLog(KillLogType.Character, 432435, 346, "apiKey");

            KillLog.Kill firstKill = getKill(63, killLog.Kills);
            KillLog.Kill secondKill = getKill(62, killLog.Kills);
            
            //Victim Checks
            Assert.AreEqual(150340823, firstKill.Victim.CharacterID);
            Assert.AreEqual("Dieinafire", firstKill.Victim.CharacterName);
            Assert.AreEqual(1000169, firstKill.Victim.CorporationID);
            Assert.AreEqual("Center for Advanced Studies", firstKill.Victim.CorporationName);
            Assert.AreEqual(0, firstKill.Victim.AllianceID);
            Assert.AreEqual(6378, firstKill.Victim.DamageTaken);
            Assert.AreEqual(12003, firstKill.Victim.ShipTypeID);
            Assert.AreEqual("", firstKill.Victim.AllianceName);

            Assert.AreEqual(150340823, secondKill.Victim.CharacterID);
            Assert.AreEqual("Dieinafire", secondKill.Victim.CharacterName);
            Assert.AreEqual(1000169, secondKill.Victim.CorporationID);
            Assert.AreEqual("Center for Advanced Studies", secondKill.Victim.CorporationName);
            Assert.AreEqual(0, secondKill.Victim.AllianceID);
            Assert.AreEqual(455, secondKill.Victim.DamageTaken);
            Assert.AreEqual(606, secondKill.Victim.ShipTypeID);
            Assert.AreEqual("", secondKill.Victim.AllianceName);

            //Attackers Check
            Assert.AreEqual(0, firstKill.Attackers[0].CharacterID);
            Assert.AreEqual("", firstKill.Attackers[0].CharacterName);
            Assert.AreEqual(1000127, firstKill.Attackers[0].CorporationID);
            Assert.AreEqual("Guristas", firstKill.Attackers[0].CorporationName);
            Assert.AreEqual(0, firstKill.Attackers[0].AllianceID);
            Assert.AreEqual(6313, firstKill.Attackers[0].DamageDone);
            Assert.AreEqual(203, firstKill.Attackers[0].ShipTypeID);
            Assert.AreEqual(0, firstKill.Attackers[0].WeaponTypeID);
            Assert.AreEqual(true, firstKill.Attackers[0].FinalBlow);
            Assert.AreEqual(0, firstKill.Attackers[0].SecurityStatus);
            Assert.AreEqual("", firstKill.Attackers[0].AllianceName);

            Assert.AreEqual(150131146, secondKill.Attackers[1].CharacterID);
            Assert.AreEqual("Mark Player", secondKill.Attackers[1].CharacterName);
            Assert.AreEqual(150147571, secondKill.Attackers[1].CorporationID);
            Assert.AreEqual("Peanut Butter Jelly Time", secondKill.Attackers[1].CorporationName);
            Assert.AreEqual(150148475, secondKill.Attackers[1].AllianceID);
            Assert.AreEqual(0, secondKill.Attackers[1].DamageDone);
            Assert.AreEqual(24698, secondKill.Attackers[1].ShipTypeID);
            Assert.AreEqual(25715, secondKill.Attackers[1].WeaponTypeID);
            Assert.AreEqual(false, secondKill.Attackers[1].FinalBlow);
            Assert.AreEqual((float)0.3, secondKill.Attackers[1].SecurityStatus);
            Assert.AreEqual("Margaritaville", secondKill.Attackers[1].AllianceName);

            //Items
            Assert.AreEqual(0, firstKill.Items.Length);

            Assert.AreEqual(6, secondKill.Items.Length);
            Assert.AreEqual(3, secondKill.Items[1].ContainedItems.Length);
            Assert.AreEqual(3520, secondKill.Items[0].TypeID);
            Assert.AreEqual(InventoryFlagType.FlagNone, secondKill.Items[0].Flag);
            Assert.AreEqual(3, secondKill.Items[0].QtyDropped);
            Assert.AreEqual(1, secondKill.Items[0].QtyDestroyed);

            Assert.AreEqual(1236, secondKill.Items[1].ContainedItems[1].TypeID);
            Assert.AreEqual(InventoryFlagType.FlagNone, secondKill.Items[1].ContainedItems[1].Flag);
            Assert.AreEqual(2, secondKill.Items[1].ContainedItems[1].QtyDropped);
            Assert.AreEqual(1, secondKill.Items[1].ContainedItems[1].QtyDestroyed);
        }

        [Test]
        public void PersistKillLog()
        {
            ResponseCache.Clear();
            KillLog killLog = EveApi.GetKillLog(KillLogType.Character, 432435, 346, "apiKey");
            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            KillLog cachedKillLog = EveApi.GetKillLog(KillLogType.Character, 432435, 346, "apiKey");

            Assert.AreEqual(killLog.CachedUntilLocal, cachedKillLog.CachedUntilLocal);

            KillLog.Kill firstKill = getKill(63, killLog.Kills);
            KillLog.Kill cachedFirstKill = getKill(63, cachedKillLog.Kills);

            Assert.AreEqual(firstKill.Victim.CharacterID, cachedFirstKill.Victim.CharacterID);
        }

        private KillLog.Kill getKill(int killID, KillLog.Kill[] kills)
        {
            foreach (KillLog.Kill kill in kills)
            {
                if (kill.KillID == killID)
                    return kill;
            }
            return null;
        }

        private bool CompareItems(KillLog.Item item1, KillLog.Item item2)
        {
            if (item1.TypeID != item2.TypeID)
            {
                return false;
            }

            for (int i = 0; i < item1.ContainedItems.Length; i++)
            {
                if (CompareItems(item1.ContainedItems[i], item2.ContainedItems[i]) == false)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
