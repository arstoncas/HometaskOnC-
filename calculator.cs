using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
         string str = Console.ReadLine();
         string[] arr = str.Split('+');
         if(arr.Length == 2) 
             {
             int _numbOne;
             bool resultFirst = Int32.TryParse(arr[0], out _numbOne);
             int _numbTwo;
             bool resultSecond = Int32.TryParse(arr[1], out _numbTwo);
             
             if (resultFirst&&resultSecond) 
                 {
                 Console.WriteLine("Сумма элементов: " + _numbOne + " + " + _numbTwo + " = " + (_numbOne + _numbTwo));
                 }
             else 
                 {
                 Console.WriteLine("Что-то с преобразованием, одно из двух неверно: ");
                 Console.WriteLine("Первое: " + _numbOne);
                 Console.WriteLine("Второе: " + _numbTwo);
                 }
             }
       }   
    }
}
