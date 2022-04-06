
using ShootBird;
using ShootBird.Hero;
using ShootBird.Randomizer.RandWeapon;
using ShootBird.Sound.FoneSound;



Task foneSound = Task.Run(async () =>  await FoneGameSound.PlayFoneGameSound());

// Приветсвенное сообщение
PresentMessage.SendWelcomeMessageForPlayer();
await Task.Delay(TimeSpan.FromSeconds(10));
// Данные для создания героя 
string heroName = HeroData.InputName();
int heroAge = HeroData.InputAge();
string heroGender = HeroData.InputHeroGender();
string species = HeroData.InputSpecies();

// Создаем героя
HeroPerson person = new(heroName, heroAge, heroGender, species);
await Task.Delay(TimeSpan.FromSeconds(2));
await person.CreateHeroAsync();

//Первый шаг героя
await Task.Delay(TimeSpan.FromSeconds(2));
Console.WriteLine("Вы сделали свой первый шаг.");
await Task.Delay(TimeSpan.FromSeconds(8));

// Генерим случайное имя монтсра
string enemyName = GeneratorNameEnemy.GenerateName(7);
HeroEnemy heroEnemy = new(enemyName);
// Создаем монстра
heroEnemy.CreateEnemyAsync().Wait();
await Task.Delay(TimeSpan.FromSeconds(15));

//Задаем колличество выстрелов
int сartridge = HeroData.InputCartridge();

// Устанавливаем показатель здоровья монстра
int startPlayEnemy = heroEnemy.GetEnemyHealth();
Console.WriteLine($"Монстр начал идти к Вам! \nПоказатель здоровья: {startPlayEnemy} хп.");
await Task.Delay(TimeSpan.FromSeconds(3));



//Присваиваем случайное оружие герою
RandomWeapon randomWeapon = new(startPlayEnemy, сartridge);
var weaponHero = randomWeapon.TakeWeapon();
// Стреляем по монстру
await Task.Delay(TimeSpan.FromSeconds(2));
await weaponHero.Shot();


Console.ReadLine();

