namespace ShootBird
{
    /// <summary>
    /// Класс героя
    /// </summary>
    internal class HeroPerson : IHeroPerson
    {
        private readonly int heroHelth;
        private readonly string heroName;
        private readonly int heroAge;
        private readonly string heroGender;
        private readonly string species;

        public HeroPerson(string heroName, int heroAge, string heroGender, string species)
        {
            this.heroHelth = 100;
            this.heroName = heroName;
            this.heroAge = heroAge;
            this.heroGender = heroGender;
            this.species = species;
        }

        public int Helth => this.heroHelth;
        public string HeroName => this.heroName;
        public int HeroAge => this.heroAge;
        public string Species => this.species;
        public string HeroGender => this.heroGender;

        /// <summary>
        /// Создание героя
        /// </summary>
        /// <returns>Возращает результат создания героя</returns>
        public async Task CreateHeroAsync()
        {
            Console.WriteLine($"Поздравлеям!" +
             $"\nСоздан новый Герой: " +
             $"\nИмя: {HeroName} " +
             $"\nВозраст: {HeroAge} " +
             $"\nГендерная принадлежность: {HeroGender} " +
             $"\nРаса: {Species} " +
             $"\nЗдоровье: {Helth}");
        }
    }
}
