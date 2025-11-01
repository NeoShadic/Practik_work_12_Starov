using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task2
{
    internal class SavingAccount : BankAccount
    {
        private string name_count; private int percent;

        public string NameCount {  get { return name_count; } }
        public int Percent { get { return percent; } }

        public void Save()
        {
            Console.WriteLine($"Ваши деньги переводятся на вас накопительный счет {name_count} с {percent} процентом");
        }
    }
}
