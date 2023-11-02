namespace MonsterFight;

public class UserInput
{
    private Monster _monster1;
    

    public Monster CreateMonster()
    {
        
        float raceChoice = ParseInput();
        
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