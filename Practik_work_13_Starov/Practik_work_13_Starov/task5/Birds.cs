using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task5
{
    internal class Birds : Animals
    {
        private int size_wings; private int flight_height;

        public int SizeWings { get { return size_wings; } }
        public int FlightHeight {  get { return flight_height; } }

        public void Fly()
        {
            Console.WriteLine($"Птица по имени {Name} махая {size_wings}-метровыми крыльями на высоте {flight_height} метров");
        }
    }
}
