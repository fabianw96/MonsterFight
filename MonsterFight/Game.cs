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
        Console.Clear();

        Console.WriteLine("A fight between {0} and {1} has started!", _monster1.ERace, _monster2.ERace);
        Monster attacker = _monster1.Sp > _monster2.Sp ? _monster1 : _monster2;
        Monster defender = attacker == _monster1 ? _monster2 : _monster1;

        Console.WriteLine($"{attacker.ERace} attacks first!");

        while (_monster1.Hp > 0 && _monster2.Hp > 0)
        {
            attacker.Attack(defender);
            Thread.Sleep(750);
            Console.WriteLine("{0} HP: {1}",defender.ERace,defender.Hp < 0 ? 0 : defender.Hp);
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
        // Console.Clear();
        Console.WriteLine("FIGHT ENDED!");
        Console.WriteLine("{0} has {1} HP left...", _monster1.ERace, _monster1.Hp < 0 ? 0 : _monster1.Hp);
        Console.WriteLine("and {0} has {1} HP left...", _monster2.ERace, _monster2.Hp < 0 ? 0 : _monster2.Hp);
        Monster winner = _monster1.Hp == 0 ? _monster2 : _monster1;
        Console.WriteLine($"{winner.ERace} won!");
        Console.ReadKey();
    }

}
