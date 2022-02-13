using System;
namespace Lab_4
{
    class Footballers : Person, IActions
    {
        public int Goals { get; set; }
        string Position { get; set; }
        protected string League { get; set; }
        protected string Club { get; set; }
        protected int Cost { get; set; }
        public int GetID () { return ID; }

        static DateTime localDate;

        static Footballers()
        {
            localDate = DateTime.Now;
        }

        public Footballers() { }


        public Footballers(int id, int Goals, string Position, string Name, string Surname, int Age, string Country, string League, string Club, int Cost) : base(id, Name, Surname, Age, Country)
        {
            this.Goals = Goals;
            this.Position = Position;
            this.League = League;
            this.Club = Club;
            this.Cost = Cost;
        }

        public void Goals_Assists(ref int x, ref int y, out int z)
        {
            z = x + y;
        }

        public void Get_Info(Footballers f)
        {
            Console.WriteLine("ID: "+ f.ID + " \nІм'я: " + f.Name + " \nПрізвище: " + f.Surname + " \nВік: " + f.Age + " \nКраїна: " + f.Country + " \nПозиція: " + f.Position + " \nКількість голів: " + f.Goals + " \nЦіна (млн євро): " + f.Cost  + " \nЛіга: " + f.League + " \nКлуб: " + f.Club + "\n");
        }

        public void Get_Info(string s, int goals)
        {
            Console.WriteLine(s + " " + goals);
        }


        private class Traditions
        {
            public string traditions { get; set; }
        }
        Traditions t;
        public void SetTraditions(string s)
        {
            t = new Traditions() { traditions = s };
        }


        public static implicit operator Footballers(int x)
        {
            return new Footballers { Goals = x };
        }
        public static explicit operator int(Footballers footballers)
        {
            return footballers.Goals;
        }

        public void Casting_types()
        {
            Footballers f1 = new Footballers { Goals = 23 };
            int x = (int)f1;
            Footballers counter2 = x;
        }
    }

}

   
