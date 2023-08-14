using Improved.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Improved.Factories
{
    internal class UsFactory : Factory
    {
        public Furniture? Create(string type)
        {
            if (type == "chair") return new Chair_US();
            else if (type == "table") return new Table_US();
            else if (type == "couch") return new Couch_US();
            else return null;
        }
    }
}
