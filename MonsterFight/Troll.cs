namespace MonsterFight;

public class Troll : Monster
{
    public Troll()
    {
        Hp = 100f;
        Ap = 15f;
        Dp = 5f;
        Sp = 5f;
        MonsterERace = ERace.Troll;
        Console.WriteLine("You chose: {0}", MonsterERace);

    }
    
    public Troll(float hp, float ap, float dp, float sp) : base(hp, ap, dp, sp)
    {
        MonsterERace = ERace.Troll;
        Console.WriteLine("You chose: {0}", MonsterERace);

    }
    
    public override float Attack(Monster defender)
    {
        //deal more damage on 15%
        Console.WriteLine("Orc attack!");
        return base.Attack(defender);
    }
}