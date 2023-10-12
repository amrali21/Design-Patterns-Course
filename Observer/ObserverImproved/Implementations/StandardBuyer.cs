using ObserverImproved.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Implementations
{
    class StandardBuyer: Buyer
    {
        public StandardBuyer(int Id, string Name) : base(Id, Name)
        {
        }

        public override void Notify()
        {
            Console.WriteLine($"Updated user {Name} dashboard");
        }
    }
}
