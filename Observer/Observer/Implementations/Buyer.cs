using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Implementations
{
    class Buyer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public Buyer(int Id, string Name, string Type)
        {
            this.Name = Name;
            this.Id = Id;

            this.Type = Type;   
        }

        public void BuyStock(Stock stock)
        {
            if (stock.Buyers.Contains(this) == false)
                stock.AddBuyer(this);

            Console.WriteLine($"User {Name} bought stock {stock.Name}\n");
        }

        public void Notify()
        {
            if(this.Type == "Standard")
            {
                Console.WriteLine($"Updated user {Name} dashboard\n");
            }
            else if(this.Type == "Premium")
            {
                Console.WriteLine($"Updated user {Name} dashboard, and displayed possibility of up or down!\n");
            }
        }
    }
}
