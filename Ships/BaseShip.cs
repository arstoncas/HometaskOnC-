using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProgram
{
    public class BaseShip
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public void whatsonlist()
        {
            Console.WriteLine("Наблюдаем: " + Type + "; под названием: " + Name +"; ");
        }
        public void Shoot()
        {
            Console.WriteLine("Залп!");
        }
    }
    class Fregate : BaseShip
    {
        public void ShootEffects()
        {
            Console.WriteLine("Так как корабль деревянный, он загорелся");
        }
    }
    class Caravelle : Fregate
    {
    
    }
    class Steamship : BaseShip
    {
        public void ShootEffects()
        {
            Console.WriteLine("Ошибочка: стрелять нечем, орудий нет.");
        }
    }
}