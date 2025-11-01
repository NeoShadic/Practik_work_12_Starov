using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task2
{
    internal class CreditAccount : BankAccount
    {
        private double limite; private string data;

        public double Limite { get { return limite; } }
        public string Data { get { return data; } }

        public void Credit()
        {
            Console.WriteLine($"Ваш лимит на кредит - {limite}, срок для его погашения - {data}");
        }
    }
}
