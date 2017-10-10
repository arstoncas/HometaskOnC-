using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProgram
{
    class Worker
    {
        public int FindSum(int number)
        {
            int result;
            result = (number + number);
            return result;
        }


        public int FindMult(int first, int second)
        {
            int result;
            result = (first * first) * (second * second);
            return result;

        }



        public string FactAndFib(int first, int second)
        {
            string result;
            string fib = "text";
            string fact;

            int factor = 1;
            if (first < 0)
            {
                fact ="Отрицательное число => не существует";
                
            }
            else
            {
                for (int i = 2; i <= first; i++)
                {
                    factor = factor * i;
                }
                fact = factor.ToString();
            }


            int fibonacci = 0;
            
            if (second < 0)
            {
                fib = "Отрицательное число => не существует";
            }
            else
            {
                if (second == 1)
                {
                    fibonacci = 0;
                }
                else
                {
                    List<int> m = new List<int>();
                    m.Add(0);
                    m.Add(1);
                    for (int i = 2; i < second; i++)
                    {
                        m.Add(m[i - 1] + m[i - 2]);
                        fibonacci = m[i];
                    }
                    fib = fibonacci.ToString();
                }
            }

            result = fact + " и " + fib;
            return result;

        }
    }
}