namespace L.S.D.Interface
{
    internal interface IHeroPerson
    {
        int Helth { get; }
        int HeroAge { get; }
        string HeroName { get; }
        int HeroLevel { get; }
        int HeroArmor { get; }
        int HeroExperience { get; }
        int HeroCoin { get; }

        Task CreateHeroAsync();
    }
}