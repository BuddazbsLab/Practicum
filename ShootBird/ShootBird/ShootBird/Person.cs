namespace ShootBird
{
    internal class Person
    {
        private readonly int helth;
        private readonly string playerName;

        public Person(string playerName)
        {
            this.playerName = playerName;
            this.helth = 100;
        }

        public async Task CreatePersonAsync()
        {
            Console.WriteLine($"Поздравлеям!" +
             $"\nСоздан персонаж: " +
             $"\nИмя: {this.playerName} " +
             $"\nЗдоровье: {this.helth}");
            await Task.Delay(TimeSpan.FromMilliseconds(10000));
        }

    }
}
