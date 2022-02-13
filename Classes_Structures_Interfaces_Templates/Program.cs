using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Footballers footballers = new Footballers(18, 139, "Нападник", "Джеймі", "Варді", 33, "Англія", "АПЛ", "Лестер Сіті", 20000000);
            int z;
            int goals = footballers.Goals;
            int assists = 65;
            footballers.Goals_Assists(ref goals, ref assists, out z);
            Console.WriteLine("\n\nСумарна кількість голів та передач у Джеймі Варді - " + z + " Неймовірний результат!\n");
            footballers.SetTraditions("Різноманітні святкування голів");

            Console.WriteLine("\n\n");
            AddClass ad = new AddClass();
            ad.Operations();


            Console.WriteLine("\n\n");

            Console.WriteLine("Дуже й дуже примітивний аналог трасферного ринку!\n");
            int k = 1;
            while (k == 1)
            {
                Console.WriteLine("Список вашої команди:\n");
                HelpClass.print();

                Console.WriteLine("Купити чи продати гравця?\n" +
                    "1 - купити\n" +
                    "2 - продати\n");
                int id = Convert.ToInt32(Console.ReadLine());
                if (id == 1)
                {
                    Console.WriteLine("Список доступних граців:\n");
                    TransferMarket.print();

                    Console.WriteLine("Введіть відповідний id футболіста");
                    id = Convert.ToInt32(Console.ReadLine());
                    HelpClass.BuyFootballer(TransferMarket.BuyFootballer(id));
                }
                else if (id == 2)
                {
                    Console.WriteLine("Введіть відповідний id футболіста");
                    id = Convert.ToInt32(Console.ReadLine());

                    HelpClass.SellFootballer(id);


                }
                else
                {
                    Console.WriteLine("Чувак, введи правильне id!");
                }

                Console.WriteLine("Бавимося дальше?\n" +
                   "1 - так\n" +
                   "будь-яке інше число - ні\n");
                k = Convert.ToInt32(Console.ReadLine());
            }


            Console.WriteLine("Тестуємо швидкодію:\n\n");
            TestClass tc = new TestClass();

            var sw = new Stopwatch();

            sw.Start();
            tc.test1();
            sw.Stop();

            Console.WriteLine("Час value: " + sw.ElapsedMilliseconds + " мc \n\n");

            sw.Restart();
            tc.test2();
            sw.Stop();

            Console.WriteLine("Час ref: " + sw.ElapsedMilliseconds + " мc \n\n");

            sw.Restart();
            tc.test3();
            sw.Stop();

            Console.WriteLine("Час out: " + sw.ElapsedMilliseconds + " мc \n\n");

            Console.WriteLine("Тестуємо швидкодію класів (20 полів):\n\n");

            sw.Restart();
            tc.testClass1_v();
            sw.Stop();

            Console.WriteLine("Час value: " + sw.ElapsedMilliseconds + " мc \n\n");

            sw.Restart();
            tc.testClass1_r();
            sw.Stop();

            Console.WriteLine("Час ref: " + sw.ElapsedMilliseconds + " мc \n\n");

            sw.Restart();
            tc.testClass1_o();
            sw.Stop();

            Console.WriteLine("Час out: " + sw.ElapsedMilliseconds + " мc \n\n");

            ///
            ///
            ///
            ///

            Console.WriteLine("Тестуємо швидкодію класів (10 полів):\n\n");

            sw.Restart();
            tc.testClass2_v();
            sw.Stop();

            Console.WriteLine("Час value: " + sw.ElapsedMilliseconds + " мc \n\n");

            sw.Restart();
            tc.testClass2_r();
            sw.Stop();

            Console.WriteLine("Час ref: " + sw.ElapsedMilliseconds + " мc \n\n");

            sw.Restart();
            tc.testClass2_o();
            sw.Stop();

            Console.WriteLine("Час out: " + sw.ElapsedMilliseconds + " мc \n\n");


            ///
            ///
            ///
            ///



            Console.WriteLine("Тестуємо швидкодію класів (5 полів):\n\n");

            sw.Restart();
            tc.testClass3_v();
            sw.Stop();

            Console.WriteLine("Час value: " + sw.ElapsedMilliseconds + " мc \n\n");

            sw.Restart();
            tc.testClass3_r();
            sw.Stop();

            Console.WriteLine("Час ref: " + sw.ElapsedMilliseconds + " мc \n\n");

            sw.Restart();
            tc.testClass3_o();
            sw.Stop();

            Console.WriteLine("Час out: " + sw.ElapsedMilliseconds + " мc \n\n");

            Console.WriteLine("Тестуємо швидкодію структур (20 полів):\n\n");

            sw.Restart();
            tc.testStruct1_v();
            sw.Stop();

            Console.WriteLine("Час value: " + sw.ElapsedMilliseconds + " мc \n\n");

            sw.Restart();
            tc.testStruct1_r();
            sw.Stop();

            Console.WriteLine("Час ref: " + sw.ElapsedMilliseconds + " мc \n\n");

            sw.Restart();
            tc.testStruct1_o();
            sw.Stop();

            Console.WriteLine("Час out: " + sw.ElapsedMilliseconds + " мc \n\n");

            ///
            ///
            ///
            ///

            Console.WriteLine("Тестуємо швидкодію структур (10 полів):\n\n");

            sw.Restart();
            tc.testStruct2_v();
            sw.Stop();

            Console.WriteLine("Час value: " + sw.ElapsedMilliseconds + " мc \n\n");

            sw.Restart();
            tc.testStruct2_r();
            sw.Stop();

            Console.WriteLine("Час ref: " + sw.ElapsedMilliseconds + " мc \n\n");

            sw.Restart();
            tc.testStruct2_o();
            sw.Stop();

            Console.WriteLine("Час out: " + sw.ElapsedMilliseconds + " мc \n\n");

            Console.WriteLine("Тестуємо швидкодію структур (5 полів):\n\n");

            sw.Restart();
            tc.testStruct3_v();
            sw.Stop();

            Console.WriteLine("Час value: " + sw.ElapsedMilliseconds + " мc \n\n");

            sw.Restart();
            tc.testStruct3_r();
            sw.Stop();

            Console.WriteLine("Час ref: " + sw.ElapsedMilliseconds + " мc \n\n");

            sw.Restart();
            tc.testStruct3_o();
            sw.Stop();

            Console.WriteLine("Час out: " + sw.ElapsedMilliseconds + " мc \n\n");

        }
    }
}
