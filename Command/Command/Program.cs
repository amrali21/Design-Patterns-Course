using Commands;
using General;


Player PlayerOne = Game.AddPlayer(5, 6);

PlayerOne.AddCommand(new Command(1, 5, 6, "cannon"));
PlayerOne.AddCommand(new Command(2, 5, 7, "building"));
PlayerOne.AddCommand(new Command(3, 5, 8, "building"));
PlayerOne.AddCommand(new Command(4, 5, 9, "building"));
PlayerOne.AddCommand(new Command(5, 5, 10, "building"));
PlayerOne.AddCommand(new Command(6, 5, 11, "building"));

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


