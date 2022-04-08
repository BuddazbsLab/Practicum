using ShootBird;
using ShootBird.Hero;
using ShootBird.Message.LastMessageToEndGame;
using ShootBird.Message.SystemMessage;
using ShootBird.Randomizer.RandWeapon;
using ShootBird.Sound.FoneSound;
using ShootBird.Weapon.Selection;

Task foneSound = Task.Run(async () =>  await FoneGameSound.PlayFoneGameSound());

// Приветсвенное сообщение
PresentMessage.SendWelcomeMessageForPlayer();
await Task.Delay(TimeSpan.FromSeconds(20));
// Данные для создания героя 
string heroName = HeroData.InputName();
int heroAge = HeroData.InputAge();


// Создаем героя
HeroPerson person = new(heroName, heroAge);
await Task.Delay(TimeSpan.FromSeconds(2));

await person.CreateHeroAsync();
// Начальный показатель здоровья
int initialHealthHero = person.Helth;

//Игрок выбирает оруже
var newWeaponHero = WeaponSelection.IssueWeaponsToTheHeroOfYourChoice();
await Task.Delay(TimeSpan.FromSeconds(2));
newWeaponHero.AboutWeapon();

////Присваиваем случайное оружие герою
//RandomWeapon randomWeapon = new();
//var weaponHero = RandomWeapon.TakeWeapon();
//await Task.Delay(TimeSpan.FromSeconds(2));
//weaponHero.AboutWeapon();

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

//await Task.Delay(TimeSpan.FromSeconds(5));
//Console.WriteLine("\nАх да, чуть не забыл. У каждого оружия есть свой лимит, прочность или запас патронов." +
//"\nЕсли что-то закончится раньше чем монстр умрет, ты проиграешь :)");

await Task.Delay(TimeSpan.FromSeconds(10));
// Стреляем по монстру
int heroDamageInEmeny = newWeaponHero.Attack().Damage;
int reserve = newWeaponHero.Attack().Endurance;

// Область где сражается герой и монстр
Battlefield battlefield = new(initialHealthHero, initialHealthEnemy, heroDamageInEmeny, reserve);
await battlefield.StartTheBattleAsync();



await Task.Delay(TimeSpan.FromSeconds(8));
Console.WriteLine("На этом игра пока закончилась");
await Task.Delay(TimeSpan.FromSeconds(2));
TheEnd.SendLastMessageInGame();
Console.ReadLine();

