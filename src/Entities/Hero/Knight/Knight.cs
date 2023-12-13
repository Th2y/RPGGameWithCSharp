namespace RPGGameWithCSharp.src.Entities.Hero.Knight
{
    public class Knight(string name, string playerName, int life, int damage) : Hero(name, playerName, life, damage, HeroTypes.Knight)
    {
        public override void Attack(Hero who)
        {
            Console.WriteLine($"{PlayerName} attacked with his sword");

            base.Attack(who);
        }
    }
}