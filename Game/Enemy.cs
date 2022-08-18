public struct Enemy
{
    public int Health { get; init; }
    public int Damage { get; init; }
    public Enemy(int health, int damage)
    {
        Health = health;
        Damage = damage;
    }
}