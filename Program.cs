using factory;

Creator creatorA = new ConcreteCreatorA();
Product productA = creatorA.FactoryMethod();
Console.WriteLine(productA.GetName());  // Product A

Creator creatorB = new ConcreteCreatorB();
Product productB = creatorB.FactoryMethod();
Console.WriteLine(productB.GetName());  // Product B