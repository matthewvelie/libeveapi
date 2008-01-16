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
        public AccountBalanceItem[] AccountBalanceItems = new AccountBalanceItem[0];

        /// <summary>
        /// Create an AccountBalance object by parsing an XmlDocument response from the eve api
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static AccountBalance FromXmlDocument(XmlDocument xmlDoc)
        {
            AccountBalance accountBalance = new AccountBalance();
            accountBalance.ParseCommonElements(xmlDoc);

            List<AccountBalanceItem> accountList = new List<AccountBalanceItem>();
            foreach (XmlNode accountRow in xmlDoc.SelectNodes("//rowset[@name='accounts']/row"))
            {
                AccountBalanceItem account = new AccountBalanceItem();
                account.AccountId = Convert.ToInt32(accountRow.Attributes["accountID"].InnerText);
                account.AccountKey = Convert.ToInt32(accountRow.Attributes["accountKey"].InnerText);
                account.Balance = Convert.ToDouble(accountRow.Attributes["balance"].InnerText);
                accountList.Add(account);
            }
            accountBalance.AccountBalanceItems = accountList.ToArray();

            return accountBalance;
        }

        /// <summary>
        /// An account associated with a character or corporation
        /// </summary>
        public class AccountBalanceItem
        {
            /// <summary>
            /// ID number of the account
            /// </summary>
            public int AccountId;

            /// <summary>
            /// Account Identifier
            /// For character: always 1000
            /// For corporation: the corp wallet division
            /// </summary>
            public int AccountKey;

            /// <summary>
            /// Amount of isk in the account
            /// </summary>
            public double Balance;
        }
    }

    /// <summary>
    /// The api allows retrieving the account balances for a character or a corporation
    /// </summary>
    public enum AccountBalanceType
    {
        /// <summary>
        /// A character account
        /// </summary>
        Character,
        /// <summary>
        /// A corporation account
        /// </summary>
        Corporation
    }
}
