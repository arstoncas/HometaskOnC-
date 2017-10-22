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
            Battleship Maria = new Battleship();
            Maria.Type = "Линкор";
            Maria.Name = "Императрица Мария";
            Maria.Whatsonlist();
            string toPrint = Maria.Shoot();
            Console.WriteLine(toPrint);
            Console.WriteLine();


            Caravelle Saint = new Caravelle();
            Saint.Type = "Каравелла";
            Saint.Name = "Святой Христофор";
            Saint.Whatsonlist();
            string toPrint2 = Saint.Shoot();
            Console.WriteLine(toPrint2);
            Console.WriteLine();


            Steamship Titanic = new Steamship();
            Titanic.Type = "Пароход";
            Titanic.Name = "Титаник";
            Titanic.Whatsonlist();
            string toPrint3 = Titanic.Shoot();
            Console.WriteLine(toPrint3);

            Console.ReadKey();
        }
    }

}
