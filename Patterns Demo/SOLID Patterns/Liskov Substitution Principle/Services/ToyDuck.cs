using Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Interfaces;

namespace Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Services;

public class ToyDuck : Bird
{
    public override void CanFly()
    {
    }

    public override void CanSwim()
    {
        Console.WriteLine("Toy Duck can swim");
    }
}