using System;
namespace Lab_4
{
    abstract class Person
    {
        private protected int ID;
        private protected string Name { get; set; }
        protected string Surname { get; set; }
        protected internal int Age { get; set; }
        internal string Country { get; set; }



        public Person() { }

        public Person(int id, string name, string surname, int Age, string Country) : this(Age, Country)
        {
            ID = id;
            Name = name;
            Surname = surname;
        }

        public Person(int age, string country)
        {
            Age = age;
            Country = country;
        }

    }
}
