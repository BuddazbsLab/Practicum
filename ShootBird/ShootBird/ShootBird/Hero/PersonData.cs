
namespace ShootBird.Hero
{
    internal class PersonData
    {
        public static string InputName()
        {
            Console.WriteLine("Введите имя персонажа: ");
            string heroName;
            while (true)
            {
                if (!string.IsNullOrWhiteSpace(heroName = Console.ReadLine()))
                    break;
                Console.WriteLine("Введи другое Имя!");
            }
            return heroName;
        }

        public static int InputAge()
        {
            Console.WriteLine("Введите возраст персонажа: ");
            int heroAge;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out heroAge))
                    break;
                Console.WriteLine("Нет нет нет. Не прокатит, введи возраст в цифрах!");
            }
            return heroAge;
        }
    }
}
