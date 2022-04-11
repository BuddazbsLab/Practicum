using L.S.D.Interface;
using L.S.D;
using L.S.D.Hero.CharacterClass;

namespace L.S.D.Hero
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

        public int OperationType => operationType;
        public string HeroName => heroName;
        public int HeroAge => heroAge;

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
