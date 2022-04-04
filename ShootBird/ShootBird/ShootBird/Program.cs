
using ShootBird;





Console.WriteLine(Message.SendWelcomeMessageForPlayer().WelcomeMessageForPlayer);
Console.WriteLine(Message.SendWelcomeMessageForPlayer().GameconditionMessage);
await Task.Delay(TimeSpan.FromMilliseconds(1000));
Console.Clear();
await Task.Delay(TimeSpan.FromMilliseconds(1500));
Console.WriteLine("Введите имя персонажа: ");
string? playerName = Console.ReadLine();
Console.Clear();
await Task.Delay(TimeSpan.FromMilliseconds(1500));
Console.WriteLine("Введите колличество выстрелов: ");
int? сartridge = Convert.ToInt32(Console.ReadLine());



Person person = new(playerName);
Console.Clear();

await Task.Delay(TimeSpan.FromMilliseconds(1500));
person.CreatePersonAsync().Wait();
Console.Clear();



Bird bird = new();
int startPlayBird = bird.StartHealth();
Console.WriteLine($"Взлетела злобная птица \nПоказатель здоровья: {startPlayBird} хп.");
await Task.Delay(TimeSpan.FromMilliseconds(3000));
Console.Clear();

Gun gun = new(startPlayBird, сartridge);
await Task.Delay(TimeSpan.FromMilliseconds(1500));
await gun.Shot();


Console.ReadLine();

