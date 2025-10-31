using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task1
{
    internal class Director : Employee
    {
        private string dept;

        public string Dept { get { return dept; } }

        public void Budget()
        {
            Console.WriteLine($"Данный директор удтверждает бюджет в отделе {dept}");
        }
    }
}
