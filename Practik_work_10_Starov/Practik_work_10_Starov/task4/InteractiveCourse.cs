using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_10_Starov.task4
{
    internal class InteractiveCourse : Course
    {
        private int amount_exercises; private int completed_exercises; 


        public int AmountExercises { get { return amount_exercises; } }
        public int CompletedExercises { get { return completed_exercises; } } 

        public void SystemChecks()
        {
            if(completed_exercises <= amount_exercises && completed_exercises > amount_exercises - 5) //диапозон ошибок
            {
                Console.WriteLine($"Вы справились - {completed_exercises} из{amount_exercises}!");
            }
            Console.WriteLine($"Вы не справились, у вас больше 5 ошибок! ({completed_exercises} из {amount_exercises})");
        }
    }
}
