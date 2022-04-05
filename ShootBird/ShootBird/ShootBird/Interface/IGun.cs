
namespace ShootBird
{
    internal interface IGun
    {
        int Cartridge { get; }
        int StartDamageRange { get; }
        int StartPlayEnemy { get; }

        Task Shot();
    }
}