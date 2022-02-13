using System;
namespace Lab_4
{
    class TetsObject
    {
        String name = "Кертіс";
        String surname = "Джонс";

        public override string ToString()
        {
            return name + "  " + surname;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode() + surname.GetHashCode();
        }

        public void TestType()
        {
            object test_object = new TetsObject();
            if (test_object.GetType() == typeof(TetsObject))
                Console.WriteLine("Це дійсно клас \"TetsObject\"");

        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            TetsObject test_object = (TetsObject)obj;
            return (this.name == test_object.name && this.surname == test_object.surname);
        }

        public void RefEq()
        {
            TetsObject t = (TetsObject)this.MemberwiseClone();
            TetsObject o = null;

            Console.WriteLine(Object.ReferenceEquals(o, t)); //false
            o = t;

            Console.WriteLine(Object.ReferenceEquals(o, t)); //true

        }

    }
}
