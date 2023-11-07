namespace MonsterFight;

public class Orc : Monster
{
    private bool _isEnraged = false;
    private float _lowLife;
    private float _lowLifePercent = 0.15f;
    
    public Orc()
    {
        Hp = 150f;
        MaxHp = Hp;
        Ap = 15f;
        Dp = 7f;
        Sp = 3f;
        MonsterERace = ERace.Orc;
        _lowLife = Hp * _lowLifePercent;
        Console.WriteLine("You chose: {0}", MonsterERace);
    }
    
    public Orc(float hp, float ap, float dp, float sp) : base(hp, ap, dp, sp)
    {
        MonsterERace = ERace.Orc;
        _lowLife = Hp * _lowLifePercent;
        Console.WriteLine("You chose: {0}", MonsterERace);
    }

    public override void Attack(Monster defender)
    {
        Console.WriteLine("Orc attack!");
        base.Attack(defender);
    }

    protected override void GetHit(float damageDealt)
    {
        if (!_isEnraged && Hp <= _lowLife)
        {
            Dp *= 1.5f;
            _isEnraged = true;
            Console.WriteLine("Orc has fallen below 15% HP!");
            Console.WriteLine("The Orc enrages and now takes 50% less damage!");
        }
        base.GetHit(damageDealt);
    }
}