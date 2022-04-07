using ShootBird;
using ShootBird.Hero;
using ShootBird.Randomizer.RandWeapon;
using ShootBird.Sound.FoneSound;



Task foneSound = Task.Run(async () =>  await FoneGameSound.PlayFoneGameSound());

// Приветсвенное сообщение
PresentMessage.SendWelcomeMessageForPlayer();
await Task.Delay(TimeSpan.FromSeconds(20));
// Данные для создания героя 
string heroName = HeroData.InputName();
int heroAge = HeroData.InputAge();

//Заранее готовим

// Создаем героя
HeroPerson person = new(heroName, heroAge);
await Task.Delay(TimeSpan.FromSeconds(2));

await person.CreateHeroAsync();
// Начальный показатель здоровья
int initialHealthHero = person.Helth;

//Присваиваем случайное оружие герою
RandomWeapon randomWeapon = new();
var weaponHero = RandomWeapon.TakeWeapon();
weaponHero.AboutWeapon();

//Первый шаг героя
await Task.Delay(TimeSpan.FromSeconds(10));
Console.WriteLine("\nВы сделали свой первый шаг на встречу приключениям.");
await Task.Delay(TimeSpan.FromSeconds(8));


Console.WriteLine("\nО нет! Вы наткнулись на монстра!");
await Task.Delay(TimeSpan.FromSeconds(5));
Console.WriteLine("\nРасслабся. Этот монстр будет тренировочным. \nТы только посмотри на его имя АХАХХА");
await Task.Delay(TimeSpan.FromSeconds(7));
Console.WriteLine("\nПри каждом сражении в этой игре, тебя и монстра будет переносить на специальную область для сражений." +
    "\nВ данной области Вы будете сражаться и только один из Вас останется в этом мире." +
    "\nЕсли победишь своего врага, то получишь награду. Спросишь какую? Так я тебе и сказал." +
    "\nНачинай играть и все поймешь со временем. ");


// Генерим случайное имя монтсра
string enemyName = GeneratorNameEnemy.GenerateName(7);
// Отдаем имя нашему монстру
HeroEnemy heroEnemy = new(enemyName);
// Ожидаем создание монстра
await heroEnemy.CreateEnemyAsync();
// Получаем показатель здоровья монстра
int initialHealthEnemy = heroEnemy.GetEnemyHealth();

await Task.Delay(TimeSpan.FromSeconds(15));
Console.WriteLine($"\nТебя {heroName} и монтсра {enemyName} переносит на Арену!");

await Task.Delay(TimeSpan.FromSeconds(5));
Console.WriteLine("\nДа начнется великая битва!!!!!");

await Task.Delay(TimeSpan.FromSeconds(5));
Console.WriteLine($"\nМонстр начал идти к Вам!");

await Task.Delay(TimeSpan.FromSeconds(5));
Console.WriteLine("\nБыстрей убей его!!!");

await Task.Delay(TimeSpan.FromSeconds(5));
Console.WriteLine("\nАх да, чуть не забыл. У каждого оружия есть свой лимит, прочность или запас патронов." +
"\nЕсли что-то закончится раньше чем монстр умрет, ты проиграешь :)");

await Task.Delay(TimeSpan.FromSeconds(10));
// Стреляем по монстру
int heroDamageInEmeny = weaponHero.Attack().Damage;
int reserve = weaponHero.Attack().Endurance;

// Область где сражается герой и монстр
Battlefield battlefield = new(initialHealthHero, initialHealthEnemy, heroDamageInEmeny, reserve);
await battlefield.StartTheBattleAsync();



await Task.Delay(TimeSpan.FromSeconds(8));
Console.WriteLine("На этом игра пока закончилась");
Console.ReadLine();

