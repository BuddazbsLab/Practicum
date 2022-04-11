using L.S.D.Interface;

namespace L.S.D.Hero.CharacterClass
{
    /// <summary>
    /// Класс героя
    /// </summary>
    internal class HeroPersonWizard : IHeroPerson
    {
        private readonly int heroHelth;
        private readonly string heroName;
        private readonly int heroAge;
        private readonly int heroLevel;
        private readonly int heroExperience;
        private readonly string nameCharacteristicsClass;

        public HeroPersonWizard(string heroName, int heroAge)
        {
            heroHelth = 100;
            this.heroName = heroName;
            this.heroAge = heroAge;
            heroLevel = 1;
            heroExperience = 0;
            nameCharacteristicsClass = "Маг";
        }

        public int Helth => heroHelth;
        public string HeroName => heroName;
        public int HeroAge => heroAge;
        public int HeroLevel => heroLevel;
        public int HeroExperience => heroExperience;
        public string NameCharacteristicsClass => nameCharacteristicsClass;

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
             $"\n Уровень героя: {HeroLevel}" +
             $"\n Опыт героя: {HeroExperience}");
            Console.WriteLine("                                                  Получено достижение 'Создатель!'");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
        }
    }
}
