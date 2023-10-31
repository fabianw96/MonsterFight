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
    }

    protected override float Attack(Monster target, float damage)
    {
        if (Hp < Hp * 0.5f)
        {
            Console.WriteLine("Half HP");
        }
        return base.Attack(target, damage);
    }
}