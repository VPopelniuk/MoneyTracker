using MoneyTracker;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MoneyTracker
{
    public partial class Form1 : Form
    {
        private float _enteredAmount = 0;
        private string _enteredCategory = "";
        private DateTime _enteredDate;
        private string _enteredNote = "";

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
                    _enteredAmount = float.Parse(textBox1.Text);
                }
            }
            catch (Exception) { }
        }

        private void addAmount_Click(object sender, EventArgs e)
        {
            OutcomeTransaction transaction = new OutcomeTransaction(_enteredAmount, _enteredCategory, _enteredDate, _enteredNote);
            List<AccountsHistory> history = AccountsHistory.AddTransactionToAccountsHistory("accountName", transaction);
            Repository.SaveTransactionToFile(transaction);
            Repository.SaveAccountHistoryToFile(history);
            textBox1.Clear();
            textBox1.Select();
        }

        private void showTransactions_Click(object sender, EventArgs e)
        {
            List<Transaction> items = Repository.GetAllTransactionsFromFile();
            foreach (Transaction item in items)
            {
                output.AppendText(item.ToString() + Environment.NewLine);
            }
        }

        private void category_TextChanged(object sender, EventArgs e)
        {
            _enteredCategory = category_TextBox.Text;
        }

        private void note_TextChanged(object sender, EventArgs e)
        {
            _enteredNote = note_TextBox.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            _enteredDate = DateTime.Parse(dateTimePicker1.Text);
        }
    }
}
