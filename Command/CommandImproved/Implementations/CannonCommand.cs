using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    public class CannonCommand: Command
    {        
        public CannonCommand(int Id, int X, int Y) : base(Id, X, Y)
        {
        }

        public override async Task Execute()
        {
            Console.Write($"started to make Cannon at {X}, {Y}...\n");

            await Task.Delay(2000);

            Console.Write($"Cannon Done ({X},{Y}).\n");
        }
    }
}
