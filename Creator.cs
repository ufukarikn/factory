using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace factory
{
// 1-Soyut Yaratıcı Sınıf
public abstract class Creator
{
    public abstract Product FactoryMethod();
}
}