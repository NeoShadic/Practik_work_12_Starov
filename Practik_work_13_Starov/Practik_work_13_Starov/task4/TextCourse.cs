using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task4
{
    internal class TextCourse : Course
    {
        private int chapter; private int amount_text;

        public int Chapter { get { return chapter; } }
        public int AmountText { get { return amount_text; } }

        public void Check()
        {
            Console.WriteLine($"Текстовый имеет в общем объема текста - {amount_text} и глав - {chapter}");
        }
    }
}
