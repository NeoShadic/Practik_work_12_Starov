using Practik_work_10_Starov.task1;
using Practik_work_10_Starov.task2;
using Practik_work_10_Starov.task3;
using Practik_work_10_Starov.task4;
using Practik_work_10_Starov.task5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practik_work_12_Starov
{
    internal class Program
    {
        static void Main(string[] args) { task1(); }

        // все проверки сопровождаются методами
        static void task1()
        {
            Manager Dmitry = new Manager();
            Director Vlad = new Director();
            Developer Nastya = new Developer();

            Nastya.WriteCode();
            Dmitry.Meeting();
            Vlad.Budget();
        }
        static void task2()
        {
            CheckingAccount check = new CheckingAccount();
            SavingAccount name_save = new SavingAccount();
            CreditAccount new_credit = new CreditAccount();

            check.Check();
            name_save.Save();
            new_credit.Credit();
        }
        static void task3()
        {
            Book Lomonosov = new Book();
            Magazine News = new Magazine();
            DVD Video = new DVD();
            Audiobook Litress = new Audiobook();

            Lomonosov.CheckBook();
            News.Journal();
            Video.i_DVD();
            Litress.I_Audio();
        }
        static void task4()
        {
            VideoCourse ISO = new VideoCourse();
            TextCourse Russian_language = new TextCourse();
            InteractiveCourse Math = new InteractiveCourse();

            ISO.Check();
            Russian_language.Check(); 
            Math.SystemChecks(); // Система ошибок при нуле выдаст и true, и false при нулевых значениях и значениях больше 5 
        }
        static void task5()
        {
            Mammals cat = new Mammals();
            Reptiles snake = new Reptiles();
            Birds crow = new Birds();
            Fish herring = new Fish();

            cat.Walk();
            snake.Rest();
            crow.Fly();
            herring.Swin();
        }
    }
}