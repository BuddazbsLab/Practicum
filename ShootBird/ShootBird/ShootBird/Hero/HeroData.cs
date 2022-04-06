
namespace ShootBird.Hero
{
    internal class HeroData
    {
        public static string InputName()
        {
            Console.WriteLine("Введите имя персонажа: ");
            string heroName = Console.ReadLine();
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
                Console.WriteLine("Нет нет нет. Не прокатит, введи возраст в цифрах");
            }
            return heroAge;
        }

        public static string InputSpecies()
        {
            Console.WriteLine("Введите расу персонажа: ");
            string species = Console.ReadLine();
            return species;
        }

        public static string InputHeroGender()
        {
            Console.WriteLine("Введите гендерную предрасположенность персонажа: ");
            string heroGender = Console.ReadLine();
            return heroGender;
        }

        public static int InputCartridge()
        {
            Console.WriteLine("Врага нужно срочно убить или он убьет Вас! \n Сколько выстрелов сделать?");
            //Задаем колличество выстрелов
            int сartridge;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out сartridge))
                    break;
                Console.WriteLine("Нет нет нет. Не прокатит, введи цифорками.");
            }
            return сartridge;
        }
    }
}
