using Observer.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverImproved.Contracts
{
    abstract class Buyer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Buyer(int Id, string Name)
        {
            this.Name = Name;
            this.Id = Id;
        }

        public void BuyStock(Stock stock)
        {
            if (stock.Buyers.Contains(this) == false)
                stock.AddBuyer(this);

            Console.WriteLine($"User {Name} bought stock {stock.Name}");
        }

        public abstract void Notify();
    }
}
