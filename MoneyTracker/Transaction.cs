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

        public virtual float Amount { get; set; }

        public DateTime Date
        {
            get { return _date; }
            set
            {
                if (value != DateTime.MinValue)
                {
                    _date = value;
                }
                else
                {
                    _date = DateTime.Today;
                }
            }
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

        public override string ToString()
        {
            return string.Format("Id: {0}; Date: {1}; Amount: {2}; Category: {3}; Note: {4}", Id, Date, Amount, Category, Note);
        }
    }
}
