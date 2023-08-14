using Naive;
using Naive.Contracts;

Furniture? f1 = SimpleFactory.Make("Chair US"); 
Furniture? f2 =  SimpleFactory.Make("Couch MD"); 
Furniture? f3 =  SimpleFactory.Make("Table EU"); 

f1?.Build();
f2?.Build();
f3?.Build();

Console.Read();