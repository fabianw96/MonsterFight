namespace MonsterFight;

public class UserInput
{
    private Monster _monster1;
    

    public Monster CreateMonster()
    {
        
        Console.WriteLine("Please chose a Monsters: ");
        for (int i = 0; i != (int) ERace.None; i++)
        {
            Console.WriteLine((ERace)i);
        }
        float raceChoice = ParseInput();
        
        Console.WriteLine("(1) Default or (2) custom stats?");
        float statChoice = ParseInput();

        if ((int)statChoice == 1)
        {
            switch (raceChoice)
            {
                case 1:
                    _monster1 = new Orc();
                    break;
                case 2:
                    _monster1 = new Troll();
                    break;
                case 3:
                    _monster1 = new Goblin();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Please enter stats in order: HP, AP, DP, SP");
            float userHp = ParseInput();
            float userAp = ParseInput();
            float userDp = ParseInput();
            float userSp = ParseInput();
            
            switch (raceChoice)
            {
                case 1:
                    _monster1 = new Orc(userHp, userAp, userDp, userSp);
                    break;
                case 2:
                    _monster1 = new Troll(userHp, userAp, userDp, userSp);
                    break;
                case 3:
                    _monster1 = new Goblin(userHp, userAp, userDp, userSp);
                    break;
            }
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