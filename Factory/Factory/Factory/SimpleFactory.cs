using Naive.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naive
{
    public static class SimpleFactory
    {
        public static Furniture? Make(string type)
        {
            if (type == "Couch US") return new Couch_US();
            else if (type == "Couch EU") return new Couch_EU();
            else if (type == "Couch MD") return new Couch_MD();

            else if (type == "Chair US") return new Chair_US();
            else if (type == "Chair EU") return new Chair_EU();
            else if (type == "Chair MD") return new Chair_MD();

            else if (type == "Table US") return new Table_US();
            else if (type == "Table EU") return new Table_EU();
            else if (type == "Table MD") return new Table_MD();

            else return null; 
        }
    }
}
