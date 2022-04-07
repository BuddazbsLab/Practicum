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
            this.enemyDamage = 0;
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

            for(int i = 0; i < numberOfShot; i++)
            {
                int damageByEnemy = this.enemyHeals - this.heroGunDamage;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Атака героем №{i + 1}");
                GunSound gunSound = new();
                gunSound.HandGunSound();

                await Task.Delay(TimeSpan.FromMilliseconds(800));

                if(this.enemyHeals > 0) { this.enemyHeals = damageByEnemy;}

                DisplayingTheProgressOfTheBattle();
                await Task.Delay(TimeSpan.FromMilliseconds(400));
                if (this.enemyHeals <= 0) break;
            }

            if (this.enemyHeals <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Вы выйграли");
            }
            else { Console.WriteLine("Враг остался жив а Вы умерли. Кек :)"); }
        }

        /// <summary>
        /// Вывод статистики после выстрела во врага.
        /// </summary>
        private void DisplayingTheProgressOfTheBattle()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Монстр получил урон! Здоровье: {this.enemyHeals} хп.");
        }

        /// <summary>
        /// Результат сражения
        /// </summary>
        public void ResultOfTheBattle()
        {

        }

    }
}
