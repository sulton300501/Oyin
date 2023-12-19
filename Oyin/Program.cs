


using Pitnashki;

var game = new Pittnashki();
game.start();
Console.CursorVisible = false;
while (game.finish() == false)
{
    var key = Console.ReadKey();

    Console.Clear();
    if (key.Key == ConsoleKey.DownArrow)
    {
        game.DownArrow();
    }
    else if (key.Key == ConsoleKey.UpArrow)
    {
        game.UpArrow();
    }
    else if (key.Key == ConsoleKey.RightArrow)
    {
        game.RightArrow();
    }
    else if (key.Key == ConsoleKey.LeftArrow)
    {
        game.LeftArrow();
    }
    game.PrintArray();
}
Console.Write("YUTTIZ!!!!!");