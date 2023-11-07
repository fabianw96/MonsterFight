﻿namespace MonsterFight;

public enum ERace {Orc = 1, Troll, Goblin, None}

public class Monster
{
    public float Hp { get; protected set; }
    public float MaxHp { get; protected set; }
    public float Ap { get; protected set; }
    public float Dp { get; protected set; }
    public float Sp { get; protected set; }
    public ERace MonsterERace { get; protected set; }
    // public ERace ERace => MonsterERace;

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
        float damageDealt = Ap - defender.Dp;
        defender.GetHit(damageDealt);
    }

    protected virtual void GetHit(float damageDealt)
    {        
        Hp -= damageDealt;
        if (Hp <= 0)
        {
            Hp = 0;
        }
        Console.WriteLine("{0} was hit for {1} and has {2}HP left", MonsterERace, damageDealt, Hp);
    }
}