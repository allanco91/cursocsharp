using System;
using System.Globalization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExLINQ.Entities;

namespace ExLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] employee = sr.ReadLine().Split(',');
                    string name = employee[0];
                    string email = employee[1];
                    double salary = double.Parse(employee[2], CultureInfo.InvariantCulture);

                    employees.Add(new Employee(name, email, salary));
                }
            }

            Console.Write("Enter salary: ");
            double salaryFilter = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Email of people whose salary is more than " 
                + salaryFilter.ToString("F2", CultureInfo.InvariantCulture));

            var emails = employees.Where(e => e.Salary > salaryFilter)
                .OrderBy(e => e.Name)
                .Select(e => e.Email);
            
            foreach (var email in emails)
            {
                Console.WriteLine(email);
            }
            
            var sumSalary = employees.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);
            Console.WriteLine("Sum of salary of people whose name starts with 'M': " 
                + sumSalary.ToString("F2", CultureInfo.InvariantCulture));

            
        }
    }
}
