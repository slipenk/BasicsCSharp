using System;
using System.Collections.Generic;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Footballer> liverpool = Liverpool();
            List<Footballer> west_ham_united = West_Ham_United();
            MatchEvent match = new MatchEvent() { Liverpool = liverpool, West_Ham_United = west_ham_united };

            match.E_ScoreGoal += E_ScoreGoal;
            match.E_ScoreGoal += E_Fornals;
            match.E_GetYellowCard += E_GetYellowCard;
            match.E_CanceldGoal += E_CanceldGoal;
            match.E_GoalScoredPenalty += E_GoalScoredPenalty;
            match.E_Substitution += E_Substitution;

            match.ScoreGoal(west_ham_united[9]);
            match.E_ScoreGoal -= E_Fornals;
            match.GoalScoredPenalty(liverpool[8]);
            match.GetYellowCard(west_ham_united[8]);
            match.Substitution(liverpool[7], liverpool[17]);
            match.Substitution(liverpool[10], liverpool[13]);
            match.Substitution(west_ham_united[10], west_ham_united[17]);
            match.CanceldGoal(liverpool[13]);
            match.ScoreGoal(liverpool[13]);
            match.Substitution(west_ham_united[5], west_ham_united[13]);
            match.Substitution(west_ham_united[6], west_ham_united[11]);
            match.Substitution(liverpool[8], liverpool[14]);


        }

        private static void E_GetYellowCard(object sender, MatchEventsArg e)
        {
            if (e.footballer.IsYellowCard)
            {
                Console.WriteLine($"Жовту картку в цьому матчі отримав {e.footballer.name}");
            }
        }

        private static void E_ScoreGoal(object sender, MatchEventsArg e)
        {
            if (e.footballer.GoalScored!=0)
            {
               
                switch (Footballer.GoalsInMatch)
                {
                    case 1:
                        Console.WriteLine($"Гол забиває {e.footballer.name}! Несподівано \"Вест Гем Юнайтед\" повів у рахунку!");
                        break;
                    case 3:
                        Console.WriteLine($"Шикарна передача від Шачірі й {e.footballer.name} виводить \"Ліверпуль\" вперед!");
                        break;
                }

            }
        }

        private static void E_GoalScoredPenalty(object sender, MatchEventsArg e)
        {
            if (e.footballer.GoalScored != 0)
            { 
                switch (Footballer.GoalsInMatch)
                { 
                    case 2:
                      Console.WriteLine($"ПЕНАЛЬТІ! Фолить Масуаку, {e.footballer.name} заробляє пенальті і єгиптянин впевнено реалізує одинадцятиметровий! 1:1");
                    break;
                   
                }

            }
        }

        private static void E_Fornals(object sender, MatchEventsArg e)
        {
            if (e.footballer.GoalScored != 0)
            {
                switch (Footballer.GoalsInMatch)
                {
                    case 1:
                        Console.WriteLine($"Другий гол у АПЛ забиває {e.footballer.name}!");
                        break;

                }

            }
        }

        private static void E_CanceldGoal(object sender, MatchEventsArg e)
        {
            if (e.footballer.CanceldGoal)
            {
                Console.WriteLine($"Забиває {e.footballer.name}, але після перегляду відеоповтору Кевін Френд скасував дане взяття воріт. ");
            }
        }

        private static void E_Substitution(object sender, MatchEventsArg e)
        {
           
                Console.WriteLine($"Заміна! Йде з поля {e.footballer.name}, а виходить {e.footballerSub.name}. ");
            
        }


        static List<Footballer> Liverpool()
        {
            List<Footballer> liverpool = new List<Footballer>();
            liverpool.Add(new Footballer() { name = "Аліссон Беккер" });
            liverpool.Add(new Footballer() { name = "Трент Александер-Арнольд" });
            liverpool.Add(new Footballer() { name = "Натаніель Філліпс" });
            liverpool.Add(new Footballer() { name = "Джозеф Ґомез" });
            liverpool.Add(new Footballer() { name = "Ендрю Робертсон" });
            liverpool.Add(new Footballer() { name = "Джорджіньо Вейналдум" });
            liverpool.Add(new Footballer() { name = "Джордан Гендерсон" });
            liverpool.Add(new Footballer() { name = "Кертіс Джонс" });
            liverpool.Add(new Footballer() { name = "Мохаммед Салах" });
            liverpool.Add(new Footballer() { name = "Садіо Мане" });
            liverpool.Add(new Footballer() { name = "Роберто Фірміно" });
            liverpool.Add(new Footballer() { name = "Неко Вільямс", IsOnField = false });
            liverpool.Add(new Footballer() { name = "Ріс Вільямс", IsOnField = false });
            liverpool.Add(new Footballer() { name = "Діогу Жота", IsOnField = false });
            liverpool.Add(new Footballer() { name = "Джеймс Мілнер", IsOnField = false });
            liverpool.Add(new Footballer() { name = "Такумі Мінаміно", IsOnField = false });
            liverpool.Add(new Footballer() { name = "Адріан", IsOnField = false });
            liverpool.Add(new Footballer() { name = "Джердан Шачірі", IsOnField = false });

            return liverpool;
        }

        static List<Footballer> West_Ham_United()
        {
            List<Footballer> West_Ham_United = new List<Footballer>();
            West_Ham_United.Add(new Footballer() { name = "Лукаш Фабіанський" });
            West_Ham_United.Add(new Footballer() { name = "Владімір Цоуфал" });
            West_Ham_United.Add(new Footballer() { name = "Фабіан Бальбуена" });
            West_Ham_United.Add(new Footballer() { name = "Анджело Огбонна" });
            West_Ham_United.Add(new Footballer() { name = "Аарон Крессвелл" });
            West_Ham_United.Add(new Footballer() { name = "Артур Масуаку" });
            West_Ham_United.Add(new Footballer() { name = "Джеррод Боуен" });
            West_Ham_United.Add(new Footballer() { name = "Томаш Соучек" });
            West_Ham_United.Add(new Footballer() { name = "Деклан Райс" });
            West_Ham_United.Add(new Footballer() { name = "Пабло Форнальс" });
            West_Ham_United.Add(new Footballer() { name = "Себастьян Алле" });
            West_Ham_United.Add(new Footballer() { name = "Саїд Бенрахма", IsOnField = false });
            West_Ham_United.Add(new Footballer() { name = "Ісса Діоп", IsOnField = false });
            West_Ham_United.Add(new Footballer() { name = "Мануель Лансіні", IsOnField = false });
            West_Ham_United.Add(new Footballer() { name = "Даррен Рендолф", IsOnField = false });
            West_Ham_United.Add(new Footballer() { name = "Роберт Снодграсс", IsOnField = false });
            West_Ham_United.Add(new Footballer() { name = "Раян Фредерікс", IsOnField = false });
            West_Ham_United.Add(new Footballer() { name = "Андрій Ярмоленко", IsOnField = false });

            return West_Ham_United;
        }

    }

   

}
