using System;
using System.Collections.Generic;
using System.Text;

namespace libeveapi.ResponseObjects
{
    class AccountBalance
    {
    }

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
}
