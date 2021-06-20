using System;

namespace CompanyPaymentEx.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
