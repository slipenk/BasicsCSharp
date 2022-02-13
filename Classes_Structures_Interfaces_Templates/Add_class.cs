using System;
namespace Lab_4
{
    class AddClass
    {
        public enum FootballClubs
        {
            Liverpool = 0,
            Leicester = 1,
            Arsenal = 10,
            Aston_Villa = Arsenal,
            Leeds = 15,
            Newcastle = 3,
            Sheffield = 5,

        }

        public void Operations()
        {
            FootballClubs Liverpool = FootballClubs.Liverpool;
            FootballClubs Leicester = FootballClubs.Leicester;
            FootballClubs Arsenal = FootballClubs.Arsenal;
            FootballClubs Aston_Villa = FootballClubs.Aston_Villa;
            FootballClubs Leeds = FootballClubs.Leeds;
            FootballClubs Newcastle = FootballClubs.Newcastle;
            FootballClubs Sheffield = FootballClubs.Sheffield;

            Console.WriteLine($"Leicester | Aston_Villa = { Leicester | Aston_Villa}");
            Console.WriteLine($"Newcastle & Sheffield = { Newcastle & Sheffield}");
            Console.WriteLine($"~Arsenal = { (int)~Arsenal}");
            Console.WriteLine($"Liverpool ^ Leeds = { (int)(Liverpool ^ Leeds)}");
        }


        public void Casting_types()
        {
            int a = 10;
            object o = a; //пакування - результат цього оператора створює посилання на об'єкт o в стеці,
                          //яке посилається на значення типу int в кучі.

            a = (int)o; //розпакування - копіювання значення в змінну типу значення
        }


    }
}
