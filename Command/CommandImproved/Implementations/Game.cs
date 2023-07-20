using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public static class Game
    {
        public static Player AddPlayer(int X, int Y)
        {
            string NewId = Guid.NewGuid().ToString();
            Player P = new Player(NewId, X, Y, 100);
            return P;
        }
    }
}
