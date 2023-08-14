using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Improved.Contracts
{
    public interface Factory
    {
        public Furniture? Create(string type);
    }
}
