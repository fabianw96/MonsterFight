namespace MonsterFight;

public class Game
{
    private UserInput _input = new UserInput();
    private HPBars _hpBars = new HPBars();
    
    public void StartGame()
    {
        Monster monster1 = _input.CreateMonster(ERace.None);
        Monster monster2 = _input.CreateMonster(monster1.MonsterERace);
           
        GameLoop(monster1, monster2);
    }
    
    private void GameLoop(Monster monster1, Monster monster2)
    {
        Console.Clear();

        Console.WriteLine("A fight between {0} and {1} has started!", monster1.MonsterERace, monster2.MonsterERace);
        Monster attacker = monster1.Sp > monster2.Sp ? monster1 : monster2;
        Monster defender = attacker == monster1 ? monster2 : monster1;
        
        Console.WriteLine($"{attacker.MonsterERace} attacks first!");
        _hpBars.DisplayHPBars(monster1, monster2);


        while (monster1.Hp > 0 && monster2.Hp > 0)
        {
            attacker.Attack(defender);
            Thread.Sleep(1000);
            Console.Clear();
            Swap(ref attacker, ref defender);
            // Console.WriteLine("{0} HP - {1} HP", monster1.Hp, monster2.Hp);
            _hpBars.DisplayHPBars(monster1, monster2);
        }
       
        GameEnd(monster1, monster2);
    }

    void Swap(ref Monster first, ref Monster second)
    {
        (first, second) = (second, first);
    }

    void GameEnd(Monster monster1, Monster monster2)
    {
        // Console.Clear();
        Console.WriteLine("FIGHT ENDED!");
        // Console.WriteLine("{0} has {1} HP left...", monster1.MonsterERace, monster1.Hp);
        // Console.WriteLine("and {0} has {1} HP left...", monster2.MonsterERace, monster2.Hp);
        Monster winner = monster1.Hp == 0 ? monster2 : monster1;
        Console.WriteLine($"{winner.MonsterERace} won!");
        Console.ReadKey();
    }

}
