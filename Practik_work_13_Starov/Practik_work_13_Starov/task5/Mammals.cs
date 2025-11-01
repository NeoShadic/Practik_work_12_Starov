using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task5
{
    internal class Mammals : Animals
    {
        private string _class; private int legs;

        public string Class {  get { return _class; } }
        public int Legs { get { return legs; } }

        public void Walk()
        {
            Console.WriteLine($"{_class} по имени {Name} ходит на {legs} лапах");
        }
    }
}
