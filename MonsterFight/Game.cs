namespace MonsterFight;

public class Game
{
    
    private List<Monster> _monsterList;
    private Monster _monster1;
    private Monster _monster2;

    public Game(List<Monster> monsterList)
    {
        _monsterList = monsterList;
        _monster1 = _monsterList[0];
        _monster2 = _monsterList[1];
    }
    
    public void GameLoop()
    {
        Monster attacker = _monster1.Sp > _monster2.Sp ? _monster1 : _monster2;
        Monster defender = attacker == _monster1 ? _monster2 : _monster1;

        Console.WriteLine($"{attacker.ERace} attacks first!");

        while (_monster1.Hp > 0 && _monster2.Hp > 0)
        {
            attacker.Attack(defender);
            Thread.Sleep(1000);
            Console.WriteLine($"{defender.ERace} HP: {defender.Hp}");
            Swap(ref attacker, ref defender);
        }

        GameEnd();
    }

    void Swap(ref Monster first, ref Monster second)
    {
        (first, second) = (second, first);
    }

    void GameEnd()
    {
        Monster winner = _monster1.Hp == 0 ? _monster2 : _monster1;
        Console.WriteLine($"{winner.ERace} won!");
        Console.ReadKey();
    }

}
