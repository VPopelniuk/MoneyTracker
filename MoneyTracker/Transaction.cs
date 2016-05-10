using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyTracker
{
    public abstract class Transaction
    {
        private string _id;
        private float _amount;

        public string Id { get; set; }

        public float Amount
        {
            get { return _amount; }
            set
            {
                if (value > 0)
                {
                    _amount = value;
                }
                else
                {
                    throw new ArgumentException("Amount should be more than zero!");
                }
            }
        }

        public Transaction()
        {
            Id = GenerateID();
            _amount = 0f;
        }

        public Transaction(float amount)
        {
            Id = GenerateID();
            Amount = amount;
        }

        protected static string GenerateID()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
