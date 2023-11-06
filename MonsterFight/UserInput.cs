namespace MonsterFight;

public class UserInput
{
    private Monster _monster1;
    

    public Monster CreateMonster()
    {
        Console.Clear();
        Console.WriteLine("Please chose a Monster: ");
        for (ERace race = (ERace)1; race < ERace.None; race++)
        {
            Console.WriteLine("{0}. {1}", (int)race, race);
        }
        
        ERace selectedRace = (ERace)ParseInput();
        Console.WriteLine(selectedRace);
        
        Console.WriteLine("(1) Default or (2) custom stats?");
        float statChoice = ParseInput();

        if ((int)statChoice == 1)
        {
            _monster1 = new MonsterFactory().CreateMonster(selectedRace);
        }
        else
        {
            Console.WriteLine("Please enter stats in order: HP, AP, DP, SP");
            float userHp = ParseInput();
            float userAp = ParseInput();
            float userDp = ParseInput();
            float userSp = ParseInput();

            _monster1 = new MonsterFactory().CreateMonster(selectedRace, userHp, userAp, userDp, userSp);
        }
        
        return _monster1;
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