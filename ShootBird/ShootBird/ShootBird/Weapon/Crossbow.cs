

using ShootBird.Sound.WeaponSound;

namespace ShootBird.Weapon
{
    internal class Crossbow : IWeapon
    {
        private int startPlayEnemy;
        private readonly int? сartridge;
        private readonly int startDamageRange;
        private readonly int endDamageRange;

        public Crossbow(int startPlayEnemy, int? сartridge)
        {
            this.startPlayEnemy = startPlayEnemy;
            this.startDamageRange = 1;
            this.endDamageRange = 2;
            this.сartridge = сartridge;
        }

        public int StartPlayEnemy { get { return startPlayEnemy; } }
        public int StartDamageRange { get { return startDamageRange; } }
        private int EndDamageRange { get { return endDamageRange; } }
        public int Cartridge { get { return (int)сartridge; } }

        /// <summary>
        /// Производим выстрел во врага.
        /// </summary>
        /// <returns>Вывод результата выстрела.</returns>
        public async Task Shot()
        {
            Random random = new();

            for (int i = 0; i < Cartridge; i++)
            {
                int randomDamage = random.Next(StartDamageRange, EndDamageRange);
                int damage = StartPlayEnemy - randomDamage;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Выстрел из арбалета {i + 1}");
                GunSound gunSound = new();
                gunSound.HandGunSound();

                await Task.Delay(TimeSpan.FromMilliseconds(800));
                if (StartPlayEnemy > 0) { this.startPlayEnemy = damage; }

                ShowDamageHealth();
                await Task.Delay(TimeSpan.FromMilliseconds(400));
                if (StartPlayEnemy <= 0) break;
            }
            if (StartPlayEnemy <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Вы выйграли");
            }
            else { Console.WriteLine("Враг остался жив а Вы умерли. Кек :)"); }

        }
        /// <summary>
        /// Вывод статистики после выстрела во врага.
        /// </summary>
        private void ShowDamageHealth()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Монстр получил урон! Здоровье: {this.startPlayEnemy} хп.");
        }
    }
}
