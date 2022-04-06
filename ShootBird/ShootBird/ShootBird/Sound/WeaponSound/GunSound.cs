using System.Media;
using System.Reflection;

namespace ShootBird.Sound.WeaponSound
{
    /// <summary>
    /// Звуки оружия
    /// </summary>
    internal class GunSound
    {
        private readonly string appDir;


        public GunSound()
        {
            this.appDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        public string AppDir => this.appDir;

        /// <summary>
        /// Звук выстрела пистолета
        /// </summary>
        public void HandGunSound()
        {
            
            var relativePath = @"Sound\WeaponSound\HandGun.wav";
            var fullPath = Path.Combine(AppDir, relativePath);
            SoundPlayer player = new(fullPath);
            player.Play();
        }
        /// <summary>
        /// Звук удара битой
        /// </summary>
        public void BaseballBattSound()
        {
            var relativePath = @"Sound\WeaponSound\HandGun.wav";
            var fullPath = Path.Combine(AppDir, relativePath);
            SoundPlayer player = new(fullPath);
            player.Play();
        }
        /// <summary>
        /// Звук выстрела арбалета
        /// </summary>
        public void CrossbowSound()
        {
            var relativePath = @"Sound\WeaponSound\HandGun.wav";
            var fullPath = Path.Combine(AppDir, relativePath);
            SoundPlayer player = new(fullPath);
            player.Play();
        }
        /// <summary>
        /// Звук выстрела автомата
        /// </summary>
        public void MachineSound()
        {
            var relativePath = @"Sound\WeaponSound\HandGun.wav";
            var fullPath = Path.Combine(AppDir, relativePath);
            SoundPlayer player = new(fullPath);
            player.Play();
        }
        /// <summary>
        /// Звук выстрела пулемета
        /// </summary>
        public void MachineGunSound()
        {
            var relativePath = @"Sound\WeaponSound\HandGun.wav";
            var fullPath = Path.Combine(AppDir, relativePath);
            SoundPlayer player = new(fullPath);
            player.Play();
        }
        /// <summary>
        /// Звук выстрела лука
        /// </summary>
        public void OnionSound()
        {
            var relativePath = @"Sound\WeaponSound\HandGun.wav";
            var fullPath = Path.Combine(AppDir, relativePath);
            SoundPlayer player = new(fullPath);
            player.Play();
        }
        /// <summary>
        /// Звук выстрела дробовика
        /// </summary>
        public void ShotGunSound()
        {
            var relativePath = @"Sound\WeaponSound\HandGun.wav";
            var fullPath = Path.Combine(AppDir, relativePath);
            SoundPlayer player = new(fullPath);
            player.Play();
        }
        /// <summary>
        /// Звук удара лопаты
        /// </summary>
        public void ShovelSound()
        {
            var relativePath = @"Sound\WeaponSound\HandGun.wav";
            var fullPath = Path.Combine(AppDir, relativePath);
            SoundPlayer player = new(fullPath);
            player.Play();
        }
    }
}
