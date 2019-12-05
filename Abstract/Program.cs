using System;
using System.Globalization;
using System.Collections.Generic;
using Abstract.Entities;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> payers = new List<Payer>();
            
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or campany (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    payers.Add(new IndividualPayer(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of emplyees: ");
                    int numberEmployees = int.Parse(Console.ReadLine());

                    payers.Add(new CompanyPayer(name, anualIncome, numberEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            foreach (Payer p in payers)
            {
                Console.WriteLine(p.Name + ": $ " + p.TaxCalc().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();

            double sum = 0;

            foreach (Payer p in payers)
            {
                sum += p.TaxCalc();
            }

            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
