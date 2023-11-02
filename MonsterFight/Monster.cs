namespace MonsterFight;

public enum ERace {Orc, Troll, Goblin, None}

public class Monster
{
    public float Hp { get; protected set; }
    public float Ap { get; protected set; }
    public float Dp { get; protected set; }
    public float Sp { get; protected set; }

    protected ERace MonsterERace = ERace.None;
    
    // public ERace ERace => MonsterERace;

    protected Monster()
    {
        
    }

    protected Monster(float hp, float ap, float dp, float sp)
    {
        Hp = hp;
        Ap = ap;
        Dp = dp;
        Sp = sp;
    }

    public virtual float Attack(Monster defender)
    {
        // Console.WriteLine("Monster attack!");
        return defender.Hp -= Ap - defender.Dp;
    }
}