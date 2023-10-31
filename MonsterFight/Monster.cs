namespace MonsterFight;

public enum ERace {Orc, Troll, Goblin, Elf, Dragonborn, None}

public class Monster
{
    protected float Hp { get; set; }
    protected float Ap { get; set; }
    protected float Dp { get; set; }
    protected float Sp { get; set; }

    protected ERace MonsterERace = ERace.None;
    
    public ERace ERace => MonsterERace;

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

    public virtual float Attack(Monster target, float damage)
    {
        return target.Hp -= Ap - target.Dp;
    }
}