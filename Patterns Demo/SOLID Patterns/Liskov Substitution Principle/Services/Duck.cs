using Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Interfaces;

namespace Patterns_Demo.SOLID_Pattern_Example.Liskov_Substitution_Principle.Services;

public class Duck : Bird
{
    public override void CanFly()
    {
        Console.WriteLine("Duck can fly");
    }

    public override void CanSwim()
    {
        Console.WriteLine("Duck can swim");
    }
}