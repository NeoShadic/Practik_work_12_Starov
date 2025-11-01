using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task4
{
    internal class VideoCourse : Course
    {
        private int amount; private int length_course;

        public int Amount { get { return amount; } }
        public int LengthCourse { get { return length_course; } }

        public void Check()
        {
            Console.WriteLine($"Весь видео курс длиться {length_course}, его кол-во видео - {amount}");
        }
    }
}
