using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            int x = int.Parse(inp);
            int i = 0;
            int j = 0;
            int m = 0;
            int n = 0;
            Random rand = new Random();

            List<List<int>> matrix1 = new List<List<int>>();
            for (i = 0; i < x; i++)
            {
                List<int> t = new List<int>();
                for (j = 0; j < x; j++)
                {
                    t.Add(rand.Next(1, 25));
                }
            }

            List<List<int>> matrix2 = new List<List<int>>();
            for (m = 0; m < x; m++)
            {
                List<int> t2 = new List<int>();
                for (n = 0; n < x; n++)
                {
                    t2.Add(rand.Next(1, 25));
                }
            }
            Console.WriteLine("Первая матрица:");
            PrintValue(matrix1);
        }
        private static void PrintValue(List<List<int>> matrix1)
        {
            foreach (var z in matrix1)
                Console.WriteLine(z.Aggregate("", (e, q) => e + " " + q));
        }
    }
}

