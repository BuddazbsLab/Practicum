using ShootBird.Gun;
using ShootBird.Weapon;

namespace ShootBird.Randomizer.RandWeapon
{
    internal class RandomWeapon
    {
        private int startPlayEnemy;
        private int сartridge;

        public RandomWeapon(int startPlayEnemy, int сartridge)
        {
            this.startPlayEnemy = startPlayEnemy;
            this.сartridge = сartridge;
        }

        public int StartPlayEnemy { get { return startPlayEnemy; } }
        public int? Cartridge { get { return сartridge; } }
        public IWeapon TakeWeapon()
        {
            var weapons = new IWeapon[]
            {
                new BaseballBat(StartPlayEnemy, Cartridge),
                new Crossbow(StartPlayEnemy, Cartridge),
                new HandGun(StartPlayEnemy, Cartridge),
                new Machine(StartPlayEnemy, Cartridge),
                new MachineGun(StartPlayEnemy, Cartridge),
                new Onion(StartPlayEnemy, Cartridge),
                new Shotgun(StartPlayEnemy, Cartridge),
                new Shovel(StartPlayEnemy, Cartridge),
            };

            Random random = new Random();
            var weapon = weapons[random.Next(0, 7)];
            return weapon;
        }
    }
}

