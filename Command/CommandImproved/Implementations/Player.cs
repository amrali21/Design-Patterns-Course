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

            Console.WriteLine($"added new command");

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
               await Commands[i].Execute();
            }
            Console.WriteLine("no more commands for now");
        }

        public void EmptyList()
        {
            Commands = new List<Command>();
        }
    }
}
