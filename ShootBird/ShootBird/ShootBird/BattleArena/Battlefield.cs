﻿namespace L.S.D.BattleArena
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
        private int heroCoin;
        #endregion

        #region Конструктор
        public Battlefield(int initialHealthHero, int initialHealthEnemy, int heroDamageInEmeny, int reserveWeapon, int enemyDamage, int initHeroExperience, int initialLevelHero, int heroCoin)
        {
            this.heroHeals = initialHealthHero;
            this.enemyHeals = initialHealthEnemy;
            this.enemyDamage = enemyDamage;
            this.heroGunDamage = heroDamageInEmeny;
            this.enemyExperience = 99;
            this.heroExperience = initHeroExperience;
            this.reserveWeapon = reserveWeapon;
            this.heroArmor = 0;
            this.heroLvl = initialLevelHero;
            this.heroCoin = 0;
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
            set { this.heroExperience = value; }
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
        public int HeroLevel
        {
            get { return this.heroLvl; }
            set { this.heroLvl = value; }
        }

        public int HeroCoin
        {
            get { return this.heroCoin; }
            set { this.heroCoin = value; }
        }
        #endregion


        /// <summary>
        /// Начать битву героя и монстра
        /// </summary>
        public async Task StartTheBattleAsync()
        {
            LogicBattle logicBattle = new(HeroHeals, EnemyHeals, HeroArmor, HeroDamage, EnemyDamage);
            for (int i = 0; i < ReserveWeapon; i++)
            {
                // ататка героя
                Console.ForegroundColor = ConsoleColor.Green;
                logicBattle.HeroAttak();
                EnemyHeals = logicBattle.EnemyHeals;

                //Уменьшаем (стрелы, прочночть, заряды)
                ReserveWeapon -= i + 1;

                //GunSound gunSound = new();
                //gunSound.HandGunSound();

                //Атака монстра
                Console.ForegroundColor = ConsoleColor.Green;
                logicBattle.EnemyAttak();
                HeroHeals = logicBattle.HeroHeals;
                if (EnemyHeals <= 0) break;
            }
            if (EnemyHeals <= 0)
            {
                //Получаеи новое значение брони
                HeroArmor = logicBattle.HeroArmor;
                //передаем новое значение жизни и брони для проверки
                AliveOrNot aliveOrNot = new(HeroHeals, HeroArmor);
                //проверяем состояние героя
                aliveOrNot.CheckingHeroAliveOrNot();
                //Присваиваем новые значения после проверки и обновляем свойства
                if (HeroArmor < 0)
                {
                    HeroHeals = aliveOrNot.NewHeroHeals + HeroArmor;
                }
                HeroArmor = aliveOrNot.NewHeroArmor;
            }
            else if (EnemyHeals > 0)
            {
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("                          Враг оказался сильнее и убил Вас!");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
                await Task.Delay(TimeSpan.FromSeconds(3));

                //Предлагаем выбрать оружие герою
                Console.WriteLine($"╔════════════════════════════════╗");
                Console.WriteLine($"║#=#  Начать игру повторно?   #=#║");
                Console.WriteLine($"║════════════════════════════════║");
                Console.WriteLine($"║  [0]-Да.                       ║");
                Console.WriteLine($"║  [1]-Нет.                      ║");
                Console.WriteLine($"╚════════════════════════════════╝");
                Console.WriteLine(">>>");
                int operationType;
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out operationType) & operationType < 2)
                        break;
                    Console.WriteLine($"╔════════════════════════════════╗");
                    Console.WriteLine($"║#=#  Начать игру повторно?   #=#║");
                    Console.WriteLine($"║════════════════════════════════║");
                    Console.WriteLine($"║  [0]-Да.                       ║");
                    Console.WriteLine($"║  [1]-Нет.                      ║");
                    Console.WriteLine($"╚════════════════════════════════╝");
                    Console.WriteLine(">>>");
                }
                if (operationType == 0)
                {
                    await Story.NewStory();
                }
                else
                {
                    //Звершаем игру
                    Environment.Exit(0);
                }
            }

        }
        /// <summary>
        /// Результат сражения
        /// </summary>
        public void ResultOfTheBattle()
        {
            Random random = new Random();
            GameCoin gameCoin = new GameCoin(HeroCoin, HeroLevel);
            HeroCoin = gameCoin.AssignGameCoin();
            EnemyExperians = random.Next(1, 7) * HeroLevel;
            HeroExperiance += EnemyExperians;
            if (HeroExperiance >= 100)
            {
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine($"                          Поздравляю! Уровень героя повышен.");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
                HeroLevel++;
                HeroExperiance -= 100;
            }
            Console.WriteLine($" Показатели героя:");
            Console.WriteLine($" Здоровье: [{HeroHeals}]");
            Console.WriteLine($" Броня: [{HeroArmor}]");
            Console.WriteLine($" Уровенеь героя: [{HeroLevel}]");
            Console.WriteLine($" Получено очков опыта: [{HeroExperiance} из 100]");
            Console.WriteLine($" Получена Braghma: [{HeroCoin}]");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
        }

    }
}
