using MonsterFight;

int[] playerChoice = new int[2];
Monster[] monster = new Monster[2];

Console.WriteLine("Please chose 2 Monsters: ");

for (int i = 0; i != (int) ERace.None; i++)
{
    Console.WriteLine((ERace)i);
}

for (int i = 0; i < playerChoice.Length; i++)
{
    while (!int.TryParse(Console.ReadLine(), out playerChoice[i]))
    {
        Console.WriteLine("Please enter a valid number!: ");
    }

    switch (playerChoice[i])
    {
        case 1:
            monster[i] = new Orc();
            break;
        case 2:
            monster[i] = new Troll();
            break;
        case 3:
            monster[i] = new Goblin();
            break;
    }
}
Console.WriteLine(monster[0]);
Console.WriteLine(monster[1]);



// while (monster[0].Hp > 0 || monster[1].Hp > 0)
// {
//     return;
// }

//chose first race
//default values or custom?
//enter custom values
//create Monster with given choices
//chose second race
//check if 2nd race is equal to 1st race
//default values or custom?
//create Monster with given choices