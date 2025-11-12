using HanoiLib;

var game = new Hanoi(3);

Console.WriteLine(game);

game.Move("A", "C");
Console.WriteLine(game);

game.Move("A", "B");
Console.WriteLine(game);

game.Move("C", "A");
Console.WriteLine(game);

game.Move("A", "B");
Console.WriteLine(game);

game.Move("A", "C");
Console.WriteLine(game);

game.Move("B", "A");
Console.WriteLine(game);

game.Move("A", "B");
Console.WriteLine(game);

game.Move("B", "A");
Console.WriteLine(game);

game.Move("B", "C");
Console.WriteLine(game);

game.Move("A", "C");
Console.WriteLine(game);
