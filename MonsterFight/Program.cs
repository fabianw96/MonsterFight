using MonsterFight;

List<Monster> monsterList = new List<Monster>();
UserInput input = new UserInput();

monsterList.Add(input.CreateMonster());
monsterList.Add(input.CreateMonster());

while (monsterList[0].ERace == monsterList[1].ERace)
{
    Console.WriteLine("The same race can't fight another!");
    monsterList.RemoveAt(1);
    monsterList.Add(input.CreateMonster());
}

Game gameLoop = new Game(monsterList);
gameLoop.GameLoop();