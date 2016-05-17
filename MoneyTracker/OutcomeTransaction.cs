using MoneyTracker.Properties;
using System;

namespace MoneyTracker
{
    public class OutcomeTransaction : Transaction
    {
        public OutcomeTransaction(float amount, string category, DateTime date, string note) : base(amount, category, date, note) { }

        public override float Amount
        {
            get { return base.Amount; }
            set { base.Amount = -value; }
        }
    }
}
