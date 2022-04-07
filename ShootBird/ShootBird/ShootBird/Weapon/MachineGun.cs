namespace ShootBird.Gun
{
    internal class MachineGun : IWeapons
    {
        private readonly int endurance;
        private readonly int minDamageRange;
        private readonly int maxDamageRange;
        private readonly string weaponName;

        public MachineGun()
        {
            this.endurance = 70;
            this.minDamageRange = 20;
            this.maxDamageRange = 25;
            this.weaponName = "Пулемет";
        }

        public int Endurance => this.endurance;
        public int MinDamageRange => this.minDamageRange;
        public int MaxDamageRange => this.maxDamageRange;
        public string WeaponName => this.weaponName;

        /// <summary>
        /// Производим выстрел во врага.
        /// </summary>
        /// <returns>Вывод результата выстрела.</returns>
        public (int Endurance, int Damage) Attack()
        {
            Random random = new();
            int damage = random.Next(MinDamageRange, MaxDamageRange);
            return (Endurance, damage);
        }
        /// <summary>
        /// Информация о оружии
        /// </summary>
        public void AboutWeapon()
        {
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                Получено новое оружие: ");
            Console.WriteLine($"\n {WeaponName}" +
                              $"\n Прочность: {Endurance}" +
                              $"\n Урон: {MinDamageRange} - {MaxDamageRange}");
            Console.WriteLine("                                                  Получено достижение 'Оружейник!'");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
        }
    }
}
