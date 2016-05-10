using System;
using System.Collections.Generic;

namespace MoneyTracker
{
    public class AccountsHistory
    {
        private string _name;
        private string _transactionId;
        public static List<AccountsHistory> history;
        private List<string> _accounts;

        public AccountsHistory(string name)
        {
            _accounts = new List<string>();
            foreach (string item in _accounts)
            {
                if (item == name)
                {
                    throw new ArgumentException("Account with this name already exist!");
                }
                else
                {
                    Name = name;
                    _accounts.Add(Name);
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                else
                {
                    _name = value;
                }
            }
        }

        public string TransactionId
        {
            get { return _transactionId; }
            set { _transactionId = value; }
        }

        public static List<AccountsHistory> AddTransactionToAccountsHistory(string accountName, Transaction transaction)
        {
            history = new List<AccountsHistory>();
            AccountsHistory accountEvent = new AccountsHistory(accountName);
            accountEvent.Name = accountName;
            accountEvent.TransactionId = transaction.Id;
            history.Add(accountEvent);

            return history;
        }
    }
}
