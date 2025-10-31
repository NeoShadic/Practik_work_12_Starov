using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task3
{
    internal class Audiobook
    {
        private string time; private string speaker;

        public string Time {  get { return time; } }
        public string Speaker { get { return speaker; } }

        public void I_Audio()
        {
            Console.WriteLine($"Аудиокнига был озвучен {speaker}, имеет длительность {time}");
        }
    }
}
