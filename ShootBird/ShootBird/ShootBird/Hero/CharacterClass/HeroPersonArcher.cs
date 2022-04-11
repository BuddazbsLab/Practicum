using L.S.D.Interface;

namespace L.S.D.Hero.CharacterClass
{
    internal class HeroPersonArcher : IHeroPerson
    {
        private readonly int heroHelth;
        private readonly string heroName;
        private readonly int heroAge;
        private readonly int heroLevel;
        private readonly int heroExperience;
        private readonly string nameCharacteristicsClass;
        private readonly int heroArmor;

        public HeroPersonArcher(string heroName, int heroAge)
        {
            this.heroHelth = 100;
            this.heroName = heroName;
            this.heroAge = heroAge;
            this.heroLevel = 1;
            this.heroExperience = 0;
            this.nameCharacteristicsClass = "Лучник";
            this.heroArmor = 0;
        }

        public int Helth => this.heroHelth;
        public string HeroName => this.heroName;
        public int HeroAge => this.heroAge;
        public int HeroLevel => this.heroLevel;
        public int HeroExperience => this.heroExperience;
        public string NameCharacteristicsClass => this.nameCharacteristicsClass;
        public int HeroArmor => this.heroArmor;

        /// <summary>
        /// Создание героя
        /// </summary>
        /// <returns>Возращает результат создания героя</returns>
        public async Task CreateHeroAsync()
        {
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                    Поздравлеям!" +
             "\n                                Создан новый Герой: " +
             $"\n Имя: {HeroName} " +
             $"\n Возраст: {HeroAge} " +
             $"\n Класс персонажа: {NameCharacteristicsClass} " +
             $"\n Здоровье: {Helth}" +
             $"\n Броня: {HeroArmor}" +
             $"\n Уровень героя: {HeroLevel}" +
             $"\n Опыт героя: {HeroExperience}");
            Console.WriteLine("                                                  Получено достижение 'Создатель!'");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
        }
    }
}
