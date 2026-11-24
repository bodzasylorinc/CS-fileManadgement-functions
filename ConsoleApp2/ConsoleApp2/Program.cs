using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static List<int> Gen(int n=1000,int from=0,int to=1000)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++) list.Add(rnd.Next(from,to));
            return list;
        }

        static void Export(string file_name,List<int> list)
        {
            File.WriteAllLines(file_name, list.;
        }
    }
}
