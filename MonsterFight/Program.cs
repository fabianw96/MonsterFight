using MonsterFight;

int[] playerChoice = new int[2];
// Monster[] monster = new Monster[2];
List<Monster> monsterList = new List<Monster>();


Console.WriteLine("Please chose 2 Monsters: ");

for (int i = 0; i != (int) ERace.None; i++)
{
    Console.WriteLine((ERace)i);
}

UserInput input = new UserInput();

monsterList.Add(input.CreateMonster());
monsterList.Add(input.CreateMonster());

Console.WriteLine(monsterList[0].Hp);

Console.WriteLine(monsterList[0].Attack(monsterList[1]));





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