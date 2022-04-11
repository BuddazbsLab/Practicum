using ShootBird;
using ShootBird.Hero;
using ShootBird.Images;
using ShootBird.Message.LastMessageToEndGame;
using ShootBird.Message.SystemMessage;
using ShootBird.PlayerActions;
using ShootBird.Sound.FoneSound;
using ShootBird.Weapon.Selection;

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


await Task.Delay(TimeSpan.FromSeconds(2));
//Игрок выбирает оруже
var newWeaponHero = WeaponSelection.IssueWeaponsToTheHeroOfYourChoice();
await Task.Delay(TimeSpan.FromSeconds(1));
newWeaponHero.AboutWeapon();

//Первый шаг героя
await Task.Delay(TimeSpan.FromSeconds(10));
Console.WriteLine("\nВы сделали свой первый шаг на встречу приключениям.");
await Task.Delay(TimeSpan.FromSeconds(8));


Console.WriteLine("\nО нет! Вы наткнулись на монстра!");
await Task.Delay(TimeSpan.FromSeconds(5));

// Генерим случайное имя монтсра
string enemyName = GeneratorNameEnemy.GenerateEnemyName();
// Отдаем имя нашему монстру
HeroEnemy heroEnemy = new(enemyName);
// Ожидаем создание монстра
await heroEnemy.CreateEnemyAsync();
// Получаем показатель здоровья монстра
int initialHealthEnemy = heroEnemy.GetEnemyHealth();


await Task.Delay(TimeSpan.FromSeconds(5));
Console.WriteLine("\nРасслабся. Этот монстр будет тренировочным.");
await Task.Delay(TimeSpan.FromSeconds(7));
Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
Console.WriteLine(" При каждом сражении в этой игре,");
Console.WriteLine(" тебя и монстра будет переносить на специальную область для сражений.");
Console.WriteLine(" В данной области Вы будете сражаться и только один из Вас останется в этом мире.");
Console.WriteLine(" Если победишь своего врага, то получишь награду. Спросишь какую?");
Console.WriteLine(" Так я тебе и сказал.");
Console.WriteLine(" Начинай играть и все поймешь со временем. ");
Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");


await Task.Delay(TimeSpan.FromSeconds(15));
Console.WriteLine($"\nТебя {heroName} и монтсра {enemyName} переносит на Арену!");

await Task.Delay(TimeSpan.FromSeconds(5));
Console.WriteLine("\nДа начнется великая битва!!!!!");

await Task.Delay(TimeSpan.FromSeconds(5));
Console.WriteLine($"\nМонстр начал идти к Вам!");

await Task.Delay(TimeSpan.FromSeconds(5));
Console.WriteLine("\nБыстрей убей его!!!");

//Напоминалка
await MyMessage.RemindAsync();

int operationType = BeatDontbeat.MakeAChoice();
if (operationType == 0)
{
    await Task.Delay(TimeSpan.FromSeconds(10));
    // Стреляем по монстру
    int heroDamageInEmeny = newWeaponHero.Attack().Damage;
    int reserve = newWeaponHero.Attack().Endurance;

    // Область где сражается герой и монстр
    Battlefield battlefield = new(initialHealthHero, initialHealthEnemy, heroDamageInEmeny, reserve);
    await battlefield.StartTheBattleAsync();
    //Выводим результат сражения и возращаем остаток здоровбя
    int remainingHealth = battlefield.ResultOfTheBattle();
    await Task.Delay(TimeSpan.FromSeconds(1));
}
//Повторение кода. Плохо! исправь!
else
{
    Console.WriteLine("Неее так не пойдет.\nЭто тренировочный бой и ты все равно будешь сражаться. \nЗапуск принудительного боя!");
    await Task.Delay(TimeSpan.FromSeconds(10));
    // Стреляем по монстру
    int heroDamageInEmeny = newWeaponHero.Attack().Damage;
    int reserve = newWeaponHero.Attack().Endurance;

    // Область где сражается герой и монстр
    Battlefield battlefield = new(initialHealthHero, initialHealthEnemy, heroDamageInEmeny, reserve);
    await battlefield.StartTheBattleAsync();
    //Выводим результат сражения и возращаем остаток здоровбя
    int remainingHealth = battlefield.ResultOfTheBattle();
    await Task.Delay(TimeSpan.FromSeconds(1));
}



//Первый шаг после тренировочного боя
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Поздравялю! \nТвой первый бой прошел успешно. \n Продолжай в том же духе!");
await Task.Delay(TimeSpan.FromSeconds(1));

//Проблемный перенос с арены обратно в мир героя
Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("                                    Уведомление!");
Console.WriteLine(" Бой завершен. Поздрваляем!");
await Task.Delay(TimeSpan.FromSeconds(1));
Console.WriteLine(" Начата процедура возращения.....");
await Task.Delay(TimeSpan.FromSeconds(8));
Console.WriteLine(" ОШИБКА!  ОШИБКА!  ОШИБКА!");
await Task.Delay(TimeSpan.FromSeconds(2));
Console.WriteLine(" Начат процесс перезагрузки системы!");
await Task.Delay(TimeSpan.FromSeconds(8));
Console.WriteLine(" Перенос на ближайшую точку");
await Task.Delay(TimeSpan.FromSeconds(2));
Console.WriteLine(" Перенос завершен");
await Task.Delay(TimeSpan.FromSeconds(2));
Console.WriteLine(" Локация: \n Лес Хенгельта. \n Уровень опасности низкий. \n Уровень монстров : 1 LVL");
Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");


await Task.Delay(TimeSpan.FromSeconds(10));
Console.WriteLine($"{heroName} Говорит:");
await Task.Delay(TimeSpan.FromSeconds(2));
Console.WriteLine("Что.... Что сейчас вообще было. Где Я!?!?!");
await Task.Delay(TimeSpan.FromSeconds(2));
Console.WriteLine("Я чувствую еще присутствие...");
await Task.Delay(TimeSpan.FromSeconds(2));
Console.WriteLine($"{heroName} Повернул голову и смотрит на тебя");
//Выводим картинку героя
await Task.Delay(TimeSpan.FromSeconds(2));
AnsiiImages.FaceHero();
await Task.Delay(TimeSpan.FromSeconds(4));

Console.WriteLine("И чего молчим?");
await Task.Delay(TimeSpan.FromSeconds(2));
Console.WriteLine("Придется все самому делать.");
await Task.Delay(TimeSpan.FromSeconds(2));
Console.WriteLine("Что смотришь? Пошли уже. Нужно добраться до города пока не стемнело.");

Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("                                    Уведомление!");
Console.WriteLine(" Конец ознакомительной главы.");
Console.WriteLine(" Судба Вашего героя теперь только на Вас. ");
Console.WriteLine(" Заварите чайку и начинаем!");
Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");
Console.WriteLine("\n\n\n");
Console.WriteLine(@"█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗█████╗
╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝╚════╝");


Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════╗");
Console.WriteLine("                                    Глава 1.");
Console.WriteLine("                                 Лес Хенгельта.");
Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════╝");



await Task.Delay(TimeSpan.FromSeconds(8));
Console.WriteLine("На этом игра пока закончилась");
await Task.Delay(TimeSpan.FromSeconds(2));
TheEnd.SendLastMessageInGame();
Console.ReadLine();

