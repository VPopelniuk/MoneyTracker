using System;

namespace MoneyTracker
{
    public abstract class Transaction
    {
        private string _id;
        private float _amount;
        private DateTime _date;
        private string _category;
        private string _note;

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

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

        public Transaction()
        {
            Id = GenerateID();
            _amount = 0f;
        }

        public Transaction(float amount, string category, DateTime date, string note)
        {
            Id = GenerateID();
            Amount = amount;
            Category = category;
            Date = date;
            Note = note;
        }

        protected static string GenerateID()
        {
            return Guid.NewGuid().ToString("N");
        }
    }
}
