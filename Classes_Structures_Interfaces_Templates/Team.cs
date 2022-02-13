using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_4
{
    class HelpClass
    {
        public static List<Footballers> MyClub = new List<Footballers>()
           {
            new Footballers(0, 0,"Воротар", "Аліссон", "Беккер", 28, "Бразилія", "АПЛ", "Ліверпуль", 80000000),
            new Footballers(1, 8,"Правий захисник", "Трент", "Александер-Арнольд", 22, "Англія", "АПЛ", "Ліверпуль", 110000000),
            new Footballers(2, 5,"Центральний захисник", "Жоель", "Матіп", 29, "Камерун", "АПЛ", "Ліверпуль", 32000000),
            new Footballers(3, 13,"Центральний захисник", "Вірґіл", "ван Дейк", 28, "Нідерланди", "АПЛ", "Ліверпуль", 80000000),
            new Footballers(4, 5,"Лівий захисник", "Ендрю", "Робертсон", 26, "Шотландія", "АПЛ", "Ліверпуль", 75000000),
            new Footballers(5, 29,"Півзахисник", "Джордан", "Гендерсон", 30, "Англія", "АПЛ", "Ліверпуль", 28000000),
            new Footballers(6, 19,"Півзахисник", "Джорджіньо", "Вейналдум", 30, "Нідерланди", "АПЛ", "Ліверпуль", 40000000),
            new Footballers(7, 0,"Півзахисник", "Тьяго", "Алькантара", 29, "Іспанія", "АПЛ", "Ліверпуль", 48000000),
            new Footballers(8, 104,"Нападник", "Мохаммед", "Салах", 28, "Єгипет", "АПЛ", "Ліверпуль", 120000000),
            new Footballers(9, 86,"Нападник", "Садіо", "Мане", 28, "Сенегал", "АПЛ", "Ліверпуль", 120000000),
            new Footballers(10, 79,"Нападник", "Роберто", "Фірміно", 29, "Бразилія", "АПЛ", "Ліверпуль", 72000000)
            };

        public static void print()
        {
            Footballers f = new Footballers();
            foreach (var v in MyClub)
                f.Get_Info(v);
        }

        static public void BuyFootballer(Footballers f)
        {

            if (f == null)
            {
                Console.WriteLine("Чувак, введи правильне id!");
                return;
            }

            Console.WriteLine("Купівля пройшла успішно!\n\n");
            MyClub.Add(f);
            print();
        }

        static public Footballers SellFootballer(int k)
        {


            Footballers f = MyClub.FirstOrDefault(t => t.GetID() == k);
            if (f == null)
            {
                Console.WriteLine("Чувак, введи правильне id!");
                return f;
            }
            Console.WriteLine("Ви продали футболіста!\n\n");
            MyClub.Remove(f);
            TransferMarket.SellFootballer(f);
            print();
            return f;
        }
    }
}

