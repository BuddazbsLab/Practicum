
using ShootBird;


Message.SendWelcomeMessageForPlayer();

//TODO : Вынести эту пижню отдельно
await Task.Delay(TimeSpan.FromMilliseconds(15000));
Console.WriteLine("Введите имя персонажа: ");
string? heroName = Console.ReadLine();

Console.WriteLine("Введите возраст персонажа: ");
int heroAge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите рассу персонажа: ");
string? species = Console.ReadLine();

Console.WriteLine("Введите гендерную предрасположенность персонажа: ");
string? heroGender = Console.ReadLine();
//

HeroPerson person = new(heroName, heroAge, heroGender, species);
await Task.Delay(TimeSpan.FromMilliseconds(1500));
person.CreateHeroAsync().Wait();

await Task.Delay(TimeSpan.FromMilliseconds(5000));
Console.WriteLine("Вы сделали свой первый шаг.");
await Task.Delay(TimeSpan.FromMilliseconds(8000));

string enemyName = GeneratorNameEnemy.GenerateName(7);
HeroEnemy heroEnemy = new(enemyName);
heroEnemy.CreateEnemyAsync().Wait();

await Task.Delay(TimeSpan.FromMilliseconds(15000));
Console.WriteLine("Врага нужно срочно убить или он убьет Вас! \n Сколько выстрелов сделать?");
int? сartridge = Convert.ToInt32(Console.ReadLine());


int startPlayEnemy = heroEnemy.StartEnemyHealth();
Console.WriteLine($"Монстр начал идти к Вам! \nПоказатель здоровья: {startPlayEnemy} хп.");
await Task.Delay(TimeSpan.FromMilliseconds(3000));


Gun gun = new(startPlayEnemy, сartridge);
await Task.Delay(TimeSpan.FromMilliseconds(1500));
await gun.Shot();


Console.ReadLine();

