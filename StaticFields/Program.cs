using System;

class Enemy
{
    private readonly string _name;
    private byte _health = 100;
    private static uint _totalEnemies;

    public Enemy(string name)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("Name cannot be empty!");
        this._name = name;
        _totalEnemies++;
    }
    public string Name => _name;
    public static uint TotalEnemies => _totalEnemies;

    public void ZombieDamage()
    {
        
    }
}

class MyClass
{
    static void Main()
    {}
}