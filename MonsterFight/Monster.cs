namespace MonsterFight;

public class Monster
{
    public float Hp { get; protected set; }
    public float MaxHp { get; protected set; }
    public float Ap { get; protected set; }
    public float Dp { get; protected set; }
    public float Sp { get; protected set; }
    public ERace MonsterERace { get; protected set; }

    protected Monster()
    {
        
    }

    protected Monster(float hp, float ap, float dp, float sp)
    {
        Hp = hp;
        MaxHp = Hp;
        Ap = ap;
        Dp = dp;
        Sp = sp;
    }

    public virtual void Attack(Monster defender)
    {
        //basic damage calculation as given in assignment
        float damageDealt = Ap - defender.Dp;
        //make sure that damage deal is not below zero to not heal enemy monster
        damageDealt = damageDealt < 0 ? 0 : damageDealt;
        defender.GetHit(damageDealt);
    }

    protected virtual void GetHit(float damageDealt)
    {        
        //method to actually change the HP values of the defending monster
        Hp -= damageDealt;
        if (Hp <= 0)
        {
            Hp = 0;
        }
        Console.WriteLine("{0} was hit for {1} and has {2} HP left", MonsterERace, damageDealt, Hp);
    }
}