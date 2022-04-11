
namespace ShootBird.Hero
{
    internal class InitialСharacteristics
    {
        private readonly string heroName;
        private readonly int heroAge;

        public InitialСharacteristics(string heroName, int heroAge)
        {
            this.heroName = heroName;
            this.heroAge = heroAge;
        }

        public string HeroName => this.heroName;
        public int HeroAge => this.heroAge;


        public IHeroPerson NewCharacterClass()
        {
            //Предлагаем выбрать оружие герою
            Console.WriteLine("                      Выбери Класс.");
            Console.WriteLine($"╔════════════════════════════════╗");
            Console.WriteLine($"║#=#Список начального оружия: #=#║");
            Console.WriteLine($"║════════════════════════════════║");
            Console.WriteLine($"║  [0]-Маг.                      ║");
            Console.WriteLine($"║  [1]-Воин.                     ║");
            Console.WriteLine($"║  [2]-Лучник.                   ║");
            Console.WriteLine($"╚════════════════════════════════╝");
            Console.WriteLine(">>>");
            int operationType;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out operationType) & operationType < 3)
                    break;
                Console.WriteLine("                      Выбери Класс.");
                Console.WriteLine($"╔════════════════════════════════╗");
                Console.WriteLine($"║#=#Список начального оружия: #=#║");
                Console.WriteLine($"║════════════════════════════════║");
                Console.WriteLine($"║  [0]-Маг.                      ║");
                Console.WriteLine($"║  [1]-Воин.                     ║");
                Console.WriteLine($"║  [2]-Лучник.                   ║");
                Console.WriteLine($"╚════════════════════════════════╝");
                Console.WriteLine(">>>");
            }
            if (operationType >= 0 || operationType <= 2)
            {
                //operationType = int.Parse(Console.ReadLine());
                AssignCharacterClass assignFirstWeapon = new(operationType , HeroName, HeroAge);
                var selectedCharacterClass = assignFirstWeapon.AssignNewCharacterClass();
                return selectedCharacterClass;
            }
            else
            {
                Console.WriteLine(" Доигрался!\nВыбрано оружие по умолчанию!");
                AssignCharacterClass assignFirstWeapon = new(0, HeroName, HeroAge);
                var selectedCharacterClass = assignFirstWeapon.AssignNewCharacterClass();
                return selectedCharacterClass;
            }
        }

       
    }
}
