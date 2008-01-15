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

            Console.WriteLine("'" + journalEntry.JournalEntryItems[0].argName1 + "'");
            Assert.AreEqual("", journalEntry.JournalEntryItems[0].argName1);
            Assert.AreEqual(59149, journalEntry.JournalEntryItems[0].refID);
            Assert.AreEqual("corpslave", journalEntry.JournalEntryItems[0].ownerName1);
            Assert.AreEqual("", journalEntry.JournalEntryItems[0].reason);
        }

        [Test]
        public void GetCorpJournalEntriesTest()
        {
            JournalEntries journalEntry = EveApi.GetJournalEntryList(JournalEntryType.Corporation, "userId", "charId", "apiKey");

            Console.WriteLine("'" + journalEntry.JournalEntryItems[0].argName1 + "'");
            Assert.AreEqual("", journalEntry.JournalEntryItems[0].argName1);
            Assert.AreEqual(59149, journalEntry.JournalEntryItems[0].refID);
            Assert.AreEqual("corpslave", journalEntry.JournalEntryItems[0].ownerName1);
            Assert.AreEqual("", journalEntry.JournalEntryItems[0].reason);
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
                Assert.AreEqual(journalEntry.JournalEntryItems[i].date, cachedJournalEntry.JournalEntryItems[i].date);
                Assert.AreEqual(journalEntry.JournalEntryItems[i].amount, cachedJournalEntry.JournalEntryItems[i].amount);
                Assert.AreEqual(journalEntry.JournalEntryItems[i].balance, cachedJournalEntry.JournalEntryItems[i].balance);
            }
             
        }
    }
}

