namespace MonsterFight;

public class Goblin : Monster
{
    private int _dodgeChance = 15;
    private bool _isEnraged = false;
    private float _lowLife;
    private float _lowLifePercent = 0.4f;
    
    public Goblin()
    {
        Hp = 100f;
        MaxHp = Hp;
        Ap = 10f;
        Dp = 3f;
        Sp = 7f;
        MonsterERace = ERace.Goblin;
        _lowLife = Hp * _lowLifePercent;
        Console.WriteLine("You chose: {0}", MonsterERace);

    }
    
    public Goblin(float hp, float ap, float dp, float sp) : base(hp, ap, dp, sp)
    {
        MonsterERace = ERace.Goblin;
        _lowLife = Hp * _lowLifePercent;
        Console.WriteLine("You chose: {0}", MonsterERace);
    }
    
    public override void Attack(Monster defender)
    {
        Console.WriteLine("Goblin attack!");
        base.Attack(defender);
    }

    protected override void GetHit(float damageDealt)
    {
        Random random = new Random();
        int dodge = random.Next(1, 100);
        if (dodge <= _dodgeChance)
        {
            damageDealt = 0;
        }
        
        if (!_isEnraged && Hp <= _lowLife)
        {
            _dodgeChance *= 2;
            Console.WriteLine("Goblin has fallen below 30% HP!");
            Console.WriteLine("The Goblin enrages and now has {0}% dodge chance!", _dodgeChance);
            _isEnraged = true;
        }
        base.GetHit(damageDealt);

    }
}