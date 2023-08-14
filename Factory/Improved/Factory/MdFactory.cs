using Improved.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Improved.Factories
{
    public class MdFactory : Factory
    {
        public Furniture? Create(string type)
        {
            if (type == "chair") return new Chair_MD();
            else if (type == "table") return new Table_MD();
            else if (type == "couch") return new Couch_MD();
            else return null;
        }
    }
}
