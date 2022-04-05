namespace ShootBird
{
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

        public int Helth { get { return this.heroHelth; } }
        public string HeroName { get { return this.heroName; } }
        public int HeroAge { get { return this.heroAge; } }
        public string Species { get { return this.species; } }
        public string HeroGender { get { return this.heroGender; } }


        public Task CreateHeroAsync()
        {
            Console.WriteLine($"Поздравлеям!" +
             $"\nСоздан новый Герой: " +
             $"\nИмя: {HeroName} " +
             $"\nВозраст: {HeroAge} " +
             $"\nГендерная принадлежность: {HeroGender} " +
             $"\nРаса: {Species} " +
             $"\nЗдоровье: {Helth}");
            return Task.CompletedTask;
        }
    }
}
