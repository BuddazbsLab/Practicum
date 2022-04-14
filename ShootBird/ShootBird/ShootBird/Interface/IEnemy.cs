namespace L.S.D.Interface
{
    internal interface IEnemy
    {
        int EnemyHelth { get; }
        string EnemyName { get; }

        Task CreateEnemyAsync();
    }
}