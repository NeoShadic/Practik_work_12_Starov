using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task3
{
    internal class Book : LibraryItem
    {
        private int amount_pages; private int isbn;

        public int Amountpages {  get { return amount_pages; } }
        public int ISBN {  get { return isbn; } }

        public void CheckBook()
        {
            Console.WriteLine($"Книга с МСКН {ISBN} имеет {amount_pages} страниц"); // МСКН - «международный стандартный книжный номер»
        }
    }
}
