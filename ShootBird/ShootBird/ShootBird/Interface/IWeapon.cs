
namespace ShootBird
{
    internal interface IWeapon
    {
        int Cartridge { get; }
        int StartDamageRange { get; }
        int StartPlayEnemy { get; }

        Task Shot();
    }
}