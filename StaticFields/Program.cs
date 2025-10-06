using System;

class Enemy
{
    private readonly string _name;
    private byte _health;
    private static uint _totalEnemies;

    public Enemy(string name, byte health, uint totalEnemies)
    {
        if (string.IsNullOrEmpty(name)) throw new ArgumentException("Description cannot be empty!");
    }
}

class MyClass
{
    static void Main()
    {}
}