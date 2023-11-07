namespace MonsterFight;

public class HPBars
{
    public void DisplayHPBars(Monster monster1, Monster monster2)
    {
        Console.WriteLine("{0}", monster1.MonsterERace);
        DrawHPBar(monster1.Hp, monster1.MaxHp);
        
        Console.WriteLine("{0}", monster2.MonsterERace);
        DrawHPBar(monster2.Hp, monster2.MaxHp);

    }

    private void DrawHPBar(float currentHP, float maxHP)
    {
        int barLength = 20;
        int fillLength = (int)(currentHP / maxHP * barLength);
        
        Console.Write("[");

        for (int i = 0; i < barLength; i++)
        {
            if (i < fillLength)
                Console.Write("#");
            else
                Console.Write("-");
        }

        Console.WriteLine($"] {currentHP}/{maxHP} HP");
    }
}