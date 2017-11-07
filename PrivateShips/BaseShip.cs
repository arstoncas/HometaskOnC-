using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProgram
{
    public class BaseShip
    {
        /*public string Type { get; set; } // прошлое дз
        public string Name { get; set; }
        public void Whatsonlist() 

        {
            Console.WriteLine("Наблюдаем: " + Type + "; под названием: " + Name + "; " );
        }
        */

        private string _SecretType;
        private string _SecretName;


        public string NotType
        {
            get
            {
                return _SecretType;
            }
            set
            {
                _SecretType = value;
            }
        }

        public string NotName
        {
            get
            {
                return _SecretName;
            }
            set
            {
                _SecretName = value;
            }
        }

        public void Whatsonlist()

        {
            Console.WriteLine("Наблюдаем: " + _SecretType + "; под названием: " + _SecretName + "; ");
        }

        public virtual string Shoot()
        {
            
            string res = "Залп!.. Враг подбит!"  ;
            return res;
        }

    }



    class Battleship : BaseShip
    {
        
    }


    class Caravelle : BaseShip
    {
        public override string Shoot()
        {
            string res = "Залп!.. Так как корабль деревянный, он загорелся";
            return res;
        }
    }



    class Steamship : BaseShip
    {
        public override string Shoot()
        {
            string res = "За.. А, нет, ошибочка: стрелять нечем, орудий нет.";
            return res;
        }
    }
}