using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task1
{
    internal class Manager : Employee
    {
        private int size_command;

        public int SizeCommand { get { return size_command; } }

        public void Meeting()
        {
            Console.WriteLine($"Проводится собрание, кол-во людей - {size_command}");
        }
    }
}
