using Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Abstractions;
using System;

namespace Patterns_Demo.Creational_Patterns.Factory_Method_Pattern.Services;

public class FactoryWithPolymorphism(IM m)
{
    private readonly IM _m = m ?? new NullObject();

    public void FactoryMethod()
    {
        _m.DoStuff();
    }
}
