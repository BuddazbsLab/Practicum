namespace ShootBird
{
   sealed internal class Message
    {
        public string? WelcomeMessageForPlayer { get; set; }
        public string? GameconditionMessage { get; set; }
        public static  Message SendWelcomeMessageForPlayer()
        {

            var welcomeMessageForPlayer = "Приветствую тебя мой друг." +
                "\nВ этой игре мы будем стрелять по птицам." +
                "\nP.S. Ни одна птица не пострадала в этой игре.";

            var gameconditionMessage = "Условия игры: " +
                "\nУ тебя только одна попытка убить с первого раза." +
                "\nУ тебя ограниченное колличество паторонов:" +
                "\n Пистолет: 50 шт.";

            return new Message { WelcomeMessageForPlayer=welcomeMessageForPlayer, GameconditionMessage=gameconditionMessage};

        }
    }
}
