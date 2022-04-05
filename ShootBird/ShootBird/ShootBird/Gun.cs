namespace ShootBird
{
    /// <summary>
    /// Оружие
    /// </summary>
    internal class Gun : IGun
    {
        private int startPlayEnemy;
        private readonly int? сartridge;
        private readonly int startDamageRange;
        private readonly int endDamageRange;

        public Gun(int startPlayEnemy, int? сartridge)
        {
            this.startPlayEnemy = startPlayEnemy;
            this.startDamageRange = 1;
            this.endDamageRange = 5;
            this.сartridge = сartridge;
        }

        public int StartPlayEnemy { get { return startPlayEnemy; } }
        public int StartDamageRange { get { return startDamageRange; } }
        private int EndDamageRange { get { return endDamageRange; } }
        public int Cartridge { get { return (int)сartridge; } }

        /// <summary>
        /// Производим выстрел во врага
        /// </summary>
        /// <returns>Выводим результат выстрела</returns>
        public async Task Shot()
        {
            Random random = new();

            for (int i = 0; i < Cartridge; i++)
            {
                int randomDamage = random.Next(StartDamageRange, EndDamageRange);
                int damage = StartPlayEnemy - randomDamage;
                Console.WriteLine($"Выстрел {i + 1}");
                Console.Beep();

                await Task.Delay(TimeSpan.FromMilliseconds(400));
                if (StartPlayEnemy > 0) { this.startPlayEnemy = damage; }

                ShowDamageHealth();
                await Task.Delay(TimeSpan.FromMilliseconds(400));
                if (StartPlayEnemy <= 0) break;
            }
            if (StartPlayEnemy <= 0) { Console.WriteLine("Вы выйграли"); }
            else { Console.WriteLine("Враг остался жив а Вы умерли. Кек :)"); }

        }
        /// <summary>
        /// Статистика монстра
        /// </summary>
        private void ShowDamageHealth()
        {
            Console.WriteLine($"Монстр получил урон! Здоровье: {this.startPlayEnemy} хп.");
        }


    }
}
