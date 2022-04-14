namespace L.S.D.BattleArena
{
    internal class LogicBattle
    {
        private int heroHeals;
        private int enemyHeals;
        private int heroArmor;
        private readonly int enemyDamage;
        private readonly int heroDamage;

        public LogicBattle(
                             int heroHeals,
                             int enemyHeals,
                             int heroArmor,
                             int heroDamage,
                             int enemyDamage
                           )
        {
            this.heroHeals = heroHeals;
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
            if (EnemyHeals > 0) { EnemyHeals = damageByEnemy; }

        }

        public void EnemyAttak()
        {
            if (HeroArmor > 0)
            {
                HeroArmor -= EnemyDamage;
                int dmageByHero = HeroHeals;
                if (HeroHeals > 0) { HeroHeals = dmageByHero; }
            }
            else
            {
                int dmageByHero = HeroHeals - EnemyDamage;
                if (HeroHeals > 0) { HeroHeals = dmageByHero; }
            }
        }
    }
}
