using System.Collections.Generic;
namespace Lab_3
{
    public class FakeData
    {
        public static List<Countries> countries = new List<Countries>()
        {
            new Countries() { ID = 0, Name = "Англія" },
            new Countries() { ID = 1, Name = "Іспанія" },
            new Countries() { ID = 2, Name = "Італія" },
            new Countries() { ID = 3, Name = "Німеччина" },
            new Countries() { ID = 4, Name = "Франція" },
            new Countries() { ID = 5, Name = "Україна" },
            new Countries() { ID = 6, Name = "Росія" },
            new Countries() { ID = 7, Name = "Австрія" },
            new Countries() { ID = 8, Name = "Бельгія" },
            new Countries() { ID = 9, Name = "Туреччина" },
            new Countries() { ID = 10, Name = "Греція" },
            new Countries() { ID = 11, Name = "Угорщина" },
            new Countries() { ID = 12, Name = "Португалія" },
            new Countries() { ID = 13, Name = "Данія" },
            new Countries() { ID = 14, Name = "Нідерланди" },

            new Countries() { ID = 15, Name = "Польща" },
            new Countries() { ID = 16, Name = "Уругвай" },
            new Countries() { ID = 17, Name = "Замбія" },
            new Countries() { ID = 18, Name = "Мексика" },
            new Countries() { ID = 19, Name = "Камерун" },
            new Countries() { ID = 20, Name = "США" },
            new Countries() { ID = 21, Name = "Швеція" },
            new Countries() { ID = 22, Name = "Хорватія" },
            new Countries() { ID = 23, Name = "Аргентина" },
            new Countries() { ID = 24, Name = "Сенегал" }
        };

        public static List<Teams> teams = new List<Teams>()
        {
            new Teams() { ID = 0, Name = "Баварія", CountryID = 3},
            new Teams() { ID = 1, Name = "Атлетіко", CountryID = 1},
            new Teams() { ID = 2, Name = "Локомотив", CountryID = 6},
            new Teams() { ID = 3, Name = "Ред Булл (Зальцбург)", CountryID = 7},
            new Teams() { ID = 4, Name = "Боруссія (Менхенгладбах)", CountryID = 3},
            new Teams() { ID = 5, Name = "Шахтар (Донецьк)", CountryID = 5},
            new Teams() { ID = 6, Name = "Реал Мадрид", CountryID = 1},
            new Teams() { ID = 7, Name = "Інтернаціонале", CountryID = 2},
            new Teams() { ID = 8, Name = "Манчестер Сіті", CountryID = 0},
            new Teams() { ID = 9, Name = "Порту", CountryID = 12},
            new Teams() { ID = 10, Name = "Олімпіакос", CountryID = 10},
            new Teams() { ID = 11, Name = "Олімпік (Марсель)", CountryID = 4},
            new Teams() { ID = 12, Name = "Ліверпуль", CountryID = 0},
            new Teams() { ID = 13, Name = "Аякс", CountryID = 14},
            new Teams() { ID = 14, Name = "Аталанта", CountryID = 2},
            new Teams() { ID = 15, Name = "Мідтьюланн", CountryID = 13},
            new Teams() { ID = 16, Name = "Челсі", CountryID = 0},
            new Teams() { ID = 17, Name = "Севілья", CountryID = 1},
            new Teams() { ID = 18, Name = "Краснодар", CountryID = 6},
            new Teams() { ID = 19, Name = "Ренн", CountryID = 4},
            new Teams() { ID = 20, Name = "Боруссія (Дортмунд)", CountryID = 3},
            new Teams() { ID = 21, Name = "Лаціо", CountryID = 2},
            new Teams() { ID = 22, Name = "Брюгге", CountryID = 8},
            new Teams() { ID = 23, Name = "Зеніт", CountryID = 6},
            new Teams() { ID = 24, Name = "Барселона", CountryID = 1},
            new Teams() { ID = 25, Name = "Ювентус", CountryID = 2},
            new Teams() { ID = 26, Name = "Динамо (Київ)", CountryID = 5},
            new Teams() { ID = 27, Name = "Ференцварош", CountryID = 11},
            new Teams() { ID = 28, Name = "Манчестер Юнайтед", CountryID = 0},
            new Teams() { ID = 29, Name = "РБ Лейпциг", CountryID = 3},
            new Teams() { ID = 30, Name = "Парі Сен-Жермен", CountryID = 4},
            new Teams() { ID = 31, Name = "Істанбул Башакшехір", CountryID = 9}
        };

