namespace RPGGameWithCSharp.src.Entities.Hero.WhiteWizard
{
    public class WhiteWizard(string name, string playerName, int life, int damage) : Hero(name, playerName, life, damage, HeroTypes.WhiteWizard)
    {
        public override void Attack(Hero who)
        {
            Console.WriteLine($"{PlayerName} attacked with fire magic");

            base.Attack(who);
        }
    }
}