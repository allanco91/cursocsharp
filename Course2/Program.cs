using System;
using System.Globalization;
using System.Collections.Generic;


namespace Course2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercicio encapsulamento
            //ContaBancaria cb;
            //double depositoSaque;

            //Console.Write("Entre o número da conta: ");
            //int conta = int.Parse(Console.ReadLine());
            //Console.Write("Entre o titular da conta: ");
            //string titular = Console.ReadLine();
            //Console.Write("Haverá depósito inicial (s/n)? ");
            //bool depInicial = Console.ReadLine().ToLower() == "s";

            //if (depInicial)
            //{
            //    Console.Write("Entre o valor de depósito inicial: ");
            //    depositoSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    cb = new ContaBancaria(conta, titular, depositoSaque);
            //}
            //else
            //{
            //    cb = new ContaBancaria(conta, titular);
            //}

            //Console.WriteLine("Dados da conta:");
            //Console.WriteLine(cb);
            //Console.WriteLine();

            //Console.Write("Entre um valor para depósito: ");
            //depositoSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //cb.Depositar(depositoSaque);

            //Console.WriteLine("Dados da conta atualizados:");
            //Console.WriteLine(cb);
            //Console.WriteLine();

            //Console.Write("Entre um valor para saque: ");
            //depositoSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //cb.Sacar(depositoSaque);

            //Console.WriteLine("Dados da conta atualizados:");
            //Console.WriteLine(cb);
            #endregion

            #region Exercicio Vetor
            //Room[] rooms = new Room[10];

            //Console.Write("How many rooms will be rented? ");
            //int N = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 1; i <= N; i++)
            //{
            //    Console.WriteLine($"Rent #{i}");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Email: ");
            //    string email = Console.ReadLine();
            //    Console.Write("Room: ");
            //    int room = int.Parse(Console.ReadLine());

            //    rooms[room] = new Room { Name = name, Email = email };
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Busy rooms:");

            //for (int i = 0; i < rooms.Length; i++)
            //{
            //    if (rooms[i] != null)
            //        Console.WriteLine($"{i}: {rooms[i].Name}, {rooms[i].Email}");
            //}

            #endregion

            #region Exercicio Lista
            //List<Employee> employees = new List<Employee>();

            //Console.Write("How many employees will be registered? ");
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= N; i++)
            //{
            //    Console.WriteLine($"Employee #{i}:");
            //    Console.Write("Id: ");
            //    int id = int.Parse(Console.ReadLine());
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Salary: ");
            //    double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    Console.WriteLine();

            //    employees.Add(new Employee(id, name, salary));
            //}

            //Console.Write("Enter the employee id that will have salary increase: ");
            //int findId = int.Parse(Console.ReadLine());
            //Employee emp = employees.Find(e => e.Id == findId);

            //if (emp != null)
            //{
            //    Console.Write("Enter percentage: ");
            //    double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    emp.IncreaseSalary(emp.Salary, percent);
            //}
            //else
            //{
            //    Console.WriteLine("This id does not exist!");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Updated list of employees:");
            //foreach (Employee e in employees)
            //{
            //    Console.WriteLine($"{e.Id}, {e.Name}, {e.Salary.ToString("F2", CultureInfo.InvariantCulture)}");
            //}
            #endregion

            #region Exercicio de matriz
            //string[] vet = Console.ReadLine().Split(' ');
            //int M = int.Parse(vet[0]);
            //int N = int.Parse(vet[1]);

            //int[,] matriz = new int[M, N];

            //for (int i = 0; i < M;i++)
            //{
            //    string[] row = Console.ReadLine().Split(' ');

            //    for (int j = 0; j < N;j++)
            //    {
            //        matriz[i, j] = int.Parse(row[j]);
            //    }
            //}

            //int num = int.Parse(Console.ReadLine());

            //for (int i = 0; i < M; i++)
            //{
            //    for (int j = 0; j < N; j++)
            //    {
            //        if (matriz[i,j] == num)
            //        {
            //            Console.WriteLine($"Position {i},{j}:");
            //            if (j - 1 >= 0) Console.WriteLine($"Left: {matriz[i, j - 1]}");
            //            if (j + 1 < N) Console.WriteLine($"Right: {matriz[i, j + 1]}");
            //            if (i - 1 >= 0) Console.WriteLine($"Up: {matriz[i - 1, j]}");
            //            if (i + 1 < M) Console.WriteLine($"Down: {matriz[i + 1, j]}");
            //        }
            //    }
            //}
            #endregion

            #region Exercicio de conjuntos
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            Console.Write("O curso A possui quantos alunos? ");
            int qnt = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos para o curos A:");
            for (int i = 0; i < qnt; i++)
            {
                int id = int.Parse(Console.ReadLine());
                A.Add(id);
            }

            Console.Write("O curso B possui quantos alunos? ");
            qnt = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos para o curos B:");
            for (int i = 0; i < qnt; i++)
            {
                int id = int.Parse(Console.ReadLine());
                B.Add(id);
            }

            Console.Write("O curso C possui quantos alunos? ");            
            qnt = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos para o curos C:");
            for (int i = 0; i < qnt; i++)
            {
                int id = int.Parse(Console.ReadLine());
                C.Add(id);
            }

            A.UnionWith(B);
            A.UnionWith(C);

            Console.WriteLine($"Total de alunos: {A.Count}");
            #endregion
        }
    }
}