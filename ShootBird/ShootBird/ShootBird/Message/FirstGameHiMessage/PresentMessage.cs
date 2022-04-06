﻿namespace ShootBird
{
    /// <summary>
    /// Приветственные сообщения
    /// </summary>
   sealed internal class PresentMessage
    {

        /// <summary>
        /// Вывод сообщений на конслоль
        /// </summary>
        /// <returns></returns>
        public static async void SendWelcomeMessageForPlayer()
        {

            var welcomeMessageForPlayer = @"Приветствую тебя!
Ты попал в петлю и нужно выбраться из нее убивая монстров
P.S.
Ни один монстр не пострадал в этой игре. Просто они позже придут за тобой :)";

            var gameconditionMessage = @"Условия игры:
Одна жизнь. Одна попытка убить монстра!
Случайным образом выдается оружие. Список:
Бита 
Пистолет 
Арбалет
Лопата
Автомат
Пулемет
Лук
Дробовик
А теперь перейдем к твоему герою собственно.";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(welcomeMessageForPlayer);
           // Console.Out.FlushAsync();
            await Task.Delay(TimeSpan.FromSeconds(6));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(gameconditionMessage);
        }
    }
}
