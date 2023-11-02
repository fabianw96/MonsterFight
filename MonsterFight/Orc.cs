namespace MonsterFight;

public class Orc : Monster
{
    public Orc()
    {
        Hp = 150f;
        Ap = 15f;
        Dp = 7f;
        Sp = 3f;
        MonsterERace = ERace.Orc;
        Console.WriteLine("You chose: {0}", MonsterERace);
    }
    
    public Orc(float hp, float ap, float dp, float sp) : base(hp, ap, dp, sp)
    {
        MonsterERace = ERace.Orc;
        Console.WriteLine("You chose: {0}", MonsterERace);
    }

    public override float Attack(Monster defender)
    {
        //take less damage on 20% hp
        Console.WriteLine("Orc attack!");
        return base.Attack(defender);
    }
}