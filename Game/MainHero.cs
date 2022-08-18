public struct MainHero
{
    public string Name { get; init; }
    public int Health { get; init; }
    public int Damage { get; init; }
    public MainHero(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }
}