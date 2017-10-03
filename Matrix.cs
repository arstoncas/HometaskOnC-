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
            Random rand = new Random();

            List<List<int>> matrix1 = new List<List<int>>();
            for (int i = 0; i < x; i++)
            {
                List<int> t = new List<int>();
                for (int j = 0; j < x; j++)
                {
                    t.Add(rand.Next(1, 4));
                }
                matrix1.Add(t);
            }

            List<List<int>> matrix2 = new List<List<int>>();
            for (int i = 0; i < x; i++)
            {
                List<int> t = new List<int>();
                for (int j = 0; j < x; j++)
                {
                    t.Add(rand.Next(1, 4));
                }
                matrix2.Add(t);
            }
            Console.WriteLine("Первая матрица:");
            PrintValue(matrix1);
            Console.WriteLine("Вторая матрица:");
            PrintValue(matrix2);
            List<List<int>> result = new List<List<int>>();
            for (int i = 0; i < x; i++)
            {
                List<int> t = new List<int>();
                for (int j = 0; j < x; j++)
                {
                    t.Add(0);
                }
                result.Add(t);
            }
            for (int i = 0; i < x; i++) 
            {
                for (int j = 0; j < x; j++) 
                {
                    {
                    for (int k = 0; k < x; k++)
                        {
                        result[i][j] = result[i][j] + (matrix1[i][k] * matrix2[k][j]); // killmeplease
                        }
                    }       
                }
            }
            Console.WriteLine("Результат");
            PrintValue(result);
            Console.ReadKey();
        }
        private static void PrintValue(List<List<int>> matrix1)
        {
            foreach (var z in matrix1)
                Console.WriteLine(z.Aggregate("", (e, q) => e + " " + q));
        }
    }
}
