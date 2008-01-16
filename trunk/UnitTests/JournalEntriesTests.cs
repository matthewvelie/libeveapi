using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;
using libeveapi;

namespace UnitTests
{
    [TestFixture]
    public class JournalEntriesTests
    {
        [SetUp]
        public void Setup()
        {
            Utility.UseLocalUrls();
        }

        [Test]
        public void GetCharJournalEntriesTest()
        {
            JournalEntries journalEntry = EveApi.GetJournalEntryList(JournalEntryType.Character, "userId", "charId", "apiKey");

            Console.WriteLine("'" + journalEntry.JournalEntryItems[0].ArgName1 + "'");
            Assert.AreEqual("", journalEntry.JournalEntryItems[0].ArgName1);
            Assert.AreEqual(59149, journalEntry.JournalEntryItems[0].RefID);
            Assert.AreEqual("corpslave", journalEntry.JournalEntryItems[0].OwnerName1);
            Assert.AreEqual("", journalEntry.JournalEntryItems[0].Reason);
        }

        [Test]
        public void GetCorpJournalEntriesTest()
        {
            JournalEntries journalEntry = EveApi.GetJournalEntryList(JournalEntryType.Corporation, "userId", "charId", "apiKey");

            Console.WriteLine("'" + journalEntry.JournalEntryItems[0].ArgName1 + "'");
            Assert.AreEqual("", journalEntry.JournalEntryItems[0].ArgName1);
            Assert.AreEqual(59149, journalEntry.JournalEntryItems[0].RefID);
            Assert.AreEqual("corpslave", journalEntry.JournalEntryItems[0].OwnerName1);
            Assert.AreEqual("", journalEntry.JournalEntryItems[0].Reason);
        }

        [Test]
        public void JournalEntriesPersist()
        {
            ResponseCache.Clear();

            JournalEntries journalEntry = EveApi.GetJournalEntryList(JournalEntryType.Corporation, "userId", "charId", "apiKey");
            ResponseCache.Save("ResponseCache.xml");
            ResponseCache.Clear();
            ResponseCache.Load("ResponseCache.xml");
            JournalEntries cachedJournalEntry = EveApi.GetJournalEntryList(JournalEntryType.Corporation, "userId", "charId", "apiKey");

            Assert.AreEqual(journalEntry.CachedUntilLocal, cachedJournalEntry.CachedUntilLocal);


            for (int i = 0; i < journalEntry.JournalEntryItems.Length; i++)
            {
                Assert.AreEqual(journalEntry.JournalEntryItems[i].Date, cachedJournalEntry.JournalEntryItems[i].Date);
                Assert.AreEqual(journalEntry.JournalEntryItems[i].Amount, cachedJournalEntry.JournalEntryItems[i].Amount);
                Assert.AreEqual(journalEntry.JournalEntryItems[i].Balance, cachedJournalEntry.JournalEntryItems[i].Balance);
            }
             
        }
    }
}

