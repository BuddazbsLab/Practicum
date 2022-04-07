
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
