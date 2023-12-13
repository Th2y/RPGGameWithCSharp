namespace RPGGameWithCSharp.src.Entities.Hero.BlackWizard
{
    public class BlackWizard(string name, string playerName, int life, int damage) : Hero(name, playerName, life, damage, HeroTypes.BlackWizard)
    {
        public override void Attack(Hero who)
        {
            Console.WriteLine($"{PlayerName} attacked with water magic");

            base.Attack(who);
        }
    }
}