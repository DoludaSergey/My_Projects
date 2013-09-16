using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FinansManager
{
    class MoneyEntry
    {
        private double _amount;
        //DateTime EntryDate;

        public MoneyEntry()
        {
            _amount = 0;
            EntryDate = DateTime.Now;
        }

        public MoneyEntry(double amount, DateTime date)
        {
            _amount = amount;
            EntryDate = date;
        }

        public void InitWithString(string amount, string date)
        {
            Double.TryParse(amount, out _amount);

            DateTime dt;
            DateTime.TryParse(date, out dt);
            EntryDate = dt;
        }

        public override string ToString()
        {
            return string.Format ("{0} от  {1}",_amount, EntryDate.Date );
        }

        public bool IsDebit
        {
            get { return (_amount > 0); }
        }

        public double Amount 
        {
            set { _amount = value; }
            get {  return _amount; }
        }

        public DateTime EntryDate { set; get; }

        public string Description { set; get; }

        public string Category { set; get; }
    }
}
