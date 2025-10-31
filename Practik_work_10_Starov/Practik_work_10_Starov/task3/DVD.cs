using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task3
{
    internal class DVD : LibraryItem
    {
        private string time; private double rating;

        public string Time {  get { return time; } }
        public double Rating { get { return rating; } }

        public void i_DVD() // информация о DVD
        {
            Console.WriteLine($"данное видео с продолжительностью {time} имеет рейтинг - {rating}");
        }
    }
}
