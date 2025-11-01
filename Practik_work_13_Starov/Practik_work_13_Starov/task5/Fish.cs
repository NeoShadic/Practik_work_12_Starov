using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task5
{
    internal class Fish : Animals
    {
        private int size; private int speed_swin;

        public int Size {  get { return size; } }
        public int SpeedSwin { get { return speed_swin; } }

        public void Swin()
        {
            Console.WriteLine($"{size}-метровая рыба по имени {Name} плывет со скоростью {speed_swin} км/ч");
        }
    }
}
