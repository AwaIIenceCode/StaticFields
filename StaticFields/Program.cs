using System;

class Enemy
{
    private readonly string _name;
    private int _health;
    private static uint _totalEnemies;
    private static float _damageMultiplier = 1.0f;

    public Enemy(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("Name cannot be empty!");
        this._name = name;
        Health = 100;
        _totalEnemies++;
    }
    public string Name => _name;
    public int Health
    {
        get => _health;
        set
        {
            if (value > 100)
                throw new ArgumentException("Health must be between 0 and 100!");
            _health = value;
        }
    }
    public void TakeDamage(int damage)
    {
        int actualDamage = _name == "Zombie" ? damage : (int)(damage * 2 / 3);
        Health -= actualDamage;
        if (Health < 0) Health = 0;
        Console.WriteLine($"{Name} takes {actualDamage} damage!");
    }
    public static float DamageMultiplier
    {
        get => _damageMultiplier;
        set => _damageMultiplier = value > 0 ? value : 1.0f;
    }
    public static uint TotalEnemies => _totalEnemies;
    public void Print()
    {
        string status = Health > 0 ? "Alive" : "Dead";
        Console.WriteLine($"Enemy: {Name}, Health: {Health}, Alive: {status}");
    }
    public static string GetEnemyCount() => $"Total enemies: {TotalEnemies}";
}

class Program
{
    static void Main()
    {
        Enemy zombie = new Enemy("Zombie");
        Enemy skeleton = new Enemy("Skeleton");
        Console.WriteLine(Enemy.GetEnemyCount());
        zombie.Print();
        skeleton.Print();
        for (int i = 0; i < 5; i++) zombie.TakeDamage(30);
        for (int i = 0; i < 4; i++) skeleton.TakeDamage(30); 
        zombie.Print();
        skeleton.Print();
        Console.WriteLine(Enemy.GetEnemyCount());
    }
}