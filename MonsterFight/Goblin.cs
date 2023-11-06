namespace MonsterFight;

public class Goblin : Monster
{
    public Goblin()
    {
        Hp = 100f;
        Ap = 10f;
        Dp = 3f;
        Sp = 7f;
        MonsterERace = ERace.Goblin;
        Console.WriteLine("You chose: {0}", MonsterERace);

    }
    
    public Goblin(float hp, float ap, float dp, float sp) : base(hp, ap, dp, sp)
    {
        MonsterERace = ERace.Goblin;
        Console.WriteLine("You chose: {0}", MonsterERace);

    }
    
    public override float Attack(Monster defender)
    {
        //need ideas!
        Console.WriteLine("Goblin attack!");
        return base.Attack(defender);
    }
}