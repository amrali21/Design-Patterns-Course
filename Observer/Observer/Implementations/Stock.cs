using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Implementations
{
    class Stock
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public List<Buyer> Buyers { get; set; }

        public Stock(string Name, float Price)
        {
            Buyers = new List<Buyer>();

            this.Price = Price;
            this.Name = Name;
        }

        public void AddBuyer(Buyer buyer)
        {
            Buyers.Add(buyer);
        }

        public void RemoveBuyer(Buyer buyer)
        {
            Buyers.Remove(buyer);
        }

        public void StockUpdate()
        {
            Console.WriteLine($"{Name} stock update\n");

            foreach (Buyer buyer in Buyers)
            {
                buyer.Notify();
            }
        }
    }
}
