using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Improved.Contracts;

namespace Improved
{
    public class Chair_US: Furniture
    {
        public void Build()
        {
            Console.WriteLine("Building US style Chair");
        }
    }
}
