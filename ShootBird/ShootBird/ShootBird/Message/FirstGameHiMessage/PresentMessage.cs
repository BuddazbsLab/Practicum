﻿namespace L.S.D.Message.FirstGameHiMessage
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
            var logo = @" 
          _____                            _____                                    _____          
         /\    \                          /\    \                                  /\    \         
        /::\____\                        /::\    \                                /::\    \        
       /:::/    /                       /::::\    \                              /::::\    \       
      /:::/    /                       /::::::\    \                            /::::::\    \      
     /:::/    /                       /:::/\:::\    \                          /:::/\:::\    \     
    /:::/    /                       /:::/__\:::\    \                        /:::/  \:::\    \    
   /:::/    /                        \:::\   \:::\    \                      /:::/    \:::\    \   
  /:::/    /                       ___\:::\   \:::\    \                    /:::/    / \:::\    \  
 /:::/    /                       /\   \:::\   \:::\    \                  /:::/    /   \:::\ ___\ 
/:::/____/                       /::\   \:::\   \:::\____\                /:::/____/     \:::|    |
\:::\    \                       \:::\   \:::\   \::/    /                \:::\    \     /:::|____|
 \:::\    \                       \:::\   \:::\   \/____/                  \:::\    \   /:::/    / 
  \:::\    \                       \:::\   \:::\    \                       \:::\    \ /:::/    /  
   \:::\    \                       \:::\   \:::\____\                       \:::\    /:::/    /   
    \:::\    \                       \:::\  /:::/    /                        \:::\  /:::/    /    
     \:::\    \                       \:::\/:::/    /                          \:::\/:::/    /     
      \:::\    \                       \::::::/    /                            \::::::/    /      
       \:::\____\                       \::::/    /                              \::::/    /       
        \::/    /                        \::/    /                                \::/____/        
         \/____/                          \/____/                                                
                       ___                             ___                                       ___ 
                      |\__\                           |\__\                                     |\__\
                      \|__|                           \|__|                                     \|__|
";




            var welcomeMessageForPlayer = @"╔═════════════════════════════════════════════════════════════════════════════════╗
║Приветствую тебя в игре Live.Survive.Die!                                        ║
║Ты попал в петлю и нужно выбраться из нее убивая монстров                        ║
║P.S.                                                                             ║
║Ни один монстр не пострадал в этой игре. Просто они позже придут за тобой :)     ║
╚═════════════════════════════════════════════════════════════════════════════════╝";
            var gameconditionMessage = @"║Условия игры:                                                                    ║
║Одна жизнь. Одна попытка убить монстра!                                          ║
║На выбор дается оружие. Список:                                                  ║
║Бита                                                                             ║
║Пистолет                                                                         ║
║Лопата                                                                           ║
║А теперь перейдем к твоему герою собственно.                                     ║
╚═════════════════════════════════════════════════════════════════════════════════╝";


            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(logo.ToString());
            await Task.Delay(TimeSpan.FromSeconds(6));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(welcomeMessageForPlayer);
            // Console.Out.FlushAsync();
            await Task.Delay(TimeSpan.FromSeconds(6));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(gameconditionMessage);
        }
    }
}
