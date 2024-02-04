namespace MonsterFight;

public class Game
{
    //creating new objects for userInput and the HPBars
    private UserInput _input = new UserInput();
    private HPBars _hpBars = new HPBars();
    
    public void StartGame()
    {
        //creating 2 monsters giving the "restricted race" as a parameter
        Monster monster1 = _input.CreateMonster(ERace.None);
        Monster monster2 = _input.CreateMonster(monster1.MonsterERace);
        
        //start the gameloop with the created monsters
        GameLoop(monster1, monster2);
    }
    
    private void GameLoop(Monster monster1, Monster monster2)
    {
        Console.Clear();

        Console.WriteLine("A fight between {0} and {1} has started!", monster1.MonsterERace, monster2.MonsterERace);
        
        //determine which monster is the first attacker
        Monster attacker = monster1.Sp > monster2.Sp ? monster1 : monster2;
        Monster defender = attacker == monster1 ? monster2 : monster1;
        
        Console.WriteLine($"{attacker.MonsterERace} attacks first!");
        
        //displays the HP bars for both monsters
        _hpBars.DisplayHPBars(monster1, monster2);
        
        //fight loop, attack method of attacking monster is called with the defending monster as parameter
        //while either HP is greater than 0
        //a 1000ms sleep makes sure that the fight isn't just over in a second
        while (monster1.Hp > 0 && monster2.Hp > 0)
        {
            attacker.Attack(defender);
            Thread.Sleep(1000);
            Console.Clear();
            //swap attack and defender by reference
            Swap(ref attacker, ref defender);
            //display HP bars with updated HP values
            _hpBars.DisplayHPBars(monster1, monster2);
        }
       
        GameEnd(monster1, monster2);
    }

    void Swap(ref Monster first, ref Monster second)
    {
        //swap monsters with "tuple deconstruction"
        (first, second) = (second, first);
    }

    void GameEnd(Monster monster1, Monster monster2)
    {
        //output winner
        Console.WriteLine("FIGHT ENDED!");
        Monster winner = monster1.Hp == 0 ? monster2 : monster1;
        Console.WriteLine($"{winner.MonsterERace} won!");
        Console.ReadKey();
    }

}
