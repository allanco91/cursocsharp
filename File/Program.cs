using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using Files.Entities;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Desktop\file";

            try
            {
                List<Product> products = new List<Product>();
                Directory.CreateDirectory(path + @"\out");

                using (StreamReader sr = File.OpenText(path + @"\summary.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] dados = sr.ReadLine().Split(',');

                        string name = dados[0];
                        double price = double.Parse(dados[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(dados[2]);

                        products.Add(new Product(name, price, quantity));
                    }
                }

                using (StreamWriter sw = File.AppendText(path + @"\out\summary.csv"))
                {
                    foreach (Product p in products)
                    {
                        double total = p.Price * p.Quantity;
                        sw.WriteLine(p.Name + "," + total.ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine($"An error ocurred: {e.Message}");
            }

        }
    }
}
