using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    public class BuildCommand: Command
    {        
        public BuildCommand(int Id, int X, int Y) : base(Id, X, Y)
        {
        }

        public override async Task Execute()
        {
            Console.Write($"started to make Building at {X}, {Y}...\n");

            await Task.Delay(2000);

            Console.Write($"Building Done ({X},{Y}).\n");
        }
    }
}
