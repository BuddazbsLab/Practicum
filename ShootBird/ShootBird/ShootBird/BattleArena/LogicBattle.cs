namespace L.S.D.BattleArena
{
    internal class LogicBattle
    {
        private int heroHeals;
        private int enemyHeals;
        private int heroArmor;
        private readonly int enemyDamage;
        private readonly int heroDamage;

        public LogicBattle(int heroHeals, int enemyHeals, int heroArmor, int heroDamage, int enemyDamage)
        {
            this.heroHeals  = heroHeals;
            this.enemyHeals = enemyHeals;
            this.heroArmor = heroArmor;
            this.enemyDamage = enemyDamage;
            this.heroDamage = heroDamage;
        }

        public int HeroArmor
        {
            get { return heroArmor; }
            set { heroArmor = value; }
        }
        public int HeroDamage => this.heroDamage;

        public int HeroHeals
        {
            get { return this.heroHeals; }
            set { this.heroHeals = value; }
        }        

        public int EnemyHeals
        {
            get { return this.enemyHeals; }
            set { this.enemyHeals = value; }
        }

        public int EnemyDamage => this.enemyDamage;

        public void HeroAttak()
        {
            int damageByEnemy = EnemyHeals - HeroDamage;
            Console.ForegroundColor = ConsoleColor.Green;
            if (EnemyHeals > 0) { EnemyHeals = damageByEnemy; }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Монстр получил урон! Здоровье: {EnemyHeals} HP.");

        }

        public void EnemyAttak()
        {
            if (HeroArmor > 0)
            {
                HeroArmor -= EnemyDamage;
                int dmageByHero = HeroHeals;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Green;
                if (HeroHeals > 0) { HeroHeals = dmageByHero; }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ваш герой получил урон! \nЗдоровье: {HeroHeals} HP.\nБорня {HeroArmor}");
            }
            else
            {
                int dmageByHero = HeroHeals - EnemyDamage;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Green;
                if (HeroHeals > 0) { HeroHeals = dmageByHero; }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ваш герой получил урон! Здоровье: {HeroHeals} HP.");
            }
        }
    }
}
