using System;

namespace Game;
class Programm
{
    public static void Main()
    {
        string EndGame = "yes";
        do
        {
            MainHero Kirill = new MainHero("Kirill", 100, 50);
            Enemy Dumb = new Enemy(50, 25);
            void Attack()
            {
                int FinallyHealth;
                FinallyHealth = Dumb.Health - Kirill.Damage;
                if (FinallyHealth > 0)
                {
                    Console.WriteLine($"У врага осталось {FinallyHealth} единиц здоровья");
                }
                else
                {
                    Console.WriteLine("Вы убили врага");
                }
            }
            Attack();
            Console.WriteLine("Вы хотите продолжить?\nyes/no");
            EndGame = Console.ReadLine();
        }
        while (EndGame != "no");
    }
}