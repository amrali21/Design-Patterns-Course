using Improved.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Improved.Factories
{
    internal class EuFactory : Factory
    {
        public Furniture? Create(string type)
        {
            if (type == "chair") return new Chair_EU();
            else if (type == "table") return new Table_EU();
            else if (type == "couch") return new Couch_EU();
            else return null;
        }
    }
}
