using L.S.D.Interface;

namespace L.S.D.Enemy
{
    /// <summary>
    /// Класс Монстра.
    /// </summary>
    internal class HeroEnemy : IEnemy
    {
        private readonly int enemyHelth;
        private string enemyName;
        private int enemyDamage;

        public HeroEnemy(string enemyName)
        {
            this.enemyHelth = 100;
            this.enemyName = enemyName;
            this.enemyDamage = 0;
        }

        public int EnemyHelth => this.enemyHelth;
        public string EnemyName
        {
            get => this.enemyName;
            set => this.enemyName = value;
        }
        public int EnemyDamage
        {
            get => this.enemyDamage;
            set => this.enemyDamage = value;
        }


        /// <summary>
        /// Создание монтсра.
        /// </summary>
        /// <returns>Возращает результат создания монтсра.</returns>
        public async Task CreateEnemyAsync()
        {
            Random random = new Random();
            EnemyDamage = random.Next(5,8);

            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                      Внимание!" +
              "\n Перед Вами появился монстр!" +
             $"\n Имя: {EnemyName} " +
             $"\n Здоровье: {EnemyHelth}" +
             $"\n Урон: {EnemyDamage}");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
        }

        /// <summary>
        /// Стартовое значение зоровья.
        /// </summary>
        /// <returns>Значение здоровья монстра.</returns>
        public int GetEnemyHealth()
        {
            return EnemyHelth;
        }

    }
}
