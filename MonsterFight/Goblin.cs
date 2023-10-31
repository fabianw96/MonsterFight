namespace MonsterFight;

public class Goblin : Monster
{
    public Goblin()
    {
        Hp = 100;
        Ap = 10;
        Dp = 3;
        Sp = 7;
        MonsterERace = ERace.Goblin;
    }
    
    public Goblin(float hp, float ap, float dp, float sp) : base(hp, ap, dp, sp)
    {
        MonsterERace = ERace.Goblin;
    }
    
}