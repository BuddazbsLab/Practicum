using ShootBird.Randomizer.Name;

namespace ShootBird
{
    /// <summary>
    /// Генератор имен
    /// </summary>
    internal class GeneratorNameEnemy
    {
        public static string GenerateEnemyName()
        {
            RandomName randomName = new RandomName();
            return randomName.Generate(); // Мужское имя.             
        }
    }
}
