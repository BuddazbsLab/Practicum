using L.S.D.Interface;
using L.S.D.Weapon;

namespace L.S.D.Randomizer.RandWeapon
{
    internal class RandomWeapon
    {
        public static IWeapons TakeWeapon()
        {
            var weapons = new IWeapons[]
            {
                new RustySword(),
                new Crossbow(),
                new RodOfSparks(),
                new Machine(),
                new MachineGun(),
                new Onion(),
                new Shotgun(),
                new RodOfSparks(),
            };

            Random random = new();
            var weapon = weapons[random.Next(0, 7)];
            return weapon;
        }
    }
}

