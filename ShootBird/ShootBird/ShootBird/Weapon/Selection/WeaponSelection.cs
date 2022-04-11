using L.S.D.Interface;

namespace L.S.D.Weapon.Selection
{
    sealed internal class WeaponSelection
    {
        public static IWeapons IssueWeaponsToTheHeroOfYourChoice()
        {
            //Предлагаем выбрать оружие герою
            Console.WriteLine("                     Выбери оружие");
            Console.WriteLine($"╔════════════════════════════════╗");
            Console.WriteLine($"║#=#Список начального оружия: #=#║");
            Console.WriteLine($"║════════════════════════════════║");
            Console.WriteLine($"║  [0]-Ржавый меч.               ║");
            Console.WriteLine($"║  [1]-Деревянный арбалет.       ║");
            Console.WriteLine($"║  [2]-Жезл Искр.                ║");
            Console.WriteLine($"╚════════════════════════════════╝");
            Console.WriteLine(">>>");
            int operationType;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out operationType) & operationType < 3)
                    break;
                Console.WriteLine("Необходимо ввести от 0 - 2!");
                Console.WriteLine($"╔════════════════════════════════╗");
                Console.WriteLine($"║#=#Список начального оружия: #=#║");
                Console.WriteLine($"║════════════════════════════════║");
                Console.WriteLine($"║  [0]-Ржавый меч.               ║");
                Console.WriteLine($"║  [1]-Деревянный арбалет.       ║");
                Console.WriteLine($"║  [2]-Жезл Искр.                ║");
                Console.WriteLine($"╚════════════════════════════════╝");
                Console.WriteLine(">>>");
            }
            if (operationType >= 0 || operationType <= 2)
            {
                //operationType = int.Parse(Console.ReadLine());
                AssignFirstWeapon assignFirstWeapon = new(operationType);
                var selectedWeapon = assignFirstWeapon.AssignWeapon();
                return selectedWeapon;
            }
            else
            {
                Console.WriteLine(" Доигрался!\nВыбрано оружие по умолчанию!");
                AssignFirstWeapon assignFirstWeapon = new(0);
                var selectedWeapon = assignFirstWeapon.AssignWeapon();
                return selectedWeapon;
            }
        }
    }
}
