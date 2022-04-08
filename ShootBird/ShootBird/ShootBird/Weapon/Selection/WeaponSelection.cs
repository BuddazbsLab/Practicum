using ShootBird.Gun;

namespace ShootBird.Weapon.Selection
{
    internal class WeaponSelection
    {
        public static IWeapons IssueWeaponsToTheHeroOfYourChoice()
        {
            //Предлагаем выбрать оружие герою
            Console.WriteLine("                     Выбери оружие");
            Console.WriteLine($"╔════════════════════════════════╗");
            Console.WriteLine($"║#=#Список начального оружия: #=#║");
            Console.WriteLine($"║════════════════════════════════║");
            Console.WriteLine($"║  [0]-Бита.                     ║");
            Console.WriteLine($"║  [1]-Лопата.                   ║");
            Console.WriteLine($"║  [2]-Пистолет.                 ║");
            Console.WriteLine($"╚════════════════════════════════╝");
            Console.WriteLine(">>>");
            int operationType = int.Parse(Console.ReadLine());

            //re-typing the operation if its invalid
            while (operationType < 0 || operationType > 2)
            {
                Console.WriteLine($"╔════════════════════════════════╗");
                Console.WriteLine($"║#=#Список начального оружия: #=#║");
                Console.WriteLine($"║════════════════════════════════║");
                Console.WriteLine($"║  [0]-Бита.                     ║");
                Console.WriteLine($"║  [1]-Лопата.                   ║");
                Console.WriteLine($"║  [2]-Пистолет.                 ║");
                Console.WriteLine($"╚════════════════════════════════╝");
                Console.WriteLine(">>>");
                operationType = int.Parse(Console.ReadLine());
            }
            AssignFirstWeapon assignFirstWeapon = new(operationType);
            var selectedWeapon = assignFirstWeapon.AssignWeapon();
            return selectedWeapon;
        }
    }
}
