namespace RPGGameWithCSharp.src.Entities.Hero;

public abstract class Hero(string name, string playerName, int life, int damage, HeroTypes heroType)
{
    public string Name { get; protected set; } = name;
    public string PlayerName { get; protected set; } = playerName;
    public int Level { get; protected set; } = 1;
    public HeroTypes HeroType { get; protected set; } = heroType;
    protected int Life { get; set; } = life;
    public int Damage { get; protected set; } = damage;

    protected int CurrentLife;
    public bool IsDie { get; private set; } = false;

    public override string ToString()
    {
        return $"{PlayerName} - Name: {Name}, Level: {Level}, Type: {HeroType}";
    }

    public virtual void Attack(Hero who)
    {
        who.TakeDamage(Damage * Level);
        Level++;
    }

    public void TakeDamage(int damage)
    {
        CurrentLife = Life - damage;

        if (CurrentLife > 0)
        {
            Console.WriteLine($"{PlayerName} current life: {CurrentLife}");
        }
        else
        {
            IsDie = true;
            Console.WriteLine($"{PlayerName} die");
        }
    }
}