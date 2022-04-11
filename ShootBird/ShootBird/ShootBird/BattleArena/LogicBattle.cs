namespace L.S.D.BattleArena
{
    internal class LogicBattle
    {
        private int heroHeals;
        private int enemyHeals;
        private int heroArmor;
        private int enemyDamage;
        private int heroDamage;

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

        public int EnemyDamage { get; }

        public int HeroAttak()
        {
            int damageByEnemy = EnemyHeals - HeroDamage;
            Console.ForegroundColor = ConsoleColor.Green;
            if (EnemyHeals > 0) { EnemyHeals = damageByEnemy; }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Монстр получил урон! Здоровье: {EnemyHeals} HP.");
            return EnemyHeals;

        }

        public int EnemyAttak()
        {
            if (HeroArmor > 0)
            {
                HeroArmor -= enemyDamage;
                int dmageByHero = HeroHeals + HeroArmor - enemyDamage;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Green;
                if (HeroHeals > 0) { HeroHeals = dmageByHero; }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ваш герой получил урон! Здоровье: {HeroHeals} HP.");
            }
            else
            {
                int dmageByHero = HeroHeals - enemyDamage;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Green;
                if (HeroHeals > 0) { HeroHeals = dmageByHero; }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ваш герой получил урон! Здоровье: {HeroHeals} HP.");
            }

            return HeroHeals;
        }
    }
}
