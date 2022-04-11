namespace L.S.D.PlayerActions
{
    internal class BeatDontbeat
    {
        public static int MakeAChoice()
        {
            //Предлагаем выбрать оружие герою
            Console.WriteLine($"╔════════════════════════════════╗");
            Console.WriteLine($"║#=#        Что делаем?       #=#║");
            Console.WriteLine($"║════════════════════════════════║");
            Console.WriteLine($"║  [0]-Убить.                    ║");
            Console.WriteLine($"║  [1]-Попробовать убежать.      ║");
            Console.WriteLine($"║  [2]-Сдаться.                  ║");
            Console.WriteLine($"╚════════════════════════════════╝");
            Console.WriteLine(">>>");
            int operationType = int.Parse(Console.ReadLine());
            return operationType;
        }
    }
}
