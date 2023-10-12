// See https://aka.ms/new-console-template for more information
using Observer.Implementations;

Stock s1 = new Stock("Tesla", 200);
Stock s2 = new Stock("Apple", 300);

Buyer b1 = new Buyer(1, "john", "Standard");
Buyer b2 = new Buyer(2, "mike", "Premium");

// users buy stocks
b1.BuyStock(s1);
b1.BuyStock(s2);

b2.BuyStock(s1);

Console.WriteLine("********************************");

// stocks update
s1.StockUpdate();

Console.WriteLine("--------------------------------");

s2.StockUpdate();

Console.ReadLine();