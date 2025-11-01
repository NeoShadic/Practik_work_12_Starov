using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task2
{
    internal class CheckingAccount : BankAccount
    {
        private int limite;

        public int Limite {  get { return limite; } }

        public void Check()
        {
            Console.WriteLine($"Ваш лимит овердтафта - {limite}");
        }
    }
}
