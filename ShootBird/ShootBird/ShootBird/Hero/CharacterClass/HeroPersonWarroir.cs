namespace ShootBird.Hero.CharacterClass
{
    internal class HeroPersonWarroir : IHeroPerson
    {
        private readonly int heroHelth;
        private readonly string heroName;
        private readonly int heroAge;
        private readonly int heroLevel;
        private readonly int heroExperience;
        private readonly string nameCharacteristicsClass;

        public HeroPersonWarroir(string heroName, int heroAge)
        {
            this.heroHelth = 100;
            this.heroName = heroName;
            this.heroAge = heroAge;
            this.heroLevel = 1;
            this.heroExperience = 0;
            this.nameCharacteristicsClass = "Воин";
        }

        public int Helth => this.heroHelth;
        public string HeroName => this.heroName;
        public int HeroAge => this.heroAge;
        public int HeroLevel => this.heroLevel;
        public int HeroExperience => this.heroExperience;
        public string NameCharacteristicsClass => this.nameCharacteristicsClass;

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
