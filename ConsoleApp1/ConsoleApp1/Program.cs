using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> stock = Gen(5000);
            stock.ForEach(product => Console.Write($"{product}; "));
            Console.WriteLine($"\n{stock.Count}");

            WriteToFile("export.csv",stock);

            List<string> stock2 = ReadFile("export.csv");
            stock2.ForEach(product => Console.Write($"{product}; "));
            Console.WriteLine($"\n{stock2.Count}");
        }
        static List<string> Gen(int n = 100)
        {
            string[] default_tuple = { "Tej 2,8%", "Fehér kenyér", "Trappista sajt", "Tejföl 20%", "Vaj 100g", "Kristálycukor", "Finomliszt", "Napraforgó étolaj", "Tojás (10 db)", "Csirkemell filé", "Sertéskaraj", "Alma", "Banán", "Burgonya", "Vöröshagyma", "Kefir", "Túró", "Szalámi", "Ásványvíz", "Őrölt kávé", "Spagetti tészta", "Rizs", "Paradicsompüré", "Kakaópor", "Méz" };
            Random rnd = new Random();
            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                list.Add(default_tuple[rnd.Next(default_tuple.Length)]);
            }

            return list;
        }

        static void WriteToFile(string filename, List<string> data)
        {
            File.WriteAllLines(filename, data, Encoding.UTF8);   
        }

        static List<string> ReadFile(string filename)
        {
            if (File.Exists(filename))
            {
                return File.ReadAllLines(filename).ToList();
            }
            return null;
        }
    }
}
