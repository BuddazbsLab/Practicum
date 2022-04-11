namespace L.S.D.Interface
{
    internal interface IHeroPerson
    {
        int Helth { get; }
        int HeroAge { get; }
        string HeroName { get; }

        Task CreateHeroAsync();
    }
}