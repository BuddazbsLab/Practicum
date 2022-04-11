namespace L.S.D.Message.SystemMessage
{
    internal class MyMessage
    {
        public static async Task RemindAsync()
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" Ах да, чуть не забыл. У каждого оружия есть свой лимит, прочность или запас патронов." +
            "\n Если что-то закончится раньше чем монстр умрет, ты проиграешь :)");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
        }
    }
}
