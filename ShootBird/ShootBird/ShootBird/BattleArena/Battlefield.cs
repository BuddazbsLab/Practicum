using L.S.D.Sound.WeaponSound;

namespace L.S.D.BattleArena
{
    /// <summary>
    /// Поле сражения. Где герой и монтср просто стражаются.
    /// </summary>
    internal class Battlefield
    {
        private int heroHeals;
        private int enemyHeals;
        private readonly int heroGunDamage;
        private readonly int enemyDamage;
        private int heroExperience;
        private int enemyExperience;
        private readonly int numberOfShot;
        private readonly int numberOfRoundsInTheClip;

        public Battlefield(int initialHealthHero, int initialHealthEnemy, int heroDamageInEmeny, int reserve)
        {
            heroHeals = initialHealthHero;
            enemyHeals = initialHealthEnemy;
            enemyDamage = 3;
            heroGunDamage = heroDamageInEmeny;
            enemyExperience = 0;
            heroExperience = 0;
            numberOfShot = reserve;
            numberOfRoundsInTheClip = reserve;
        }


        /// <summary>
        /// Начать битву героя и монстра
        /// </summary>
        public async Task StartTheBattleAsync()
        {
            // Повторяющийся код! Плохо!

            for (int i = 0; i < numberOfShot; i++)
            {
                int damageByEnemy = enemyHeals - heroGunDamage;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Атака героем №{i + 1}");
                //GunSound gunSound = new();
                //gunSound.HandGunSound();

                await Task.Delay(TimeSpan.FromSeconds(2));

                if (enemyHeals > 0) { enemyHeals = damageByEnemy; }
                DisplayingTheProgressOfTheBattleHero();

                await Task.Delay(TimeSpan.FromSeconds(2));

                int dmageByHero = heroHeals - enemyDamage;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Атака монстра №{i + 1}");
                await Task.Delay(TimeSpan.FromSeconds(2));


                if (heroHeals > 0) { heroHeals = dmageByHero; }
                DisplayingTheProgressOfTheBattleEnemy();



                await Task.Delay(TimeSpan.FromSeconds(2));
                if (enemyHeals <= 0) break;
            }

            if (enemyHeals <= 0)
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
            Console.WriteLine($"Монстр получил урон! Здоровье: {enemyHeals} HP.");
        }

        private void DisplayingTheProgressOfTheBattleEnemy()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ваш герой получил урон! Здоровье: {heroHeals} HP.");
        }

        /// <summary>
        /// Результат сражения
        /// </summary>
        public int ResultOfTheBattle()
        {
            Console.WriteLine($"У вас осталось здоровья {heroHeals}");
            return heroHeals;
        }

    }
}
