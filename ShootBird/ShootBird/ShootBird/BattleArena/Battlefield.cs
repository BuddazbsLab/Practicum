using L.S.D.Sound.WeaponSound;

namespace L.S.D.BattleArena
{
    /// <summary>
    /// Поле сражения.
    /// </summary>
    internal class Battlefield
    {
        #region Поля класса
        private int heroHeals;
        private int enemyHeals;
        private readonly int heroGunDamage;
        private readonly int enemyDamage;
        private int heroExperience;
        private int enemyExperience;
        private int reserveWeapon;
        private int heroArmor;
        private int heroLvl;
        #endregion

        #region Конструктор
        public Battlefield(int initialHealthHero, int initialHealthEnemy, int heroDamageInEmeny, int reserveWeapon)
        {
            this.heroHeals = initialHealthHero;
            this.enemyHeals = initialHealthEnemy;
            this.enemyDamage = 3;
            this.heroGunDamage = heroDamageInEmeny;
            this.enemyExperience = 0;
            this.heroExperience = 0;
            this.reserveWeapon = reserveWeapon;
            this.heroArmor = 0;
            this.heroLvl = 0;
        }
        #endregion

        #region Свойства
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
        public int HeroDamage => this.heroGunDamage;
        public int EnemyDamage => this.enemyDamage;
        public int HeroExperiance
        {
            get { return this.heroExperience; }
            set { this.heroExperience = value;}
        }
        public int EnemyExperians
        {
            get { return this.enemyExperience; }
            set { this.enemyExperience = value; }
        }

        public int HeroArmor
        {
            get { return this.heroArmor; }
            set { this.heroArmor = value; }
        }

        public int ReserveWeapon
        {
            get { return this.reserveWeapon; }
            set { this.reserveWeapon = value; }
        }
        #endregion


        /// <summary>
        /// Начать битву героя и монстра
        /// </summary>
        public async Task StartTheBattleAsync()
        {
            // Повторяющийся код! Плохо!
            LogicBattle logicBattle = new(HeroHeals, EnemyHeals, HeroArmor, HeroDamage, EnemyDamage);
            for (int i = 0; i < ReserveWeapon; i++)
            {
               // ататка героя
                Console.ForegroundColor = ConsoleColor.Green;
                await Task.Delay(TimeSpan.FromSeconds(1));
                Console.WriteLine($"Атака героем №{i + 1}");
                await Task.Delay(TimeSpan.FromSeconds(1));
                logicBattle.HeroAttak();
                EnemyHeals = logicBattle.EnemyHeals;

                //Уменьшаем (стрелы, прочночть, заряды)
                ReserveWeapon -= i + 1;

                //GunSound gunSound = new();
                //gunSound.HandGunSound();

                //Атака монстра
                await Task.Delay(TimeSpan.FromSeconds(1));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Атака монстра №{i + 1}");
                await Task.Delay(TimeSpan.FromSeconds(1));
                logicBattle.EnemyAttak();
                HeroHeals = logicBattle.HeroHeals;
                
                if (EnemyHeals <= 0) break;               
            }
            if (EnemyHeals <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Вы выйграли");
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
            else { Console.WriteLine("Враг остался жив а Вы умерли. Кек :)"); }
        }
        /// <summary>
        /// Результат сражения
        /// </summary>
        public void ResultOfTheBattle()
        {
            Random random = new Random();
            int getEnemyExpireance = random.Next(1, 3);
            int newHeroExpireance = HeroExperiance + getEnemyExpireance;
            Console.WriteLine($"У вас осталось здоровья {HeroHeals}");
            Console.WriteLine($"У вас осталось Брони {HeroArmor}");
            Console.WriteLine($"Получено очков опыта {newHeroExpireance}");
            Console.WriteLine($"Ваш уровень: {this.heroLvl}");
        }

    }
}
