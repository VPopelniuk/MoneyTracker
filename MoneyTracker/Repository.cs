using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MoneyTracker
{
    public class Repository
    {
        public static List<Transaction> GetAllTransactionsFromFile()
        {

            List<Transaction> transactions = new List<Transaction>();
            string[] transactionsFromFile = File.ReadAllLines("Data/Transactions.json");
            foreach (string item in transactionsFromFile)
            {
                IncomeTransaction transaction = JsonConvert.DeserializeObject<IncomeTransaction>(item);
                transactions.Add(transaction);
            }
            return transactions;
        }

        public static void SaveTransactionToFile(Transaction transaction)
        {
            string serializedTransaction = JsonConvert.SerializeObject(transaction);
            File.AppendAllText("Data/Transactions.json", serializedTransaction + Environment.NewLine);
        }

        public static void SaveAccountHistoryToFile(List<AccountsHistory> history)
        {
            foreach (AccountsHistory item in history)
            {
                if (history.Count != 0)
                {
                    string serializedAccountHistiry = JsonConvert.SerializeObject(item);
                    File.AppendAllText("Data/AccountsHistory.json", serializedAccountHistiry + Environment.NewLine);
                }
                else
                {
                    throw new ArgumentException("Nothing to add!");
                }
            }
        }
    }
}
