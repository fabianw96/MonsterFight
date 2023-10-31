namespace MonsterFight;

public class Troll : Monster
{
    public Troll()
    {
        Hp = 100;
        Ap = 15;
        Dp = 5;
        Sp = 5;
        MonsterERace = ERace.Troll;
    }
    
    public Troll(float hp, float ap, float dp, float sp) : base(hp, ap, dp, sp)
    {
        MonsterERace = ERace.Troll;
    }
}