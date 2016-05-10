using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTracker
{
    public class OutputTransaction : Transaction
    {
        public OutputTransaction(float amount) : base(amount) { }
    }
}
