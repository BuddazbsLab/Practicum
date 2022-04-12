namespace L.S.D.BattleArena
{
    internal class AliveOrNot
    {
        private int newHeroHeals;
        private int newHeroArmor;

        public AliveOrNot(int newHeroHeals, int newHeroArmor)
        {
            this.newHeroHeals = newHeroHeals;
            this.newHeroArmor = newHeroArmor;
        }

        public int NewHeroHeals
        {
            get { return newHeroHeals; }
            set { newHeroHeals = value; }
        }

        public int NewHeroArmor
        {
            get { return newHeroArmor; }
            set { newHeroArmor = value; }
        }

        public void CheckingHeroAliveOrNot()
        {
            if (NewHeroHeals > 0)
            {
                if (NewHeroArmor <= 0)
                {
                    NewHeroArmor = 0;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
                Console.WriteLine("                         Поздравялю! Вы убили монстра!");
                Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
            }
        }      
    }
}
