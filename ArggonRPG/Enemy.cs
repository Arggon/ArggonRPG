namespace ArggonRPG;

public class Enemy
{
    private static readonly List<Enemy> Enemies = [];
    public Enemy(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
        AddEnemy(this);
    }

    private static void AddEnemy(Enemy enemy)
    {
        Enemies.Add(enemy);
    }
    
    public static List<Enemy> GetAllEnemies()
    {
        return Enemies;
    }

    public string Name { get; }
    public int Health { get; }
    public int AttackPower { get; }

    public static Enemy GetEnemy(string enemy)
    {
        return Enemies.FirstOrDefault(e => e.Name.Equals(enemy)) ?? throw new InvalidOperationException("Enemy not found");
    }
}