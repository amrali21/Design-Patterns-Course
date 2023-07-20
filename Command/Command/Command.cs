using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commands
{
    public class Command
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string Type { get; set; }

        public Command(int Id, int X, int Y, string Type)
        {
            this.Id = Id;
            this.X = X;
            this.Y = Y;
            this.Type = Type;
        }
    }
}
