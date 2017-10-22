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
            Fregate Nevskiy = new Fregate();
            Nevskiy.Type = "Фрегат";
            Nevskiy.Name = "Александр Невский";
            Nevskiy.whatsonlist();
            Nevskiy.Shoot();
            Nevskiy.ShootEffects();
            Console.WriteLine();


            Caravelle Saint = new Caravelle();
            Saint.Type = "Каравелла";
            Saint.Name = "Святой Христофор";
            Saint.whatsonlist();
            Saint.Shoot();
            Saint.ShootEffects();
            Console.WriteLine();


            Steamship Titanic = new Steamship();
            Titanic.Type = "Пароход";
            Titanic.Name = "Титаник";
            Titanic.whatsonlist();
            Titanic.Shoot();
            Titanic.ShootEffects();

            Console.ReadKey();
        }
    }

}