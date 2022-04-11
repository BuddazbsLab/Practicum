
using ShootBird.Hero.CharacterClass;

namespace ShootBird.Hero
{
    internal class AssignCharacterClass
    {
        private readonly int operationType;
        private readonly string heroName;
        private readonly int heroAge;

        public AssignCharacterClass(int operationType, string heroName, int heroAge)
        {
            this.operationType = operationType;
            this.heroName = heroName;
            this.heroAge = heroAge;
        }

        public int OperationType => this.operationType;
        public string HeroName => this.heroName;
        public int HeroAge => this.heroAge;

        public IHeroPerson AssignNewCharacterClass()
        {
            var characterClass = new IHeroPerson[]
            {
                new HeroPersonWizard(HeroName, HeroAge),
                new HeroPersonWarroir(HeroName, HeroAge),
                new HeroPersonArcher(HeroName, HeroAge),
            };

            var newCharacterClass = characterClass[OperationType];
            return newCharacterClass;
        }
    }
}
