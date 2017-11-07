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
            Maria.NotType = "Линкор";
            Maria.NotName = "Императрица Мария";
            Maria.Whatsonlist();
            string toPrint = Maria.Shoot();
            Console.WriteLine(toPrint);
            Console.WriteLine();


            Caravelle Saint = new Caravelle();
            Saint.NotType = "Каравелла";
            Saint.NotName = "Святой Христофор";
            Saint.Whatsonlist();
            string toPrint2 = Saint.Shoot();
            Console.WriteLine(toPrint2);
            Console.WriteLine();


            Steamship Titanic = new Steamship();
            Titanic.NotType = "Пароход";
            Titanic.NotName = "Титаник";
            Titanic.Whatsonlist();
            string toPrint3 = Titanic.Shoot();
            Console.WriteLine(toPrint3);

            Console.ReadKey();
        }
    }

}
