using ShootBird.Gun;
using ShootBird.Weapon;

namespace ShootBird.Randomizer.RandWeapon
{
    internal class RandomWeapon
    {
        public static IWeapons TakeWeapon()
        {
            var weapons = new IWeapons[]
            {
                new BaseballBat(),
                new Crossbow(),
                new HandGun(),
                new Machine(),
                new MachineGun(),
                new Onion(),
                new Shotgun(),
                new Shovel(),
            };

            Random random = new();
            var weapon = weapons[random.Next(0, 7)];
            return weapon;
        }
    }
}

