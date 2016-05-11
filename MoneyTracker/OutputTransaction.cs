using System;

namespace MoneyTracker
{
    public class OutputTransaction : Transaction
    {
        public OutputTransaction(float amount, string category, DateTime date, string note) : base(amount, category, date, note) { }
    }
}
