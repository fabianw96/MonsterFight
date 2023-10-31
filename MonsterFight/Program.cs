using MonsterFight;

int[] playerChoice = new int[2];
Monster[] monster = new Monster[2];

Console.WriteLine("Please chose 2 of 3 Monsters: ");

for (int i = 0; i != (int) ERace.None; i++)
{
    Console.WriteLine((ERace)i);
}

Console.WriteLine("Monster 1: ");
while (!int.TryParse(Console.ReadLine(), out playerChoice[0]))
{
    Console.WriteLine("Try again! See above!");
}

Console.WriteLine("Monster 2: ");
while (!int.TryParse(Console.ReadLine(), out playerChoice[1]))
{
    Console.WriteLine("Try again! See above!");
}

if (playerChoice[0] == playerChoice[1])
{
    Console.WriteLine("A monster can't fight it's own race!");
}

for (int i = 0; i < 2; i++)
{
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