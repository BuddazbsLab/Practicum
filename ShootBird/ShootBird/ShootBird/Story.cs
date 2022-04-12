using L.S.D.BattleArena;
using L.S.D.Enemy;
using L.S.D.Hero;
using L.S.D.Images;
using L.S.D.Message.FirstGameHiMessage;
using L.S.D.Message.LastMessageToEndGame;
using L.S.D.Message.SystemMessage;
using L.S.D.PlayerActions;
using L.S.D.Randomizer.NameEnemy;
using L.S.D.Sound.FoneSound;
using L.S.D.Weapon.Selection;

namespace L.S.D
{
    internal class Story
    {
        public static async Task NewStory()
        {
            Task foneSound = Task.Run(async () =>  await FoneGameSound.PlayFoneGameSound());

            // Приветсвенное сообщение
            PresentMessage.SendWelcomeMessageForPlayer();
            await Task.Delay(TimeSpan.FromSeconds(20));

            // Создание героя
            string heroName = PersonData.InputName();
            int heroAge = PersonData.InputAge();

            await Task.Delay(TimeSpan.FromSeconds(1));

            InitialСharacteristics initialСharacteristics = new(heroName, heroAge);
            var initialHero = initialСharacteristics.NewCharacterClass();
            await initialHero.CreateHeroAsync();
            int initialHealthHero = initialHero.Helth;
            int initialLevelHero = initialHero.HeroLevel;
            int initArmorHero = initialHero.HeroArmor;


            await Task.Delay(TimeSpan.FromSeconds(2));
            //Игрок выбирает оруже
            var newWeaponHero = WeaponSelection.IssueWeaponsToTheHeroOfYourChoice();
            await Task.Delay(TimeSpan.FromSeconds(1));
            newWeaponHero.AboutWeapon();

            //Первый шаг героя
            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("\nВы сделали свой первый шаг на встречу приключениям.");
            await Task.Delay(TimeSpan.FromSeconds(4));


            Console.WriteLine("\nО нет! Вы наткнулись на монстра!");
            await Task.Delay(TimeSpan.FromSeconds(3));

            // Генерим случайное имя монтсра
            string enemyName = GeneratorNameEnemy.GenerateEnemyName();
            //Инициаоизируем монстра 
            HeroEnemy heroEnemy = new(enemyName);
            int initEnemyDamage = heroEnemy.EnemyDamage;
            // Получаем показатель здоровья монстра
            int initialHealthEnemy = heroEnemy.EnemyHelth;
            // Ожидаем создание монстра
            await heroEnemy.CreateEnemyAsync();



            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("\nРасслабся. Этот монстр будет тренировочным.");
            await Task.Delay(TimeSpan.FromSeconds(4));
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine(" При каждом сражении в этой игре,");
            Console.WriteLine(" тебя и монстра будет переносить на специальную область для сражений.");
            Console.WriteLine(" В данной области Вы будете сражаться и только один из Вас останется в этом мире.");
            Console.WriteLine(" Если победишь своего врага, то получишь награду. Спросишь какую?");
            Console.WriteLine(" Так я тебе и сказал.");
            Console.WriteLine(" Начинай играть и все поймешь со временем. ");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");


            await Task.Delay(TimeSpan.FromSeconds(8));
            Console.WriteLine($"\nТебя {heroName} и монтсра {enemyName} переносит на Арену!");

            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("\nДа начнется великая битва!!!!!");

            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine($"\nМонстр начал идти к Вам!");

            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("\nБыстрей убей его!!!");

            //Напоминалка
            await MyMessage.RemindAsync();


            // Получаем данные об оружии (урон и запас прочности либо запас стрел)
            int heroDamageInEmeny = newWeaponHero.Attack().Damage;
            int reserveWeapon = newWeaponHero.Attack().Endurance;

            //Инициализируем поле сражения
            Battlefield battlefield = new(initialHealthHero, initialHealthEnemy, heroDamageInEmeny, reserveWeapon, initEnemyDamage);
            
            //Выбор убить или не убить монстра
            int operationType = BeatDontbeat.MakeAChoice();
            if (operationType == 0)
            {
                await Task.Delay(TimeSpan.FromSeconds(3));
                // Область где сражается герой и монстр
                await battlefield.StartTheBattleAsync();
                //Выводим результат сражения и возращаем остаток здоровбя
                battlefield.ResultOfTheBattle();
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
            else
            {
                Console.WriteLine("Неее так не пойдет.\nЭто тренировочный бой и ты все равно будешь сражаться. \nЗапуск принудительного боя!");
                await Task.Delay(TimeSpan.FromSeconds(3));
                // Область где сражается герой и монстр
                await battlefield.StartTheBattleAsync();
                //Выводим результат сражения и возращаем остаток здоровья на консоль. 
                battlefield.ResultOfTheBattle();
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
            //Получаем новые показатели героя после битвы
            int initNewHealsHero = battlefield.HeroHeals;
            int initNewArmorHero = battlefield.HeroArmor;


            await Task.Delay(TimeSpan.FromSeconds(1));
            //Первый шаг после тренировочного боя
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Поздравялю! \nТвой первый бой прошел успешно. \n Продолжай в том же духе!");
            await Task.Delay(TimeSpan.FromSeconds(1));

            //Проблемный перенос с арены обратно в мир героя
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                    Уведомление!");
            Console.WriteLine(" Бой завершен. Поздрваляем!");
            await Task.Delay(TimeSpan.FromSeconds(1));
            Console.WriteLine(" Начата процедура возвращения.....");
            await Task.Delay(TimeSpan.FromSeconds(4));
            Console.WriteLine(" ОШИБКА!  ОШИБКА!  ОШИБКА!");
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.WriteLine(" Начат процесс перезагрузки системы!");
            await Task.Delay(TimeSpan.FromSeconds(4));
            Console.WriteLine(" Перенос на ближайшую точку");
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.WriteLine(" Перенос завершен");
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.WriteLine(" Локация: \n Лес Хенгельта. \n Уровень опасности низкий. \n Уровень монстров : 1 LVL");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");


            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine($"{heroName} Говорит:");
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.WriteLine("Что.... Что сейчас вообще было. Где Я!?!?!");
            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("Я чувствую чей-то взгляд...");
            await Task.Delay(TimeSpan.FromSeconds(2));
            Console.WriteLine($"{heroName} Повернул голову и смотрит на тебя");
            //Выводим картинку героя
            await Task.Delay(TimeSpan.FromSeconds(2));
            AnsiiImages.FaceHero();
            await Task.Delay(TimeSpan.FromSeconds(4));

            Console.WriteLine("И чего молчим?");
            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("Эххх. Ладно, придется все самому делать.");
            await Task.Delay(TimeSpan.FromSeconds(3));
            Console.WriteLine("Что смотришь? Пошли уже. Нужно добраться до города пока не стемнело.");
            await Task.Delay(TimeSpan.FromSeconds(3));

            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                    Уведомление!");
            Console.WriteLine(" Конец ознакомительной главы.");
            Console.WriteLine(" Судба Вашего героя теперь зависит только от Вас. ");
            Console.WriteLine(" Заварите чайку и начинаем!");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n\n\n");
            Console.WriteLine(@"█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗
╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝");


            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                                    Глава 1.");
            Console.WriteLine("                                 Лес Хенгельта.");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");



            await Task.Delay(TimeSpan.FromSeconds(5));
            Console.WriteLine("На этом игра пока закончилась");
            await Task.Delay(TimeSpan.FromSeconds(2));
            TheEnd.SendLastMessageInGame();
            Console.ReadLine();
        }
    }
}
