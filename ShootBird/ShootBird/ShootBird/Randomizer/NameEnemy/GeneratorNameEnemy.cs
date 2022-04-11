using L.S.D.Randomizer.Name;

namespace L.S.D.Randomizer.NameEnemy
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
