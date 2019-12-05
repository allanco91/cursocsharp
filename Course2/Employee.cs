using System;
using System.Collections.Generic;
using System.Text;

namespace Course2
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            IncreaseSalary(salary, 0.0);
        }

        public void IncreaseSalary(double salary, double percent)
        {
            Salary = salary + salary * percent / 100;
        }
    }
}
