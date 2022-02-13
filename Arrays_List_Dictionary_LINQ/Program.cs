using System;
using System.Collections.Generic;
using System.Linq;
namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Task_1();
            Task_2();
            Task_3();
            Task_4();
            Task_5();
            Task_6();
            Task_7();
            Task_8();
        }

        public static void Task_1()
        {
            Console.WriteLine("Завдання 1: \n\nСписок гравців:\n");
            Console.WriteLine(string.Join("\n", FakeData.players.Select(p => $"{p.Name}")));
        }

        public static void Task_2()
        {
            Console.WriteLine("\nЗавдання 2: \n\nАнглійські команди в ЛЧ:\n");
            Console.WriteLine(string.Join("\n", FakeData.teams.Where(p => p.CountryID == 0).Select(p => $"{p.Name}")));
        }
        public static void Task_3()
        {
            Console.WriteLine("\nЗавдання 3: \n\n");

            List<Countries> countries = FakeData.countries.ToList();
            List<Teams> teams = FakeData.teams.ToList();
            
            var TeamsCountries = teams.Join(countries, t => t.CountryID, c => c.ID, (t, c) => new { t.Name, Country = c.Name }).GroupBy(p => p.Country)
                .Select(g => new { Name = g.Key, Count = g.Count() });

            Console.WriteLine("\nСписок клубів та відповідні їм країни: \n\n");
            Console.WriteLine(string.Join("\n", TeamsCountries));

            Console.WriteLine("\nСписок клубів (використання словника): \n\n");
            Dictionary<int, Teams> dictionary = teams.ToDictionary(p => p.ID);
            foreach (var d in dictionary)
            {
                Console.WriteLine($"{d.Key} - {d.Value.Name}");
            }

            Queue<string> q = new Queue<string>();
            foreach (var c in countries) { q.Enqueue(c.Name); }
           
            
        }

        public static void Task_4()
        {
            Console.WriteLine("\nЗавдання 4. Гравець, який грає в найкращому клубі світу: \n");
            var best_club = FakeData.players.Plays_in_the_best_club();
            Console.WriteLine(string.Join("\n", best_club.Select(p => p.Name)));
        }


        public static void Task_5()
        {
            List<Countries> countries = FakeData.countries.ToList();
            List<Players> players = FakeData.players.ToList();

            var PlayersCountries = players.Join(countries, t => t.CountryID, c => c.ID, (t, c) => new { t.Name, Country = c.Name }).ToList();

            Console.WriteLine("\nЗавдання 5.\n\nСписок гравців та відповідні їм країни: \n\n");
            Console.WriteLine(string.Join("\n", PlayersCountries));
        }

        public static void Task_6()
        {
            Console.WriteLine("\nЗавдання 6.\n\nСписок команд, які відсортовані за довжиною:\n\n");
            var teams = FakeData.teams;
            teams.Sort(Comparer<Teams>.Create((t1, t2) => t1.Name.Length - t2.Name.Length));
            Console.WriteLine(string.Join("\n", teams.Select(p => p.Name)));
        }

        public static void Task_7()
        {
            Console.WriteLine("\nЗавдання 7.\n\nСписок країн:\n\n");
            var countries = FakeData.countries.ToArray();
            Console.WriteLine(string.Join("\n", countries.Select(c => c.Name)));
        }

        public static void Task_8()
        {
            Console.WriteLine("\nЗавдання 8.\n\nСортування команд за назвою:\n\n");
            var teams = FakeData.teams.OrderBy(t => t.Name);
            Console.WriteLine(string.Join("\n", teams.Select(c => c.Name)));

            var PlayersCountries = FakeData.players.Join(FakeData.countries, t => t.CountryID, c => c.ID, (t, c) => new { t.Name, Country = c.Name }).OrderBy(c => c.Country).ToList();

            Console.WriteLine("\nСортування гравців за країнами: \n\n");
            Console.WriteLine(string.Join("\n", PlayersCountries));
        }

    }
    

    static class Extension 
    {
        public static List<Players> Plays_in_the_best_club(this List<Players> players)
        {
            return players.Where(p => p.TeamID == 12).ToList();
        }

    }
}




