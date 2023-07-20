using Commands;
using General;

Player PlayerOne = Game.AddPlayer(5, 6);

PlayerOne.AddCommand(new CannonCommand(1, 5, 6));
PlayerOne.AddCommand(new BuildCommand(1, 7, 6));
PlayerOne.AddCommand(new BuildCommand(2, 3, 6));
PlayerOne.AddCommand(new BuildCommand(4, 9, 6));

keypress();

Console.Read();


void keypress()
{
    ConsoleKeyInfo keyInfo;

    do
    {
        keyInfo = Console.ReadKey();

        if (keyInfo.Key == ConsoleKey.Enter)
        {
            Console.WriteLine("Commands cleared!");
            PlayerOne.EmptyList();
        }
    }
    while (keyInfo.Key != ConsoleKey.Escape);
}


