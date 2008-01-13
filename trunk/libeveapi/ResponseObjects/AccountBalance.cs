using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace libeveapi
{
    /// <summary>
    /// Represents a character or corporation AccountBalance response from the eve api
    /// http://wiki.eve-dev.net/APIv2_Char_AccountBalance_XML
    /// http://wiki.eve-dev.net/APIv2_Corp_AccountBalance_XML
    /// </summary>
    public class AccountBalance : ApiResponse
    {
        /// <summary>
        /// The accounts associated with this character or corporation
        /// </summary>
        public Account[] Accounts = new Account[0];

        /// <summary>
        /// Create an AccountBalance object by parsing an XmlDocument response from the eve api
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static AccountBalance FromXmlDocument(XmlDocument xmlDoc)
        {
            AccountBalance accountBalance = new AccountBalance();
            accountBalance.ParseCommonElements(xmlDoc);

            List<Account> accountList = new List<Account>();
            foreach (XmlNode accountRow in xmlDoc.SelectNodes("//rowset[@name='accounts']/row"))
            {
                Account account = new Account();
                account.AccountId = accountRow.Attributes["accountID"].InnerText;
                account.AccountKey = accountRow.Attributes["accountKey"].InnerText;
                account.Balance = Convert.ToDouble(accountRow.Attributes["balance"].InnerText);
                accountList.Add(account);
            }
            accountBalance.Accounts = accountList.ToArray();

            return accountBalance;
        }
    }

    /// <summary>
    /// An account associated with a character or corporation
    /// </summary>
    public class Account
    {
        /// <summary>
        /// ID number of the account
        /// </summary>
        public string AccountId;

        /// <summary>
        /// Account Identifier
        /// For character: always 1000
        /// For corporation: the corp wallet division
        /// </summary>
        public string AccountKey;

        /// <summary>
        /// Amount of isk in the account
        /// </summary>
        public double Balance;
    }

    /// <summary>
    /// The api allows retrieving the account balances for a character or a corporation
    /// </summary>
    public enum AccountBalanceType
    {
        Character,
        Corporation
    }
}
