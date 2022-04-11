using System.Media;
using System.Reflection;

namespace L.S.D.Sound.FoneSound
{
    /// <summary>
    /// Фоновая музыка игры
    /// </summary>
    internal class FoneGameSound
    {
        /// <summary>
        /// Фоновый звук
        /// </summary>
        public static async Task PlayFoneGameSound()
        {
            var appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var relativePath = @"Sound\FoneSound\GameFoneSound.wav";
            var fullPath = Path.Combine(appDir, relativePath);
            SoundPlayer player = new(fullPath);
            while (true)
            {
#pragma warning disable CA1416 // Проверка совместимости платформы
                player.Play();
#pragma warning restore CA1416 // Проверка совместимости платформы
                await Task.Delay(TimeSpan.FromMinutes(3));
            }

        }
    }
}
