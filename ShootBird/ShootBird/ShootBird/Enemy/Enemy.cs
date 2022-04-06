namespace ShootBird
{
    /// <summary>
    /// Класс Монстра.
    /// </summary>
    internal class HeroEnemy : IEnemy
    {
        private readonly int enemyHelth;
        private readonly string enemyName;

        public HeroEnemy(string enemyName)
        {
            this.enemyHelth = 100;
            this.enemyName = enemyName;
        }

        public int EnemyHelth => this.enemyHelth;
        public string EnemyName => this.enemyName;


        /// <summary>
        /// Создание монтсра.
        /// </summary>
        /// <returns>Возращает результат создания монтсра.</returns>
        public async Task CreateEnemyAsync()
        {
            Console.WriteLine("Внимание!" +
             $"\nПеред Вами появился монстр!" +
             $"\nИмя: {EnemyName} " +
             $"\nЗдоровье: {EnemyHelth}");
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
