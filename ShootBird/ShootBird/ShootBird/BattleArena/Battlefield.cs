using ShootBird.Sound.WeaponSound;

namespace ShootBird
{
    /// <summary>
    /// Поле сражения. Где герой и монтср просто стражаются.
    /// </summary>
    internal class Battlefield
    {
        private int heroHeals;
        private int enemyHeals;
        private int heroGunDamage;
        private int enemyDamage;
        private int heroExperience;
        private int enemyExperience;
        private int numberOfShot;
        private int numberOfRoundsInTheClip;

        public Battlefield(int initialHealthHero, int initialHealthEnemy, int heroDamageInEmeny, int reserve)
        {
            this.heroHeals = initialHealthHero;
            this.enemyHeals = initialHealthEnemy;
            this.enemyDamage = 3;
            this.heroGunDamage = heroDamageInEmeny;
            this.enemyExperience = 0;
            this.heroExperience = 0;
            this.numberOfShot = reserve;
            this.numberOfRoundsInTheClip = reserve;
        }


        /// <summary>
        /// Начать битву героя и монстра
        /// </summary>
        public async Task StartTheBattleAsync()
        {
            // Повторяющийся код! Плохо!

            for(int i = 0; i < numberOfShot; i++)
            {
                int damageByEnemy = this.enemyHeals - this.heroGunDamage;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Атака героем №{i + 1}");
                GunSound gunSound = new();
                gunSound.HandGunSound();

                await Task.Delay(TimeSpan.FromSeconds(2));

                if (this.enemyHeals > 0) { this.enemyHeals = damageByEnemy;}
                DisplayingTheProgressOfTheBattleHero();

                await Task.Delay(TimeSpan.FromSeconds(2));

                int dmageByHero = this.heroHeals - this.enemyDamage;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Атака монстра №{i + 1}");
                await Task.Delay(TimeSpan.FromSeconds(2));


                if (this.heroHeals > 0) { this.heroHeals = dmageByHero; }
                DisplayingTheProgressOfTheBattleEnemy();



                await Task.Delay(TimeSpan.FromSeconds(2));
                if (this.enemyHeals <= 0) break;
            }

            if (this.enemyHeals <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Вы выйграли");
                await Task.Delay(TimeSpan.FromSeconds(4));

            }
            else { Console.WriteLine("Враг остался жив а Вы умерли. Кек :)"); }
        }

        /// <summary>
        /// Вывод статистики после атаки на врага.
        /// </summary>
        private void DisplayingTheProgressOfTheBattleHero()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Монстр получил урон! Здоровье: {this.enemyHeals} HP.");
        }

        private void DisplayingTheProgressOfTheBattleEnemy()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ваш герой получил урон! Здоровье: {this.heroHeals} HP.");
        }

        /// <summary>
        /// Результат сражения
        /// </summary>
        public int ResultOfTheBattle()
        {
            Console.WriteLine($"У вас осталось здоровья {this.heroHeals}");
            return this.heroHeals;
        }

    }
}
