
namespace ShootBird
{
    internal interface IEnemy
    {
        int EnemyHelth { get; }
        string EnemyName { get; }

        Task CreateEnemyAsync();
        int GetEnemyHealth();
    }
}