namespace L.S.D.BattleArena
{
    internal class GameCoin
    {
        private int heroCoin;
        private readonly int heroLevl;

        public GameCoin(int heroCoin, int heroLevl)
        {
            this.heroCoin = heroCoin;
            this.heroLevl = heroLevl;
        }

        public int HeroCoin
        {
            get { return heroCoin; }
            set { heroCoin = value; }
        }
        public int HeroLevl => this.heroLevl;

        public int AssignGameCoin()
        {
            Random random = new();
            if (HeroLevl >= 1)
            {
                HeroCoin = random.Next(1, 10) * HeroLevl;
            }
            return HeroCoin;
        }
    }
}
