using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTracker
{
    public class Repository
    {
        public static string[] GetAllTransactionsFromFile()
        {
            string[] transactionsFromFile = File.ReadAllLines("Data/Transactions.json");
            return transactionsFromFile;
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
