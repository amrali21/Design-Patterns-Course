// See https://aka.ms/new-console-template for more information
using Observer.Implementations;
using ObserverImproved.Contracts;

Stock s1 = new Stock("Tesla", 200);
Stock s2 = new Stock("Apple", 300);

Buyer b1 = new PremiumBuyer(1, "john");
Buyer b2 = new StandardBuyer(2, "mike");

// users buy stocks
b1.BuyStock(s1);
b1.BuyStock(s2);

b2.BuyStock(s1);

// stock update
s1.StockUpdate();
s2.StockUpdate();

Console.ReadLine();