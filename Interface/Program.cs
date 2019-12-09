using System;
using System.Globalization;
using Interfaces.Entities;
using Interfaces.Services;

namespace Interfaces
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
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int installmentsNumber = int.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, totalValue);

            ContractService cs = new ContractService();
            cs.ProcessContract(contract, installmentsNumber);

            Console.WriteLine("Intallments:");

            foreach (Installment i in contract.Installments)
            {
                Console.WriteLine(i);
            }
        }
    }
}
