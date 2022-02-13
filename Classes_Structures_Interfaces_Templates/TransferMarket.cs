using System.Collections.Generic;
namespace Lab_4
{
    class TransferMarket
    {
        public static List<Footballers> Transfer_market = new List<Footballers>()
        {
            new Footballers(11, 26,"Півзахисник", "Джеймс", "Мілнер", 34, "Англія", "АПЛ", "Ліверпуль", 5000000),
            new Footballers(12, 13,"Нападник", "Люк", "де Йонг", 30, "Нідерланди", "Ла-Ліга", "Севілья", 12000000),
            new Footballers(13, 27,"Нападник", "Ерлінг", "Голанд", 20, "Норвегія", "Бундесліга", "«Боруссія» (Дортмунд)", 80000000),
            new Footballers(14, 41,"Нападник", "Ромелу", "Лукаку", 27, "Бельгія", "Серія А", "Інтернаціонале", 85000000),
            new Footballers(15, 12,"Захисник", "Ніколас", "Тальяфіко", 28, "Аргентина", "Ередивізі", "Аякс", 28000000),
            new Footballers(16, 0,"Захисник", "Ян", "Вертонген", 33, "Бельгія", "Прімейра-Ліга", "Бенфіка", 10000000),
            new Footballers(17, 0,"Воротар", "Руслан", "Нещерет", 18, "Україна", "Favbet Ліга", "«Динамо» (Київ)", 400000)

        };

        static public Footballers BuyFootballer(int k)
        {
            Footballers f = Transfer_market.Find(t => t.GetID() == k);
            if (f == null)
            {
                return f;
            }
            Transfer_market.Remove(f);
            return f;
        }

        static public void SellFootballer(Footballers f)
        {
            Transfer_market.Add(f);
        }

        static public void print()
        {
            Footballers f = new Footballers();

            foreach (var v in Transfer_market)
                f.Get_Info(v);
        }
    }
}
