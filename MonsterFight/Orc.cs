namespace MonsterFight;

public class Orc : Monster
{
    public Orc()
    {
        Hp = 150;
        Ap = 15;
        Dp = 7;
        Sp = 3;
        MonsterERace = ERace.Orc;
    }
    
    public Orc(float hp, float ap, float dp, float sp) : base(hp, ap, dp, sp)
    {
        MonsterERace = ERace.Orc;
    }
}