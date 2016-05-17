using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTracker
{
    class IncomeTransaction : Transaction
    {
       public IncomeTransaction(float amount, string category, DateTime date, string note) : base (amount, category, date, note) { }
    }
}
