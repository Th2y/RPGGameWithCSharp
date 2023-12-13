namespace RPGGameWithCSharp.src.Entities.Hero.Ninja
{
    public class Ninja(string name, string playerName, int life, int damage) : Hero(name, playerName, life, damage, HeroTypes.Ninja)
    {
        public override void Attack(Hero who)
        {
            Console.WriteLine($"{PlayerName} attacked with his sword");

            base.Attack(who);
        }
    }
}