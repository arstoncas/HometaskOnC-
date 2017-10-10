using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var str = input.Split(',', ' ');
            Point point = new Point();
            point.X = Convert.ToInt32(str[0]);
            point.Y = Convert.ToInt32(str[1]);

            int result;
            Worker worker = new Worker();
            result = worker.FindSum(point.X) + worker.FindSum(point.Y);
            Console.WriteLine("Сумма:" + result);


            result = worker.FindMult(point.X, point.Y);
            Console.WriteLine("Произведение:" + result);

            string result1;
            result1 = worker.FactAndFib(point.X, point.Y);
            Console.WriteLine("Факториал x и последнее число Фибоначчи для y: " + result1);
            Console.ReadKey();


        }
    }

}
