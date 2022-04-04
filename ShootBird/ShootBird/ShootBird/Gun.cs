namespace ShootBird
{
    internal class Gun
    {
        private int startPlayBird;
        private readonly int? сartridge;
        private readonly int startDamageRange;
        private readonly int endDamageRange;

        public Gun(int startPlayBird, int? сartridge)
        {
            this.startPlayBird = startPlayBird;
            this.startDamageRange = 1;
            this.endDamageRange = 5;
            this.сartridge = сartridge;
        }

        public async Task Shot()
        {
            Random random = new();
            
            for (int i = 0; i < this.сartridge; i++)
            {
                int randomDamage = random.Next(this.startDamageRange, this.endDamageRange);
                int damage = this.startPlayBird - randomDamage;
                Console.WriteLine($"Выстрел {i+1}");
                Console.Beep();

                await Task.Delay(TimeSpan.FromMilliseconds(800));
                if (this.startPlayBird > 0) { this.startPlayBird = damage; }

                ShowDamageHealth();
                await Task.Delay(TimeSpan.FromMilliseconds(800));                
            }
            if (this.startPlayBird <= 0) { Console.WriteLine("Вы выйграли");}
            else { Console.WriteLine("Враг остался жив а Вы умерли. Кек :)");}

        }

        private void ShowDamageHealth()
        {
            Console.WriteLine($"Нанесен урон врагу. Здоровье: {this.startPlayBird} хп.");
        }


    }
}
