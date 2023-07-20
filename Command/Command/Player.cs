using Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public class Player
    {
        public string Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Health { get; set; }
        public bool Executing { get; set; }
        List<Command> Commands { get; set; }

        public Player(string Id, int X, int Y, int Health)
        {
            this.Id = Id;
            this.X = X;
            this.Y = Y;
            this.Health = Health;
            Commands = new List<Command>();
        }

        public void AddCommand(Command C) 
        {
            Commands.Add(C);

            Console.WriteLine("added new command");

            if (!Executing)
            {
                _ = StartSequence(); 
                Executing = true;
            }
        }

        private async Task StartSequence()
        {
            for(int i = 0; i < Commands.Count; i++)
            {
              await Make(Commands[i].Type, Commands[i].X, Commands[i].Y); 
            }
            Console.WriteLine("no more commands for now");
        }

        public async Task Make(string type, int x, int y)
        {
            if (type == "building")
                await MakeBuilding(x, y);
            else if (type == "cannon")
                await MakeCannon(x, y);
        }

        public void EmptyList()
        {
            Commands = new List<Command>();
        }

        async Task MakeBuilding(int x, int y)
        {
            // Player makes building on x,y.
            Console.Write($"started to make building at {x}, {y}...\n");

            await Task.Delay(5000);

            Console.Write("Building Done.\n");
        }

        async Task MakeCannon(int x, int y)
        {
            // Player makes cannon on x,y.
            Console.Write($"started to make cannnon at {x}, {y}...\n");

            await Task.Delay(10000);

            Console.Write("Cannon Done.\n");
        }
    }
}
