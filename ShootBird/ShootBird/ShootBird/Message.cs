namespace ShootBird
{
   sealed internal class Message
    {
        public string? WelcomeMessageForPlayer { get; set; }
        public string? GameconditionMessage { get; set; }
        public static  Message SendWelcomeMessageForPlayer()
        {

            var welcomeMessageForPlayer = "Приветствую тебя!" +
                "\nТы попал в петлю и нужно выбраться из нее убивая монстров." +
                "\nP.S." +
                "\nНи один монстр не пострадала в этой игре. Просто они позже придут за тобой :)";

            var gameconditionMessage = "\nУсловия игры: " +
                "\nОдна жизнь. Одна попытка убить монстра!" +
                "\nА теперь перейдем к твоему герою собственно.";

            return new Message { WelcomeMessageForPlayer=welcomeMessageForPlayer, GameconditionMessage=gameconditionMessage};

        }
    }
}
