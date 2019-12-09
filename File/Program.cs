using System;
using System.IO;
using System.Globalization;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Desktop\file";

            try
            {
                Directory.CreateDirectory(path + @"\out");

                using (StreamReader sr = File.OpenText(path + @"\summary.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] dados = sr.ReadLine().Split(',');

                        using (StreamWriter sw = File.AppendText(path + @"\out\summary.csv"))
                        {
                            double valor = double.Parse(dados[1], CultureInfo.InvariantCulture);
                            int qnt = int.Parse(dados[2]);
                            double total = valor * qnt;

                            string line = dados[0] + "," + total.ToString("F2", CultureInfo.InvariantCulture);
                            sw.WriteLine(line);
                        }
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
