using CompanyPaymentEx.Entities;
using CompanyPaymentEx.Services;
using System;
using System.Globalization;

namespace CompanyPaymentEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int nInstallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, contractValue);

            for(int i = 1; i <= nInstallments; i++)
            {
                Installment installment = new Installment(date, i);
                contract.AddInstallment(installment);
            }

        }
    }
}
