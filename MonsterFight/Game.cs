namespace MonsterFight;

public class Game
{
    private List<Monster> _monsterList = new List<Monster>();
    public Game(List<Monster> monsterList)
    {
        _monsterList = monsterList;
    }

    public void GameLoop()
    {
        Monster monster1 = _monsterList[0];
        Monster monster2 = _monsterList[1];

        if (monster1.Sp > monster2.Sp)
        {
            Console.WriteLine("Monster 1 attacks first!");
            monster1.Attack(monster2);
            while (monster1.Hp > 0 && monster2.Hp > 0)
            {
                monster2.Attack(monster1);
                Thread.Sleep(1000);
                Console.WriteLine("Monster 1 HP: {0}",monster1.Hp);
                monster1.Attack(monster2);
                Console.WriteLine("Monster 2 HP: {0}",monster2.Hp);
                Thread.Sleep(1000);
            }
        }
        else
        {
            Console.WriteLine("Monster 2 attacks first!");
            monster2.Attack(monster1);
            while (monster1.Hp > 0 && monster2.Hp > 0)
            {
                monster1.Attack(monster2);
                Thread.Sleep(1000);
                Console.WriteLine("Monster 2 HP: {0}",monster2.Hp);
                monster2.Attack(monster1);
                Console.WriteLine("Monster 1 HP: {0}",monster1.Hp);
                Thread.Sleep(1000);
            }
        }
    }
    
}