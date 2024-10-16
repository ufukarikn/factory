using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory
{
// 2- Somut Yaratıcılar
public class ConcreteCreatorA : Creator
{
    public override Product FactoryMethod() => new ConcreteProductA();
}
}