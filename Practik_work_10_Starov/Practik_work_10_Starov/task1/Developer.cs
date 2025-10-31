using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task1
{
    internal class Developer : Employee
    {
        private string lang_program;

        public string LangProgram {  get { return lang_program; } }

        public void WriteCode()
        {
            Console.WriteLine($"Данный программист пишет код на языке {lang_program}");
        }
    }
}
