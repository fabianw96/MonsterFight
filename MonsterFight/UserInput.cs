namespace MonsterFight;

public class UserInput
{
    
    public Monster CreateMonster(ERace forbiddenRace)
    {
        Console.Clear();
        Console.WriteLine("Please choose a Monster: ");
        for (ERace race = (ERace)1; race != ERace.None; race++)
        {
            Console.WriteLine("{0}. {1}", (int)race, race);
        }

        ERace selectedRace = (ERace)ParseInput();
        Console.WriteLine(selectedRace);
        Console.WriteLine((int)selectedRace);
        while (selectedRace == forbiddenRace)
        {
            Console.WriteLine("The same race can't fight another!");
            Console.Write("Please choose a different race: ");
            
            selectedRace = (ERace)ParseInput();
            Console.WriteLine(selectedRace);
        }
        
        
        Console.WriteLine("(1) Default or (2) custom stats?");
        int statChoice = (int)ParseInput();

        if (statChoice != 2)
        {
            Monster monster1 = new MonsterFactory().CreateMonster(selectedRace);
            return monster1;
        }
        
        Console.WriteLine("Please enter stats in order: HP, AP, DP, SP");
        float userHp = ParseInput();
        float userAp = ParseInput();
        float userDp = ParseInput();
        float userSp = ParseInput();

        
        Monster monster = new MonsterFactory().CreateMonster(selectedRace, userHp, userAp, userDp, userSp);
        
        return monster;
    }

    private float ParseInput()
    {
        float input;
        while (!float.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Incorrect Input. Please enter a number.");
        }
        return input;
    }
}