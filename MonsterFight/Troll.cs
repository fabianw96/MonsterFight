namespace MonsterFight;

public class Troll : Monster
{
    private bool _isEnraged = false;
    private float _lowLife;
    private float _lowLifePercent = 0.3f;

    public Troll()
    {
        Hp = 100f;
        Ap = 15f;
        Dp = 5f;
        Sp = 5f;
        MonsterERace = ERace.Troll;
        _lowLife = Hp * _lowLifePercent;
        Console.WriteLine("You chose: {0}", MonsterERace);

    }
    
    public Troll(float hp, float ap, float dp, float sp) : base(hp, ap, dp, sp)
    {
        MonsterERace = ERace.Troll;
        _lowLife = Hp * _lowLifePercent;
        Console.WriteLine("You chose: {0}", MonsterERace);

    }
    
    public override float Attack(Monster defender)
    {
        
        //deal more damage on 30%
        if (Hp <= _lowLife && !_isEnraged)
        {
            Ap *= 2;
            _isEnraged = true;
            Console.WriteLine("Troll has fallen below 30% HP!");
            Console.WriteLine("The Troll enrages and now deals double damage!");
            
        }
        Console.WriteLine("Troll attack!");
        return base.Attack(defender);
    }
}