        public static List<Players> players = new List<Players>()
        {
            new Players() { ID = 0, Name = "Роберт Левандовський", CountryID = 15, TeamID = 0},
            new Players() { ID = 1, Name = "Луїс Суарес", CountryID = 16, TeamID = 1},
            new Players() { ID = 2, Name = "Антон Міранчук", CountryID = 6, TeamID = 2 },
            new Players() { ID = 3, Name = "Петсон Дака", CountryID = 17, TeamID = 3},
            new Players() { ID = 4, Name = "Алассан Плеа", CountryID = 4, TeamID = 4},
            new Players() { ID = 5, Name = "Тарас Степаненко", CountryID = 5, TeamID = 5},
            new Players() { ID = 6, Name = "Еден Азар", CountryID = 8, TeamID = 6},
            new Players() { ID = 7, Name = "Ромелу Лукаку", CountryID = 8, TeamID = 7},
            new Players() { ID = 8, Name = "Олександр Зінченко", CountryID = 5, TeamID = 8},
            new Players() { ID = 9, Name = "Хесус Корона", CountryID = 18, TeamID = 9},
            new Players() { ID = 10, Name = "Андреас Бухалакіс", CountryID = 10, TeamID = 10},
            new Players() { ID = 11, Name = "Дімітрі Паєт", CountryID = 4, TeamID = 11},
            new Players() { ID = 12, Name = "Джордан Гендерсон", CountryID = 0, TeamID = 12},
            new Players() { ID = 13, Name = "Андре Онана", CountryID = 19, TeamID = 13},
            new Players() { ID = 14, Name = "Руслан Маліновський", CountryID = 5, TeamID = 14},
            new Players() { ID = 15, Name = "Піоне Сісто", CountryID = 13, TeamID = 15},
            new Players() { ID = 16, Name = "Крістіан Пулишич", CountryID = 20, TeamID = 16},
            new Players() { ID = 17, Name = "Люк де Йонг", CountryID = 14, TeamID = 17},
            new Players() { ID = 18, Name = "Маркус Берг", CountryID = 21, TeamID = 18},
            new Players() { ID = 19, Name = "Едуарду Камавінга", CountryID = 4, TeamID = 19},
            new Players() { ID = 20, Name = "Марко Ройс", CountryID = 3, TeamID = 20},
            new Players() { ID = 21, Name = "Луїс Альберто", CountryID = 1, TeamID = 21},
            new Players() { ID = 22, Name = "Сімон Міньйоле", CountryID = 8, TeamID = 22},
            new Players() { ID = 23, Name = "Деян Ловрен", CountryID = 22, TeamID = 23},
            new Players() { ID = 24, Name = "Ліонель Мессі", CountryID = 23, TeamID = 24},
            new Players() { ID = 25, Name = "Кріштіану Роналду", CountryID = 12, TeamID = 25},
            new Players() { ID = 26, Name = "Сергій Сидорчук", CountryID = 5, TeamID = 26},
            new Players() { ID = 27, Name = "Ігор Харатін", CountryID = 5, TeamID = 27},
            new Players() { ID = 28, Name = "Маркус Рашфорд", CountryID = 0, TeamID = 28},
            new Players() { ID = 29, Name = "Анхеліньйо", CountryID = 1, TeamID = 29},
            new Players() { ID = 30, Name = "Кіліан Мбаппе", CountryID = 4, TeamID = 30},
            new Players() { ID = 31, Name = "Демба Ба", CountryID = 24, TeamID = 31}
        };
    }
}
