
namespace ShootBird
{
    internal interface IHeroPerson
    {
        int Helth { get; }
        int HeroAge { get; }
        string HeroGender { get; }
        string HeroName { get; }
        string Species { get; }

        Task CreateHeroAsync();
    }
}