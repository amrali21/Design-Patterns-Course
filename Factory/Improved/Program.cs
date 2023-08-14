using Improved.Contracts;
using Improved.Factories;

Factory euFactory = new EuFactory();
Factory usFactory = new UsFactory();
Factory mdFactory = new MdFactory();

Furniture? f1 = euFactory.Create("chair");
f1?.Build();

Furniture? f2 = usFactory.Create("table");
f2?.Build();

Furniture? f3 = mdFactory.Create("couch");
f3?.Build();

Console.ReadLine();