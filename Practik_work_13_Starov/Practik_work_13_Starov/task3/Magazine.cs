using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task3
{
    internal class Magazine : LibraryItem // журнал
    {
        private int num_release; private string time_work;

        public int Release {  get { return num_release; } }
        public string TimeWork { get { return time_work; } }

        public void Journal()
        {
            Console.WriteLine($"Журнал с {num_release} - номером выпуска действует {time_work}");
        }
    }
}
