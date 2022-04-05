namespace ShootBird
{
    /// <summary>
    /// Приветственные сообщения
    /// </summary>
   sealed internal class Message
    {

        /// <summary>
        /// Вывод сообщений на конслоль
        /// </summary>
        /// <returns></returns>
        public static async void SendWelcomeMessageForPlayer()
        {

            var welcomeMessageForPlayer = "Приветствую тебя!" +
                "\nТы попал в петлю и нужно выбраться из нее убивая монстров." +
                "\nP.S." +
                "\nНи один монстр не пострадала в этой игре. Просто они позже придут за тобой :)";

            var gameconditionMessage = "\nУсловия игры: " +
                "\nОдна жизнь. Одна попытка убить монстра!" +
                "\nА теперь перейдем к твоему герою собственно.";

            Console.WriteLine(welcomeMessageForPlayer);
            await Task.Delay(300);
            Console.WriteLine(gameconditionMessage);

        }
    }
}
