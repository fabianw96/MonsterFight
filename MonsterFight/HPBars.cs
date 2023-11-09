namespace MonsterFight;

public class HPBars
{
    public void DisplayHPBars(Monster monster1, Monster monster2)
    {
        Console.WriteLine("{0}, {1} / {2} HP ", monster1.MonsterERace, monster1.Hp, monster1.MaxHp);
        DrawHPBar(monster1.Hp, monster1.MaxHp);
        
        Console.WriteLine("{0}, {1} / {2} HP ", monster2.MonsterERace, monster2.Hp, monster2.MaxHp);
        DrawHPBar(monster2.Hp, monster2.MaxHp);

    }

    private void DrawHPBar(float currentHP, float maxHP)
    {
        // int barLength = 20;
        int barLength = (int)maxHP / 10; // =10
        int fillLength = (int)(currentHP / maxHP * barLength); // =10

        for (int i = 0; i < fillLength; i++) // i = 0
        {
            if (currentHP < maxHP / 4)
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.Write(" ");
            }
            else if (currentHP < maxHP / 2)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write(" ");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write(" ");
            }
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine();
    }
}