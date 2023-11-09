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

        ERace selectedRace = (ERace)ParseInput(1, (int)ERace.None - 1);
        Console.WriteLine(selectedRace);
        while (selectedRace == forbiddenRace)
        {
            Console.WriteLine("The same race can't fight another!");
            Console.Write("Please choose a different race: ");
            
            selectedRace = (ERace)ParseInput(1, (int)ERace.None);
            Console.WriteLine(selectedRace);
        }
        
        
        Console.WriteLine("(1) Default or (2) custom stats?");
        int statChoice = (int)ParseInput(1, 2);

        if (statChoice != 2)
        {
            Monster monster1 = new MonsterFactory().CreateMonster(selectedRace);
            return monster1;
        }
        
        Console.WriteLine("Please enter stats in order: HP, AP, DP, SP");
        float userHp = ParseInput(50, 200);
        float userAp = ParseInput(1, 20);
        float userDp = ParseInput(1, 20);
        float userSp = ParseInput(1, 20);

        
        Monster monster = new MonsterFactory().CreateMonster(selectedRace, userHp, userAp, userDp, userSp);
        
        return monster;
    }

    private float ParseInput(float min, float max)
    {
        float input;
        
        while (!float.TryParse(Console.ReadLine(), out input) || input < min || input > max)
        {
            Console.WriteLine("Incorrect Input. Please enter a number.");
        }

        return input;
    }
}