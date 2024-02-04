namespace MonsterFight;

public class MonsterFactory
{
    //create monster with default values
    public Monster CreateMonster(ERace selectedRace)
    {
        switch (selectedRace)
        {
            case ERace.Orc:
                return new Orc();
            case ERace.Troll:
                return new Troll();
            case ERace.Goblin:
                return new Goblin();
            default:
                throw new InvalidOperationException("Invalid race selection");
        }
    }
    
    //create monster with custom values
    public Monster CreateMonster(ERace selectedRace, float userHp, float userAp, float userDp, float userSp)
    {
        switch (selectedRace)
        {
            case ERace.Orc:
                return new Orc(userHp, userAp, userDp, userSp);
            case ERace.Troll:
                return new Troll(userHp, userAp, userDp, userSp);
            case ERace.Goblin:
                return new Goblin(userHp, userAp, userDp, userSp);
            default:
                throw new InvalidOperationException("Invalid race selection");
        }
    }

}