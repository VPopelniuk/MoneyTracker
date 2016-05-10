using MoneyTracker;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MoneyTracker
{
    public partial class Form1 : Form
    {
        private float enteredAmount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void amountInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    textBox1.Clear();
                }
                else
                {
                    enteredAmount = float.Parse(textBox1.Text);
                }
            }
            catch (Exception) { }
        }

        private void addAmount_Click(object sender, EventArgs e)
        {
            OutputTransaction transaction = new OutputTransaction(enteredAmount);
            List<AccountsHistory> history = AccountsHistory.AddTransactionToAccountsHistory("accountName", transaction);
            Repository.SaveTransactionToFile(transaction);
            Repository.SaveAccountHistoryToFile(history);
            textBox1.Clear();
            textBox1.Select();
        }

        private void output_TextChanged(object sender, EventArgs e)
        {

        }

        private void showTransactions_Click(object sender, EventArgs e)
        {
            string[] items = Repository.GetAllTransactionsFromFile();
            foreach (string item in items)
            {
                output.AppendText(item + Environment.NewLine);
            }

        }

    }
}
