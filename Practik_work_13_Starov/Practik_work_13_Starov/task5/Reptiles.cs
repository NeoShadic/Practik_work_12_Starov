using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task5
{
    internal class Reptiles : Animals
    {
        private bool ability_to_swim; private string color_squama;

        public bool AbilSwin {  get { return ability_to_swim; } }
        public string ColorSquama { get { return color_squama; } }

        public void Rest()
        {
            if(ability_to_swim = true)
            {
                Console.WriteLine($"{color_squama} рептилия по имени {Name} отдыхает в воде");
            }
            else
            {
                Console.WriteLine($"{color_squama} рептилия по имени {Name} отдыхает на суше");
            }
        }
    }
}
